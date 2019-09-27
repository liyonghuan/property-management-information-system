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
    public partial class Login_Form : Form
    {
        public Login_Form()
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

        private void Login_Form_Load(object sender, EventArgs e)
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
                Application.Exit();       //关闭整个工程
            }
        }

        private void pbox_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbox_min_MouseHover(object sender, EventArgs e)
        {
            pbox_min.Image = Image.FromFile("images/min_mouse.png");
        }

        private void pbox_min_MouseLeave(object sender, EventArgs e)
        {
            pbox_min.Image = Image.FromFile("images/min.png");
        }

        private void pbox_close_MouseHover(object sender, EventArgs e)
        {
            pbox_close.Image = Image.FromFile("images/close_mouse.png");
        }

        private void pbox_close_MouseLeave(object sender, EventArgs e)
        {
            pbox_close.Image = Image.FromFile("images/close.png");
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if(txt_username.Text == "请输入用户名")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.Black;
            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if(txt_username.Text == "")
            {
                txt_username.Text = "请输入用户名";
                txt_username.ForeColor = Color.Gray;
            }
            else
            {
                txt_username.ForeColor = Color.Black;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if(txt_password.Text == "请输入密码")
            {
                txt_password.PasswordChar = '*';
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "" || txt_password.Text == "请输入密码")
            {
                txt_password.PasswordChar = Convert.ToChar(0);
                txt_password.Text = "请输入密码";
                txt_password.ForeColor = Color.Gray;
            }
            else
            {
                txt_password.ForeColor = Color.Black;
            }
        }

        private void picbox_header_Click(object sender, EventArgs e)
        {
            if (picbox_header.Tag.ToString() == "yuangong")
            {
                picbox_header.Image = Image.FromFile("images/yezhu.png");
                picbox_header.Tag = "yezhu";
            }
            else
            {
                picbox_header.Image = Image.FromFile("images/yuangong.png");
                picbox_header.Tag = "yuangong";
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (Input_Regex.IsNumAndEnCh(txt_username.Text) && txt_username.Text != "请输入用户名")
            {
                if (txt_password.Text != "请输入密码")
                {
                    if (txt_username.Text != null && txt_password.Text != null)
                    {
                        lab_message.Text = "正在尝试登陆，请稍后......";
                        if (picbox_header.Tag.ToString() == "yuangong")
                        {
                            DataSet ygDSet = SQLClass.getDataSet("select * from yuangong where username = '" + txt_username.Text.Trim() + "' and password = '" + txt_password.Text.Trim() + "'", "员工信息表");
                            DataTable ygdt = ygDSet.Tables["员工信息表"];
                            if(ygdt.Rows.Count > 0)
                            {
                                if(ygdt.Rows[0][6].ToString() == "0")
                                {
                                    lab_message.Text = "你不是管理员不能够登录该系统！";
                                    return;
                                }
                                else if(ygdt.Rows[0][6].ToString() == "1" || ygdt.Rows[0][6].ToString() == "2")
                                {
                                    this.Visible = false;
                                    Main_Yuangong_Form mainForm = new Main_Yuangong_Form();
                                    DataSet gwDSet = SQLClass.getDataSet("select * from gangwei where id = '" + ygdt.Rows[0][3].ToString() + "'", "岗位信息表");
                                    DataTable gwdt = gwDSet.Tables["岗位信息表"];
                                    mainForm.glyid = Convert.ToInt32(ygdt.Rows[0][0].ToString());
                                    mainForm.glyxm = ygdt.Rows[0][1].ToString();
                                    mainForm.glyxb = ygdt.Rows[0][2].ToString();
                                    mainForm.glybm = gwdt.Rows[0][1].ToString();
                                    mainForm.glygw = gwdt.Rows[0][2].ToString();
                                    mainForm.glylx = ygdt.Rows[0][4].ToString();
                                    mainForm.glydz = ygdt.Rows[0][5].ToString();
                                    mainForm.glyqx = Convert.ToInt32(ygdt.Rows[0][6].ToString());
                                    mainForm.glyyhm = ygdt.Rows[0][7].ToString();
                                    mainForm.ShowDialog();      //显示主窗体
                                    if (mainForm.changeuser)
                                    {
                                        txt_username.Text = "请输入用户名";
                                        txt_password.Text = "请输入密码";
                                        lab_message.Text = "";
                                        txt_password.PasswordChar = Convert.ToChar(0);
                                        txt_username.ForeColor = Color.Gray;
                                        txt_password.ForeColor = Color.Gray;
                                        btn_ok.Focus();
                                        this.Visible = true;
                                    }
                                    else
                                    {
                                        Application.Exit();
                                    }
                                }
                            }
                            else
                            {
                                lab_message.Text = "登录失败，请检查你的用户名或密码是否正确！";
                                return;
                            }
                        }
                        else if(picbox_header.Tag.ToString() == "yezhu")
                        {
                            DataSet yzDSet = SQLClass.getDataSet("select * from yezhu where username = '" + txt_username.Text.Trim() + "' and password = '" + txt_password.Text.Trim() + "'", "业主信息表");
                            DataTable yzdt = yzDSet.Tables["业主信息表"];
                            if (yzdt.Rows.Count > 0)
                            {
                                if (yzdt.Rows[0][6].ToString() == "0")
                                {
                                    lab_message.Text = "你的账号尚未通过管理员的审核，暂时不能登录！";
                                    return;
                                }
                                else if (yzdt.Rows[0][6].ToString() == "1")
                                {
                                    this.Visible = false;
                                    Main_Yezhu_Form mainForm = new Main_Yezhu_Form();
                                    mainForm.yzid = Convert.ToInt32(yzdt.Rows[0][0].ToString());
                                    mainForm.yzxm = yzdt.Rows[0][1].ToString();
                                    mainForm.yzxb = yzdt.Rows[0][2].ToString();
                                    mainForm.yzlx = yzdt.Rows[0][3].ToString();
                                    mainForm.yzzz = yzdt.Rows[0][4].ToString();
                                    mainForm.yzsfz = yzdt.Rows[0][5].ToString();
                                    mainForm.yzqx = Convert.ToInt32(yzdt.Rows[0][6].ToString());
                                    mainForm.yzyhm = yzdt.Rows[0][7].ToString();
                                    mainForm.yzfy = Convert.ToInt32(yzdt.Rows[0][9].ToString());
                                    mainForm.ShowDialog();
                                    if(mainForm.changeuser)
                                    {
                                        txt_username.Text = "请输入用户名";
                                        txt_password.Text = "请输入密码";
                                        lab_message.Text = "";
                                        txt_password.PasswordChar = Convert.ToChar(0);
                                        txt_username.ForeColor = Color.Gray;
                                        txt_password.ForeColor = Color.Gray;
                                        btn_ok.Focus();
                                        this.Visible = true;
                                    }
                                    else
                                    {
                                        Application.Exit();
                                    }
                                }
                                else if (yzdt.Rows[0][6].ToString() == "2")
                                {
                                    lab_message.Text = "你的账号处于禁用状态，不能登录！";
                                    return;
                                }
                            }
                            else
                            {
                                lab_message.Text = "登录失败，请检查你的用户名或密码是否正确！";
                                return;
                            }

                        }
                    }
                    else
                    {
                        lab_message.Text = "请检查您的用户名是否正确。";
                    }
                }
                else
                {
                    lab_message.Text = "请输入正确的密码。";
                }
            }
            else 
            {
                lab_message.Text = "请输入正确的用户名。";
            }
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Reg_Form regForm = new Reg_Form();
            regForm.ShowDialog();
            this.Visible = true;
        }

    }
}
