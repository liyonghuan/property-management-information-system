namespace WYMIS
{
    partial class Gangwei_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gangwei_Form));
            this.picbox_min = new System.Windows.Forms.PictureBox();
            this.picbox_close = new System.Windows.Forms.PictureBox();
            this.lab_bumen = new System.Windows.Forms.Label();
            this.lab_gangwei = new System.Windows.Forms.Label();
            this.lab_fuzeren = new System.Windows.Forms.Label();
            this.combox_bm = new System.Windows.Forms.ComboBox();
            this.txt_gangwei = new System.Windows.Forms.TextBox();
            this.txt_fuzeren = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lab_message = new System.Windows.Forms.Label();
            this.lab_m_gangwei = new System.Windows.Forms.Label();
            this.lab_m_fuzeren = new System.Windows.Forms.Label();
            this.picbox_logo = new System.Windows.Forms.PictureBox();
            this.lab_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_min
            // 
            this.picbox_min.BackColor = System.Drawing.Color.Transparent;
            this.picbox_min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_min.BackgroundImage")));
            this.picbox_min.Location = new System.Drawing.Point(440, 0);
            this.picbox_min.Name = "picbox_min";
            this.picbox_min.Size = new System.Drawing.Size(30, 30);
            this.picbox_min.TabIndex = 0;
            this.picbox_min.TabStop = false;
            this.picbox_min.Click += new System.EventHandler(this.picbox_min_Click);
            this.picbox_min.MouseLeave += new System.EventHandler(this.picbox_min_MouseLeave);
            this.picbox_min.MouseHover += new System.EventHandler(this.picbox_min_MouseHover);
            // 
            // picbox_close
            // 
            this.picbox_close.BackColor = System.Drawing.Color.Transparent;
            this.picbox_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_close.BackgroundImage")));
            this.picbox_close.Location = new System.Drawing.Point(470, 0);
            this.picbox_close.Name = "picbox_close";
            this.picbox_close.Size = new System.Drawing.Size(30, 30);
            this.picbox_close.TabIndex = 1;
            this.picbox_close.TabStop = false;
            this.picbox_close.Click += new System.EventHandler(this.picbox_close_Click);
            this.picbox_close.MouseLeave += new System.EventHandler(this.picbox_close_MouseLeave);
            this.picbox_close.MouseHover += new System.EventHandler(this.picbox_close_MouseHover);
            // 
            // lab_bumen
            // 
            this.lab_bumen.AutoSize = true;
            this.lab_bumen.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_bumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_bumen.Location = new System.Drawing.Point(70, 195);
            this.lab_bumen.Name = "lab_bumen";
            this.lab_bumen.Size = new System.Drawing.Size(49, 14);
            this.lab_bumen.TabIndex = 2;
            this.lab_bumen.Text = "部门：";
            // 
            // lab_gangwei
            // 
            this.lab_gangwei.AutoSize = true;
            this.lab_gangwei.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_gangwei.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_gangwei.Location = new System.Drawing.Point(70, 235);
            this.lab_gangwei.Name = "lab_gangwei";
            this.lab_gangwei.Size = new System.Drawing.Size(49, 14);
            this.lab_gangwei.TabIndex = 3;
            this.lab_gangwei.Text = "岗位：";
            // 
            // lab_fuzeren
            // 
            this.lab_fuzeren.AutoSize = true;
            this.lab_fuzeren.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_fuzeren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_fuzeren.Location = new System.Drawing.Point(43, 275);
            this.lab_fuzeren.Name = "lab_fuzeren";
            this.lab_fuzeren.Size = new System.Drawing.Size(77, 14);
            this.lab_fuzeren.TabIndex = 4;
            this.lab_fuzeren.Text = "负责人ID：";
            // 
            // combox_bm
            // 
            this.combox_bm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combox_bm.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combox_bm.FormattingEnabled = true;
            this.combox_bm.Location = new System.Drawing.Point(120, 195);
            this.combox_bm.Name = "combox_bm";
            this.combox_bm.Size = new System.Drawing.Size(121, 22);
            this.combox_bm.TabIndex = 5;
            this.combox_bm.Tag = "1";
            this.combox_bm.Leave += new System.EventHandler(this.combox_bm_Leave);
            // 
            // txt_gangwei
            // 
            this.txt_gangwei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gangwei.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_gangwei.Location = new System.Drawing.Point(120, 230);
            this.txt_gangwei.MaxLength = 12;
            this.txt_gangwei.Multiline = true;
            this.txt_gangwei.Name = "txt_gangwei";
            this.txt_gangwei.Size = new System.Drawing.Size(150, 30);
            this.txt_gangwei.TabIndex = 6;
            this.txt_gangwei.Tag = "0";
            this.txt_gangwei.Leave += new System.EventHandler(this.txt_gangwei_Leave);
            // 
            // txt_fuzeren
            // 
            this.txt_fuzeren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fuzeren.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_fuzeren.Location = new System.Drawing.Point(120, 270);
            this.txt_fuzeren.MaxLength = 8;
            this.txt_fuzeren.Multiline = true;
            this.txt_fuzeren.Name = "txt_fuzeren";
            this.txt_fuzeren.Size = new System.Drawing.Size(150, 30);
            this.txt_fuzeren.TabIndex = 7;
            this.txt_fuzeren.Tag = "0";
            this.txt_fuzeren.Leave += new System.EventHandler(this.txt_fuzeren_Leave);
            // 
            // btn_ok
            // 
            this.btn_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ok.BackgroundImage")));
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(120, 330);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 30);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "确定(&Y)";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reset.BackgroundImage")));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(245, 330);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 30);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "清空(&C)";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lab_message
            // 
            this.lab_message.AutoSize = true;
            this.lab_message.Location = new System.Drawing.Point(120, 310);
            this.lab_message.Name = "lab_message";
            this.lab_message.Size = new System.Drawing.Size(0, 12);
            this.lab_message.TabIndex = 10;
            // 
            // lab_m_gangwei
            // 
            this.lab_m_gangwei.AutoSize = true;
            this.lab_m_gangwei.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_gangwei.Location = new System.Drawing.Point(280, 240);
            this.lab_m_gangwei.Name = "lab_m_gangwei";
            this.lab_m_gangwei.Size = new System.Drawing.Size(101, 12);
            this.lab_m_gangwei.TabIndex = 12;
            this.lab_m_gangwei.Text = "请输入岗位名称！";
            // 
            // lab_m_fuzeren
            // 
            this.lab_m_fuzeren.AutoSize = true;
            this.lab_m_fuzeren.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_fuzeren.Location = new System.Drawing.Point(280, 280);
            this.lab_m_fuzeren.Name = "lab_m_fuzeren";
            this.lab_m_fuzeren.Size = new System.Drawing.Size(125, 12);
            this.lab_m_fuzeren.TabIndex = 13;
            this.lab_m_fuzeren.Text = "请输入该岗位负责人！";
            // 
            // picbox_logo
            // 
            this.picbox_logo.BackColor = System.Drawing.Color.Transparent;
            this.picbox_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_logo.BackgroundImage")));
            this.picbox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_logo.Location = new System.Drawing.Point(5, 0);
            this.picbox_logo.Name = "picbox_logo";
            this.picbox_logo.Size = new System.Drawing.Size(30, 30);
            this.picbox_logo.TabIndex = 14;
            this.picbox_logo.TabStop = false;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.BackColor = System.Drawing.Color.Transparent;
            this.lab_title.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_title.ForeColor = System.Drawing.Color.White;
            this.lab_title.Location = new System.Drawing.Point(30, 7);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(105, 18);
            this.lab_title.TabIndex = 15;
            this.lab_title.Text = "MIS by LiHuan";
            // 
            // Gangwei_Form
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 380);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.picbox_logo);
            this.Controls.Add(this.lab_m_fuzeren);
            this.Controls.Add(this.lab_m_gangwei);
            this.Controls.Add(this.lab_message);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_fuzeren);
            this.Controls.Add(this.txt_gangwei);
            this.Controls.Add(this.combox_bm);
            this.Controls.Add(this.lab_fuzeren);
            this.Controls.Add(this.lab_gangwei);
            this.Controls.Add(this.lab_bumen);
            this.Controls.Add(this.picbox_close);
            this.Controls.Add(this.picbox_min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gangwei_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gangwei_Form";
            this.Load += new System.EventHandler(this.Gangwei_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_min;
        private System.Windows.Forms.PictureBox picbox_close;
        private System.Windows.Forms.Label lab_bumen;
        private System.Windows.Forms.Label lab_gangwei;
        private System.Windows.Forms.Label lab_fuzeren;
        private System.Windows.Forms.ComboBox combox_bm;
        private System.Windows.Forms.TextBox txt_gangwei;
        private System.Windows.Forms.TextBox txt_fuzeren;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lab_message;
        private System.Windows.Forms.Label lab_m_gangwei;
        private System.Windows.Forms.Label lab_m_fuzeren;
        private System.Windows.Forms.PictureBox picbox_logo;
        private System.Windows.Forms.Label lab_title;
    }
}