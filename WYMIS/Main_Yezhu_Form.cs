using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WYMIS
{
    public partial class Main_Yezhu_Form : Form
    {
        public Main_Yezhu_Form()
        {
            InitializeComponent();
        }

        SQL_Class SQLClass = new SQL_Class();
        Zhuangtai_Class zhuangtai = new Zhuangtai_Class();
        TreeNode SelectNode = new TreeNode();       //创建一个TreeNode对象SelectNode，用以存储被选中的树节点
        Search_Class search = new Search_Class();
        Export_Class export = new Export_Class();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wparam, int lparam);
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)//按下的是鼠标左键            
            {
                Capture = false;//释放鼠标使能够手动操作                
                SendMessage(Handle, 0x00A1, 2, 0);//拖动窗体            
            }
        }

        public string tempsql;
        public bool isonce = true;
        public bool needwhere = true;

        public bool changeuser;

        public int yzid;
        public string yzxm;
        public string yzxb;
        public string yzlx;
        public string yzzz;
        public string yzsfz;
        public string yzyhm;
        public int yzfy;
        public int yzqx;

        private void Main_Yezhu_Form_Load(object sender, EventArgs e)
        {
            lab_title.Text = this.Text + " - " + lab_title.Text;
            lab_yzxm.Text = yzxm;
            lab_yzxb.Text = yzxb;
            lab_yzlx.Text = yzlx;
            lab_yzzz.Text = yzzz;
            lab_yzsfz.Text = yzsfz;
            lab_yzyhm.Text = yzyhm;
            lab_yzfy.Text = yzfy.ToString() + "元";
            picbox_sy_Click(sender, e);
            UpdateComboBox();
        }

        private void picbox_close_MouseHover(object sender, EventArgs e)
        {
            picbox_close.Image = Image.FromFile("images/close_mouse.png");
        }
        private void picbox_close_MouseLeave(object sender, EventArgs e)
        {
            picbox_close.Image = Image.FromFile("images/close.png");
        }
        private void picbox_min_MouseHover(object sender, EventArgs e)
        {
            picbox_min.Image = Image.FromFile("images/min_mouse.png");
        }
        private void picbox_min_MouseLeave(object sender, EventArgs e)
        {
            picbox_min.Image = Image.FromFile("images/min.png");
        }
        private void picbox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void picbox_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void picbox_sy_Click(object sender, EventArgs e)
        {
            picbox_sy.Image = Image.FromFile("images/sy_select.png");
        }

        private void picbox_about_MouseHover(object sender, EventArgs e)
        {
            picbox_about.Image = Image.FromFile("images/gy_mouse.png");
        }

        private void picbox_about_MouseLeave(object sender, EventArgs e)
        {
            picbox_about.Image = Image.FromFile("images/gy.png");
        }

        private void picbox_about_Click(object sender, EventArgs e)
        {
            picbox_sy.Image = Image.FromFile("images/sy.png");
            picbox_about.Image = Image.FromFile("images/gy_select.png");
            About about = new About();
            about.Text = "关于本程序";
            about.ShowDialog();
            picbox_sy.Image = Image.FromFile("images/sy_select.png");
            picbox_about.Image = Image.FromFile("images/gy.png");
        }

        private void treeview_AfterSelect(object sender, EventArgs e)
        {
            if (treeview.SelectedNode == null)      //判断是否选中了树节点
            {
                return;
            }
            else
            {
                listview.Items.Clear();
                if(treeview.SelectedNode.Text == "服务申请")
                {
                    listview.Items.Clear();
                    UpdateListview("select * from fuwu where yezhuid = '" + yzid + "'");
                }
                else if(treeview.SelectedNode.Parent.Text == "服务申请")
                {
                    switch(treeview.SelectedNode.Name)
                    {
                        case "0":
                            UpdateListview("select * from fuwu where zhuangtai = '0' and yezhuid = '" + yzid + "'");
                            break;
                        case "1":
                            UpdateListview("select * from fuwu where zhuangtai = '1' and yezhuid = '" + yzid + "'");
                            break;
                        case "2":
                            UpdateListview("select * from fuwu where zhuangtai = '2' and yezhuid = '" + yzid + "'");
                            break;
                    }
                }
            }
        }

        //更新树节点------------------------------------------
        private void UpdateTreeview()       //加载treeview根节点下面的子节点
        {

        }

        //更新列表--------------------------
        private void UpdateListview(string sql)     //加载listview中的数据，其中sql参数表示传递的SQL的语句
        {
            DataSet DSet = SQLClass.getDataSet(sql, "服务信息表");
            DataTable dt = DSet.Tables["服务信息表"];        //创建一个DataTable对象
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ygname = zhuangtai.YuangongName(dt.Rows[i][6].ToString(), true);
                string fwzhuangtai = zhuangtai.Fuwu(dt.Rows[i][4].ToString());
                string[] item = { (i + 1).ToString(), dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), yzxm, dt.Rows[i][3].ToString(), fwzhuangtai, dt.Rows[i][5].ToString(), ygname, dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString() + "元" };
                ListViewItem newitem = new ListViewItem(item);
                newitem.ImageIndex = 9;       //设置数据行的图标
                listview.Items.Add(newitem);
            }
        }

        private void 添加申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fuwu_Form fw = new Fuwu_Form();
            fw.Text = "添加服务申请";
            fw.Form_Type = 4;
            fw.yzid = yzid.ToString();
            fw.ShowDialog();
            if (fw.Form_OK == 1)
            {
                treeview_AfterSelect(sender, e);
                MessageBox.Show("添加服务申请成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 修改申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview.SelectedItems.Count <= 0 || listview.SelectedItems[0].SubItems[1].Text == "")
            {
                MessageBox.Show("未选中任何一条服务！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (listview.SelectedItems[0].SubItems[5].Text == "已受理" || listview.SelectedItems[0].SubItems[4].Text == "已完成")
                {
                    MessageBox.Show("该申请已处于受理或完成状态，无法修改！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Fuwu_Form fw = new Fuwu_Form();
                    fw.Text = "修改服务申请";
                    fw.Form_Type = 5;
                    fw.fwid = listview.SelectedItems[0].SubItems[1].Text;
                    fw.yzid = yzid.ToString();
                    fw.ShowDialog();
                    if (fw.Form_OK == 1)
                    {
                        treeview_AfterSelect(sender, e);
                        MessageBox.Show("修改服务申请成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void 删除申请ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview.SelectedItems.Count <= 0 || listview.SelectedItems[0].SubItems[1].Text == "")
            {
                MessageBox.Show("未选中任何一条服务！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (listview.SelectedItems[0].SubItems[5].Text == "已受理" || listview.SelectedItems[0].SubItems[5].Text == "已完成")
                {
                    MessageBox.Show("该记录处于受理或完成状态，无法进行删除动作！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (DialogResult.OK == MessageBox.Show("确定删除（[" + listview.SelectedItems[0].SubItems[1].Text + "]" + listview.SelectedItems[0].SubItems[2].Text + ")的所有信息吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                    {
                        //确认删除数据
                        SQLClass.getsqlcom("delete from fuwu where id = '" + listview.SelectedItems[0].SubItems[1].Text + "'");
                        treeview_AfterSelect(sender, e);
                        SQLClass.con_close();       //关闭数据库连接，释放资源
                        MessageBox.Show("删除服务申请成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("操作已取消！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void 导出ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview.Items.Count <= 0)
            {
                MessageBox.Show("列表为空，不能导出！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                export.ExportToExecl(listview);
            }
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeview_AfterSelect(sender, e);
        }

        public void UpdateComboBox()
        {
            combox.Items.Clear();
            combox.Items.Add("申请编号");
            combox.Items.Add("申请名称");
            combox.Items.Add("申请人");
            combox.Items.Add("状态");
            combox.Items.Add("负责人");
            combox.SelectedIndex = 0;
        }

        private void combox_TextChanged(object sender, EventArgs e)
        {
            switch (combox.Text)
            {
                case "申请编号":
                    txt_context.Text = "请输入申请编号！";
                    break;
                case "申请名称":
                    txt_context.Text = "请输入申请名称！";
                    break;
                case "申请人":
                    txt_context.Text = "请输入业主姓名！";
                    break;
                case "状态":
                    txt_context.Text = "0:未处理 1:已处理: 2:已完成";
                    break;
                case "负责人":
                    break;
            }
            txt_context.ForeColor = Color.Gray;
        }

        private void txt_context_Enter(object sender, EventArgs e)
        {
            txt_context.Tag = txt_context.Text;
            txt_context.Text = "";
            txt_context.ForeColor = Color.Black;
        }

        private void txt_context_Leave(object sender, EventArgs e)
        {
            if (txt_context.Text == "")
            {
                txt_context.Text = txt_context.Tag.ToString();
                txt_context.ForeColor = Color.Gray;
            }
        }

        private void txt_context_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                picbox_search_Click(sender, e);
                e.Handled = true;
            }
        }

        private void picbox_search_Click(object sender, EventArgs e)
        {
            listview.Items.Clear();
            tempsql = givetempsql(tempsql);
            UpdateListview(tempsql);
        }

        public string givetempsql(string sql)
        {
            if (checkbox.Checked)
            {
                if (isonce)
                {
                    isonce = false;
                    needwhere = true;
      
                        sql = search.newsql("yw", "2");
                        sql = search.Searchsql(sql, combox.Text, txt_context.Text.Trim(), "yw", "2", needwhere);
                }
                else
                {
                    isonce = false;
                    needwhere = false;
                    sql = search.Searchsql(sql, combox.Text, txt_context.Text.Trim(), "yw", "2", needwhere);
                }
            }
            else
            {
                if (isonce)
                {

                    isonce = false;
                    needwhere = true;
                    sql = search.newsql("yw", "2");
                    sql = search.Searchsql(sql, combox.Text, txt_context.Text.Trim(), "yw", "2", needwhere);
                }
                else
                {

                    isonce = false;
                    needwhere = true;
                    sql = search.newsql("yw", "2");
                    sql = search.Searchsql(sql, combox.Text, txt_context.Text.Trim(), "yw", "2", needwhere);
                }
            }
            return sql;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            changeuser = true;
            this.Close();
        }

        private void picbox_search_MouseHover(object sender, EventArgs e)
        {
            picbox_search.Image = Image.FromFile("images/search_mouse.png");
        }

        private void picbox_search_MouseLeave(object sender, EventArgs e)
        {
            picbox_search.Image = Image.FromFile("images/search.png");
        }

    }
}
