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

namespace WYMIS
{
    public partial class Bumen_Form : Form
    {
        public Bumen_Form()
        {
            InitializeComponent();
        }

        public string bmname;
        //public int Form_Type;
        public int Form_OK;

        SQL_Class SQLClass = new SQL_Class();

        private void Bumen_Form_Load(object sender, EventArgs e)
        {
            txt_bumen.Text = bmname;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(txt_bumen.Text == "")
            {
                MessageBox.Show("部门名称不能为空！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SQLClass.getsqlcom("update gangwei set bumen = '" + txt_bumen.Text + "' where bumen = '" + bmname + "'");
            }
            SQLClass.con_close();
            Form_OK = 1;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form_OK = 0;
            this.Close();
        }

    }

}
