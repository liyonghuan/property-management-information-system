namespace WYMIS
{
    partial class Zhufang_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zhufang_Form));
            this.picbox_min = new System.Windows.Forms.PictureBox();
            this.picbox_close = new System.Windows.Forms.PictureBox();
            this.lab_louceng = new System.Windows.Forms.Label();
            this.lab_peizhi = new System.Windows.Forms.Label();
            this.lab_yezhu = new System.Windows.Forms.Label();
            this.lab_zhuangtai = new System.Windows.Forms.Label();
            this.lab_fangchan = new System.Windows.Forms.Label();
            this.lab_shoufei = new System.Windows.Forms.Label();
            this.txt_louceng = new System.Windows.Forms.TextBox();
            this.txt_peizhi = new System.Windows.Forms.TextBox();
            this.txt_yezhu = new System.Windows.Forms.TextBox();
            this.combox_fc = new System.Windows.Forms.ComboBox();
            this.txt_shoufei = new System.Windows.Forms.TextBox();
            this.rad_yi = new System.Windows.Forms.RadioButton();
            this.rad_wei = new System.Windows.Forms.RadioButton();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lab_message = new System.Windows.Forms.Label();
            this.lab_m_louceng = new System.Windows.Forms.Label();
            this.lab_m_peizhi = new System.Windows.Forms.Label();
            this.lab_m_yezhu = new System.Windows.Forms.Label();
            this.lab_m_shoufei = new System.Windows.Forms.Label();
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
            this.picbox_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.picbox_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_close.Location = new System.Drawing.Point(470, 0);
            this.picbox_close.Name = "picbox_close";
            this.picbox_close.Size = new System.Drawing.Size(30, 30);
            this.picbox_close.TabIndex = 1;
            this.picbox_close.TabStop = false;
            this.picbox_close.Click += new System.EventHandler(this.picbox_close_Click);
            this.picbox_close.MouseLeave += new System.EventHandler(this.picbox_close_MouseLeave);
            this.picbox_close.MouseHover += new System.EventHandler(this.picbox_close_MouseHover);
            // 
            // lab_louceng
            // 
            this.lab_louceng.AutoSize = true;
            this.lab_louceng.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_louceng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_louceng.Location = new System.Drawing.Point(42, 195);
            this.lab_louceng.Name = "lab_louceng";
            this.lab_louceng.Size = new System.Drawing.Size(77, 14);
            this.lab_louceng.TabIndex = 2;
            this.lab_louceng.Text = "住房楼层：";
            // 
            // lab_peizhi
            // 
            this.lab_peizhi.AutoSize = true;
            this.lab_peizhi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_peizhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_peizhi.Location = new System.Drawing.Point(42, 235);
            this.lab_peizhi.Name = "lab_peizhi";
            this.lab_peizhi.Size = new System.Drawing.Size(77, 14);
            this.lab_peizhi.TabIndex = 3;
            this.lab_peizhi.Text = "住房配置：";
            // 
            // lab_yezhu
            // 
            this.lab_yezhu.AutoSize = true;
            this.lab_yezhu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_yezhu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_yezhu.Location = new System.Drawing.Point(42, 275);
            this.lab_yezhu.Name = "lab_yezhu";
            this.lab_yezhu.Size = new System.Drawing.Size(63, 14);
            this.lab_yezhu.TabIndex = 4;
            this.lab_yezhu.Text = "业主ID：";
            // 
            // lab_zhuangtai
            // 
            this.lab_zhuangtai.AutoSize = true;
            this.lab_zhuangtai.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_zhuangtai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_zhuangtai.Location = new System.Drawing.Point(42, 315);
            this.lab_zhuangtai.Name = "lab_zhuangtai";
            this.lab_zhuangtai.Size = new System.Drawing.Size(77, 14);
            this.lab_zhuangtai.TabIndex = 5;
            this.lab_zhuangtai.Text = "住房状态：";
            // 
            // lab_fangchan
            // 
            this.lab_fangchan.AutoSize = true;
            this.lab_fangchan.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_fangchan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_fangchan.Location = new System.Drawing.Point(42, 355);
            this.lab_fangchan.Name = "lab_fangchan";
            this.lab_fangchan.Size = new System.Drawing.Size(77, 14);
            this.lab_fangchan.TabIndex = 6;
            this.lab_fangchan.Text = "所属房产：";
            // 
            // lab_shoufei
            // 
            this.lab_shoufei.AutoSize = true;
            this.lab_shoufei.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_shoufei.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_shoufei.Location = new System.Drawing.Point(42, 395);
            this.lab_shoufei.Name = "lab_shoufei";
            this.lab_shoufei.Size = new System.Drawing.Size(77, 14);
            this.lab_shoufei.TabIndex = 7;
            this.lab_shoufei.Text = "费用状况：";
            // 
            // txt_louceng
            // 
            this.txt_louceng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_louceng.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_louceng.Location = new System.Drawing.Point(120, 190);
            this.txt_louceng.MaxLength = 5;
            this.txt_louceng.Multiline = true;
            this.txt_louceng.Name = "txt_louceng";
            this.txt_louceng.Size = new System.Drawing.Size(150, 30);
            this.txt_louceng.TabIndex = 8;
            this.txt_louceng.Tag = "0";
            this.txt_louceng.Leave += new System.EventHandler(this.txt_louceng_Leave);
            // 
            // txt_peizhi
            // 
            this.txt_peizhi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_peizhi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_peizhi.Location = new System.Drawing.Point(120, 230);
            this.txt_peizhi.MaxLength = 25;
            this.txt_peizhi.Multiline = true;
            this.txt_peizhi.Name = "txt_peizhi";
            this.txt_peizhi.Size = new System.Drawing.Size(150, 30);
            this.txt_peizhi.TabIndex = 9;
            this.txt_peizhi.Tag = "0";
            this.txt_peizhi.Leave += new System.EventHandler(this.txt_peizhi_Leave);
            // 
            // txt_yezhu
            // 
            this.txt_yezhu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_yezhu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_yezhu.Location = new System.Drawing.Point(120, 270);
            this.txt_yezhu.MaxLength = 12;
            this.txt_yezhu.Multiline = true;
            this.txt_yezhu.Name = "txt_yezhu";
            this.txt_yezhu.Size = new System.Drawing.Size(150, 30);
            this.txt_yezhu.TabIndex = 10;
            this.txt_yezhu.Tag = "0";
            this.txt_yezhu.Leave += new System.EventHandler(this.txt_yezhu_Leave);
            // 
            // combox_fc
            // 
            this.combox_fc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_fc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combox_fc.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combox_fc.FormattingEnabled = true;
            this.combox_fc.Location = new System.Drawing.Point(120, 355);
            this.combox_fc.Name = "combox_fc";
            this.combox_fc.Size = new System.Drawing.Size(150, 22);
            this.combox_fc.TabIndex = 11;
            // 
            // txt_shoufei
            // 
            this.txt_shoufei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_shoufei.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_shoufei.Location = new System.Drawing.Point(120, 390);
            this.txt_shoufei.MaxLength = 8;
            this.txt_shoufei.Multiline = true;
            this.txt_shoufei.Name = "txt_shoufei";
            this.txt_shoufei.Size = new System.Drawing.Size(150, 30);
            this.txt_shoufei.TabIndex = 12;
            this.txt_shoufei.Tag = "0";
            this.txt_shoufei.Text = "0";
            this.txt_shoufei.Leave += new System.EventHandler(this.txt_shoufei_Leave);
            // 
            // rad_yi
            // 
            this.rad_yi.AutoSize = true;
            this.rad_yi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rad_yi.Location = new System.Drawing.Point(190, 315);
            this.rad_yi.Name = "rad_yi";
            this.rad_yi.Size = new System.Drawing.Size(67, 18);
            this.rad_yi.TabIndex = 13;
            this.rad_yi.Text = "已入住";
            this.rad_yi.UseVisualStyleBackColor = true;
            // 
            // rad_wei
            // 
            this.rad_wei.AutoSize = true;
            this.rad_wei.Checked = true;
            this.rad_wei.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rad_wei.Location = new System.Drawing.Point(120, 315);
            this.rad_wei.Name = "rad_wei";
            this.rad_wei.Size = new System.Drawing.Size(67, 18);
            this.rad_wei.TabIndex = 14;
            this.rad_wei.TabStop = true;
            this.rad_wei.Text = "未入住";
            this.rad_wei.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            this.btn_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ok.BackgroundImage")));
            this.btn_ok.Location = new System.Drawing.Point(120, 455);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 30);
            this.btn_ok.TabIndex = 15;
            this.btn_ok.Text = "确定(&Y)";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reset.BackgroundImage")));
            this.btn_reset.Location = new System.Drawing.Point(224, 455);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 30);
            this.btn_reset.TabIndex = 16;
            this.btn_reset.Text = "清空(&C)";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lab_message
            // 
            this.lab_message.AutoSize = true;
            this.lab_message.Location = new System.Drawing.Point(120, 432);
            this.lab_message.Name = "lab_message";
            this.lab_message.Size = new System.Drawing.Size(0, 12);
            this.lab_message.TabIndex = 17;
            // 
            // lab_m_louceng
            // 
            this.lab_m_louceng.AutoSize = true;
            this.lab_m_louceng.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_louceng.Location = new System.Drawing.Point(290, 200);
            this.lab_m_louceng.Name = "lab_m_louceng";
            this.lab_m_louceng.Size = new System.Drawing.Size(125, 12);
            this.lab_m_louceng.TabIndex = 18;
            this.lab_m_louceng.Text = "请输入住房所在楼层！";
            // 
            // lab_m_peizhi
            // 
            this.lab_m_peizhi.AutoSize = true;
            this.lab_m_peizhi.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_peizhi.Location = new System.Drawing.Point(290, 240);
            this.lab_m_peizhi.Name = "lab_m_peizhi";
            this.lab_m_peizhi.Size = new System.Drawing.Size(137, 12);
            this.lab_m_peizhi.TabIndex = 19;
            this.lab_m_peizhi.Text = "请输入住房的配置信息！";
            // 
            // lab_m_yezhu
            // 
            this.lab_m_yezhu.AutoSize = true;
            this.lab_m_yezhu.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_yezhu.Location = new System.Drawing.Point(290, 280);
            this.lab_m_yezhu.Name = "lab_m_yezhu";
            this.lab_m_yezhu.Size = new System.Drawing.Size(0, 12);
            this.lab_m_yezhu.TabIndex = 20;
            // 
            // lab_m_shoufei
            // 
            this.lab_m_shoufei.AutoSize = true;
            this.lab_m_shoufei.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_shoufei.Location = new System.Drawing.Point(290, 400);
            this.lab_m_shoufei.Name = "lab_m_shoufei";
            this.lab_m_shoufei.Size = new System.Drawing.Size(101, 12);
            this.lab_m_shoufei.TabIndex = 21;
            this.lab_m_shoufei.Text = "请输入费用状况！";
            // 
            // picbox_logo
            // 
            this.picbox_logo.BackColor = System.Drawing.Color.Transparent;
            this.picbox_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_logo.BackgroundImage")));
            this.picbox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_logo.Location = new System.Drawing.Point(5, 0);
            this.picbox_logo.Name = "picbox_logo";
            this.picbox_logo.Size = new System.Drawing.Size(30, 30);
            this.picbox_logo.TabIndex = 22;
            this.picbox_logo.TabStop = false;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.BackColor = System.Drawing.Color.Transparent;
            this.lab_title.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_title.ForeColor = System.Drawing.Color.Transparent;
            this.lab_title.Location = new System.Drawing.Point(30, 7);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(105, 18);
            this.lab_title.TabIndex = 23;
            this.lab_title.Text = "MIS by LiHuan";
            // 
            // Zhufang_Form
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.picbox_logo);
            this.Controls.Add(this.lab_m_shoufei);
            this.Controls.Add(this.lab_m_yezhu);
            this.Controls.Add(this.lab_m_peizhi);
            this.Controls.Add(this.lab_m_louceng);
            this.Controls.Add(this.lab_message);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.rad_wei);
            this.Controls.Add(this.rad_yi);
            this.Controls.Add(this.txt_shoufei);
            this.Controls.Add(this.combox_fc);
            this.Controls.Add(this.txt_yezhu);
            this.Controls.Add(this.txt_peizhi);
            this.Controls.Add(this.txt_louceng);
            this.Controls.Add(this.lab_shoufei);
            this.Controls.Add(this.lab_fangchan);
            this.Controls.Add(this.lab_zhuangtai);
            this.Controls.Add(this.lab_yezhu);
            this.Controls.Add(this.lab_peizhi);
            this.Controls.Add(this.lab_louceng);
            this.Controls.Add(this.picbox_close);
            this.Controls.Add(this.picbox_min);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zhufang_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zhufang";
            this.Load += new System.EventHandler(this.Zhufang_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_min;
        private System.Windows.Forms.PictureBox picbox_close;
        private System.Windows.Forms.Label lab_louceng;
        private System.Windows.Forms.Label lab_peizhi;
        private System.Windows.Forms.Label lab_yezhu;
        private System.Windows.Forms.Label lab_zhuangtai;
        private System.Windows.Forms.Label lab_fangchan;
        private System.Windows.Forms.Label lab_shoufei;
        private System.Windows.Forms.TextBox txt_louceng;
        private System.Windows.Forms.TextBox txt_peizhi;
        private System.Windows.Forms.TextBox txt_yezhu;
        private System.Windows.Forms.ComboBox combox_fc;
        private System.Windows.Forms.TextBox txt_shoufei;
        private System.Windows.Forms.RadioButton rad_yi;
        private System.Windows.Forms.RadioButton rad_wei;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lab_message;
        private System.Windows.Forms.Label lab_m_louceng;
        private System.Windows.Forms.Label lab_m_peizhi;
        private System.Windows.Forms.Label lab_m_yezhu;
        private System.Windows.Forms.Label lab_m_shoufei;
        private System.Windows.Forms.PictureBox picbox_logo;
        private System.Windows.Forms.Label lab_title;
    }
}