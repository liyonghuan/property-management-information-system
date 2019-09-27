namespace WYMIS
{
    partial class Main_Yezhu_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Yezhu_Form));
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("未处理");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("已受理");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("已完成");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("服务申请", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.picbox_logo = new System.Windows.Forms.PictureBox();
            this.lab_title = new System.Windows.Forms.Label();
            this.picbox_min = new System.Windows.Forms.PictureBox();
            this.picbox_close = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeview = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lab_yzfy = new System.Windows.Forms.Label();
            this.lab_m_yzfy = new System.Windows.Forms.Label();
            this.lab_yzzz = new System.Windows.Forms.Label();
            this.lab_yzyhm = new System.Windows.Forms.Label();
            this.lab_yzlx = new System.Windows.Forms.Label();
            this.lab_yzsfz = new System.Windows.Forms.Label();
            this.lab_yzxb = new System.Windows.Forms.Label();
            this.lab_yzxm = new System.Windows.Forms.Label();
            this.lab_m_yzzz = new System.Windows.Forms.Label();
            this.lab_m_yzyhm = new System.Windows.Forms.Label();
            this.lab_m_yzlx = new System.Windows.Forms.Label();
            this.lab_m_yzsfz = new System.Windows.Forms.Label();
            this.lab_m_yzxb = new System.Windows.Forms.Label();
            this.lab_m_yzxm = new System.Windows.Forms.Label();
            this.listview = new System.Windows.Forms.ListView();
            this.序号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.申请编号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.申请名称 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.申请人 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.申请时间 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.状态 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.受理时间 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.负责人 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.完成时间 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.费用 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.conmenustr_list = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加申请ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改申请ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除申请ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picbox_about = new System.Windows.Forms.PictureBox();
            this.picbox_sy = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.combox = new System.Windows.Forms.ComboBox();
            this.txt_context = new System.Windows.Forms.TextBox();
            this.picbox_search = new System.Windows.Forms.PictureBox();
            this.导出ExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.conmenustr_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_about)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_sy)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_search)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_logo
            // 
            this.picbox_logo.BackColor = System.Drawing.Color.Transparent;
            this.picbox_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_logo.BackgroundImage")));
            this.picbox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_logo.Location = new System.Drawing.Point(5, 0);
            this.picbox_logo.Name = "picbox_logo";
            this.picbox_logo.Size = new System.Drawing.Size(30, 30);
            this.picbox_logo.TabIndex = 0;
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
            this.lab_title.TabIndex = 1;
            this.lab_title.Text = "MIS by LiHuan";
            // 
            // picbox_min
            // 
            this.picbox_min.BackColor = System.Drawing.Color.Transparent;
            this.picbox_min.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_min.BackgroundImage")));
            this.picbox_min.Location = new System.Drawing.Point(964, 0);
            this.picbox_min.Name = "picbox_min";
            this.picbox_min.Size = new System.Drawing.Size(30, 30);
            this.picbox_min.TabIndex = 2;
            this.picbox_min.TabStop = false;
            this.picbox_min.Click += new System.EventHandler(this.picbox_min_Click);
            this.picbox_min.MouseLeave += new System.EventHandler(this.picbox_min_MouseLeave);
            this.picbox_min.MouseHover += new System.EventHandler(this.picbox_min_MouseHover);
            // 
            // picbox_close
            // 
            this.picbox_close.BackColor = System.Drawing.Color.Transparent;
            this.picbox_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_close.BackgroundImage")));
            this.picbox_close.Location = new System.Drawing.Point(994, 0);
            this.picbox_close.Name = "picbox_close";
            this.picbox_close.Size = new System.Drawing.Size(30, 30);
            this.picbox_close.TabIndex = 3;
            this.picbox_close.TabStop = false;
            this.picbox_close.Click += new System.EventHandler(this.picbox_close_Click);
            this.picbox_close.MouseLeave += new System.EventHandler(this.picbox_close_MouseLeave);
            this.picbox_close.MouseHover += new System.EventHandler(this.picbox_close_MouseHover);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 125);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listview);
            this.splitContainer1.Panel2MinSize = 700;
            this.splitContainer1.Size = new System.Drawing.Size(1022, 380);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeview);
            this.splitContainer2.Panel1MinSize = 150;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2MinSize = 200;
            this.splitContainer2.Size = new System.Drawing.Size(200, 380);
            this.splitContainer2.SplitterDistance = 150;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeview
            // 
            this.treeview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeview.Location = new System.Drawing.Point(0, 0);
            this.treeview.Name = "treeview";
            treeNode5.Name = "0";
            treeNode5.Text = "未处理";
            treeNode6.Name = "1";
            treeNode6.Text = "已受理";
            treeNode7.Name = "2";
            treeNode7.Text = "已完成";
            treeNode8.Name = "0";
            treeNode8.Text = "服务申请";
            this.treeview.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeview.Size = new System.Drawing.Size(200, 150);
            this.treeview.TabIndex = 0;
            this.treeview.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeview_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lab_yzfy);
            this.groupBox1.Controls.Add(this.lab_m_yzfy);
            this.groupBox1.Controls.Add(this.lab_yzzz);
            this.groupBox1.Controls.Add(this.lab_yzyhm);
            this.groupBox1.Controls.Add(this.lab_yzlx);
            this.groupBox1.Controls.Add(this.lab_yzsfz);
            this.groupBox1.Controls.Add(this.lab_yzxb);
            this.groupBox1.Controls.Add(this.lab_yzxm);
            this.groupBox1.Controls.Add(this.lab_m_yzzz);
            this.groupBox1.Controls.Add(this.lab_m_yzyhm);
            this.groupBox1.Controls.Add(this.lab_m_yzlx);
            this.groupBox1.Controls.Add(this.lab_m_yzsfz);
            this.groupBox1.Controls.Add(this.lab_m_yzxb);
            this.groupBox1.Controls.Add(this.lab_m_yzxm);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "业主信息";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(145, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 15);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lab_yzfy
            // 
            this.lab_yzfy.AutoSize = true;
            this.lab_yzfy.Location = new System.Drawing.Point(135, 60);
            this.lab_yzfy.Name = "lab_yzfy";
            this.lab_yzfy.Size = new System.Drawing.Size(0, 12);
            this.lab_yzfy.TabIndex = 13;
            // 
            // lab_m_yzfy
            // 
            this.lab_m_yzfy.AutoSize = true;
            this.lab_m_yzfy.Location = new System.Drawing.Point(102, 60);
            this.lab_m_yzfy.Name = "lab_m_yzfy";
            this.lab_m_yzfy.Size = new System.Drawing.Size(41, 12);
            this.lab_m_yzfy.TabIndex = 12;
            this.lab_m_yzfy.Text = "费用：";
            // 
            // lab_yzzz
            // 
            this.lab_yzzz.AutoSize = true;
            this.lab_yzzz.Location = new System.Drawing.Point(70, 180);
            this.lab_yzzz.MaximumSize = new System.Drawing.Size(120, 40);
            this.lab_yzzz.Name = "lab_yzzz";
            this.lab_yzzz.Size = new System.Drawing.Size(0, 12);
            this.lab_yzzz.TabIndex = 11;
            // 
            // lab_yzyhm
            // 
            this.lab_yzyhm.AutoSize = true;
            this.lab_yzyhm.Location = new System.Drawing.Point(72, 150);
            this.lab_yzyhm.MaximumSize = new System.Drawing.Size(120, 30);
            this.lab_yzyhm.Name = "lab_yzyhm";
            this.lab_yzyhm.Size = new System.Drawing.Size(0, 12);
            this.lab_yzyhm.TabIndex = 10;
            // 
            // lab_yzlx
            // 
            this.lab_yzlx.AutoSize = true;
            this.lab_yzlx.Location = new System.Drawing.Point(70, 120);
            this.lab_yzlx.MaximumSize = new System.Drawing.Size(120, 30);
            this.lab_yzlx.Name = "lab_yzlx";
            this.lab_yzlx.Size = new System.Drawing.Size(0, 12);
            this.lab_yzlx.TabIndex = 9;
            // 
            // lab_yzsfz
            // 
            this.lab_yzsfz.AutoSize = true;
            this.lab_yzsfz.Location = new System.Drawing.Point(70, 90);
            this.lab_yzsfz.MaximumSize = new System.Drawing.Size(120, 30);
            this.lab_yzsfz.Name = "lab_yzsfz";
            this.lab_yzsfz.Size = new System.Drawing.Size(0, 12);
            this.lab_yzsfz.TabIndex = 8;
            // 
            // lab_yzxb
            // 
            this.lab_yzxb.AutoSize = true;
            this.lab_yzxb.Location = new System.Drawing.Point(70, 60);
            this.lab_yzxb.MinimumSize = new System.Drawing.Size(120, 30);
            this.lab_yzxb.Name = "lab_yzxb";
            this.lab_yzxb.Size = new System.Drawing.Size(120, 30);
            this.lab_yzxb.TabIndex = 7;
            // 
            // lab_yzxm
            // 
            this.lab_yzxm.AutoSize = true;
            this.lab_yzxm.Location = new System.Drawing.Point(70, 30);
            this.lab_yzxm.MaximumSize = new System.Drawing.Size(77, 30);
            this.lab_yzxm.Name = "lab_yzxm";
            this.lab_yzxm.Size = new System.Drawing.Size(0, 12);
            this.lab_yzxm.TabIndex = 6;
            // 
            // lab_m_yzzz
            // 
            this.lab_m_yzzz.AutoSize = true;
            this.lab_m_yzzz.Location = new System.Drawing.Point(35, 180);
            this.lab_m_yzzz.MaximumSize = new System.Drawing.Size(150, 40);
            this.lab_m_yzzz.Name = "lab_m_yzzz";
            this.lab_m_yzzz.Size = new System.Drawing.Size(41, 12);
            this.lab_m_yzzz.TabIndex = 5;
            this.lab_m_yzzz.Text = "住址：";
            // 
            // lab_m_yzyhm
            // 
            this.lab_m_yzyhm.AutoSize = true;
            this.lab_m_yzyhm.Location = new System.Drawing.Point(23, 150);
            this.lab_m_yzyhm.Name = "lab_m_yzyhm";
            this.lab_m_yzyhm.Size = new System.Drawing.Size(53, 12);
            this.lab_m_yzyhm.TabIndex = 4;
            this.lab_m_yzyhm.Text = "用户名：";
            // 
            // lab_m_yzlx
            // 
            this.lab_m_yzlx.AutoSize = true;
            this.lab_m_yzlx.Location = new System.Drawing.Point(11, 120);
            this.lab_m_yzlx.Name = "lab_m_yzlx";
            this.lab_m_yzlx.Size = new System.Drawing.Size(65, 12);
            this.lab_m_yzlx.TabIndex = 3;
            this.lab_m_yzlx.Text = "联系方式：";
            // 
            // lab_m_yzsfz
            // 
            this.lab_m_yzsfz.AutoSize = true;
            this.lab_m_yzsfz.Location = new System.Drawing.Point(23, 90);
            this.lab_m_yzsfz.Name = "lab_m_yzsfz";
            this.lab_m_yzsfz.Size = new System.Drawing.Size(53, 12);
            this.lab_m_yzsfz.TabIndex = 2;
            this.lab_m_yzsfz.Text = "身份证：";
            // 
            // lab_m_yzxb
            // 
            this.lab_m_yzxb.AutoSize = true;
            this.lab_m_yzxb.Location = new System.Drawing.Point(35, 60);
            this.lab_m_yzxb.Name = "lab_m_yzxb";
            this.lab_m_yzxb.Size = new System.Drawing.Size(41, 12);
            this.lab_m_yzxb.TabIndex = 1;
            this.lab_m_yzxb.Text = "性别：";
            // 
            // lab_m_yzxm
            // 
            this.lab_m_yzxm.AutoSize = true;
            this.lab_m_yzxm.Location = new System.Drawing.Point(35, 30);
            this.lab_m_yzxm.Name = "lab_m_yzxm";
            this.lab_m_yzxm.Size = new System.Drawing.Size(41, 12);
            this.lab_m_yzxm.TabIndex = 0;
            this.lab_m_yzxm.Text = "姓名：";
            // 
            // listview
            // 
            this.listview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.序号,
            this.申请编号,
            this.申请名称,
            this.申请人,
            this.申请时间,
            this.状态,
            this.受理时间,
            this.负责人,
            this.完成时间,
            this.费用});
            this.listview.ContextMenuStrip = this.conmenustr_list;
            this.listview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listview.FullRowSelect = true;
            this.listview.GridLines = true;
            this.listview.Location = new System.Drawing.Point(0, 0);
            this.listview.MultiSelect = false;
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(818, 380);
            this.listview.SmallImageList = this.imageList1;
            this.listview.TabIndex = 0;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.Details;
            // 
            // 序号
            // 
            this.序号.Text = "序号";
            this.序号.Width = 40;
            // 
            // 申请编号
            // 
            this.申请编号.Text = "申请编号";
            // 
            // 申请名称
            // 
            this.申请名称.Text = "申请名称";
            this.申请名称.Width = 80;
            // 
            // 申请人
            // 
            this.申请人.Text = "申请人";
            this.申请人.Width = 80;
            // 
            // 申请时间
            // 
            this.申请时间.Text = "申请时间";
            this.申请时间.Width = 100;
            // 
            // 状态
            // 
            this.状态.Text = "状态";
            this.状态.Width = 70;
            // 
            // 受理时间
            // 
            this.受理时间.Text = "受理时间";
            this.受理时间.Width = 100;
            // 
            // 负责人
            // 
            this.负责人.Text = "负责人";
            this.负责人.Width = 80;
            // 
            // 完成时间
            // 
            this.完成时间.Text = "完成时间";
            this.完成时间.Width = 100;
            // 
            // 费用
            // 
            this.费用.Text = "费用";
            // 
            // conmenustr_list
            // 
            this.conmenustr_list.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加申请ToolStripMenuItem,
            this.修改申请ToolStripMenuItem,
            this.删除申请ToolStripMenuItem,
            this.导出ExcelToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.conmenustr_list.Name = "conmenustr_list";
            this.conmenustr_list.Size = new System.Drawing.Size(153, 136);
            // 
            // 添加申请ToolStripMenuItem
            // 
            this.添加申请ToolStripMenuItem.Name = "添加申请ToolStripMenuItem";
            this.添加申请ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加申请ToolStripMenuItem.Text = "添加申请";
            this.添加申请ToolStripMenuItem.Click += new System.EventHandler(this.添加申请ToolStripMenuItem_Click);
            // 
            // 修改申请ToolStripMenuItem
            // 
            this.修改申请ToolStripMenuItem.Name = "修改申请ToolStripMenuItem";
            this.修改申请ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改申请ToolStripMenuItem.Text = "修改申请";
            this.修改申请ToolStripMenuItem.Click += new System.EventHandler(this.修改申请ToolStripMenuItem_Click);
            // 
            // 删除申请ToolStripMenuItem
            // 
            this.删除申请ToolStripMenuItem.Name = "删除申请ToolStripMenuItem";
            this.删除申请ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除申请ToolStripMenuItem.Text = "删除申请";
            this.删除申请ToolStripMenuItem.Click += new System.EventHandler(this.删除申请ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.ico");
            this.imageList1.Images.SetKeyName(1, "1.ico");
            this.imageList1.Images.SetKeyName(2, "2.png");
            this.imageList1.Images.SetKeyName(3, "3.ico");
            this.imageList1.Images.SetKeyName(4, "4.ico");
            this.imageList1.Images.SetKeyName(5, "5.ico");
            this.imageList1.Images.SetKeyName(6, "6.ico");
            this.imageList1.Images.SetKeyName(7, "7.ico");
            this.imageList1.Images.SetKeyName(8, "8.ico");
            this.imageList1.Images.SetKeyName(9, "9.ico");
            this.imageList1.Images.SetKeyName(10, "10.ico");
            this.imageList1.Images.SetKeyName(11, "11.ico");
            this.imageList1.Images.SetKeyName(12, "12.ico");
            this.imageList1.Images.SetKeyName(13, "13.ico");
            this.imageList1.Images.SetKeyName(14, "14.ico");
            this.imageList1.Images.SetKeyName(15, "15.ico");
            this.imageList1.Images.SetKeyName(16, "16.ico");
            this.imageList1.Images.SetKeyName(17, "17.ico");
            this.imageList1.Images.SetKeyName(18, "18.ico");
            this.imageList1.Images.SetKeyName(19, "19.ico");
            this.imageList1.Images.SetKeyName(20, "20.ico");
            // 
            // picbox_about
            // 
            this.picbox_about.BackColor = System.Drawing.Color.Transparent;
            this.picbox_about.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_about.BackgroundImage")));
            this.picbox_about.Location = new System.Drawing.Point(120, 40);
            this.picbox_about.Name = "picbox_about";
            this.picbox_about.Size = new System.Drawing.Size(75, 75);
            this.picbox_about.TabIndex = 5;
            this.picbox_about.TabStop = false;
            this.picbox_about.Click += new System.EventHandler(this.picbox_about_Click);
            this.picbox_about.MouseLeave += new System.EventHandler(this.picbox_about_MouseLeave);
            this.picbox_about.MouseHover += new System.EventHandler(this.picbox_about_MouseHover);
            // 
            // picbox_sy
            // 
            this.picbox_sy.BackColor = System.Drawing.Color.Transparent;
            this.picbox_sy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_sy.BackgroundImage")));
            this.picbox_sy.Location = new System.Drawing.Point(40, 40);
            this.picbox_sy.Name = "picbox_sy";
            this.picbox_sy.Size = new System.Drawing.Size(75, 75);
            this.picbox_sy.TabIndex = 6;
            this.picbox_sy.TabStop = false;
            this.picbox_sy.Click += new System.EventHandler(this.picbox_sy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.checkbox);
            this.groupBox2.Controls.Add(this.combox);
            this.groupBox2.Controls.Add(this.txt_context);
            this.groupBox2.Controls.Add(this.picbox_search);
            this.groupBox2.Location = new System.Drawing.Point(740, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "搜索";
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Location = new System.Drawing.Point(93, 33);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(96, 16);
            this.checkbox.TabIndex = 14;
            this.checkbox.Text = "在结果中检索";
            this.checkbox.UseVisualStyleBackColor = true;
            // 
            // combox
            // 
            this.combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.combox.FormattingEnabled = true;
            this.combox.Location = new System.Drawing.Point(6, 28);
            this.combox.Name = "combox";
            this.combox.Size = new System.Drawing.Size(80, 22);
            this.combox.TabIndex = 13;
            this.combox.TextChanged += new System.EventHandler(this.combox_TextChanged);
            // 
            // txt_context
            // 
            this.txt_context.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_context.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_context.Location = new System.Drawing.Point(6, 64);
            this.txt_context.MaxLength = 12;
            this.txt_context.Multiline = true;
            this.txt_context.Name = "txt_context";
            this.txt_context.Size = new System.Drawing.Size(150, 30);
            this.txt_context.TabIndex = 11;
            this.txt_context.Enter += new System.EventHandler(this.txt_context_Enter);
            this.txt_context.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_context_KeyPress);
            this.txt_context.Leave += new System.EventHandler(this.txt_context_Leave);
            // 
            // picbox_search
            // 
            this.picbox_search.BackColor = System.Drawing.Color.Transparent;
            this.picbox_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_search.BackgroundImage")));
            this.picbox_search.Location = new System.Drawing.Point(162, 64);
            this.picbox_search.Name = "picbox_search";
            this.picbox_search.Size = new System.Drawing.Size(30, 30);
            this.picbox_search.TabIndex = 12;
            this.picbox_search.TabStop = false;
            this.picbox_search.Click += new System.EventHandler(this.picbox_search_Click);
            this.picbox_search.MouseLeave += new System.EventHandler(this.picbox_search_MouseLeave);
            this.picbox_search.MouseHover += new System.EventHandler(this.picbox_search_MouseHover);
            // 
            // 导出ExcelToolStripMenuItem
            // 
            this.导出ExcelToolStripMenuItem.Name = "导出ExcelToolStripMenuItem";
            this.导出ExcelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.导出ExcelToolStripMenuItem.Text = "导出Excel";
            this.导出ExcelToolStripMenuItem.Click += new System.EventHandler(this.导出ExcelToolStripMenuItem_Click);
            // 
            // Main_Yezhu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.picbox_sy);
            this.Controls.Add(this.picbox_about);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.picbox_close);
            this.Controls.Add(this.picbox_min);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.picbox_logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Yezhu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "业主信息管理";
            this.Load += new System.EventHandler(this.Main_Yezhu_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_close)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.conmenustr_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_about)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_sy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_logo;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.PictureBox picbox_min;
        private System.Windows.Forms.PictureBox picbox_close;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeview;
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_yzfy;
        private System.Windows.Forms.Label lab_m_yzfy;
        private System.Windows.Forms.Label lab_yzzz;
        private System.Windows.Forms.Label lab_yzyhm;
        private System.Windows.Forms.Label lab_yzlx;
        private System.Windows.Forms.Label lab_yzsfz;
        private System.Windows.Forms.Label lab_yzxb;
        private System.Windows.Forms.Label lab_yzxm;
        private System.Windows.Forms.Label lab_m_yzzz;
        private System.Windows.Forms.Label lab_m_yzyhm;
        private System.Windows.Forms.Label lab_m_yzlx;
        private System.Windows.Forms.Label lab_m_yzsfz;
        private System.Windows.Forms.Label lab_m_yzxb;
        private System.Windows.Forms.Label lab_m_yzxm;
        private System.Windows.Forms.PictureBox picbox_about;
        private System.Windows.Forms.PictureBox picbox_sy;
        private System.Windows.Forms.ContextMenuStrip conmenustr_list;
        private System.Windows.Forms.ColumnHeader 序号;
        private System.Windows.Forms.ColumnHeader 申请编号;
        private System.Windows.Forms.ColumnHeader 申请名称;
        private System.Windows.Forms.ColumnHeader 申请人;
        private System.Windows.Forms.ColumnHeader 申请时间;
        private System.Windows.Forms.ColumnHeader 状态;
        private System.Windows.Forms.ColumnHeader 受理时间;
        private System.Windows.Forms.ColumnHeader 负责人;
        private System.Windows.Forms.ColumnHeader 完成时间;
        private System.Windows.Forms.ColumnHeader 费用;
        private System.Windows.Forms.ToolStripMenuItem 添加申请ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改申请ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除申请ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.ComboBox combox;
        private System.Windows.Forms.TextBox txt_context;
        private System.Windows.Forms.PictureBox picbox_search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 导出ExcelToolStripMenuItem;
    }
}