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
    public partial class Gangwei_Form : Form
    {
        public Gangwei_Form()
        {
            InitializeComponent();
        }

        public string gwid;
        public string bmname;
        public int Form_Type;
        public int Form_OK;

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

        private void Gangwei_Form_Load(object sender, EventArgs e)
        {
            lab_title.Text = this.Text + " - " + lab_title.Text;
            LoadInfo();
            combox_bm.SelectedIndex = bm();
            switch (Form_Type)
            {
                case 0:
                    break;
                case 1:
                    txt_fuzeren.Tag = 1;
                    break;
                case 2:
                    txt_gangwei.ReadOnly = true;
                    txt_fuzeren.ReadOnly = true;
                    combox_bm.Enabled = false;
                    break;
            }
        }

        public void LoadInfo()
        {
            DataSet DSet = SQLClass.getDataSet("select * from gangwei where id = '" + gwid + "'", "岗位信息表");
            DataTable dt = DSet.Tables["岗位信息表"];
            if(dt.Rows.Count > 0)
            {
                txt_fuzeren.Text = dt.Rows[0][3].ToString();
                txt_gangwei.Text = dt.Rows[0][2].ToString();
            }
        }
        public int bm()
        {
            int num = 0;
            combox_bm.Items.Clear();
            DataSet DSet = SQLClass.getDataSet("select bumen from gangwei group by bumen", "部门信息表");
            DataTable dt = DSet.Tables["部门信息表"];
            if(dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if(dt.Rows[i][0].ToString() == bmname)
                    {
                        num = i;
                    }
                    combox_bm.Items.Add(dt.Rows[i][0].ToString());
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

        private void txt_gangwei_Leave(object sender, EventArgs e)
        {
            txt_gangwei.Tag = 0;
            if (txt_gangwei.Text == "")
            {
                lab_m_gangwei.Text = "岗位不能为空！";
                lab_m_gangwei.ForeColor = Color.Red;
            }
            else
            {
                SqlDataReader dr = SQLClass.getcom("select * from gangwei where gangwei = '" + txt_gangwei.Text + "'");
                bool ifcom = dr.Read();
                if (ifcom)
                {
                    lab_m_gangwei.Text = "你输入的岗位名称已存在";
                    lab_m_gangwei.ForeColor = Color.Red;
                }
                else
                {
                    lab_m_gangwei.Text = "";
                    txt_gangwei.Tag = 1;
                }
            }
        }

        private void txt_fuzeren_Leave(object sender, EventArgs e)
        {
            txt_fuzeren.Tag = 0;
            if (txt_fuzeren.Text == "")
            {
                lab_m_fuzeren.Text = "负责人ID不能为空！";
                lab_m_fuzeren.ForeColor = Color.Red;
            }
            else
            {
                if (Input_Regex.IsNum(txt_fuzeren.Text))
                {
                    DataSet DSet = SQLClass.getDataSet("select xingming from yuangong where id = '" + txt_fuzeren.Text + "'", "员工信息表");
                    DataTable dt = DSet.Tables["员工信息表"];
                    if (dt.Rows.Count > 0)
                    {
                        lab_m_fuzeren.Text = "你输入负责人ID为：" + dt.Rows[0][0].ToString();
                        txt_fuzeren.Tag = 1;
                        lab_m_fuzeren.ForeColor = Color.Black;
                    }
                    else
                    {
                        lab_m_fuzeren.Text = "该负责人ID不存在，请重新输入！";
                        lab_m_fuzeren.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lab_m_fuzeren.Text = "负责人ID只能为数字！";
                    lab_m_fuzeren.ForeColor = Color.Red;
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_gangwei.Text = "";
            txt_gangwei.Tag = "0";
            txt_fuzeren.Text = "";
            txt_fuzeren.Tag = "0";
            combox_bm.SelectedIndex = bm();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(txt_gangwei.Tag.ToString() == "1" && txt_fuzeren.Tag.ToString() == "1" && combox_bm.Tag.ToString() == "1")
            {
                switch (Form_Type)
                {
                    case 0:
                        SqlDataReader sdr = SQLClass.getcom("select id from gangwei where bumen = '" + combox_bm.Text.ToString() + "' and gangwei = '" + txt_gangwei.Text.Trim() + "'");
                        bool ifcom = sdr.Read();
                        if (ifcom)
                        {
                            lab_message.Text = "你输入的岗位已存在，请重新修改后提交！";
                            return;
                        }
                        else
                        {
                            SQLClass.getsqlcom("insert into gangwei values ('" + combox_bm.Text.ToString() + "', '" + txt_gangwei.Text.ToString().Trim() + "', '" + txt_fuzeren.Text.ToString().Trim() + "')");
                            Form_OK = 1;        //操作完成
                        }
                        break;
                    case 1:
                        DataSet gwDSet = SQLClass.getDataSet("select id from gangwei where bumen = '" + combox_bm.Text.ToString() + "' and gangwei = '" + txt_gangwei.Text.Trim() + "'","岗位信息表");
                        DataTable gwdt = gwDSet.Tables["岗位信息表"];
                        if (gwdt.Rows.Count > 0)
                        {
                            if (gwdt.Rows[0][0].ToString() != gwid)
                            {
                                lab_message.Text = "你修改的信息在已存在，请修改后再试！";
                                return;
                            }
                            else
                            {

                            }
                        }
                        else
                        {

                        }
                        SQLClass.getsqlcom("update gangwei set bumen = '" + combox_bm.Text.ToString() + "', gangwei = '" + txt_gangwei.Text.Trim() + "', yuangongid = '" + txt_fuzeren.Text.Trim() + "' where id = '" + gwid + "'");
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

        private void combox_bm_Leave(object sender, EventArgs e)
        {
            if(combox_bm.Text.ToString() == "")
            {
                lab_message.Text = "部门不能为空！";
            }
            else
            {
                combox_bm.Tag = "1";
            }
        }
    }
}
