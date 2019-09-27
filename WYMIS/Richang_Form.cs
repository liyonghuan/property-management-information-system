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
    public partial class Richang_Form : Form
    {
        public Richang_Form()
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

        public string rcid;
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

        private void txt_shixiang_Leave(object sender, EventArgs e)
        {
            txt_shixiang.Tag = "0";
            if(txt_shixiang.Text == "")
            {
                lab_m_shixiang.Text = "输入的日常事项名称不能为空！";
                lab_m_shixiang.ForeColor = Color.Red;
            }
            else
            {
                lab_m_shixiang.Text = "";
                txt_shixiang.Tag = "1";
            }
        }

        private void txt_yuangong_Leave(object sender, EventArgs e)
        {
            txt_yuangong.Tag = "0";
            if(txt_yuangong.Text == "")
            {
                lab_m_yuangong.Text = "输入的日常事项名称不能为空！";
                lab_m_yuangong.ForeColor = Color.Red;
            }
            else
            {
                DataSet DSet = SQLClass.getDataSet("select xingming from yuangong where id = '" + txt_yuangong.Text.Trim() + "'", "员工信息表");
                DataTable dt = DSet.Tables["员工信息表"];
                if(dt.Rows.Count > 0)
                {
                    lab_m_yuangong.Text = "该ID的员工姓名为：" + dt.Rows[0][0].ToString();
                    lab_m_yuangong.ForeColor = Color.Black;
                    txt_yuangong.Tag = "1";
                }
                else
                {
                    lab_m_yuangong.Text = "输入员工ID不存在！";
                    lab_m_yuangong.ForeColor = Color.Red;
                }
            }
        }

        private void Richang_Form_Load(object sender, EventArgs e)
        {
            lab_title.Text = this.Text + " - " + lab_title.Text;
            switch(Form_Type)
            {
                case 0:
                    date_shijian.MinDate = DateTime.Now.Date;
                    break;
                case 1:
                    LoadInfo();
                    break;
                case 2:
                    LoadInfo();
                    break;
            }
        }

        public void LoadInfo()
        {
            DataSet DSet = SQLClass.getDataSet("select * from richang where id = '" + rcid + "'", "日常信息表");
            DataTable dt = DSet.Tables["日常信息表"];
            if(dt.Rows.Count > 0)
            {
                txt_shixiang.Text = dt.Rows[0][1].ToString();
                date_shijian.Text = dt.Rows[0][2].ToString();
                txt_yuangong.Text = dt.Rows[0][4].ToString();
                txt_beizhu.Text = dt.Rows[0][5].ToString();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if(Form_Type == 2)
            {
                return;
            }
            else
            {
                txt_shixiang.Text = "";
                txt_shixiang.Tag = "0";
                txt_yuangong.Text = "";
                txt_yuangong.Tag = "0";
                txt_beizhu.Text = "";
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(txt_shixiang.Tag.ToString() == "1" && txt_yuangong.Tag.ToString() == "1")
            {
                switch(Form_Type)
                {
                    case 0:
                        SQLClass.getcom("insert into richang values ('" + txt_shixiang.Text.Trim() + "', '" + date_shijian.Text.ToString() + "', '0', '" + txt_yuangong.Text.Trim() + "', '" + txt_beizhu.Text.Trim() + "')");
                        Form_OK = 1;
                        break;
                    case 1:
                        SQLClass.getcom("update richang set shixiang = '" + txt_shixiang.Text.Trim() + "',shijian = '" + date_shijian.ToString() + "', yuangongid = '" + txt_yuangong.Text.Trim() + ", beizhu = '" + txt_beizhu.Text.Trim() + "' where id = '" + rcid + "'");
                        Form_OK = 1;
                        break;
                    case 2:
                        break;
                }
                SQLClass.con_close();
                this.Close();
            }
        }
    }
}
