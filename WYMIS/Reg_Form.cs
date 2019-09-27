using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WYMIS
{
    public partial class Reg_Form : Form
    {
        public Reg_Form()
        {
            InitializeComponent();
        }

        SQL_Class SQLClass = new SQL_Class();

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

        public string yzid;
        public int Form_OK;
        public int Form_Type;


        private void Reg_Form_Load(object sender, EventArgs e)
        {
            lab_title.Text = this.Text + " - " + lab_title.Text;
            try
            {
                SQL_Class.getcon();       //连接数据库
            }
            catch
            {
                //当连接数据库失败时，显示错误信息
                MessageBox.Show("数据库连接失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();       //关闭窗口
            }
            switch(Form_Type)
            {
                case 0:
                    break;
                case 1:
                    LoadInfo();
                    break;
                case 2:
                    break;
            }
        }

        public void LoadInfo()
        {
            DataSet DSet = SQLClass.getDataSet("select * from yezhu where id = '" + yzid + "'", "业主信息表");
            DataTable dt = DSet.Tables["业主信息表"];
            if(dt.Rows.Count > 0)
            {
                txt_xingming.Text = dt.Rows[0][1].ToString();
                if(dt.Rows[0][2].ToString() == "男")
                {
                    rdo_nan.Checked = true;
                }
                else
                {
                    rdo_nv.Checked = true;
                }
                txt_lianxi.Text = dt.Rows[0][3].ToString();
                txt_zhuzhi.Text = dt.Rows[0][4].ToString();
                txt_shenfenzheng.Text = dt.Rows[0][5].ToString();
                txt_username.Text = dt.Rows[0][7].ToString();
            }
        }

        private void picbox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picbox_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_xingming.Text = "";
            rdo_nan.Checked = true;
            txt_lianxi.Text = "";
            txt_shenfenzheng.Text = "";
            txt_zhuzhi.Text = "";
            txt_username.Text = "";
            txt_password1.Text = "";
            txt_password2.Text = "";
        }

        private void txt_xingming_Leave(object sender, EventArgs e)
        {
            if(txt_xingming.Text == "")
            {
                lab_m_xingming.Text = "请输入你的姓名！";
                lab_m_xingming.ForeColor = Color.Red;
            }
            else
            {
                lab_m_xingming.Text = "";
            }
        }

        private void txt_lianxi_Leave(object sender, EventArgs e)
        {
            if (!Input_Regex.IsPhoneNum(txt_lianxi.Text) || txt_lianxi.Text == "")
            {
                lab_m_lianxi.Text = "请输入正确的联系方式！";
                lab_m_lianxi.ForeColor = Color.Red;
            }
            else
            {
                lab_m_lianxi.Text = "";
            }
        }

        private void txt_shenfenzheng_Leave(object sender, EventArgs e)
        {
            if (!Input_Regex.IsIdCard(txt_shenfenzheng.Text))
            {
                lab_m_shenfenzheng.Text = "请输入正确的身份证号码！";
                lab_m_shenfenzheng.ForeColor = Color.Red;
            }
            else
            {
                lab_m_shenfenzheng.Text = "";
            }
        }

        private void txt_zhuzhi_Leave(object sender, EventArgs e)
        {
            if(!Convert.ToBoolean(txt_zhuzhi.Text.Count()))
            {
                lab_m_zhuzhi.Text = "请输入你的住址1！";
                lab_m_zhuzhi.ForeColor = Color.Red;
            }
            else
            {
                lab_m_zhuzhi.Text = "";
            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if(!Input_Regex.IsNumAndEnCh(txt_username.Text) || txt_username.Text == "")
            {
                lab_m_username.Text = "请输入正确的登陆用户名！";
                lab_m_username.ForeColor = Color.Red;
            }
            else
            {
                SQL_Class SQLClass = new SQL_Class();
                SqlDataReader dr = SQLClass.getcom("select * from yezhu where username = '" + txt_username.Text + "'");
                bool ifcom = dr.Read();
                if (ifcom)
                {
                    lab_m_username.Text = "登陆用户名已存在！";
                    lab_m_username.ForeColor = Color.Red;
                }
                else
                {
                    lab_m_username.Text = "";
                }
            }
        }

        private void txt_password1_Leave(object sender, EventArgs e)
        {
            if (Form_Type == 1)
            {

            }
            else
            {
                if (txt_password1.Text == "")
                {
                    lab_m_password1.Text = "请输入你的密码！";
                    lab_m_password1.ForeColor = Color.Red;
                }
                else if (txt_password2.Text != "" && (txt_password2.Text != txt_password1.Text))
                {
                    lab_m_password2.Text = "确认密码与之前的密码不符！";
                    lab_m_password2.ForeColor = Color.Red;
                }
                else
                {
                    lab_m_password1.Text = "";
                }
            }
        }

        private void txt_password2_Leave(object sender, EventArgs e)
        {
            if (Form_Type == 1)
            {

            }
            else
            {
                if (txt_password2.Text == "")
                {
                    lab_m_password2.Text = "确认密码不能为空！";
                    lab_m_password2.ForeColor = Color.Red;
                }
                else if (txt_password2.Text != txt_password1.Text)
                {
                    lab_m_password2.Text = "确认密码与之前的密码不符！";
                    lab_m_password2.ForeColor = Color.Red;
                }
                else
                {
                    lab_m_password2.Text = "";
                }
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (Form_Type == 1)
            {
                if (txt_xingming.Text != "" && (Input_Regex.IsPhoneNum(txt_lianxi.Text) && txt_lianxi.Text != "") && (Input_Regex.IsIdCard(txt_shenfenzheng.Text) && txt_shenfenzheng.Text != "") && (Convert.ToBoolean(txt_zhuzhi.Text.Count()) && txt_zhuzhi.Text != "") && (Input_Regex.IsNumAndEnCh(txt_username.Text) || txt_username.Text != ""))
                {
                    if (rdo_nv.Checked == true)
                    {
                        rdo_nan.Tag = "女";
                    }
                    else
                    {
                        rdo_nan.Tag = "男";
                    }
                    if (txt_password1.Text != "" && txt_password2.Text != "" && txt_password2.Text == txt_password1.Text)
                    {
                        SQLClass.getsqlcom("update yezhu set xingming = '" + txt_xingming.Text.ToString().Trim() + "', xingbie = '" + rdo_nan.Tag.ToString() + "', lianxi = '" + txt_lianxi.Text.ToString().Trim() + "', zhuzhi = '" + txt_zhuzhi.Text.ToString().Trim() + "', shenfenzheng = '" + txt_shenfenzheng.Text.ToString().Trim() + "', username = '" + txt_username.Text.ToString().Trim() + "', password = '" + txt_password1.Text.ToString().Trim() + "' where id = '" + yzid + "'");
                    }
                    else
                    {
                        SQLClass.getsqlcom("update yezhu set xingming = '" + txt_xingming.Text.ToString().Trim() + "', xingbie = '" + rdo_nan.Tag.ToString() + "', lianxi = '" + txt_lianxi.Text.ToString().Trim() + "', zhuzhi = '" + txt_zhuzhi.Text.ToString().Trim() + "', shenfenzheng = '" + txt_shenfenzheng.Text.ToString().Trim() + "', username = '" + txt_username.Text.ToString().Trim() + "' where id = '" + yzid + "'");
                    }
                    Form_OK = 1;
                    this.Close();
                }
                else
                {
                    lab_message_reg.Text = "修改失败，请检查输入是否正确！";
                }
            }
            else
            {
                SqlDataReader dr = SQLClass.getcom("select * from yezhu where username = '" + txt_username.Text + "'");
                bool ifcom = dr.Read();
                if (!ifcom)
                {
                    if (txt_xingming.Text != "" && (Input_Regex.IsPhoneNum(txt_lianxi.Text) && txt_lianxi.Text != "") && (Input_Regex.IsIdCard(txt_shenfenzheng.Text) && txt_shenfenzheng.Text != "") && (Convert.ToBoolean(txt_zhuzhi.Text.Count()) && txt_zhuzhi.Text != "") && (Input_Regex.IsNumAndEnCh(txt_username.Text) || txt_username.Text != "") && txt_password1.Text != "" && txt_password2.Text != "" && txt_password2.Text == txt_password1.Text)
                    {
                        //lab_message_reg.Text = "注册成功，请等待管理员审核！";
                        if (rdo_nv.Checked == true)
                        {
                            rdo_nan.Tag = "女";
                        }
                        else
                        {
                            rdo_nan.Tag = "男";
                        }
                        SQLClass.getsqlcom("insert into yezhu values ('" + txt_xingming.Text + "','" + rdo_nan.Tag.ToString() + "','" + txt_lianxi.Text + "','" + txt_zhuzhi.Text + "','" + txt_shenfenzheng.Text + "','0','" + txt_username.Text + "','" + txt_password1.Text + "','0')");
                        //if (Form_Type == 0)
                        //{

                        //}
                        //else
                        //{

                        //}
                        Form_OK = 1;
                        MessageBox.Show("注册成功，请等待管理员审核！", "注册成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        lab_message_reg.Text = "注册失败，请检查输入是否正确！";
                    }
                }
                else
                {
                    MessageBox.Show("注册失败，你的输入的用户名已存在！", "注册失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
