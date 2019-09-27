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
    public partial class Fuwu_Form : Form
    {
        public Fuwu_Form()
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

        public string yzid;
        public string fwid;
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

        private void txt_shixiang_Leave(object sender, EventArgs e)
        {
            if (Form_Type == 0 || Form_Type == 1 || Form_Type == 4 || Form_Type == 5)
            {
                txt_shixiang.Tag = "0";
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
                        if (zhuangtai.YezhuName(txt_yezhu.Text.Trim(), true) != "")
                        {
                            lab_m_yezhu.Text = "该ID业主为：" + zhuangtai.YezhuName(txt_yezhu.Text.Trim(), true);
                            lab_m_yezhu.ForeColor = Color.Black;
                            txt_yezhu.Tag = "1";
                        }
                        else
                        {
                            lab_m_yezhu.Text = "业主ID不存在！";
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
            if (Form_Type == 2)
            {
                txt_yuangong.Tag = "0";
                if (txt_yuangong.Text == "")
                {
                    lab_m_yuangong.Text = "请输入员工主ID！";
                    lab_m_yuangong.ForeColor = Color.Red;
                }
                else
                {
                    if (Input_Regex.IsNum(txt_yuangong.Text))
                    {
                        if (zhuangtai.YuangongName(txt_yuangong.Text.Trim(), true) != "")
                        {
                            lab_m_yuangong.Text = "该ID员工为：" + zhuangtai.YuangongName(txt_yuangong.Text.Trim(), true);
                            lab_m_yuangong.ForeColor = Color.Black;
                            txt_yuangong.Tag = "1";
                        }
                        else
                        {
                            lab_m_yuangong.Text = "员工ID不存在！";
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
        }

        private void txt_shoufei_Leave(object sender, EventArgs e)
        {
            if (Form_Type == 3)
            {
                txt_shoufei.Tag = "0";
                if (txt_shoufei.Text == "")
                {
                    lab_m_shoufei.Text = "请输入收费金额的信息！";
                    lab_m_yezhu.ForeColor = Color.Red;
                }
                else
                {
                    if (Input_Regex.IsNum(txt_shoufei.Text))
                    {
                        lab_m_shoufei.Text = "";
                        txt_shoufei.Tag = "1";
                    }
                    else
                    {
                        lab_m_shoufei.Text = "收费金额只能为数字！";
                        lab_m_shoufei.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            switch(Form_Type)
            {
                case 0:
                    txt_shixiang.Text = "";
                    txt_shixiang.Tag = "0";
                    txt_yezhu.Text = "";
                    txt_yezhu.Tag = "0";
                    break;
                case 1:
                    txt_shixiang.Text = "";
                    txt_shixiang.Tag = "0";
                    txt_yezhu.Text = "";
                    txt_yezhu.Tag = "0";
                    break;
                case 2:
                    txt_yuangong.Text = "";
                    txt_yuangong.Tag = "";
                    break;
                case 3:
                    txt_shoufei.Text = "";
                    txt_shoufei.Tag = "0";
                    break;
                case 4:
                    txt_shixiang.Text = "";
                    txt_shixiang.Tag = "0";
                    break;
                case 5:
                    txt_shixiang.Text = "";
                    txt_shixiang.Tag = "0";
                    break;
            }
        }

        private void Fuwu_Form_Load(object sender, EventArgs e)
        {
            lab_title.Text = this.Text + " - " + lab_title.Text;
            switch(Form_Type)
            {
                case 0:
                    txt_yuangong.Tag = "1";
                    txt_shoufei.Tag = "1";
                    txt_yuangong.ReadOnly = true;
                    txt_shoufei.ReadOnly = true;
                    break;
                case 1:
                    LoadInfo();
                    txt_shixiang.Tag = "1";
                    txt_yezhu.Tag = "1";
                    txt_yuangong.Tag = "1";
                    txt_shoufei.Tag = "1";
                    txt_yuangong.ReadOnly = true;
                    txt_shoufei.ReadOnly = true;
                    break;
                case 2:
                    LoadInfo();
                    txt_shixiang.Tag = "1";
                    txt_yezhu.Tag = "1";
                    //txt_yuangong.Tag = "1";
                    txt_shoufei.Tag = "1";
                    txt_shixiang.ReadOnly = true;
                    txt_yezhu.ReadOnly = true;
                    txt_shoufei.ReadOnly = true;
                    break;
                case 3:
                    LoadInfo();
                    txt_shixiang.Tag = "1";
                    txt_yezhu.Tag = "1";
                    txt_yuangong.Tag = "1";
                    //txt_shoufei.Tag = "1";
                    txt_shixiang.ReadOnly = true;
                    txt_yezhu.ReadOnly = true;
                    txt_yuangong.ReadOnly = true;
                    break;
                case 4:
                    txt_yezhu.Text = yzid;
                    txt_yezhu.Tag = "1";
                    txt_yuangong.Tag = "1";
                    txt_shoufei.Tag = "1";
                    txt_yezhu.ReadOnly = true;
                    txt_yuangong.ReadOnly = true;
                    txt_shoufei.ReadOnly = true;
                    break;
                case 5:
                    LoadInfo();
                    txt_yezhu.Text = yzid;
                    txt_yezhu.Tag = "1";
                    txt_yuangong.Tag = "1";
                    txt_shoufei.Tag = "1";
                    txt_yezhu.ReadOnly = true;
                    txt_yuangong.ReadOnly = true;
                    txt_shoufei.ReadOnly = true;
                    break;
            }
        }

        public void LoadInfo()
        {
            DataSet DSet = SQLClass.getDataSet("select shixiang,yezhuid,yuangongid,shoufei from fuwu where id = '" + fwid + "'", "服务信息表");
            DataTable dt = DSet.Tables["服务信息表"];
            if(dt.Rows.Count > 0)
            {
                txt_shixiang.Text = dt.Rows[0][0].ToString();
                txt_yezhu.Text = dt.Rows[0][1].ToString();
                txt_yuangong.Text = dt.Rows[0][2].ToString();
                txt_shoufei.Text = dt.Rows[0][3].ToString();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            switch(Form_Type)
            {
                case 0:
                    if(txt_shixiang.Tag.ToString() == "1" && txt_yezhu.Tag.ToString() == "1")
                    {
                        SQLClass.getsqlcom("insert into fuwu values ('" + txt_shixiang.Text.Trim() + "', '" + txt_yezhu.Text.Trim() +  "', '" + DateTime.Now.Date.ToShortDateString() +"', '0', '', '', '', '')");
                    }
                    else
                    {
                        lab_message.Text = "操作失败，请检查你的输入！";
                        return;
                    }
                    Form_OK = 1;
                    break;
                case 1:
                    if (txt_shixiang.Tag.ToString() == "1" && txt_yezhu.Tag.ToString() == "1")
                    {
                        SQLClass.getsqlcom("update fuwu set shixiang = '" + txt_shixiang.Text.Trim() + "', yezhuid = '" + txt_yezhu.Text.Trim() + "', shenqing = '" + DateTime.Now.Date.ToShortDateString() + "' where id = '" + fwid + "'");
                    }
                    else
                    {
                        lab_message.Text = "操作失败，请检查你的输入！";
                        return;
                    }
                    Form_OK = 1;
                    break;
                case 2:
                    if (txt_yuangong.Tag.ToString() == "1")
                    {
                        SQLClass.getsqlcom("update fuwu set yuangongid = '" + txt_yuangong.Text.Trim() + "', queren = '" + DateTime.Now.Date.ToShortDateString() + "', zhuangtai = '1' where id = '" + fwid + "'");
                    }
                    else
                    {
                        lab_message.Text = "操作失败，请检查你的输入！";
                        return;
                    }
                    Form_OK = 1;
                    break;
                case 3:
                    if (txt_shoufei.Tag.ToString() == "1")
                    {
                        DataSet yzDSet = SQLClass.getDataSet("select feiyong from yezhu where id = '" + txt_yezhu.Text.Trim() + "'", "业主信息表");
                        DataTable yzdt = yzDSet.Tables["业主信息表"];
                        if(yzdt.Rows.Count > 0)
                        {
                            sfje = Convert.ToInt32(yzdt.Rows[0][0].ToString()) + Convert.ToInt32(txt_shoufei.Text.Trim());

                        }
                        SQLClass.getsqlcom("update yezhu set feiyong = '" + sfje + "' where id = '" + txt_yezhu.Text.Trim() + "'");
                        SQLClass.getsqlcom("update fuwu set shoufei = '" + txt_shoufei.Text.Trim() + "', zhuangtai = '2', wancheng = '" + DateTime.Now.Date.ToShortDateString() + "' where id = '" + fwid + "'");
                    }
                    else
                    {
                        lab_message.Text = "操作失败，请检查你的输入！";
                        return;
                    }
                    Form_OK = 1;
                    break;
                case 4:
                    if(txt_shixiang.Tag.ToString() == "1")
                    {
                        SQLClass.getsqlcom("insert into fuwu values ('" + txt_shixiang.Text.Trim() + "', '" + txt_yezhu.Text.Trim() +  "', '" + DateTime.Now.Date.ToShortDateString() +"', '0', '', '', '', '')");
                    }
                    else
                    {
                        lab_message.Text = "操作失败，请检查你的输入！";
                        return;
                    }
                    Form_OK = 1;
                    break;
                case 5:
                    if (txt_shixiang.Tag.ToString() == "1")
                    {
                        SQLClass.getsqlcom("update fuwu set shixiang = '" + txt_shixiang.Text.Trim() + "', shenqing = '" + DateTime.Now.Date.ToShortDateString() + "' where id = '" + fwid + "'");
                    }
                    else
                    {
                        lab_message.Text = "操作失败，请检查你的输入！";
                        return;
                    }
                    Form_OK = 1;
                    break;
            }
            SQLClass.con_close();
            this.Close();
        }
    }
}
