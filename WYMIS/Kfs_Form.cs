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
    public partial class Kfs_Form : Form
    {
        public Kfs_Form()
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

        public string kfsid;
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

        private void Kfs_Form_Load(object sender, EventArgs e)
        {
            lab_title.Text = this.Text + " - " + lab_title.Text;
            switch(Form_Type)
            {
                case 0:
                    break;
                case 1:
                    LoadInfo();     //调用自定义方法LoadInfo()，队窗体中的控件进行赋值
                    break;
                case 2:
                    LoadInfo();
                    txt_gongsi.ReadOnly = true;
                    txt_fuzeren.ReadOnly = true;
                    txt_lianxi.ReadOnly = true;
                    txt_dizhi.ReadOnly = true;
                    break;
            }
        }

        private void LoadInfo()
        {
            //创建一个DataSet对象，并把SQL的查询结果赋值给DSet
            DataSet Dset = SQLClass.getDataSet("select * from kaifashang where id = '" + kfsid + "'","开发商信息");
            DataTable dt = Dset.Tables["开发商信息"];        //创建一个DataTable对象
            txt_gongsi.Text = dt.Rows[0][1].ToString();
            txt_fuzeren.Text = dt.Rows[0][4].ToString();
            txt_lianxi.Text = dt.Rows[0][3].ToString();
            txt_dizhi.Text = dt.Rows[0][2].ToString();
        }

        private void txt_gongsi_Leave(object sender, EventArgs e)
        {
            if(txt_gongsi.Text == "")
            {
                lab_m_gongsi.Text = "请输入正确的开发商名称！";
                lab_m_gongsi.ForeColor = Color.Red;
            }
            else
            {
                lab_m_gongsi.Text = "";
            }
        }

        private void txt_fuzeren_Leave(object sender, EventArgs e)
        {
            if (txt_fuzeren.Text == "")
            {
                lab_m_fuzeren.Text = "请输入正确的负责人名称！";
                lab_m_fuzeren.ForeColor = Color.Red;
            }
            else
            {
                lab_m_fuzeren.Text = "";
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

        private void txt_dizhi_Leave(object sender, EventArgs e)
        {
            if (!Convert.ToBoolean(txt_dizhi.Text.Count()))
            {
                lab_m_dizhi.Text = "请输入你的住址！";
                lab_m_dizhi.ForeColor = Color.Red;
            }
            else
            {
                lab_m_dizhi.Text = "";
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (Form_Type != 2)
            {
                txt_gongsi.Text = "";
                txt_fuzeren.Text = "";
                txt_lianxi.Text = "";
                txt_dizhi.Text = "";
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_gongsi.Text != "" && txt_fuzeren.Text != "" && (txt_lianxi.Text != "" && Input_Regex.IsPhoneNum(txt_lianxi.Text)) && Convert.ToBoolean(txt_dizhi.Text.Count()))
            {
                switch (Form_Type)
                {
                    case 0:
                        SqlDataReader dr = SQLClass.getcom("select id from kaifashang where gongsi = '" + txt_gongsi.Text.ToString().Trim() + "'");
                        bool ifcom = dr.Read();
                        if(ifcom)
                        {
                            MessageBox.Show("该开发商已存在，不能重复添加！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        SQLClass.getsqlcom("insert into kaifashang values ('" + txt_gongsi.Text.ToString().Trim() + "','" + txt_dizhi.Text.ToString().Trim() + "','" + txt_lianxi.Text.ToString().Trim() + "','" + txt_fuzeren.Text.ToString().Trim() + "')");
                        Form_OK = 1;        //操作完成
                        break;
                    case 1:
                        SQLClass.getsqlcom("update kaifashang set gongsi = '" + txt_gongsi.Text.ToString().Trim() + "', fuzeren = '" + txt_fuzeren.Text.ToString().Trim() + "', lianxi = '" + txt_lianxi.Text.ToString().Trim() + "', dizhi = '" + txt_dizhi.Text.ToString().Trim() + "' where id = '" + kfsid + "'");
                        Form_OK = 1;
                        break;
                    case 2:
                        Form_OK = 0;        //没有执行相关操作
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
    }
}
