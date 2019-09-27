namespace WYMIS
{
    partial class Reg_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_Form));
            this.picbox_close = new System.Windows.Forms.PictureBox();
            this.picbox_min = new System.Windows.Forms.PictureBox();
            this.txt_xingming = new System.Windows.Forms.TextBox();
            this.txt_lianxi = new System.Windows.Forms.TextBox();
            this.txt_zhuzhi = new System.Windows.Forms.TextBox();
            this.txt_shenfenzheng = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password1 = new System.Windows.Forms.TextBox();
            this.txt_password2 = new System.Windows.Forms.TextBox();
            this.rdo_nan = new System.Windows.Forms.RadioButton();
            this.rdo_nv = new System.Windows.Forms.RadioButton();
            this.lab_xingming = new System.Windows.Forms.Label();
            this.lab_xingbie = new System.Windows.Forms.Label();
            this.lab_lianxi = new System.Windows.Forms.Label();
            this.lab_shenfenzheng = new System.Windows.Forms.Label();
            this.lab_zhuzhi = new System.Windows.Forms.Label();
            this.lab_username = new System.Windows.Forms.Label();
            this.lab_password1 = new System.Windows.Forms.Label();
            this.lab_password2 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lab_m_xingming = new System.Windows.Forms.Label();
            this.lab_m_lianxi = new System.Windows.Forms.Label();
            this.lab_m_shenfenzheng = new System.Windows.Forms.Label();
            this.lab_m_zhuzhi = new System.Windows.Forms.Label();
            this.lab_m_username = new System.Windows.Forms.Label();
            this.lab_m_password1 = new System.Windows.Forms.Label();
            this.lab_m_password2 = new System.Windows.Forms.Label();
            this.lab_message_reg = new System.Windows.Forms.Label();
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
            this.picbox_min.Location = new System.Drawing.Point(440, 0);
            this.picbox_min.Name = "picbox_min";
            this.picbox_min.Size = new System.Drawing.Size(30, 30);
            this.picbox_min.TabIndex = 1;
            this.picbox_min.TabStop = false;
            this.picbox_min.Click += new System.EventHandler(this.picbox_min_Click);
            this.picbox_min.MouseLeave += new System.EventHandler(this.picbox_min_MouseLeave);
            this.picbox_min.MouseHover += new System.EventHandler(this.picbox_min_MouseHover);
            // 
            // txt_xingming
            // 
            this.txt_xingming.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_xingming.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_xingming.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_xingming.Location = new System.Drawing.Point(120, 190);
            this.txt_xingming.MaxLength = 12;
            this.txt_xingming.Multiline = true;
            this.txt_xingming.Name = "txt_xingming";
            this.txt_xingming.Size = new System.Drawing.Size(150, 30);
            this.txt_xingming.TabIndex = 0;
            this.txt_xingming.Leave += new System.EventHandler(this.txt_xingming_Leave);
            // 
            // txt_lianxi
            // 
            this.txt_lianxi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lianxi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_lianxi.Location = new System.Drawing.Point(120, 260);
            this.txt_lianxi.MaxLength = 15;
            this.txt_lianxi.Multiline = true;
            this.txt_lianxi.Name = "txt_lianxi";
            this.txt_lianxi.Size = new System.Drawing.Size(150, 30);
            this.txt_lianxi.TabIndex = 3;
            this.txt_lianxi.Leave += new System.EventHandler(this.txt_lianxi_Leave);
            // 
            // txt_zhuzhi
            // 
            this.txt_zhuzhi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_zhuzhi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_zhuzhi.Location = new System.Drawing.Point(120, 340);
            this.txt_zhuzhi.MaxLength = 255;
            this.txt_zhuzhi.Multiline = true;
            this.txt_zhuzhi.Name = "txt_zhuzhi";
            this.txt_zhuzhi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_zhuzhi.Size = new System.Drawing.Size(200, 60);
            this.txt_zhuzhi.TabIndex = 5;
            this.txt_zhuzhi.Leave += new System.EventHandler(this.txt_zhuzhi_Leave);
            // 
            // txt_shenfenzheng
            // 
            this.txt_shenfenzheng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_shenfenzheng.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_shenfenzheng.Location = new System.Drawing.Point(120, 300);
            this.txt_shenfenzheng.MaxLength = 20;
            this.txt_shenfenzheng.Multiline = true;
            this.txt_shenfenzheng.Name = "txt_shenfenzheng";
            this.txt_shenfenzheng.Size = new System.Drawing.Size(200, 30);
            this.txt_shenfenzheng.TabIndex = 4;
            this.txt_shenfenzheng.Leave += new System.EventHandler(this.txt_shenfenzheng_Leave);
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_username.Location = new System.Drawing.Point(120, 410);
            this.txt_username.MaxLength = 25;
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(150, 30);
            this.txt_username.TabIndex = 6;
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // txt_password1
            // 
            this.txt_password1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_password1.Location = new System.Drawing.Point(120, 450);
            this.txt_password1.MaxLength = 25;
            this.txt_password1.Multiline = true;
            this.txt_password1.Name = "txt_password1";
            this.txt_password1.PasswordChar = '*';
            this.txt_password1.Size = new System.Drawing.Size(150, 30);
            this.txt_password1.TabIndex = 7;
            this.txt_password1.Leave += new System.EventHandler(this.txt_password1_Leave);
            // 
            // txt_password2
            // 
            this.txt_password2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_password2.Location = new System.Drawing.Point(120, 490);
            this.txt_password2.MaxLength = 25;
            this.txt_password2.Multiline = true;
            this.txt_password2.Name = "txt_password2";
            this.txt_password2.PasswordChar = '*';
            this.txt_password2.Size = new System.Drawing.Size(150, 30);
            this.txt_password2.TabIndex = 8;
            this.txt_password2.Leave += new System.EventHandler(this.txt_password2_Leave);
            // 
            // rdo_nan
            // 
            this.rdo_nan.AutoSize = true;
            this.rdo_nan.Checked = true;
            this.rdo_nan.Location = new System.Drawing.Point(120, 230);
            this.rdo_nan.Name = "rdo_nan";
            this.rdo_nan.Size = new System.Drawing.Size(35, 16);
            this.rdo_nan.TabIndex = 1;
            this.rdo_nan.TabStop = true;
            this.rdo_nan.Text = "男";
            this.rdo_nan.UseVisualStyleBackColor = true;
            // 
            // rdo_nv
            // 
            this.rdo_nv.AutoSize = true;
            this.rdo_nv.Location = new System.Drawing.Point(170, 230);
            this.rdo_nv.Name = "rdo_nv";
            this.rdo_nv.Size = new System.Drawing.Size(35, 16);
            this.rdo_nv.TabIndex = 2;
            this.rdo_nv.Text = "女";
            this.rdo_nv.UseVisualStyleBackColor = true;
            // 
            // lab_xingming
            // 
            this.lab_xingming.AutoSize = true;
            this.lab_xingming.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_xingming.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_xingming.Location = new System.Drawing.Point(70, 195);
            this.lab_xingming.Name = "lab_xingming";
            this.lab_xingming.Size = new System.Drawing.Size(49, 14);
            this.lab_xingming.TabIndex = 12;
            this.lab_xingming.Text = "姓名：";
            this.lab_xingming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_xingbie
            // 
            this.lab_xingbie.AutoSize = true;
            this.lab_xingbie.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_xingbie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_xingbie.Location = new System.Drawing.Point(70, 230);
            this.lab_xingbie.Name = "lab_xingbie";
            this.lab_xingbie.Size = new System.Drawing.Size(49, 14);
            this.lab_xingbie.TabIndex = 13;
            this.lab_xingbie.Text = "性别：";
            this.lab_xingbie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_lianxi
            // 
            this.lab_lianxi.AutoSize = true;
            this.lab_lianxi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_lianxi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_lianxi.Location = new System.Drawing.Point(42, 265);
            this.lab_lianxi.Name = "lab_lianxi";
            this.lab_lianxi.Size = new System.Drawing.Size(77, 14);
            this.lab_lianxi.TabIndex = 14;
            this.lab_lianxi.Text = "联系方式：";
            this.lab_lianxi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_shenfenzheng
            // 
            this.lab_shenfenzheng.AutoSize = true;
            this.lab_shenfenzheng.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_shenfenzheng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_shenfenzheng.Location = new System.Drawing.Point(56, 305);
            this.lab_shenfenzheng.Name = "lab_shenfenzheng";
            this.lab_shenfenzheng.Size = new System.Drawing.Size(63, 14);
            this.lab_shenfenzheng.TabIndex = 15;
            this.lab_shenfenzheng.Text = "身份证：";
            this.lab_shenfenzheng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_zhuzhi
            // 
            this.lab_zhuzhi.AutoSize = true;
            this.lab_zhuzhi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_zhuzhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_zhuzhi.Location = new System.Drawing.Point(70, 345);
            this.lab_zhuzhi.Name = "lab_zhuzhi";
            this.lab_zhuzhi.Size = new System.Drawing.Size(49, 14);
            this.lab_zhuzhi.TabIndex = 16;
            this.lab_zhuzhi.Text = "地址：";
            this.lab_zhuzhi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_username.Location = new System.Drawing.Point(56, 415);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(63, 14);
            this.lab_username.TabIndex = 17;
            this.lab_username.Text = "用户名：";
            this.lab_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_password1
            // 
            this.lab_password1.AutoSize = true;
            this.lab_password1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_password1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_password1.Location = new System.Drawing.Point(70, 455);
            this.lab_password1.Name = "lab_password1";
            this.lab_password1.Size = new System.Drawing.Size(49, 14);
            this.lab_password1.TabIndex = 18;
            this.lab_password1.Text = "密码：";
            this.lab_password1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_password2
            // 
            this.lab_password2.AutoSize = true;
            this.lab_password2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_password2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_password2.Location = new System.Drawing.Point(42, 495);
            this.lab_password2.Name = "lab_password2";
            this.lab_password2.Size = new System.Drawing.Size(77, 14);
            this.lab_password2.TabIndex = 19;
            this.lab_password2.Text = "确认密码：";
            this.lab_password2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ok
            // 
            this.btn_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ok.BackgroundImage")));
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(120, 550);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 30);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Text = "确定(&Y)";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reset.BackgroundImage")));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(245, 550);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 30);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "清空(&C)";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lab_m_xingming
            // 
            this.lab_m_xingming.AutoSize = true;
            this.lab_m_xingming.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_xingming.Location = new System.Drawing.Point(280, 195);
            this.lab_m_xingming.Name = "lab_m_xingming";
            this.lab_m_xingming.Size = new System.Drawing.Size(101, 12);
            this.lab_m_xingming.TabIndex = 20;
            this.lab_m_xingming.Text = "请输入你的名字！";
            // 
            // lab_m_lianxi
            // 
            this.lab_m_lianxi.AutoSize = true;
            this.lab_m_lianxi.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_lianxi.Location = new System.Drawing.Point(280, 265);
            this.lab_m_lianxi.Name = "lab_m_lianxi";
            this.lab_m_lianxi.Size = new System.Drawing.Size(125, 12);
            this.lab_m_lianxi.TabIndex = 21;
            this.lab_m_lianxi.Text = "请输入你的联系方式！";
            // 
            // lab_m_shenfenzheng
            // 
            this.lab_m_shenfenzheng.AutoSize = true;
            this.lab_m_shenfenzheng.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_shenfenzheng.Location = new System.Drawing.Point(330, 305);
            this.lab_m_shenfenzheng.Name = "lab_m_shenfenzheng";
            this.lab_m_shenfenzheng.Size = new System.Drawing.Size(137, 12);
            this.lab_m_shenfenzheng.TabIndex = 22;
            this.lab_m_shenfenzheng.Text = "请输入你的身份证号码！";
            // 
            // lab_m_zhuzhi
            // 
            this.lab_m_zhuzhi.AutoSize = true;
            this.lab_m_zhuzhi.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_zhuzhi.Location = new System.Drawing.Point(330, 345);
            this.lab_m_zhuzhi.Name = "lab_m_zhuzhi";
            this.lab_m_zhuzhi.Size = new System.Drawing.Size(125, 12);
            this.lab_m_zhuzhi.TabIndex = 23;
            this.lab_m_zhuzhi.Text = "请输入你现在的住址！";
            // 
            // lab_m_username
            // 
            this.lab_m_username.AutoSize = true;
            this.lab_m_username.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_username.Location = new System.Drawing.Point(280, 415);
            this.lab_m_username.Name = "lab_m_username";
            this.lab_m_username.Size = new System.Drawing.Size(173, 12);
            this.lab_m_username.TabIndex = 24;
            this.lab_m_username.Text = "登陆用户名只包含英文和字母！";
            // 
            // lab_m_password1
            // 
            this.lab_m_password1.AutoSize = true;
            this.lab_m_password1.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_password1.Location = new System.Drawing.Point(280, 455);
            this.lab_m_password1.Name = "lab_m_password1";
            this.lab_m_password1.Size = new System.Drawing.Size(101, 12);
            this.lab_m_password1.TabIndex = 25;
            this.lab_m_password1.Text = "请设置你的密码！";
            // 
            // lab_m_password2
            // 
            this.lab_m_password2.AutoSize = true;
            this.lab_m_password2.ForeColor = System.Drawing.Color.Silver;
            this.lab_m_password2.Location = new System.Drawing.Point(280, 495);
            this.lab_m_password2.Name = "lab_m_password2";
            this.lab_m_password2.Size = new System.Drawing.Size(125, 12);
            this.lab_m_password2.TabIndex = 26;
            this.lab_m_password2.Text = "请确认你输入的密码！";
            // 
            // lab_message_reg
            // 
            this.lab_message_reg.AutoSize = true;
            this.lab_message_reg.Location = new System.Drawing.Point(120, 530);
            this.lab_message_reg.Name = "lab_message_reg";
            this.lab_message_reg.Size = new System.Drawing.Size(0, 12);
            this.lab_message_reg.TabIndex = 27;
            // 
            // picbox_logo
            // 
            this.picbox_logo.BackColor = System.Drawing.Color.Transparent;
            this.picbox_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_logo.BackgroundImage")));
            this.picbox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_logo.Location = new System.Drawing.Point(5, 0);
            this.picbox_logo.Name = "picbox_logo";
            this.picbox_logo.Size = new System.Drawing.Size(30, 30);
            this.picbox_logo.TabIndex = 28;
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
            this.lab_title.TabIndex = 29;
            this.lab_title.Text = "MIS by LiHuan";
            // 
            // Reg_Form
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.picbox_logo);
            this.Controls.Add(this.lab_message_reg);
            this.Controls.Add(this.lab_m_password2);
            this.Controls.Add(this.lab_m_password1);
            this.Controls.Add(this.lab_m_username);
            this.Controls.Add(this.lab_m_zhuzhi);
            this.Controls.Add(this.lab_m_shenfenzheng);
            this.Controls.Add(this.lab_m_lianxi);
            this.Controls.Add(this.lab_m_xingming);
            this.Controls.Add(this.txt_xingming);
            this.Controls.Add(this.rdo_nan);
            this.Controls.Add(this.rdo_nv);
            this.Controls.Add(this.txt_lianxi);
            this.Controls.Add(this.txt_shenfenzheng);
            this.Controls.Add(this.txt_zhuzhi);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_password1);
            this.Controls.Add(this.txt_password2);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lab_password2);
            this.Controls.Add(this.lab_password1);
            this.Controls.Add(this.lab_username);
            this.Controls.Add(this.lab_zhuzhi);
            this.Controls.Add(this.lab_shenfenzheng);
            this.Controls.Add(this.lab_lianxi);
            this.Controls.Add(this.lab_xingbie);
            this.Controls.Add(this.lab_xingming);
            this.Controls.Add(this.picbox_min);
            this.Controls.Add(this.picbox_close);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reg_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "业主注册";
            this.Load += new System.EventHandler(this.Reg_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_close;
        private System.Windows.Forms.PictureBox picbox_min;
        private System.Windows.Forms.TextBox txt_xingming;
        private System.Windows.Forms.TextBox txt_lianxi;
        private System.Windows.Forms.TextBox txt_zhuzhi;
        private System.Windows.Forms.TextBox txt_shenfenzheng;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password1;
        private System.Windows.Forms.TextBox txt_password2;
        private System.Windows.Forms.RadioButton rdo_nan;
        private System.Windows.Forms.RadioButton rdo_nv;
        private System.Windows.Forms.Label lab_xingming;
        private System.Windows.Forms.Label lab_xingbie;
        private System.Windows.Forms.Label lab_lianxi;
        private System.Windows.Forms.Label lab_shenfenzheng;
        private System.Windows.Forms.Label lab_zhuzhi;
        private System.Windows.Forms.Label lab_username;
        private System.Windows.Forms.Label lab_password1;
        private System.Windows.Forms.Label lab_password2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lab_m_xingming;
        private System.Windows.Forms.Label lab_m_lianxi;
        private System.Windows.Forms.Label lab_m_shenfenzheng;
        private System.Windows.Forms.Label lab_m_zhuzhi;
        private System.Windows.Forms.Label lab_m_username;
        private System.Windows.Forms.Label lab_m_password1;
        private System.Windows.Forms.Label lab_m_password2;
        private System.Windows.Forms.Label lab_message_reg;
        private System.Windows.Forms.PictureBox picbox_logo;
        private System.Windows.Forms.Label lab_title;
    }
}