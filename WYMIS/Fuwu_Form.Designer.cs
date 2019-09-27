namespace WYMIS
{
    partial class Fuwu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fuwu_Form));
            this.picbox_min = new System.Windows.Forms.PictureBox();
            this.picbox_close = new System.Windows.Forms.PictureBox();
            this.lab_shixiang = new System.Windows.Forms.Label();
            this.lab_yezhu = new System.Windows.Forms.Label();
            this.lab_yuangong = new System.Windows.Forms.Label();
            this.lab_shoufei = new System.Windows.Forms.Label();
            this.txt_shixiang = new System.Windows.Forms.TextBox();
            this.txt_yezhu = new System.Windows.Forms.TextBox();
            this.txt_yuangong = new System.Windows.Forms.TextBox();
            this.txt_shoufei = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lab_m_shixiang = new System.Windows.Forms.Label();
            this.lab_m_yezhu = new System.Windows.Forms.Label();
            this.lab_m_yuangong = new System.Windows.Forms.Label();
            this.lab_m_shoufei = new System.Windows.Forms.Label();
            this.lab_message = new System.Windows.Forms.Label();
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
            this.picbox_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
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
            // lab_shixiang
            // 
            this.lab_shixiang.AutoSize = true;
            this.lab_shixiang.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_shixiang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_shixiang.Location = new System.Drawing.Point(42, 195);
            this.lab_shixiang.Name = "lab_shixiang";
            this.lab_shixiang.Size = new System.Drawing.Size(77, 14);
            this.lab_shixiang.TabIndex = 2;
            this.lab_shixiang.Text = "服务名称：";
            // 
            // lab_yezhu
            // 
            this.lab_yezhu.AutoSize = true;
            this.lab_yezhu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_yezhu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_yezhu.Location = new System.Drawing.Point(56, 235);
            this.lab_yezhu.Name = "lab_yezhu";
            this.lab_yezhu.Size = new System.Drawing.Size(63, 14);
            this.lab_yezhu.TabIndex = 3;
            this.lab_yezhu.Text = "业主ID：";
            // 
            // lab_yuangong
            // 
            this.lab_yuangong.AutoSize = true;
            this.lab_yuangong.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_yuangong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_yuangong.Location = new System.Drawing.Point(56, 275);
            this.lab_yuangong.Name = "lab_yuangong";
            this.lab_yuangong.Size = new System.Drawing.Size(63, 14);
            this.lab_yuangong.TabIndex = 8;
            this.lab_yuangong.Text = "员工ID：";
            // 
            // lab_shoufei
            // 
            this.lab_shoufei.AutoSize = true;
            this.lab_shoufei.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_shoufei.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_shoufei.Location = new System.Drawing.Point(70, 315);
            this.lab_shoufei.Name = "lab_shoufei";
            this.lab_shoufei.Size = new System.Drawing.Size(49, 14);
            this.lab_shoufei.TabIndex = 9;
            this.lab_shoufei.Text = "收费：";
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
            this.txt_shixiang.TabIndex = 10;
            this.txt_shixiang.Tag = "0";
            this.txt_shixiang.Leave += new System.EventHandler(this.txt_shixiang_Leave);
            // 
            // txt_yezhu
            // 
            this.txt_yezhu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_yezhu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_yezhu.Location = new System.Drawing.Point(120, 230);
            this.txt_yezhu.MaxLength = 8;
            this.txt_yezhu.Multiline = true;
            this.txt_yezhu.Name = "txt_yezhu";
            this.txt_yezhu.Size = new System.Drawing.Size(150, 30);
            this.txt_yezhu.TabIndex = 11;
            this.txt_yezhu.Tag = "0";
            this.txt_yezhu.Leave += new System.EventHandler(this.txt_yezhu_Leave);
            // 
            // txt_yuangong
            // 
            this.txt_yuangong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_yuangong.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_yuangong.Location = new System.Drawing.Point(120, 270);
            this.txt_yuangong.MaxLength = 8;
            this.txt_yuangong.Multiline = true;
            this.txt_yuangong.Name = "txt_yuangong";
            this.txt_yuangong.Size = new System.Drawing.Size(150, 30);
            this.txt_yuangong.TabIndex = 12;
            this.txt_yuangong.Tag = "0";
            this.txt_yuangong.Leave += new System.EventHandler(this.txt_yuangong_Leave);
            // 
            // txt_shoufei
            // 
            this.txt_shoufei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_shoufei.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_shoufei.Location = new System.Drawing.Point(120, 310);
            this.txt_shoufei.Multiline = true;
            this.txt_shoufei.Name = "txt_shoufei";
            this.txt_shoufei.Size = new System.Drawing.Size(150, 30);
            this.txt_shoufei.TabIndex = 13;
            this.txt_shoufei.Tag = "0";
            this.txt_shoufei.Leave += new System.EventHandler(this.txt_shoufei_Leave);
            // 
            // btn_ok
            // 
            this.btn_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ok.BackgroundImage")));
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(120, 370);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 30);
            this.btn_ok.TabIndex = 14;
            this.btn_ok.Text = "确定(&Y)";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reset.BackgroundImage")));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(245, 370);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 30);
            this.btn_reset.TabIndex = 15;
            this.btn_reset.Text = "清空(&C)";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lab_m_shixiang
            // 
            this.lab_m_shixiang.AutoSize = true;
            this.lab_m_shixiang.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_shixiang.Location = new System.Drawing.Point(280, 200);
            this.lab_m_shixiang.Name = "lab_m_shixiang";
            this.lab_m_shixiang.Size = new System.Drawing.Size(101, 12);
            this.lab_m_shixiang.TabIndex = 16;
            this.lab_m_shixiang.Text = "请输入服务名称！";
            // 
            // lab_m_yezhu
            // 
            this.lab_m_yezhu.AutoSize = true;
            this.lab_m_yezhu.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_yezhu.Location = new System.Drawing.Point(280, 240);
            this.lab_m_yezhu.Name = "lab_m_yezhu";
            this.lab_m_yezhu.Size = new System.Drawing.Size(89, 12);
            this.lab_m_yezhu.TabIndex = 17;
            this.lab_m_yezhu.Text = "请输入业主ID！";
            // 
            // lab_m_yuangong
            // 
            this.lab_m_yuangong.AutoSize = true;
            this.lab_m_yuangong.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_yuangong.Location = new System.Drawing.Point(280, 280);
            this.lab_m_yuangong.Name = "lab_m_yuangong";
            this.lab_m_yuangong.Size = new System.Drawing.Size(83, 12);
            this.lab_m_yuangong.TabIndex = 18;
            this.lab_m_yuangong.Text = "请输入员工ID!";
            // 
            // lab_m_shoufei
            // 
            this.lab_m_shoufei.AutoSize = true;
            this.lab_m_shoufei.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_shoufei.Location = new System.Drawing.Point(280, 320);
            this.lab_m_shoufei.Name = "lab_m_shoufei";
            this.lab_m_shoufei.Size = new System.Drawing.Size(95, 12);
            this.lab_m_shoufei.TabIndex = 19;
            this.lab_m_shoufei.Text = "请输入收费信息!";
            // 
            // lab_message
            // 
            this.lab_message.AutoSize = true;
            this.lab_message.Location = new System.Drawing.Point(120, 350);
            this.lab_message.Name = "lab_message";
            this.lab_message.Size = new System.Drawing.Size(0, 12);
            this.lab_message.TabIndex = 20;
            // 
            // picbox_logo
            // 
            this.picbox_logo.BackColor = System.Drawing.Color.Transparent;
            this.picbox_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_logo.BackgroundImage")));
            this.picbox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_logo.Location = new System.Drawing.Point(5, 0);
            this.picbox_logo.Name = "picbox_logo";
            this.picbox_logo.Size = new System.Drawing.Size(30, 30);
            this.picbox_logo.TabIndex = 21;
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
            this.lab_title.TabIndex = 22;
            this.lab_title.Text = "MIS by LiHuan";
            // 
            // Fuwu_Form
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 430);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.picbox_logo);
            this.Controls.Add(this.lab_message);
            this.Controls.Add(this.lab_m_shoufei);
            this.Controls.Add(this.lab_m_yuangong);
            this.Controls.Add(this.lab_m_yezhu);
            this.Controls.Add(this.lab_m_shixiang);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_shoufei);
            this.Controls.Add(this.txt_yuangong);
            this.Controls.Add(this.txt_yezhu);
            this.Controls.Add(this.txt_shixiang);
            this.Controls.Add(this.lab_shoufei);
            this.Controls.Add(this.lab_yuangong);
            this.Controls.Add(this.lab_yezhu);
            this.Controls.Add(this.lab_shixiang);
            this.Controls.Add(this.picbox_close);
            this.Controls.Add(this.picbox_min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fuwu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shenqing_Form";
            this.Load += new System.EventHandler(this.Fuwu_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_min;
        private System.Windows.Forms.PictureBox picbox_close;
        private System.Windows.Forms.Label lab_shixiang;
        private System.Windows.Forms.Label lab_yezhu;
        private System.Windows.Forms.Label lab_yuangong;
        private System.Windows.Forms.Label lab_shoufei;
        private System.Windows.Forms.TextBox txt_shixiang;
        private System.Windows.Forms.TextBox txt_yezhu;
        private System.Windows.Forms.TextBox txt_yuangong;
        private System.Windows.Forms.TextBox txt_shoufei;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lab_m_shixiang;
        private System.Windows.Forms.Label lab_m_yezhu;
        private System.Windows.Forms.Label lab_m_yuangong;
        private System.Windows.Forms.Label lab_m_shoufei;
        private System.Windows.Forms.Label lab_message;
        private System.Windows.Forms.PictureBox picbox_logo;
        private System.Windows.Forms.Label lab_title;
    }
}