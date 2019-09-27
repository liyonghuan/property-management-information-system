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
    public partial class Yuangong_Form : Form
    {
        public Yuangong_Form()
        {
            InitializeComponent();
        }

        SQL_Class SQLClass = new SQL_Class();
        Zhuangtai_Class zhuangtai = new Zhuangtai_Class();

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

        public string ygid;
        public string bmname;
        public string gwname;
        public int Form_Type;
        public int Form_OK;

        private void Yuangong_Form_Load(object sender, EventArgs e)
        {
            lab_title.Text = this.Text + " - " + lab_title.Text;
            if (Form_Type != 0)
            {
                LoadInfo();
            }
            combox_bm.SelectedIndex = bm();
            combox_gw.SelectedIndex = gw(bmname);
            switch(Form_Type)
            {
                case 0:
                    break;
                case 1:
                    txt_xingming.Tag = 1;
                    txt_lianxi.Tag = 1;
                    txt_zhuzhi.Tag = 1;
                    txt_username.Tag = 1;
                    txt_password1.Tag = 1;
                    txt_password2.Tag = 1;
                    break;
                case 2:
                    txt_xingming.ReadOnly = true;
                    rad_nan.Enabled = false;
                    rad_nv.Enabled = false;
                    combox_bm.Enabled = false;
                    combox_gw.Enabled = false;
                    txt_lianxi.ReadOnly = true;
                    txt_zhuzhi.ReadOnly = true;
                    txt_username.ReadOnly = true;
                    txt_password1.ReadOnly = true;
                    txt_password2.ReadOnly = true;
                    break;
            }
        }

        public void LoadInfo()
        {
            DataSet DSet = SQLClass.getDataSet("select * from yuangong where id = '" + ygid + "'", "员工信息表");
            DataTable dt = DSet.Tables["员工信息表"];
            if(dt.Rows.Count > 0)
            {
                txt_xingming.Text = dt.Rows[0][1].ToString();
                if(dt.Rows[0][2].ToString() == "男")
                {
                    rad_nan.Checked = true;
                }
                else
                {
                    rad_nv.Checked = true;
                }
                txt_lianxi.Text = dt.Rows[0][4].ToString();
                txt_zhuzhi.Text = dt.Rows[0][5].ToString();
                txt_username.Text = dt.Rows[0][7].ToString();
            }
        }
        public int bm()     //获取部门信息函数
        {
            int num = 0;
            combox_bm.Items.Clear();
            DataSet bmDSet = SQLClass.getDataSet("select bumen from gangwei group by bumen", "部门信息表");
            DataTable bmdt = bmDSet.Tables["部门信息表"];
            if (bmdt.Rows.Count > 0)
            {
                for (int i = 0; i < bmdt.Rows.Count; i++)
                {
                    if (bmdt.Rows[i][0].ToString() == bmname)
                    {
                        num = i;
                    }
                    combox_bm.Items.Add(bmdt.Rows[i][0].ToString());
                    //combox_gw.SelectedIndex = gw(dt.Rows[i][0].ToString());       //调用岗位函数获取该部门下岗位信息
                }
            }
            return num;

        }
        public int gw(string bm)
        {
            int num = 0;
            combox_gw.Items.Clear();
            DataSet gwDSet = SQLClass.getDataSet("select gangwei from gangwei where bumen = '" + bm + "'", "岗位信息表");
            DataTable gwdt = gwDSet.Tables["岗位信息表"];
            if (gwdt.Rows.Count > 0)
            {
                for (int i = 0; i < gwdt.Rows.Count; i++)
                {
                    if (gwdt.Rows[i][0].ToString() == gwname)
                    {
                        num = i;
                    }
                    combox_gw.Items.Add(gwdt.Rows[i][0].ToString());
                }
            }
            return num;
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

        private void txt_xingming_Leave(object sender, EventArgs e)
        {
            txt_xingming.Tag = 0;
            if (txt_xingming.Text == "")
            {
                lab_m_xingming.Text = "姓名不能为空！";
                lab_m_xingming.ForeColor = Color.Red;
            }
            else
            {
                lab_m_xingming.Text = "";
                txt_xingming.Tag = 1;
            }
        }

        private void txt_lianxi_Leave(object sender, EventArgs e)
        {
            txt_lianxi.Tag = 0;
            if (txt_lianxi.Text == "")
            {
                lab_m_lianxi.Text = "联系方式不能为空！";
                lab_m_lianxi.ForeColor = Color.Red;
            }
            else
            {
                if (!Input_Regex.IsPhoneNum(txt_lianxi.Text.ToString()))
                {
                    lab_m_lianxi.Text = "请检查输入的联系号码是否正确！";
                    lab_m_lianxi.ForeColor = Color.Red;
                }
                else
                {
                    lab_m_lianxi.Text = "";
                    txt_lianxi.Tag = 1;
                }
            }
        }

        private void txt_zhuzhi_Leave(object sender, EventArgs e)
        {
            txt_zhuzhi.Tag = 0;
            if (txt_zhuzhi.Text == "")
            {
                lab_m_zhuzhi.Text = "住址不能为空！";
                lab_m_zhuzhi.ForeColor = Color.Red;
            }
            else
            {
                lab_m_zhuzhi.Text = "";
                txt_zhuzhi.Tag = 1;
            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            txt_username.Tag = 0;
            if (txt_username.Text == "")
            {
                lab_m_username.Text = "用户名不能为空！";
                lab_m_username.ForeColor = Color.Red;
            }
            else
            {
                if (Input_Regex.IsNumAndEnCh(txt_username.Text))
                {
                    DataSet DSet = SQLClass.getDataSet("select id from yuangong where username = '" + txt_username.Text + "'", "员工信息表");
                    DataTable dt = DSet.Tables["员工信息表"];
                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0][0].ToString() != ygid)
                        {
                            lab_m_username.Text = "用户名已存在！";
                            lab_m_username.ForeColor = Color.Red;
                        }
                        else
                        {
                            lab_m_username.Text = "";
                            txt_username.Tag = 1;
                        }
                    }
                    else
                    {
                        lab_m_username.Text = "";
                        txt_username.Tag = 1;
                    }
                }
                else
                {
                    lab_m_username.Text = "用户名只能为英文和数字！";
                    lab_m_username.ForeColor = Color.Red;
                }
            }
        }

        private void txt_password1_Leave(object sender, EventArgs e)
        {
            txt_password1.Tag = 0;
            switch (Form_Type)
            {
                case 1:
                    if(txt_password1.Text == "")
                    {
                        if(txt_password2.Text == "")
                        {
                            lab_m_password1.Text = "";
                            txt_password1.Tag = 1;
                            txt_password2.Tag = 2;
                        }
                        else
                        {
                            txt_password2_Leave(sender, e);
                        }
                    }
                    else
                    {
                        txt_password2_Leave(sender, e);
                    }
                    break;
                default:
                    if (txt_password1.Text == "")
                    {
                        lab_m_password1.Text = "密码不能为空！";
                        lab_m_password1.ForeColor = Color.Red;
                    }
                    else
                    {
                        lab_m_password1.Text = "";
                        txt_password1.Tag = 1;
                    }
                    if (txt_password1.Tag.ToString() == "1")
                    {
                        txt_password2_Leave(sender, e);
                    }
                    break;
            }
        }

        private void txt_password2_Leave(object sender, EventArgs e)
        {
            txt_password2.Tag = 0;
            switch (Form_Type)
            {
                case 1:
                    if(txt_password1.Text == "")
                    {
                        if(txt_password2.Text == "")
                        {
                            lab_m_password2.Text = "";
                            txt_password2.Tag = 1;
                            txt_password1.Tag = 1;
                        }
                        else
                        {
                            lab_m_password2.Text = "确认密码不正确！";
                            lab_m_password2.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        if(txt_password1.Text == txt_password2.Text)
                        {
                            lab_m_password2.Text = "";
                            txt_password2.Tag = 1;
                            txt_password1.Tag = 1;
                        }
                        else
                        {
                            lab_m_password2.Text = "确认密码不正确！";
                            lab_m_password2.ForeColor = Color.Red;
                        }
                    }
                    break;
                default:
                    if (txt_password2.Text == "")
                    {
                        lab_m_password2.Text = "密码不能为空！";
                        lab_m_password2.ForeColor = Color.Red;
                    }
                    else
                    {
                        if (txt_password1.Text != txt_password2.Text)
                        {
                            lab_m_password2.Text = "输入的确认密码不同！";
                            lab_m_password2.ForeColor = Color.Red;
                        }
                        else
                        {
                            lab_m_password2.Text = "";
                            txt_password2.Tag = 1;
                        }
                    }
                    break;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_xingming.Tag.ToString() == "1" && txt_lianxi.Tag.ToString() == "1" && txt_zhuzhi.Tag.ToString() == "1" && txt_username.Tag.ToString() == "1" && txt_password1.Tag.ToString() == "1" && txt_password2.Tag.ToString() == "1")
            {
                if(rad_nan.Checked == true)
                {
                    rad_nan.Tag = "男";
                }
                else
                {
                    rad_nan.Tag = "女";
                }
                DataSet okDSet = SQLClass.getDataSet("select id from gangwei where gangwei = '" + combox_gw.SelectedItem.ToString() + "' and bumen = '" + combox_bm.SelectedItem.ToString() + "'", "岗位信息表");
                DataTable okdt = okDSet.Tables["岗位信息表"];
                switch(Form_Type)
                {
                    case 0:
                        SQLClass.getsqlcom("insert into yuangong values ('" + txt_xingming.Text.Trim() + "', '" + rad_nan.Tag.ToString() + "', '" + okdt.Rows[0][0].ToString() + "', '" + txt_lianxi.Text.Trim() + "', '" + txt_zhuzhi.Text.Trim() + "', '0', '" + txt_username.Text.Trim() + "', '" + txt_password1.Text.Trim() + "')");
                        Form_OK = 1;
                        break;
                    case 1:
                        if (txt_password1.Text == txt_password2.Text && txt_password1.Text == "" && txt_password2.Text == "")
                        {
                            SQLClass.getsqlcom("update yuangong set xingming = '" + txt_xingming.Text.Trim() + "', xingbie = '" + rad_nan.Tag.ToString() + "', gangweiid = '" + okdt.Rows[0][0].ToString() + "', lianxi = '" + txt_lianxi.Text.Trim() + "', dizhi = '" + txt_zhuzhi.Text.Trim() + "', username = '" + txt_username.Text.Trim() + "' where id = '" + ygid + "'");
                        }
                        else
                        {
                            SQLClass.getsqlcom("update yuangong set xingming = '" + txt_xingming.Text.Trim() + "', xingbie = '" + rad_nan.Tag.ToString() + "', gangweiid = '" + okdt.Rows[0][0].ToString() + "', lianxi = '" + txt_lianxi.Text.Trim() + "', dizhi = '" + txt_zhuzhi.Text.Trim() + "', username = '" + txt_username.Text.Trim() + "', password = '" + txt_password1.Text.Trim() + "' where id = '" + ygid + "'");
                        }
                        Form_OK = 1;
                        break;
                    case 2:
                        Form_OK = 0;
                        break;
                }
                SQLClass.con_close();
                this.Close();
            }
            else
            {
                lab_message.Text = "操作失败，请检查你的输入是否正确！";
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (Form_Type != 2)
            {
                txt_xingming.Text = "";
                txt_xingming.Tag = "0";
                txt_lianxi.Text = "";
                txt_lianxi.Tag = "0";
                txt_zhuzhi.Text = "";
                txt_zhuzhi.Tag = "0";
                txt_username.Text = "";
                txt_username.Tag = "0";
                txt_password1.Text = "";
                txt_password1.Tag = "0";
                txt_password2.Text = "";
                txt_password2.Tag = "0";
            }
        }

        private void combox_bm_SelectedIndexChanged(object sender, EventArgs e)
        {
            gw(combox_bm.Text);
            combox_gw.SelectedIndex = 0;
        }

    }
}
