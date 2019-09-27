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
    public partial class Zhufang_Form : Form
    {
        public Zhufang_Form()
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
        public string zfid;
        public string fcname;
        public int Form_OK;
        public int Form_Type;
        public int yzfy;
        private void Zhufang_Form_Load(object sender, EventArgs e)
        {
            lab_title.Text = this.Text + " - " + lab_title.Text;
            if (Form_Type != 0)
            {
                LoadInfo();
            }
            combox_fc.SelectedIndex = fc();
            switch(Form_Type)
            {
                case 0:
                    rad_wei.Checked = true;
                    rad_wei.Enabled = false;
                    rad_yi.Enabled = false;
                    txt_yezhu.Tag = "1";
                    txt_yezhu.ReadOnly = true;
                    txt_shoufei.Tag = "1";
                    break;
                case 1:
                    rad_wei.Checked = true;
                    rad_wei.Enabled = false;
                    rad_yi.Enabled = false;
                    txt_louceng.Tag = "1";
                    txt_peizhi.Tag = "1";
                    txt_yezhu.Tag = "1";
                    txt_yezhu.ReadOnly = true;
                    txt_shoufei.Tag = "1";
                    break;
                case 2:
                    txt_louceng.Tag = "1";
                    txt_louceng.ReadOnly = true;
                    txt_peizhi.Tag = "1";
                    txt_peizhi.Tag = true;
                    txt_yezhu.Tag = "1";
                    txt_yezhu.ReadOnly = true;
                    rad_wei.Enabled = false;
                    rad_yi.Enabled = false;
                    combox_fc.Enabled = false;
                    txt_shoufei.Tag = "1";
                    txt_shoufei.ReadOnly = true;
                    break;
                case 3:
                    txt_louceng.Tag = "1";
                    txt_louceng.ReadOnly = true;
                    txt_peizhi.Tag = "1";
                    txt_peizhi.ReadOnly = true;
                    rad_yi.Checked = true;
                    rad_wei.Enabled = false;
                    rad_yi.Enabled = false;
                    combox_fc.Enabled = false;
                    txt_shoufei.Tag = "1";
                    txt_shoufei.ReadOnly = true;
                    break;
                case 4:
                    txt_louceng.Tag = "1";
                    txt_louceng.ReadOnly = true;
                    txt_peizhi.Tag = "1";
                    txt_peizhi.Tag = true;
                    txt_yezhu.Text = "";
                    txt_yezhu.Tag = "1";
                    txt_yezhu.ReadOnly = true;
                    rad_wei.Checked = true;
                    rad_wei.Enabled = false;
                    rad_yi.Enabled = false;
                    combox_fc.Enabled = false;
                    txt_shoufei.Tag = "1";
                    txt_shoufei.ReadOnly = true;
                    break;
            }
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
        public void LoadInfo()
        {
            DataSet DSet = SQLClass.getDataSet("select * from zhufang where id = '" + zfid + "'", "住房信息表");
            DataTable dt = DSet.Tables["住房信息表"];
            if (dt.Rows.Count > 0)
            {
                txt_louceng.Text = dt.Rows[0][1].ToString();
                txt_peizhi.Text = dt.Rows[0][2].ToString();
                txt_yezhu.Text = zhuangtai.YezhuName(dt.Rows[0][3].ToString(), true);
                if(zhuangtai.Zhufang(dt.Rows[0][4].ToString()) == "已入住")
                {
                    rad_yi.Checked = true;
                }
                else
                {
                    rad_wei.Checked = true;
                }
                fcname = zhuangtai.FangchanName(dt.Rows[0][5].ToString(), true);
                txt_shoufei.Text = dt.Rows[0][6].ToString();
            }
        }
        public int fc()
        {
            int num = 0;
            combox_fc.Items.Clear();
            DataSet DSet = SQLClass.getDataSet("select jianzu from fangchan", "楼盘信息表");
            DataTable dt = DSet.Tables["楼盘信息表"];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() == fcname)
                    {
                        num = i;
                    }
                    combox_fc.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            return num;
        }

        private void txt_louceng_Leave(object sender, EventArgs e)
        {
            txt_louceng.Tag = 0;
            if (txt_louceng.Text == "")
            {
                lab_m_louceng.Text = "住房楼层不能为空！";
                lab_m_louceng.ForeColor = Color.Red;
            }
            else
            {
                lab_m_louceng.Text = "";
                txt_louceng.Tag = 1;
            }
        }

        private void txt_peizhi_Leave(object sender, EventArgs e)
        {
            txt_peizhi.Tag = 0;
            if (txt_peizhi.Text == "")
            {
                lab_m_peizhi.Text = "请输入住房的配置信息！";
                lab_m_peizhi.ForeColor = Color.Red;
            }
            else
            {
                lab_m_peizhi.Text = "";
                txt_peizhi.Tag = 1;
            }
        }

        private void txt_yezhu_Leave(object sender, EventArgs e)
        {
            if (Form_Type == 0 || Form_Type == 1 || Form_Type == 2)
            {
                return;
            }
            txt_yezhu.Tag = "0";
            if (txt_yezhu.Text != "")
            {
                if (Input_Regex.IsNum(txt_yezhu.Text.Trim()))
                {
                    DataSet yzDSet = SQLClass.getDataSet("select xingming,feiyong from yezhu where id = '" + txt_yezhu.Text.ToString().Trim() + "'","业主信息表");
                    DataTable yzdt = yzDSet.Tables["业主信息表"];
                    if (yzdt.Rows.Count > 0)
                    {
                        lab_m_yezhu.Text = "该业主ID为：" + yzdt.Rows[0][0].ToString();
                        yzfy = Convert.ToInt32(yzdt.Rows[0][1].ToString());
                        txt_yezhu.Tag = 1;
                    }
                    else
                    {
                        lab_m_yezhu.Text = "该业主不存在，请返回修改！";
                        lab_m_yezhu.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lab_m_yezhu.Text = "业主ID只能为数字，请返回修改！";
                    lab_m_yezhu.ForeColor = Color.Red;
                }
            }
            else
            {
                lab_m_yezhu.Text = "业主不能为空，请返回修改！";
                lab_m_yezhu.ForeColor = Color.Red;
            }
        }

        private void txt_shoufei_Leave(object sender, EventArgs e)
        {
            txt_shoufei.Tag = 0;
            if (txt_shoufei.Text == "")
            {
                lab_m_shoufei.Text = "收费信息不能为空！";
                lab_m_shoufei.ForeColor = Color.Red;
            }
            else
            {
                if (Input_Regex.IsNum(txt_shoufei.Text))
                {
                    lab_m_shoufei.Text = "";
                    txt_shoufei.Tag = 1;
                }
                else
                {
                    lab_m_shoufei.Text = "费用信息只能为数字！";
                    lab_m_shoufei.ForeColor = Color.Red;
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            switch(Form_Type)
            {
                case 0:
                    txt_louceng.Text = "";
                    txt_louceng.Tag = "0";
                    txt_peizhi.Text = "";
                    txt_peizhi.Tag = "0";
                    txt_yezhu.Text = "";
                    rad_wei.Checked = true;
                    combox_fc.SelectedIndex = fc();
                    txt_shoufei.Text = "0";
                    break;
                case 1:
                    txt_louceng.Text = "";
                    txt_louceng.Tag = "0";
                    txt_peizhi.Text = "";
                    txt_peizhi.Tag = "0";
                    //txt_yezhu.Text = "";
                    //rad_wei.Checked = true;
                    combox_fc.SelectedIndex = fc();
                    txt_shoufei.Text = "0";
                    break;
                case 2:
                    break;
                case 3:
                    //txt_louceng.Text = "";
                    //txt_louceng.Tag = "0";
                    //txt_peizhi.Text = "";
                    //txt_peizhi.Tag = "0";
                    txt_yezhu.Text = "";
                    //rad_wei.Checked = true;
                    //combox_fc.SelectedIndex = fc();
                    //txt_shoufei.Text = "0";
                    break;
                case 4:
                    break;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if((txt_louceng.Tag.ToString() == "1") && (txt_peizhi.Tag.ToString() == "1") && (txt_yezhu.Tag.ToString() == "1") && (txt_shoufei.Tag.ToString() == "1"))
            {
                string zhufangzt;
                if(rad_wei.Checked)
                {
                    zhufangzt = "0";
                }
                else
                {
                    zhufangzt = "1";
                }
                switch(Form_Type)
                {
                    case 0:
                        SQLClass.getsqlcom("insert into zhufang values ('" + txt_louceng.Text.ToString().Trim() + "','" + txt_peizhi.Text.ToString().Trim() + "','" + zhuangtai.YezhuName(txt_yezhu.Text.ToString().Trim(), false) + "','" + zhufangzt + "','" + zhuangtai.FangchanName(combox_fc.SelectedItem.ToString(), false) + "','" + txt_shoufei.Text.ToString().Trim() + "')");
                        Form_OK = 1;        //操作完成
                        break;
                    case 1:
                        SQLClass.getsqlcom("update zhufang set louceng = '" + txt_louceng.Text.ToString().Trim() + "', peizhi = '" + txt_peizhi.Text.ToString().Trim() + "', yezhuid = '" + zhuangtai.YezhuName(txt_yezhu.Text.ToString().Trim(), false) + "', fangchanid = '" + zhuangtai.FangchanName(combox_fc.SelectedItem.ToString(), false) + "', shoufei = '" + txt_shoufei.Text.ToString().Trim() + "' where id = '" + zfid + "'");
                        Form_OK = 1;
                        break;
                    case 2:
                        Form_OK = 0;
                        break;
                    case 3:
                        if(txt_yezhu.Text == "")
                        {
                            lab_message.Text = "操作失败，请检查你的输入是否正确！";
                            return;
                        }
                        SQLClass.getsqlcom("update zhufang set yezhuid = '" + txt_yezhu.Text.ToString().Trim() + "', zhuangtai = '" + zhufangzt + "' where id = '" + zfid + "'");
                        yzfy += Convert.ToInt32(txt_shoufei.Text);
                        SQLClass.getsqlcom("update yezhu set feiyong = '" + yzfy + "' where id = '" + txt_yezhu.Text.ToString().Trim() + "'");
                        Form_OK = 1;
                        break;
                    case 4:
                        SQLClass.getsqlcom("update zhufang set louceng = '" + txt_louceng.Text.ToString().Trim() + "', peizhi = '" + txt_peizhi.Text.ToString().Trim() + "', yezhuid = '" + zhuangtai.YezhuName(txt_yezhu.Text.ToString().Trim(), false) + "', zhuangtai = '" + zhufangzt + "', fangchanid = '" + zhuangtai.FangchanName(combox_fc.SelectedItem.ToString(), false) + "', shoufei = '" + txt_shoufei.Text.ToString().Trim() + "' where id = '" + zfid + "'");
                        Form_OK = 1;
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
