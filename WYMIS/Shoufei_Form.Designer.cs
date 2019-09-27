namespace WYMIS
{
    partial class Shoufei_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shoufei_Form));
            this.picbox_close = new System.Windows.Forms.PictureBox();
            this.picbox_min = new System.Windows.Forms.PictureBox();
            this.lab_shoufei = new System.Windows.Forms.Label();
            this.lab_jine = new System.Windows.Forms.Label();
            this.lab_shijian = new System.Windows.Forms.Label();
            this.lab_yezhu = new System.Windows.Forms.Label();
            this.lab_yuangong = new System.Windows.Forms.Label();
            this.lab_beizhu = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_shixiang = new System.Windows.Forms.TextBox();
            this.txt_jine = new System.Windows.Forms.TextBox();
            this.txt_yezhu = new System.Windows.Forms.TextBox();
            this.txt_yuangong = new System.Windows.Forms.TextBox();
            this.txt_beizhu = new System.Windows.Forms.TextBox();
            this.date_shijian = new System.Windows.Forms.DateTimePicker();
            this.lab_m_shixiang = new System.Windows.Forms.Label();
            this.lab_m_jine = new System.Windows.Forms.Label();
            this.lab_m_yezhu = new System.Windows.Forms.Label();
            this.lab_m_yuangong = new System.Windows.Forms.Label();
            this.lab_message = new System.Windows.Forms.Label();
            this.picbox_logo = new System.Windows.Forms.PictureBox();
            this.lab_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_close
            // 
            this.picbox_close.BackColor = System.Drawing.Color.Transparent;
            this.picbox_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_close.BackgroundImage")));
            this.picbox_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_close.Location = new System.Drawing.Point(470, 0);
            this.picbox_close.Name = "picbox_close";
            this.picbox_close.Size = new System.Drawing.Size(30, 30);
            this.picbox_close.TabIndex = 0;
            this.picbox_close.TabStop = false;
            this.picbox_close.Click += new System.EventHandler(this.picbox_close_Click);
            this.picbox_close.MouseLeave += new System.EventHandler(this.picbox_close_MouseLeave);
            this.picbox_close.MouseHover += new System.EventHandler(this.picbox_close_MouseHover);
            // 
            // picbox_min
            // 
            this.picbox_min.BackColor = System.Drawing.Color.Transparent;
            this.picbox_min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_min.BackgroundImage")));
            this.picbox_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_min.Location = new System.Drawing.Point(440, 0);
            this.picbox_min.Name = "picbox_min";
            this.picbox_min.Size = new System.Drawing.Size(30, 30);
            this.picbox_min.TabIndex = 1;
            this.picbox_min.TabStop = false;
            this.picbox_min.Click += new System.EventHandler(this.picbox_min_Click);
            this.picbox_min.MouseLeave += new System.EventHandler(this.picbox_min_MouseLeave);
            this.picbox_min.MouseHover += new System.EventHandler(this.picbox_min_MouseHover);
            // 
            // lab_shoufei
            // 
            this.lab_shoufei.AutoSize = true;
            this.lab_shoufei.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_shoufei.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_shoufei.Location = new System.Drawing.Point(42, 195);
            this.lab_shoufei.Name = "lab_shoufei";
            this.lab_shoufei.Size = new System.Drawing.Size(77, 14);
            this.lab_shoufei.TabIndex = 2;
            this.lab_shoufei.Text = "收费事项：";
            // 
            // lab_jine
            // 
            this.lab_jine.AutoSize = true;
            this.lab_jine.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_jine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_jine.Location = new System.Drawing.Point(70, 235);
            this.lab_jine.Name = "lab_jine";
            this.lab_jine.Size = new System.Drawing.Size(49, 14);
            this.lab_jine.TabIndex = 3;
            this.lab_jine.Text = "金额：";
            // 
            // lab_shijian
            // 
            this.lab_shijian.AutoSize = true;
            this.lab_shijian.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_shijian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_shijian.Location = new System.Drawing.Point(42, 275);
            this.lab_shijian.Name = "lab_shijian";
            this.lab_shijian.Size = new System.Drawing.Size(77, 14);
            this.lab_shijian.TabIndex = 5;
            this.lab_shijian.Text = "缴费时间：";
            // 
            // lab_yezhu
            // 
            this.lab_yezhu.AutoSize = true;
            this.lab_yezhu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_yezhu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_yezhu.Location = new System.Drawing.Point(56, 315);
            this.lab_yezhu.Name = "lab_yezhu";
            this.lab_yezhu.Size = new System.Drawing.Size(63, 14);
            this.lab_yezhu.TabIndex = 6;
            this.lab_yezhu.Text = "业主ID：";
            // 
            // lab_yuangong
            // 
            this.lab_yuangong.AutoSize = true;
            this.lab_yuangong.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_yuangong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_yuangong.Location = new System.Drawing.Point(56, 355);
            this.lab_yuangong.Name = "lab_yuangong";
            this.lab_yuangong.Size = new System.Drawing.Size(63, 14);
            this.lab_yuangong.TabIndex = 7;
            this.lab_yuangong.Text = "员工ID：";
            // 
            // lab_beizhu
            // 
            this.lab_beizhu.AutoSize = true;
            this.lab_beizhu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_beizhu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_beizhu.Location = new System.Drawing.Point(70, 395);
            this.lab_beizhu.Name = "lab_beizhu";
            this.lab_beizhu.Size = new System.Drawing.Size(49, 14);
            this.lab_beizhu.TabIndex = 8;
            this.lab_beizhu.Text = "备注：";
            // 
            // btn_ok
            // 
            this.btn_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ok.BackgroundImage")));
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(120, 515);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 30);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Text = "确定(&Y)";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancel.BackgroundImage")));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(245, 515);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "清空(&C)";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_shixiang
            // 
            this.txt_shixiang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_shixiang.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_shixiang.Location = new System.Drawing.Point(120, 190);
            this.txt_shixiang.MaxLength = 12;
            this.txt_shixiang.Multiline = true;
            this.txt_shixiang.Name = "txt_shixiang";
            this.txt_shixiang.Size = new System.Drawing.Size(150, 30);
            this.txt_shixiang.TabIndex = 11;
            this.txt_shixiang.Tag = "0";
            this.txt_shixiang.Leave += new System.EventHandler(this.txt_shixiang_Leave);
            // 
            // txt_jine
            // 
            this.txt_jine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_jine.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_jine.Location = new System.Drawing.Point(120, 230);
            this.txt_jine.MaxLength = 8;
            this.txt_jine.Multiline = true;
            this.txt_jine.Name = "txt_jine";
            this.txt_jine.Size = new System.Drawing.Size(150, 30);
            this.txt_jine.TabIndex = 12;
            this.txt_jine.Tag = "0";
            this.txt_jine.Leave += new System.EventHandler(this.txt_jine_Leave);
            // 
            // txt_yezhu
            // 
            this.txt_yezhu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_yezhu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_yezhu.Location = new System.Drawing.Point(120, 310);
            this.txt_yezhu.MaxLength = 8;
            this.txt_yezhu.Multiline = true;
            this.txt_yezhu.Name = "txt_yezhu";
            this.txt_yezhu.Size = new System.Drawing.Size(150, 30);
            this.txt_yezhu.TabIndex = 13;
            this.txt_yezhu.Tag = "0";
            this.txt_yezhu.Leave += new System.EventHandler(this.txt_yezhu_Leave);
            // 
            // txt_yuangong
            // 
            this.txt_yuangong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_yuangong.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_yuangong.Location = new System.Drawing.Point(120, 350);
            this.txt_yuangong.MaxLength = 8;
            this.txt_yuangong.Multiline = true;
            this.txt_yuangong.Name = "txt_yuangong";
            this.txt_yuangong.Size = new System.Drawing.Size(150, 30);
            this.txt_yuangong.TabIndex = 14;
            this.txt_yuangong.Tag = "0";
            this.txt_yuangong.Leave += new System.EventHandler(this.txt_yuangong_Leave);
            // 
            // txt_beizhu
            // 
            this.txt_beizhu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_beizhu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_beizhu.Location = new System.Drawing.Point(120, 390);
            this.txt_beizhu.Multiline = true;
            this.txt_beizhu.Name = "txt_beizhu";
            this.txt_beizhu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_beizhu.Size = new System.Drawing.Size(200, 100);
            this.txt_beizhu.TabIndex = 15;
            // 
            // date_shijian
            // 
            this.date_shijian.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.date_shijian.Location = new System.Drawing.Point(120, 270);
            this.date_shijian.Name = "date_shijian";
            this.date_shijian.Size = new System.Drawing.Size(150, 23);
            this.date_shijian.TabIndex = 16;
            // 
            // lab_m_shixiang
            // 
            this.lab_m_shixiang.AutoSize = true;
            this.lab_m_shixiang.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_shixiang.Location = new System.Drawing.Point(280, 195);
            this.lab_m_shixiang.Name = "lab_m_shixiang";
            this.lab_m_shixiang.Size = new System.Drawing.Size(125, 12);
            this.lab_m_shixiang.TabIndex = 17;
            this.lab_m_shixiang.Text = "请输入收费事项名称！";
            // 
            // lab_m_jine
            // 
            this.lab_m_jine.AutoSize = true;
            this.lab_m_jine.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_jine.Location = new System.Drawing.Point(280, 235);
            this.lab_m_jine.Name = "lab_m_jine";
            this.lab_m_jine.Size = new System.Drawing.Size(101, 12);
            this.lab_m_jine.TabIndex = 18;
            this.lab_m_jine.Text = "请输入收费金额！";
            // 
            // lab_m_yezhu
            // 
            this.lab_m_yezhu.AutoSize = true;
            this.lab_m_yezhu.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_yezhu.Location = new System.Drawing.Point(280, 315);
            this.lab_m_yezhu.Name = "lab_m_yezhu";
            this.lab_m_yezhu.Size = new System.Drawing.Size(89, 12);
            this.lab_m_yezhu.TabIndex = 19;
            this.lab_m_yezhu.Text = "请输入业主ID！";
            // 
            // lab_m_yuangong
            // 
            this.lab_m_yuangong.AutoSize = true;
            this.lab_m_yuangong.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_yuangong.Location = new System.Drawing.Point(280, 355);
            this.lab_m_yuangong.Name = "lab_m_yuangong";
            this.lab_m_yuangong.Size = new System.Drawing.Size(89, 12);
            this.lab_m_yuangong.TabIndex = 20;
            this.lab_m_yuangong.Text = "请输入员工ID！";
            // 
            // lab_message
            // 
            this.lab_message.AutoSize = true;
            this.lab_message.Location = new System.Drawing.Point(120, 497);
            this.lab_message.Name = "lab_message";
            this.lab_message.Size = new System.Drawing.Size(0, 12);
            this.lab_message.TabIndex = 21;
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
            this.lab_title.ForeColor = System.Drawing.Color.White;
            this.lab_title.Location = new System.Drawing.Point(30, 7);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(105, 18);
            this.lab_title.TabIndex = 23;
            this.lab_title.Text = "MIS by LiHuan";
            // 
            // Shoufei_Form
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.picbox_logo);
            this.Controls.Add(this.lab_message);
            this.Controls.Add(this.lab_m_yuangong);
            this.Controls.Add(this.lab_m_yezhu);
            this.Controls.Add(this.lab_m_jine);
            this.Controls.Add(this.lab_m_shixiang);
            this.Controls.Add(this.date_shijian);
            this.Controls.Add(this.txt_beizhu);
            this.Controls.Add(this.txt_yuangong);
            this.Controls.Add(this.txt_yezhu);
            this.Controls.Add(this.txt_jine);
            this.Controls.Add(this.txt_shixiang);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lab_beizhu);
            this.Controls.Add(this.lab_yuangong);
            this.Controls.Add(this.lab_yezhu);
            this.Controls.Add(this.lab_shijian);
            this.Controls.Add(this.lab_jine);
            this.Controls.Add(this.lab_shoufei);
            this.Controls.Add(this.picbox_min);
            this.Controls.Add(this.picbox_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shoufei_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shoufei_Form";
            this.Load += new System.EventHandler(this.Shoufei_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_close;
        private System.Windows.Forms.PictureBox picbox_min;
        private System.Windows.Forms.Label lab_shoufei;
        private System.Windows.Forms.Label lab_jine;
        private System.Windows.Forms.Label lab_shijian;
        private System.Windows.Forms.Label lab_yezhu;
        private System.Windows.Forms.Label lab_yuangong;
        private System.Windows.Forms.Label lab_beizhu;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_shixiang;
        private System.Windows.Forms.TextBox txt_jine;
        private System.Windows.Forms.TextBox txt_yezhu;
        private System.Windows.Forms.TextBox txt_yuangong;
        private System.Windows.Forms.TextBox txt_beizhu;
        private System.Windows.Forms.DateTimePicker date_shijian;
        private System.Windows.Forms.Label lab_m_shixiang;
        private System.Windows.Forms.Label lab_m_jine;
        private System.Windows.Forms.Label lab_m_yezhu;
        private System.Windows.Forms.Label lab_m_yuangong;
        private System.Windows.Forms.Label lab_message;
        private System.Windows.Forms.PictureBox picbox_logo;
        private System.Windows.Forms.Label lab_title;
    }
}