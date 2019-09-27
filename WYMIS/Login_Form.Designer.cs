namespace WYMIS
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_reg = new System.Windows.Forms.Button();
            this.pbox_close = new System.Windows.Forms.PictureBox();
            this.pbox_min = new System.Windows.Forms.PictureBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.picbox_header = new System.Windows.Forms.PictureBox();
            this.lab_message = new System.Windows.Forms.Label();
            this.picbox_logo = new System.Windows.Forms.PictureBox();
            this.lab_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ok.BackgroundImage")));
            this.btn_ok.Location = new System.Drawing.Point(120, 240);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 30);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "确定(&Y)";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_reg
            // 
            this.btn_reg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reg.BackgroundImage")));
            this.btn_reg.Location = new System.Drawing.Point(258, 238);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(75, 30);
            this.btn_reg.TabIndex = 3;
            this.btn_reg.Text = "注册(&R)";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // pbox_close
            // 
            this.pbox_close.BackColor = System.Drawing.Color.Transparent;
            this.pbox_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbox_close.BackgroundImage")));
            this.pbox_close.Location = new System.Drawing.Point(420, 0);
            this.pbox_close.Name = "pbox_close";
            this.pbox_close.Size = new System.Drawing.Size(30, 30);
            this.pbox_close.TabIndex = 2;
            this.pbox_close.TabStop = false;
            this.pbox_close.Click += new System.EventHandler(this.pbox_close_Click);
            this.pbox_close.MouseLeave += new System.EventHandler(this.pbox_close_MouseLeave);
            this.pbox_close.MouseHover += new System.EventHandler(this.pbox_close_MouseHover);
            // 
            // pbox_min
            // 
            this.pbox_min.BackColor = System.Drawing.Color.Transparent;
            this.pbox_min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbox_min.BackgroundImage")));
            this.pbox_min.Location = new System.Drawing.Point(390, 0);
            this.pbox_min.Name = "pbox_min";
            this.pbox_min.Size = new System.Drawing.Size(30, 30);
            this.pbox_min.TabIndex = 3;
            this.pbox_min.TabStop = false;
            this.pbox_min.Click += new System.EventHandler(this.pbox_min_Click);
            this.pbox_min.MouseLeave += new System.EventHandler(this.pbox_min_MouseLeave);
            this.pbox_min.MouseHover += new System.EventHandler(this.pbox_min_MouseHover);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_username.ForeColor = System.Drawing.Color.Gray;
            this.txt_username.Location = new System.Drawing.Point(180, 160);
            this.txt_username.MaxLength = 25;
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(150, 30);
            this.txt_username.TabIndex = 4;
            this.txt_username.Text = "请输入用户名";
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_password.ForeColor = System.Drawing.Color.Gray;
            this.txt_password.Location = new System.Drawing.Point(180, 200);
            this.txt_password.MaxLength = 25;
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(150, 30);
            this.txt_password.TabIndex = 5;
            this.txt_password.Text = "请输入密码";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // picbox_header
            // 
            this.picbox_header.Image = ((System.Drawing.Image)(resources.GetObject("picbox_header.Image")));
            this.picbox_header.Location = new System.Drawing.Point(120, 160);
            this.picbox_header.Name = "picbox_header";
            this.picbox_header.Size = new System.Drawing.Size(50, 70);
            this.picbox_header.TabIndex = 6;
            this.picbox_header.TabStop = false;
            this.picbox_header.Tag = "yuangong";
            this.picbox_header.Click += new System.EventHandler(this.picbox_header_Click);
            // 
            // lab_message
            // 
            this.lab_message.AutoSize = true;
            this.lab_message.ForeColor = System.Drawing.Color.Black;
            this.lab_message.Location = new System.Drawing.Point(120, 277);
            this.lab_message.Name = "lab_message";
            this.lab_message.Size = new System.Drawing.Size(0, 12);
            this.lab_message.TabIndex = 0;
            // 
            // picbox_logo
            // 
            this.picbox_logo.BackColor = System.Drawing.Color.Transparent;
            this.picbox_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_logo.BackgroundImage")));
            this.picbox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_logo.Location = new System.Drawing.Point(5, 0);
            this.picbox_logo.Name = "picbox_logo";
            this.picbox_logo.Size = new System.Drawing.Size(30, 30);
            this.picbox_logo.TabIndex = 8;
            this.picbox_logo.TabStop = false;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.BackColor = System.Drawing.Color.Transparent;
            this.lab_title.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_title.Location = new System.Drawing.Point(30, 7);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(105, 18);
            this.lab_title.TabIndex = 1;
            this.lab_title.Text = "MIS by LiHuan";
            // 
            // Login_Form
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.picbox_logo);
            this.Controls.Add(this.lab_message);
            this.Controls.Add(this.picbox_header);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.pbox_min);
            this.Controls.Add(this.pbox_close);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.btn_ok);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.PictureBox pbox_close;
        private System.Windows.Forms.PictureBox pbox_min;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox picbox_header;
        private System.Windows.Forms.Label lab_message;
        private System.Windows.Forms.PictureBox picbox_logo;
        private System.Windows.Forms.Label lab_title;
    }
}