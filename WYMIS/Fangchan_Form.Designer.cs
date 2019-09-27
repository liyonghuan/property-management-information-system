namespace WYMIS
{
    partial class Fangchan_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fangchan_Form));
            this.picbox_min = new System.Windows.Forms.PictureBox();
            this.picbox_close = new System.Windows.Forms.PictureBox();
            this.lab_jianzu = new System.Windows.Forms.Label();
            this.lab_dizhi = new System.Windows.Forms.Label();
            this.lab_kaifashang = new System.Windows.Forms.Label();
            this.lab_shijian = new System.Windows.Forms.Label();
            this.lab_beizhu = new System.Windows.Forms.Label();
            this.txt_jianzu = new System.Windows.Forms.TextBox();
            this.txt_dizhi = new System.Windows.Forms.TextBox();
            this.txt_beizhu = new System.Windows.Forms.TextBox();
            this.combox_kfs = new System.Windows.Forms.ComboBox();
            this.datetime_riqi = new System.Windows.Forms.DateTimePicker();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lab_m_jianzu = new System.Windows.Forms.Label();
            this.lab_m_dizhi = new System.Windows.Forms.Label();
            this.lab_messgae = new System.Windows.Forms.Label();
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
            // lab_jianzu
            // 
            this.lab_jianzu.AutoSize = true;
            this.lab_jianzu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_jianzu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_jianzu.Location = new System.Drawing.Point(42, 195);
            this.lab_jianzu.Name = "lab_jianzu";
            this.lab_jianzu.Size = new System.Drawing.Size(77, 14);
            this.lab_jianzu.TabIndex = 2;
            this.lab_jianzu.Text = "楼房名称：";
            // 
            // lab_dizhi
            // 
            this.lab_dizhi.AutoSize = true;
            this.lab_dizhi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_dizhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_dizhi.Location = new System.Drawing.Point(42, 235);
            this.lab_dizhi.Name = "lab_dizhi";
            this.lab_dizhi.Size = new System.Drawing.Size(77, 14);
            this.lab_dizhi.TabIndex = 3;
            this.lab_dizhi.Text = "楼房地址：";
            // 
            // lab_kaifashang
            // 
            this.lab_kaifashang.AutoSize = true;
            this.lab_kaifashang.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_kaifashang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_kaifashang.Location = new System.Drawing.Point(28, 275);
            this.lab_kaifashang.Name = "lab_kaifashang";
            this.lab_kaifashang.Size = new System.Drawing.Size(91, 14);
            this.lab_kaifashang.TabIndex = 4;
            this.lab_kaifashang.Text = "开发商名称：";
            // 
            // lab_shijian
            // 
            this.lab_shijian.AutoSize = true;
            this.lab_shijian.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_shijian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_shijian.Location = new System.Drawing.Point(42, 315);
            this.lab_shijian.Name = "lab_shijian";
            this.lab_shijian.Size = new System.Drawing.Size(77, 14);
            this.lab_shijian.TabIndex = 5;
            this.lab_shijian.Text = "建成时间：";
            // 
            // lab_beizhu
            // 
            this.lab_beizhu.AutoSize = true;
            this.lab_beizhu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_beizhu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_beizhu.Location = new System.Drawing.Point(70, 355);
            this.lab_beizhu.Name = "lab_beizhu";
            this.lab_beizhu.Size = new System.Drawing.Size(49, 14);
            this.lab_beizhu.TabIndex = 6;
            this.lab_beizhu.Text = "备注：";
            // 
            // txt_jianzu
            // 
            this.txt_jianzu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_jianzu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_jianzu.Location = new System.Drawing.Point(120, 190);
            this.txt_jianzu.MaxLength = 12;
            this.txt_jianzu.Multiline = true;
            this.txt_jianzu.Name = "txt_jianzu";
            this.txt_jianzu.Size = new System.Drawing.Size(150, 30);
            this.txt_jianzu.TabIndex = 7;
            this.txt_jianzu.Leave += new System.EventHandler(this.txt_jianzu_Leave);
            // 
            // txt_dizhi
            // 
            this.txt_dizhi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dizhi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_dizhi.Location = new System.Drawing.Point(120, 230);
            this.txt_dizhi.MaxLength = 255;
            this.txt_dizhi.Multiline = true;
            this.txt_dizhi.Name = "txt_dizhi";
            this.txt_dizhi.Size = new System.Drawing.Size(150, 30);
            this.txt_dizhi.TabIndex = 8;
            this.txt_dizhi.Leave += new System.EventHandler(this.txt_dizhi_Leave);
            // 
            // txt_beizhu
            // 
            this.txt_beizhu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_beizhu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_beizhu.Location = new System.Drawing.Point(120, 350);
            this.txt_beizhu.Multiline = true;
            this.txt_beizhu.Name = "txt_beizhu";
            this.txt_beizhu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_beizhu.Size = new System.Drawing.Size(200, 60);
            this.txt_beizhu.TabIndex = 10;
            // 
            // combox_kfs
            // 
            this.combox_kfs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_kfs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combox_kfs.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combox_kfs.FormattingEnabled = true;
            this.combox_kfs.Location = new System.Drawing.Point(120, 275);
            this.combox_kfs.Name = "combox_kfs";
            this.combox_kfs.Size = new System.Drawing.Size(150, 22);
            this.combox_kfs.TabIndex = 11;
            // 
            // datetime_riqi
            // 
            this.datetime_riqi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datetime_riqi.Location = new System.Drawing.Point(120, 315);
            this.datetime_riqi.Name = "datetime_riqi";
            this.datetime_riqi.Size = new System.Drawing.Size(150, 23);
            this.datetime_riqi.TabIndex = 12;
            this.datetime_riqi.Value = new System.DateTime(2015, 1, 3, 0, 0, 0, 0);
            // 
            // btn_ok
            // 
            this.btn_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ok.BackgroundImage")));
            this.btn_ok.Location = new System.Drawing.Point(120, 440);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 30);
            this.btn_ok.TabIndex = 13;
            this.btn_ok.Text = "确定(&Y)";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reset.BackgroundImage")));
            this.btn_reset.Location = new System.Drawing.Point(245, 440);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 30);
            this.btn_reset.TabIndex = 14;
            this.btn_reset.Text = "清空(&C)";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lab_m_jianzu
            // 
            this.lab_m_jianzu.AutoSize = true;
            this.lab_m_jianzu.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_jianzu.Location = new System.Drawing.Point(290, 195);
            this.lab_m_jianzu.Name = "lab_m_jianzu";
            this.lab_m_jianzu.Size = new System.Drawing.Size(101, 12);
            this.lab_m_jianzu.TabIndex = 15;
            this.lab_m_jianzu.Text = "请输入楼房名称！";
            // 
            // lab_m_dizhi
            // 
            this.lab_m_dizhi.AutoSize = true;
            this.lab_m_dizhi.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_dizhi.Location = new System.Drawing.Point(290, 237);
            this.lab_m_dizhi.Name = "lab_m_dizhi";
            this.lab_m_dizhi.Size = new System.Drawing.Size(101, 12);
            this.lab_m_dizhi.TabIndex = 16;
            this.lab_m_dizhi.Text = "请输入楼房地址！";
            // 
            // lab_messgae
            // 
            this.lab_messgae.AutoSize = true;
            this.lab_messgae.Location = new System.Drawing.Point(120, 420);
            this.lab_messgae.Name = "lab_messgae";
            this.lab_messgae.Size = new System.Drawing.Size(0, 12);
            this.lab_messgae.TabIndex = 17;
            // 
            // picbox_logo
            // 
            this.picbox_logo.BackColor = System.Drawing.Color.Transparent;
            this.picbox_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_logo.BackgroundImage")));
            this.picbox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_logo.Location = new System.Drawing.Point(5, 0);
            this.picbox_logo.Name = "picbox_logo";
            this.picbox_logo.Size = new System.Drawing.Size(30, 30);
            this.picbox_logo.TabIndex = 18;
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
            this.lab_title.TabIndex = 19;
            this.lab_title.Text = "MIS by LiHuan";
            // 
            // Fangchan_Form
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 490);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.picbox_logo);
            this.Controls.Add(this.lab_messgae);
            this.Controls.Add(this.lab_m_dizhi);
            this.Controls.Add(this.lab_m_jianzu);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.datetime_riqi);
            this.Controls.Add(this.combox_kfs);
            this.Controls.Add(this.txt_beizhu);
            this.Controls.Add(this.txt_dizhi);
            this.Controls.Add(this.txt_jianzu);
            this.Controls.Add(this.lab_beizhu);
            this.Controls.Add(this.lab_shijian);
            this.Controls.Add(this.lab_kaifashang);
            this.Controls.Add(this.lab_dizhi);
            this.Controls.Add(this.lab_jianzu);
            this.Controls.Add(this.picbox_close);
            this.Controls.Add(this.picbox_min);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fangchan_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fangchan_Form";
            this.Load += new System.EventHandler(this.Fangchan_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_min;
        private System.Windows.Forms.PictureBox picbox_close;
        private System.Windows.Forms.Label lab_jianzu;
        private System.Windows.Forms.Label lab_dizhi;
        private System.Windows.Forms.Label lab_kaifashang;
        private System.Windows.Forms.Label lab_shijian;
        private System.Windows.Forms.Label lab_beizhu;
        private System.Windows.Forms.TextBox txt_jianzu;
        private System.Windows.Forms.TextBox txt_dizhi;
        private System.Windows.Forms.TextBox txt_beizhu;
        private System.Windows.Forms.ComboBox combox_kfs;
        private System.Windows.Forms.DateTimePicker datetime_riqi;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lab_m_jianzu;
        private System.Windows.Forms.Label lab_m_dizhi;
        private System.Windows.Forms.Label lab_messgae;
        private System.Windows.Forms.PictureBox picbox_logo;
        private System.Windows.Forms.Label lab_title;
    }
}