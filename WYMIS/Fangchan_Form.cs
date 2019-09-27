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
    public partial class Fangchan_Form : Form
    {
        public Fangchan_Form()
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

        public string fcid;
        public string kfsname;
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

        private void Fangchan_Form_Load(object sender, EventArgs e)
        {
            lab_title.Text = this.Text + " - " + lab_title.Text;
            if(Form_Type != 0)
            {
                LoadInfo();
            }
            datetime_riqi.MaxDate = DateTime.Now.Date;
            combox_kfs.SelectedIndex = kfs();
            switch(Form_Type)
            {
                case 0:
                    break;
                case 1:
                    //LoadInfo();
                    break;
                case 2:
                    //LoadInfo();
                    txt_jianzu.ReadOnly = true;
                    txt_dizhi.ReadOnly = true;
                    combox_kfs.Enabled = false;
                    datetime_riqi.Enabled = false;
                    txt_beizhu.ReadOnly = true;
                    break;
            }
        }

        public int kfs()
        {
            int num = 0;
            combox_kfs.Items.Clear();
            DataSet DSet = SQLClass.getDataSet("select gongsi from kaifashang", "开发商信息表");
            DataTable dt = DSet.Tables["开发商信息表"];
            if(dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    if(dt.Rows[i][0].ToString() == kfsname)
                    {
                        num = i;
                    }
                    combox_kfs.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            return num;
        }

        public void LoadInfo()
        {
            DataSet DSet = SQLClass.getDataSet("select * from fangchan where id = '" + fcid + "'", "房产信息表");
            DataTable dt = DSet.Tables["房产信息表"];
            if(dt.Rows.Count > 0)
            {
                txt_jianzu.Text = dt.Rows[0][1].ToString();
                txt_dizhi.Text = dt.Rows[0][2].ToString();
                kfsname = zhuangtai.KaifashangName(dt.Rows[0][3].ToString(),true);
                datetime_riqi.Text = dt.Rows[0][4].ToString();
                txt_beizhu.Text = dt.Rows[0][5].ToString();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if(Form_Type != 2)
            {
                txt_jianzu.Text = "";
                txt_dizhi.Text = "";
                combox_kfs.SelectedIndex = kfs();
                datetime_riqi.Text = DateTime.Now.Date.ToShortDateString();
                txt_beizhu.Text = "";
            }
        }

        private void txt_jianzu_Leave(object sender, EventArgs e)
        {
            if (txt_jianzu.Text == "")
            {
                lab_m_jianzu.Text = "请输入正确的楼房名称！";
                lab_m_jianzu.ForeColor = Color.Red;
            }
            else
            {
                lab_m_jianzu.Text = "";
            }
        }

        private void txt_dizhi_Leave(object sender, EventArgs e)
        {
            if (txt_dizhi.Text == "")
            {
                lab_m_dizhi.Text = "请输入正确的楼房地址！";
                lab_m_dizhi.ForeColor = Color.Red;
            }
            else
            {
                lab_m_dizhi.Text = "";
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(txt_jianzu.Text != "" && txt_dizhi.Text != "")
            {
                switch(Form_Type)
                {
                    case 0:
                        SqlDataReader dr = SQLClass.getcom("select id from fangchan where jianzu = '" + txt_jianzu.Text.ToString().Trim() + "'");
                        bool ifcom = dr.Read();
                        if(ifcom)
                        {
                            MessageBox.Show("该楼房已存在，不能重复添加！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        SQLClass.getsqlcom("insert into fangchan values ('" + txt_jianzu.Text.ToString().Trim() + "','" + txt_dizhi.Text.ToString().Trim() + "','" + zhuangtai.KaifashangName(combox_kfs.SelectedItem.ToString(),false)  + "','" + datetime_riqi.Text + "','" + txt_beizhu.Text.ToString().Trim() + "')");
                        Form_OK = 1;        //操作完成
                        break;
                    case 1:
                        SQLClass.getsqlcom("update fangchan set jianzu = '" + txt_jianzu.Text.ToString().Trim() + "', dizhi = '" + txt_dizhi.Text.ToString().Trim() + "', kaifashangid = '" + zhuangtai.KaifashangName(combox_kfs.SelectedItem.ToString(), false) + "', shijian = '" + datetime_riqi.Text.ToString() + "', beizhu = '" + txt_beizhu.Text.ToString().Trim() + "' where id = '" + fcid + "'");
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
                lab_messgae.Text = "操作失败，请检查你的输入是否正确！";
            }
        }

    }
}
