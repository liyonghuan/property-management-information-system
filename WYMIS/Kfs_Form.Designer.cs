namespace WYMIS
{
    partial class Kfs_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kfs_Form));
            this.lab_gongsi = new System.Windows.Forms.Label();
            this.lab_lianxi = new System.Windows.Forms.Label();
            this.lab_fuzeren = new System.Windows.Forms.Label();
            this.lab_dizhi = new System.Windows.Forms.Label();
            this.txt_gongsi = new System.Windows.Forms.TextBox();
            this.txt_fuzeren = new System.Windows.Forms.TextBox();
            this.txt_lianxi = new System.Windows.Forms.TextBox();
            this.txt_dizhi = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.picbox_min = new System.Windows.Forms.PictureBox();
            this.picbox_close = new System.Windows.Forms.PictureBox();
            this.lab_m_gongsi = new System.Windows.Forms.Label();
            this.lab_m_fuzeren = new System.Windows.Forms.Label();
            this.lab_m_lianxi = new System.Windows.Forms.Label();
            this.lab_m_dizhi = new System.Windows.Forms.Label();
            this.lab_message = new System.Windows.Forms.Label();
            this.picbox_logo = new System.Windows.Forms.PictureBox();
            this.lab_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_gongsi
            // 
            this.lab_gongsi.AutoSize = true;
            this.lab_gongsi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_gongsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_gongsi.Location = new System.Drawing.Point(28, 195);
            this.lab_gongsi.Name = "lab_gongsi";
            this.lab_gongsi.Size = new System.Drawing.Size(91, 14);
            this.lab_gongsi.TabIndex = 0;
            this.lab_gongsi.Text = "开发商名称：";
            // 
            // lab_lianxi
            // 
            this.lab_lianxi.AutoSize = true;
            this.lab_lianxi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_lianxi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_lianxi.Location = new System.Drawing.Point(42, 275);
            this.lab_lianxi.Name = "lab_lianxi";
            this.lab_lianxi.Size = new System.Drawing.Size(77, 14);
            this.lab_lianxi.TabIndex = 1;
            this.lab_lianxi.Text = "联系方式：";
            // 
            // lab_fuzeren
            // 
            this.lab_fuzeren.AutoSize = true;
            this.lab_fuzeren.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_fuzeren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_fuzeren.Location = new System.Drawing.Point(56, 235);
            this.lab_fuzeren.Name = "lab_fuzeren";
            this.lab_fuzeren.Size = new System.Drawing.Size(63, 14);
            this.lab_fuzeren.TabIndex = 2;
            this.lab_fuzeren.Text = "负责人：";
            // 
            // lab_dizhi
            // 
            this.lab_dizhi.AutoSize = true;
            this.lab_dizhi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_dizhi.Location = new System.Drawing.Point(42, 315);
            this.lab_dizhi.Name = "lab_dizhi";
            this.lab_dizhi.Size = new System.Drawing.Size(77, 14);
            this.lab_dizhi.TabIndex = 3;
            this.lab_dizhi.Text = "公司地址：";
            // 
            // txt_gongsi
            // 
            this.txt_gongsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gongsi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_gongsi.Location = new System.Drawing.Point(120, 190);
            this.txt_gongsi.MaxLength = 25;
            this.txt_gongsi.Multiline = true;
            this.txt_gongsi.Name = "txt_gongsi";
            this.txt_gongsi.Size = new System.Drawing.Size(150, 30);
            this.txt_gongsi.TabIndex = 0;
            this.txt_gongsi.Leave += new System.EventHandler(this.txt_gongsi_Leave);
            // 
            // txt_fuzeren
            // 
            this.txt_fuzeren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fuzeren.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_fuzeren.Location = new System.Drawing.Point(120, 230);
            this.txt_fuzeren.MaxLength = 25;
            this.txt_fuzeren.Multiline = true;
            this.txt_fuzeren.Name = "txt_fuzeren";
            this.txt_fuzeren.Size = new System.Drawing.Size(150, 30);
            this.txt_fuzeren.TabIndex = 1;
            this.txt_fuzeren.Leave += new System.EventHandler(this.txt_fuzeren_Leave);
            // 
            // txt_lianxi
            // 
            this.txt_lianxi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lianxi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_lianxi.Location = new System.Drawing.Point(120, 270);
            this.txt_lianxi.MaxLength = 15;
            this.txt_lianxi.Multiline = true;
            this.txt_lianxi.Name = "txt_lianxi";
            this.txt_lianxi.Size = new System.Drawing.Size(150, 30);
            this.txt_lianxi.TabIndex = 2;
            this.txt_lianxi.Leave += new System.EventHandler(this.txt_lianxi_Leave);
            // 
            // txt_dizhi
            // 
            this.txt_dizhi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dizhi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_dizhi.Location = new System.Drawing.Point(120, 310);
            this.txt_dizhi.MaxLength = 255;
            this.txt_dizhi.Multiline = true;
            this.txt_dizhi.Name = "txt_dizhi";
            this.txt_dizhi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_dizhi.Size = new System.Drawing.Size(200, 60);
            this.txt_dizhi.TabIndex = 3;
            this.txt_dizhi.Leave += new System.EventHandler(this.txt_dizhi_Leave);
            // 
            // btn_ok
            // 
            this.btn_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ok.BackgroundImage")));
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(120, 400);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 30);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "确定(&Y)";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reset.BackgroundImage")));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(245, 400);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 30);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "清空(&C)";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // picbox_min
            // 
            this.picbox_min.BackColor = System.Drawing.Color.Transparent;
            this.picbox_min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_min.BackgroundImage")));
            this.picbox_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_min.Location = new System.Drawing.Point(440, 0);
            this.picbox_min.Name = "picbox_min";
            this.picbox_min.Size = new System.Drawing.Size(30, 30);
            this.picbox_min.TabIndex = 10;
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
            this.picbox_close.TabIndex = 11;
            this.picbox_close.TabStop = false;
            this.picbox_close.Click += new System.EventHandler(this.picbox_close_Click);
            this.picbox_close.MouseLeave += new System.EventHandler(this.picbox_close_MouseLeave);
            this.picbox_close.MouseHover += new System.EventHandler(this.picbox_close_MouseHover);
            // 
            // lab_m_gongsi
            // 
            this.lab_m_gongsi.AutoSize = true;
            this.lab_m_gongsi.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_gongsi.Location = new System.Drawing.Point(280, 195);
            this.lab_m_gongsi.Name = "lab_m_gongsi";
            this.lab_m_gongsi.Size = new System.Drawing.Size(113, 12);
            this.lab_m_gongsi.TabIndex = 12;
            this.lab_m_gongsi.Text = "请输入开发商名称！";
            // 
            // lab_m_fuzeren
            // 
            this.lab_m_fuzeren.AutoSize = true;
            this.lab_m_fuzeren.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_fuzeren.Location = new System.Drawing.Point(280, 235);
            this.lab_m_fuzeren.Name = "lab_m_fuzeren";
            this.lab_m_fuzeren.Size = new System.Drawing.Size(173, 12);
            this.lab_m_fuzeren.TabIndex = 13;
            this.lab_m_fuzeren.Text = "请输入开发商公司负责人名称！";
            // 
            // lab_m_lianxi
            // 
            this.lab_m_lianxi.AutoSize = true;
            this.lab_m_lianxi.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_lianxi.Location = new System.Drawing.Point(280, 275);
            this.lab_m_lianxi.Name = "lab_m_lianxi";
            this.lab_m_lianxi.Size = new System.Drawing.Size(161, 12);
            this.lab_m_lianxi.TabIndex = 14;
            this.lab_m_lianxi.Text = "请输入开发商公司联系方式！";
            // 
            // lab_m_dizhi
            // 
            this.lab_m_dizhi.AutoSize = true;
            this.lab_m_dizhi.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_dizhi.Location = new System.Drawing.Point(327, 315);
            this.lab_m_dizhi.Name = "lab_m_dizhi";
            this.lab_m_dizhi.Size = new System.Drawing.Size(137, 12);
            this.lab_m_dizhi.TabIndex = 15;
            this.lab_m_dizhi.Text = "请输入开发商公司地址！";
            // 
            // lab_message
            // 
            this.lab_message.AutoSize = true;
            this.lab_message.ForeColor = System.Drawing.Color.Black;
            this.lab_message.Location = new System.Drawing.Point(120, 377);
            this.lab_message.Name = "lab_message";
            this.lab_message.Size = new System.Drawing.Size(0, 12);
            this.lab_message.TabIndex = 16;
            // 
            // picbox_logo
            // 
            this.picbox_logo.BackColor = System.Drawing.Color.Transparent;
            this.picbox_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_logo.BackgroundImage")));
            this.picbox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_logo.Location = new System.Drawing.Point(5, 0);
            this.picbox_logo.Name = "picbox_logo";
            this.picbox_logo.Size = new System.Drawing.Size(30, 30);
            this.picbox_logo.TabIndex = 17;
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
            this.lab_title.TabIndex = 18;
            this.lab_title.Text = "MIS by LiHuan";
            // 
            // Kfs_Form
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.picbox_logo);
            this.Controls.Add(this.lab_message);
            this.Controls.Add(this.lab_m_dizhi);
            this.Controls.Add(this.lab_m_lianxi);
            this.Controls.Add(this.lab_m_fuzeren);
            this.Controls.Add(this.lab_m_gongsi);
            this.Controls.Add(this.picbox_close);
            this.Controls.Add(this.picbox_min);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_dizhi);
            this.Controls.Add(this.txt_lianxi);
            this.Controls.Add(this.txt_fuzeren);
            this.Controls.Add(this.txt_gongsi);
            this.Controls.Add(this.lab_dizhi);
            this.Controls.Add(this.lab_fuzeren);
            this.Controls.Add(this.lab_lianxi);
            this.Controls.Add(this.lab_gongsi);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kfs_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kfs_Form";
            this.Load += new System.EventHandler(this.Kfs_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_gongsi;
        private System.Windows.Forms.Label lab_lianxi;
        private System.Windows.Forms.Label lab_fuzeren;
        private System.Windows.Forms.Label lab_dizhi;
        private System.Windows.Forms.TextBox txt_gongsi;
        private System.Windows.Forms.TextBox txt_fuzeren;
        private System.Windows.Forms.TextBox txt_lianxi;
        private System.Windows.Forms.TextBox txt_dizhi;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.PictureBox picbox_min;
        private System.Windows.Forms.PictureBox picbox_close;
        private System.Windows.Forms.Label lab_m_gongsi;
        private System.Windows.Forms.Label lab_m_fuzeren;
        private System.Windows.Forms.Label lab_m_lianxi;
        private System.Windows.Forms.Label lab_m_dizhi;
        private System.Windows.Forms.Label lab_message;
        private System.Windows.Forms.PictureBox picbox_logo;
        private System.Windows.Forms.Label lab_title;
    }
}