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
    public partial class Shoufei_Form : Form
    {
        public Shoufei_Form()
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

        public string sfid;
        public string yzid;
        public int sfje;
        public int Form_OK;
        public int Form_Type;

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

        private void Shoufei_Form_Load(object sender, EventArgs e)
        {
            lab_title.Text = this.Text + " - " + lab_title.Text;
            date_shijian.MaxDate = DateTime.Now.Date;
            switch(Form_Type)
            {
                case 0:
                    if (yzid != "")
                    {
                        txt_yezhu.Text = yzid;
                        txt_yezhu_Leave(sender, e);
                    }
                    date_shijian.Enabled = false;
                    txt_yuangong.Tag = "1";
                    txt_yuangong.ReadOnly = true;
                    break;
                case 1:     //修改费用信息
                    LoadInfo();
                    //sfje = Convert.ToInt32(txt_jine.Text.Trim());
                    date_shijian.Enabled = false;
                    txt_yuangong.Tag = "1";
                    txt_yuangong.ReadOnly = true;
                    txt_yezhu.Tag = "1";
                    txt_yezhu.ReadOnly = true;
                    txt_shixiang.Tag = "1";
                    txt_jine.Tag = "1";
                    break;
                case 2:     //查看费用信息，暂时不启用此功能
                    LoadInfo();
                    break;
                case 3:     //设置成缴费
                    LoadInfo();
                    txt_shixiang.Tag = "1";
                    txt_shixiang.ReadOnly = true;
                    txt_jine.Tag = "1";
                    txt_jine.ReadOnly = true;
                    txt_yezhu.Tag = "1";
                    txt_yezhu.ReadOnly = true;
                    txt_beizhu.ReadOnly = true;
                    date_shijian.Value = DateTime.Now.Date;
                    break;
                case 4:
                    break;
            }
        }

        public void LoadInfo()
        {
            DataSet DSet = SQLClass.getDataSet("select * from shoufei where id = '" + sfid + "'", "收费信息表");
            DataTable dt = DSet.Tables["收费信息表"];
            if(dt.Rows.Count > 0)
            {
                txt_shixiang.Text = dt.Rows[0][1].ToString();
                txt_jine.Text = dt.Rows[0][2].ToString();
                date_shijian.Text = dt.Rows[0][4].ToString();
                txt_yezhu.Text = dt.Rows[0][5].ToString();
                txt_yuangong.Text = dt.Rows[0][6].ToString();
                txt_beizhu.Text = dt.Rows[0][7].ToString();
            }
        }

        private void txt_shixiang_Leave(object sender, EventArgs e)
        {
            if (Form_Type == 3)
            {
                return;
            }
            else
            {
                if (txt_shixiang.Text == "")
                {
                    lab_m_shixiang.Text = "请输入事项名称！";
                    lab_m_shixiang.ForeColor = Color.Red;
                }
                else
                {
                    lab_m_shixiang.Text = "";
                    txt_shixiang.Tag = "1";
                }
            }
        }

        private void txt_jine_Leave(object sender, EventArgs e)
        {
            if (Form_Type == 3)
            {
                return;
            }
            else
            {
                txt_jine.Tag = "0";
                if (txt_jine.Text == "")
                {
                    lab_m_jine.Text = "金额不能为空！";
                    lab_m_jine.ForeColor = Color.Red;
                }
                else
                {
                    if (Input_Regex.IsNum(txt_jine.Text))
                    {
                        lab_m_jine.Text = "";
                        txt_jine.Tag = "1";
                    }
                    else
                    {
                        lab_m_jine.Text = "金额只能为数字！";
                        lab_m_jine.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void txt_yezhu_Leave(object sender, EventArgs e)
        {
            if (Form_Type == 0 || Form_Type == 1)
            {
                txt_yezhu.Tag = "0";
                if (txt_yezhu.Text == "")
                {
                    lab_m_yezhu.Text = "请输入业主ID！";
                    lab_m_yezhu.ForeColor = Color.Red;
                }
                else
                {
                    if (Input_Regex.IsNum(txt_yezhu.Text))
                    {
                        DataSet yzDSet = SQLClass.getDataSet("select xingming from yezhu where id = '" + txt_yezhu.Text + "'", "业主信息表");
                        DataTable yzdt = yzDSet.Tables["业主信息表"];
                        if (yzdt.Rows.Count > 0)
                        {

                            lab_m_yezhu.Text = "你输入的业主名称为：" + yzdt.Rows[0][0].ToString();
                            lab_m_yezhu.ForeColor = Color.Black;
                            txt_yezhu.Tag = "1";
                        }
                        else
                        {
                            lab_m_yezhu.Text = "你输入的业主ID不存在！";
                            lab_m_yezhu.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        lab_m_yezhu.Text = "业主ID只能为数字！";
                        lab_m_yezhu.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void txt_yuangong_Leave(object sender, EventArgs e)
        {
            if (Form_Type == 3)
            {
                txt_yuangong.Tag = "0";
                if (txt_yuangong.Text == "")
                {
                    lab_m_yuangong.Text = "请输入员工ID！";
                    lab_m_yuangong.ForeColor = Color.Red;
                }
                else
                {
                    if (Input_Regex.IsNum(txt_yuangong.Text))
                    {
                        DataSet ygDSet = SQLClass.getDataSet("select xingming from yuangong where id = '" + txt_yuangong.Text.Trim() + "'", "员工信息表");
                        DataTable ygdt = ygDSet.Tables["员工信息表"];
                        if (ygdt.Rows.Count > 0)
                        {

                            lab_m_yuangong.Text = "你输入的员工名称为：" + ygdt.Rows[0][0].ToString();
                            lab_m_yuangong.ForeColor = Color.Black;
                            txt_yuangong.Tag = "1";
                        }
                        else
                        {
                            lab_m_yuangong.Text = "你输入的员工ID不存在！";
                            lab_m_yuangong.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        lab_m_yuangong.Text = "员工ID只能为数字！";
                        lab_m_yuangong.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                //lab_m_yuangong.Text = "未知错误！";
                //lab_m_yuangong.ForeColor = Color.Red;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(Form_Type == 3)
            {
                txt_yuangong.Text = "";
                txt_yuangong.Tag = "0";
            }
            else
            {
                txt_shixiang.Text = "";
                txt_shixiang.Tag = "0";
                txt_jine.Text = "";
                txt_jine.Tag = "0";
                txt_yezhu.Text = "";
                txt_yezhu.Tag = "0";
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            switch (Form_Type)
            {
                case 0:
                    if (txt_shixiang.Tag.ToString() == "1" && txt_jine.Tag.ToString() == "1" && txt_yezhu.Tag.ToString() == "1")
                    {
                        //DataSet yzDSet = SQLClass.getDataSet("select feiyong from yezhu where id = '" + txt_yezhu.Text.Trim() + "'", "业主信息表");
                        //DataTable yzdt = yzDSet.Tables["业主信息表"];
                        //sfje = Convert.ToInt32(yzdt.Rows[0][0].ToString()) + Convert.ToInt32(txt_jine.Text.Trim());
                        //SQLClass.getsqlcom("update yezhu set feiyong = '" + sfje + "' where id = '" + txt_yezhu.Text.Trim() + "'");
                        SQLClass.getsqlcom("insert into shoufei values ('" + txt_shixiang.Text + "', '" + txt_jine.Text.Trim() + "', '0', '', '" + txt_yezhu.Text + "', '', '" + txt_beizhu.Text + "')");
                        Form_OK = 1;
                    }
                    else
                    {
                        lab_message.Text = "操作失败，请检查后再试！";
                        return;
                    }
                    break;
                case 1:
                    if (txt_shixiang.Tag.ToString() == "1" && txt_jine.Tag.ToString() == "1" && txt_yezhu.Tag.ToString() == "1")
                    {
                        SQLClass.getsqlcom("update shoufei set shixiang = '" + txt_shixiang.Text + "', jine = '" + txt_jine.Text.Trim() + "', yezhuid = '" + txt_yezhu.Text.Trim() + "', beizhu = '" + txt_beizhu.Text + "' where id = '" + sfid + "'");
                        Form_OK = 1;
                    }
                    else
                    {
                        lab_message.Text = "操作失败，请检查后再试！";
                        return;
                    }
                    break;
                case 2:

                    break;
                case 3:
                    if (txt_yuangong.Tag.ToString() == "1")
                    {
                        DataSet yzDSet = SQLClass.getDataSet("select feiyong from yezhu where id = '" + txt_yezhu.Text.Trim() + "'", "业主信息表");
                        DataTable yzdt = yzDSet.Tables["业主信息表"];
                        if (yzdt.Rows.Count > 0)
                        {
                            sfje = Convert.ToInt32(yzdt.Rows[0][0].ToString()) - Convert.ToInt32(txt_jine.Text);
                        }
                        SQLClass.getsqlcom("update shoufei set shijian = '" + date_shijian.Text.ToString() + "', yuangongid = '" + txt_yuangong.Text.Trim() + "', leixing = '1' where id = '" + sfid + "'");
                        SQLClass.getsqlcom("update yezhu set feiyong = '" + sfje + "' where id = '" + txt_yezhu.Text.Trim() + "'");
                        Form_OK = 1;
                    }
                    else
                    {
                        lab_message.Text = "操作失败，请检查后再试！";
                        return;
                    }
                    break;

            }
            SQLClass.con_close();
            this.Close();
        }
    }
}
