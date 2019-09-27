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
using System.Runtime.InteropServices;

namespace WYMIS
{
    public partial class Main_Yuangong_Form : Form
    {
        SQL_Class SQLClass = new SQL_Class();       //创建一个SQL_Class对象SQLClass，用以调用SQL_Class类中的函数
        TreeNode SelectNode = new TreeNode();       //创建一个TreeNode对象SelectNode，用以存储被选中的树节点
        Zhuangtai_Class Zhuangtai = new Zhuangtai_Class();
        Search_Class search = new Search_Class();
        Export_Class export = new Export_Class();

        public static int tempint;
        public static string tempsql;
        public static bool iswhere;
        public static bool isonce = true;
        public static bool needwhere = true;

        public bool changeuser;

        //管理员信息变量--------------------------
        public int glyid;       //管理员ID
        public string glyxm;        //管理员姓名
        public string glyxb;        //管理员性别
        public string glybm;        //管理员部门
        public string glygw;        //管理员岗位
        public string glylx;        //管理员联系方式
        public string glydz;        //管理员住址
        public string glyyhm;       //管理员用户名
        public int glyqx;       //管理员权限

        public Main_Yuangong_Form()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wparam, int lparam);
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)//按下的是鼠标左键            
            {
                Capture = false;//释放鼠标使能够手动操作                
                SendMessage(Handle, 0x00A1, 2, 0);//拖动窗体            
            }
        }
        

        //以下为重点代码--------------------------------------------------------------------
        public void listview_columns()     //列表的列项添加
        {
            listview_right.Columns.Clear();
            listview_right.Items.Clear();
            //if (treeview_left.SelectedNode == null)      //判断是否选中了树节点
            //{
            //    return;
            //}
            switch(splitcon1.Tag.ToString())
            {
                case "sy":
                    listview_right.Columns.Add("0", "序号", 50);
                    listview_right.Columns.Add("1", "住房编号", 70);
                    listview_right.Columns.Add("2", "楼层", 50);
                    listview_right.Columns.Add("3", "住房配置", 100);
                    listview_right.Columns.Add("4", "业主名称", 100);
                    listview_right.Columns.Add("5","状态",50);
                    listview_right.Columns.Add("6","所属房产",100);
                    listview_right.Columns.Add("7", "费用", 100);
                    break;
                case "yz":
                    listview_right.Columns.Add("0", "序号", 50);
                    listview_right.Columns.Add("1", "业主编号", 70);
                    listview_right.Columns.Add("2", "姓名", 100);
                    listview_right.Columns.Add("3", "性别", 50);
                    listview_right.Columns.Add("4", "联系方式", 100);
                    listview_right.Columns.Add("5", "住址",150);
                    listview_right.Columns.Add("6", "身份证号",100);
                    listview_right.Columns.Add("7", "权限", 50);
                    listview_right.Columns.Add("9", "费用", 50);
                    listview_right.Columns.Add("8", "用户名", 70);
                    break;
                case "yg":
                    listview_right.Columns.Add("0", "序号", 50);
                    listview_right.Columns.Add("1", "员工编号", 70);
                    listview_right.Columns.Add("2", "姓名", 100);
                    listview_right.Columns.Add("3", "性别", 50);
                    listview_right.Columns.Add("4", "岗位",100);
                    listview_right.Columns.Add("5", "联系方式",100);
                    listview_right.Columns.Add("6", "地址", 150);
                    listview_right.Columns.Add("7", "权限", 80);
                    listview_right.Columns.Add("8", "用户名", 50);
                    break;
                case "yw":
                    if(treeview_left.SelectedNode == null)
                    {
                        return;
                    }
                    switch (treeview_left.SelectedNode.Name)
                    {
                        case "1":
                            listview_right.Columns.Add("0", "序号", 50);
                            listview_right.Columns.Add("1", "事务编号", 100);
                            listview_right.Columns.Add("2", "事务名称", 100);
                            listview_right.Columns.Add("3", "任务时间", 80);
                            listview_right.Columns.Add("4", "状态", 50);
                            listview_right.Columns.Add("5", "负责人",70);
                            listview_right.Columns.Add("6", "备注",100);
                            break;
                        case "2":
                            listview_right.Columns.Add("0", "序号", 50);
                            listview_right.Columns.Add("1", "申请编号", 100);
                            listview_right.Columns.Add("2", "申请名称", 100);
                            listview_right.Columns.Add("3", "申请人", 100);
                            listview_right.Columns.Add("4", "申请时间", 80);
                            listview_right.Columns.Add("5", "状态", 50);
                            listview_right.Columns.Add("6", "受理时间", 80);
                            listview_right.Columns.Add("7", "负责人",100);
                            listview_right.Columns.Add("8", "完成时间",80);
                            listview_right.Columns.Add("9", "费用", 50);

                            break;
                        case "3":
                            listview_right.Columns.Add("0", "序号", 50);
                            listview_right.Columns.Add("1", "收费编号", 70);
                            listview_right.Columns.Add("2", "收费事项", 100);
                            listview_right.Columns.Add("3", "金额", 50);
                            listview_right.Columns.Add("4", "类型",70);
                            listview_right.Columns.Add("5", "缴费时间",80);
                            listview_right.Columns.Add("6", "缴费业主", 100);
                            listview_right.Columns.Add("7", "负责人", 100);
                            listview_right.Columns.Add("8", "备注", 100);
                            break;
                    }
                    break;
            }
        }

        private void Main_Yuangong_Form_Load(object sender, EventArgs e)        //加载窗体函数
        {
            lab_title.Text = this.Text + " - " + lab_title.Text;
            lab_glyxm.Text += glyxm;
            lab_glyxb.Text += glyxb;
            lab_glygw.Text = glybm + " " + glygw;
            lab_glylx.Text += glylx;
            lab_glydz.Text += glydz;
            lab_glyyhm.Text += glyyhm;
            //设置加载窗体时首页图片的选中
            //picbox_shouye.Image = Image.FromFile("images/sy_select.png");
            //picbox_shouye.Tag = "1";
            //UpdateTreeview();
            //this.listview_right.ContextMenuStrip = conMenuStr_list_1;
            picbox_shouye_Click(sender, e);
        }

        //更新树节点------------------------------------------
        private void UpdateTreeview()       //加载treeview根节点下面的子节点
        {
            isonce = true;
            treeview_left.Nodes.Clear();
            listview_columns();
            switch(splitcon1.Tag.ToString())
            {
                case "sy":
                    DataSet TreeSet = SQLClass.getDataSet("select id,gongsi from kaifashang", "房产开发商");
                    DataTable treedt = TreeSet.Tables["房产开发商"];      //创建一个DataTable对象
                    if (treedt.Rows.Count > 0)
                    {
                        for (int i = 0; i < treedt.Rows.Count; i++)
                        {
                            //创建一个TreeNode对象，并对node的属性进行赋值
                            TreeNode node = new TreeNode(treedt.Rows[i][1].ToString(), 1, 2);
                            node.Name = treedt.Rows[i][0].ToString();
                            treeview_left.Nodes.Add(node);     //把node添加到根节点上
                            DataSet sonTreeSet = SQLClass.getDataSet("Select id,jianzu from fangchan where kaifashangid = '" + treedt.Rows[i][0] + "'", "楼盘信息表");
                            DataTable sontreedt = sonTreeSet.Tables["楼盘信息表"];
                            if (sontreedt.Rows.Count > 0)
                            {
                                for (int j = 0; j < sontreedt.Rows.Count; j++)
                                {
                                    TreeNode sonnode = new TreeNode(sontreedt.Rows[j][1].ToString(), 1, 2);
                                    sonnode.Name = sontreedt.Rows[j][0].ToString();
                                    treeview_left.Nodes[i].Nodes.Add(sonnode);
                                }
                            }
                        }
                    }
                    break;
                case "yz":
                    for (int i = 0; i < 2; i++)
                    {
                        string sort = Zhuangtai.YezhuQuanxian(i.ToString());
                        TreeNode node = new TreeNode(sort, 1, 2);
                        node.Name = i.ToString();
                        treeview_left.Nodes.Add(node);
                    }
                    break;
                case "yg":      //当面板为员工时
                    DataSet ygDSet = SQLClass.getDataSet("select bumen from gangwei group by bumen","部门信息表");
                    DataTable ygdt = ygDSet.Tables["部门信息表"];
                    if (ygdt.Rows.Count > 0)
                    {
                        for (int i = 0; i < ygdt.Rows.Count; i++)
                        {
                            TreeNode ygnode = new TreeNode(ygdt.Rows[i][0].ToString(), 1, 2);
                            ygnode.Name = i.ToString();
                            treeview_left.Nodes.Add(ygnode);     //把node添加到根节点上
                            DataSet gwDSet = SQLClass.getDataSet("select id,gangwei from gangwei where bumen = '" + ygdt.Rows[i][0].ToString() + "'", "岗位信息表");
                            DataTable gwdt = gwDSet.Tables["岗位信息表"];
                            if(gwdt.Rows.Count > 0)
                            {
                                for (int j = 0; j < gwdt.Rows.Count; j++)
                                {
                                    TreeNode gwnode = new TreeNode(gwdt.Rows[j][1].ToString(), 1, 2);
                                    gwnode.Name = gwdt.Rows[j][0].ToString();
                                    treeview_left.Nodes[i].Nodes.Add(gwnode);     //把node添加到根节点上
                                }
                            }
                        }
                    }
                    break;
                case "yw":
                    for (int i = 0; i < 3; i++)
                    {
                        string sort = Zhuangtai.Yewu((i + 1).ToString());
                        TreeNode node = new TreeNode(sort, 1, 2);
                        node.Name = (i + 1).ToString();
                        treeview_left.Nodes.Add(node);
                    }
                    break;
            }
        }

        //更新列表--------------------------
        private void UpdateListview(string sql)     //加载listview中的数据，其中sql参数表示传递的SQL的语句
        {
           DataSet DSet = SQLClass.getDataSet(sql, "数据库信息表");
           DataTable dt = DSet.Tables["数据库信息表"];        //创建一个DataTable对象
           switch (splitcon1.Tag.ToString())
            {
                case "sy":
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            tempint++;
                            string zhuangtai = Zhuangtai.Zhufang(dt.Rows[i][4].ToString());
                            string yezhu;
                            if (dt.Rows[i][3].ToString() != "")
                            {
                                yezhu = Zhuangtai.YezhuName(dt.Rows[i][3].ToString(), true);
                            }
                            else
                            {
                                yezhu = "";
                            }
                            string fcname = Zhuangtai.FangchanName(dt.Rows[i][5].ToString(), true);
                            //定义一个string数组item，按listview中列的顺序存放数据
                            string[] item = { tempint.ToString(), dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), yezhu, zhuangtai, fcname, dt.Rows[i][6].ToString() + "元" };
                            //创建一个ListView对象newitem，并对newitem的属性进行赋值
                            ListViewItem newitem = new ListViewItem(item);
                            newitem.ImageIndex = 9;     //设置数据行的图标
                            listview_right.Items.Add(newitem);      //把newitem添加到listview中
                        }
                    }
                    break;
               case "yz":
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            tempint++;
                            string yzquanxian = Zhuangtai.YezhuQuanxian(dt.Rows[i][6].ToString());
                            //定义一个string数组item，按listview中列的顺序存放数据
                            string[] item = { tempint.ToString(), dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), yzquanxian, dt.Rows[i][9].ToString() + "元", dt.Rows[i][7].ToString() };
                            //创建一个ListView对象newitem，并对newitem的属性进行赋值
                            ListViewItem newitem = new ListViewItem(item);
                            newitem.ImageIndex = 9;     //设置数据行的图标
                            listview_right.Items.Add(newitem);      //把newitem添加到listview中
                        }
                    }
                    break;
               case "yg":
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            tempint++;
                            string ygquanxian = Zhuangtai.YuangongQuanxian(dt.Rows[i][6].ToString());
                            string yggw = Zhuangtai.GangweiName(dt.Rows[i][3].ToString(), true);
                            //定义一个string数组item，按listview中列的顺序存放数据
                            string[] item = { tempint.ToString(), dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), yggw, dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), ygquanxian, dt.Rows[i][7].ToString() };
                            //创建一个ListView对象newitem，并对newitem的属性进行赋值
                            ListViewItem newitem = new ListViewItem(item);
                            newitem.ImageIndex = 9;     //设置数据行的图标
                            listview_right.Items.Add(newitem);      //把newitem添加到listview中
                        }
                    }
                    break;
               case "yw":
                    if (dt.Rows.Count > 0)
                    {
                        switch (treeview_left.SelectedNode.Name)
                        {
                            case "1":
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    tempint++;
                                    string rczhuangtai = Zhuangtai.Richang(dt.Rows[i][3].ToString());
                                    string ygxm = Zhuangtai.YuangongName(dt.Rows[i][4].ToString(), true);
                                    string[] item = { tempint.ToString(), dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), rczhuangtai, ygxm, dt.Rows[i][5].ToString() };
                                    ListViewItem newitem = new ListViewItem(item);
                                    newitem.ImageIndex = 9;       //设置数据行的图标
                                    listview_right.Items.Add(newitem);
                                }
                                break;
                            case "2":
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    tempint++;
                                    string ywzhuangtai = Zhuangtai.Fuwu(dt.Rows[i][4].ToString());
                                    string yzxm = Zhuangtai.YezhuName(dt.Rows[i][2].ToString(),true);
                                    string ygxm = Zhuangtai.YuangongName(dt.Rows[i][6].ToString(),true);
                                    string[] item = { tempint.ToString(), dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), yzxm, dt.Rows[i][3].ToString(), ywzhuangtai, dt.Rows[i][5].ToString(), ygxm, dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString() + "元" };
                                    ListViewItem newitem = new ListViewItem(item);
                                    newitem.ImageIndex = 9;       //设置数据行的图标
                                    listview_right.Items.Add(newitem);
                                }
                                break;
                            case "3":
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    tempint++;
                                    string leixing = Zhuangtai.Shoufei_leixing(dt.Rows[i][3].ToString());
                                    string yz = Zhuangtai.YezhuName(dt.Rows[i][5].ToString(), true);
                                    string yg = Zhuangtai.YuangongName(dt.Rows[i][6].ToString(),true);
                                    string[] item = { tempint.ToString(), dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString() + "元", leixing, dt.Rows[i][4].ToString(), yz, yg, dt.Rows[i][7].ToString() };
                                    ListViewItem newitem = new ListViewItem(item);
                                    newitem.ImageIndex = 9;       //设置数据行的图标
                                    listview_right.Items.Add(newitem);
                                }
                                break;
                        }
                    }
                    break;
            }
        }

        //选中------------------TreeView
        private void treeview_left_AfterSelect(object sender, EventArgs e)      //点击treeview所触发的函数
        {
            isonce = true;
            listview_columns();
            if (treeview_left.SelectedNode == null)      //判断是否选中了树节点
            {
                switch (splitcon1.Tag.ToString())
                {
                    case "sy":
                        tempint = 0;
                        tempsql = "select * from zhufang";
                        iswhere = false;
                        UpdateListview(tempsql);
                        break;
                    case "yz":
                        tempint = 0;
                        tempsql = "select * from yezhu";
                        iswhere = false;
                        UpdateListview(tempsql);
                        break;
                    case "yg":
                        tempint = 0;
                        tempsql = "select * from yuangong";
                        iswhere = false;
                        UpdateListview(tempsql);
                        break;
                    case "yw":
                        break;
                }
                //return;
            }
            else
            {
                SelectNode = treeview_left.SelectedNode;        //把当前选中的节点赋值给SelectNode
                treeview_left.MouseDown += new MouseEventHandler(treeview_left_MouseDown);
                switch (splitcon1.Tag.ToString())
                {
                    case "sy":
                        //当鼠标位于控件treeView上并按下鼠标键时，加载treeview_MouseDown的函数
                        DataSet DSet = SQLClass.getDataSet("select id from kaifashang where id = '" + treeview_left.SelectedNode.Name + "' and gongsi = '" + treeview_left.SelectedNode.Text + "'", "开发商信息表");
                        DataTable dt = DSet.Tables["开发商信息表"];
                        if (dt.Rows.Count > 0)
                        {
                            //treeview_left.Nodes[treeview_left.SelectedNode.Name].Nodes.Clear();
                            DataSet parentDSet = SQLClass.getDataSet("select id from fangchan where kaifashangid = '" + treeview_left.SelectedNode.Name + "'", "楼盘信息表");
                            DataTable parentdt = parentDSet.Tables["楼盘信息表"];
                            if (parentdt.Rows.Count > 0)
                            {
                                tempint = 0;
                                for (int i = 0; i < parentdt.Rows.Count; i++)
                                {
                                    if (tempint == 0)
                                    {
                                        tempsql = "select * from zhufang where fangchanid = '" + parentdt.Rows[i][0].ToString() + "'";
                                    }
                                    else
                                    {
                                        tempsql = tempsql + " or fangchanid = '" + parentdt.Rows[i][0].ToString() + "'";
                                    }
                                    iswhere = true;
                                    UpdateListview("select * from zhufang where fangchanid = '" + parentdt.Rows[i][0].ToString() + "'");
                                }
                            }
                        }
                        else
                        {
                            DataSet newDSet = SQLClass.getDataSet("select id from fangchan where jianzu = '" + treeview_left.SelectedNode.Text + "'", "房产信息表");
                            DataTable newdt = newDSet.Tables["房产信息表"];
                            if (newdt.Rows.Count > 0)
                            {
                                tempint = 0;
                                for (int i = 0; i < newdt.Rows.Count; i++)
                                {
                                    if (tempint == 0)
                                    {
                                        tempsql = "select * from zhufang where fangchanid = '" + newdt.Rows[i][0].ToString() + "'";
                                    }
                                    else
                                    {
                                        tempsql = tempsql + " or fangchanid = '" + newdt.Rows[i][0].ToString() + "'";
                                    }
                                    iswhere = true;
                                    UpdateListview("select * from zhufang where fangchanid = '" + newdt.Rows[i][0].ToString() + "'");
                                }
                            }
                        }
                        break;
                    case "yz":
                        tempint = 0;
                        tempsql = "select * from yezhu where quanxian = '" + treeview_left.SelectedNode.Name + "'";
                        iswhere = true;
                        UpdateListview(tempsql);
                        break;
                    case "yg":
                        listview_right.Items.Clear();
                        DataSet gwDSet = SQLClass.getDataSet("select id from gangwei where gangwei = '" + treeview_left.SelectedNode.Text + "'", "岗位信息表");
                        DataTable gwdt = gwDSet.Tables["岗位信息表"];
                        if (gwdt.Rows.Count > 0)
                        {
                            tempint = 0;
                            tempsql = "select * from yuangong where gangweiid = '" + treeview_left.SelectedNode.Name + "'";
                            iswhere = true;
                            UpdateListview(tempsql);
                        }
                        else
                        {
                            DataSet ygDSet = SQLClass.getDataSet("select id from gangwei where bumen = '" + treeview_left.SelectedNode.Text + "'", "部门信息表");
                            DataTable ygdt = ygDSet.Tables["部门信息表"];
                            if (ygdt.Rows.Count > 0)
                            {
                                tempint = 0;
                                for (int i = 0; i < ygdt.Rows.Count; i++)
                                {
                                    tempsql = "select * from yuangong where gangweiid = '" + ygdt.Rows[i][0] + "'";
                                    iswhere = true;
                                    UpdateListview(tempsql);
                                }
                            }
                        }
                        break;
                    case "yw":
                        switch (treeview_left.SelectedNode.Name)
                        {
                            case "1":
                                UpdateComboBox();
                                tempint = 0;
                                tempsql = "select * from richang";
                                iswhere = false;
                                UpdateListview(tempsql);
                                break;
                            case "2":
                                UpdateComboBox();
                                tempint = 0;
                                tempsql = "select * from fuwu";
                                iswhere = false;
                                UpdateListview(tempsql);
                                break;
                            case "3":
                                UpdateComboBox();
                                tempint = 0;
                                tempsql = "select * from shoufei";
                                iswhere = false;
                                UpdateListview(tempsql);
                                break;
                        }
                        break;
                }
            }
        }

        //private void toolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("数据库连接失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //鼠标按钮动作-----------------------------
        private void treeview_left_MouseDown(object sender, MouseEventArgs e)
        {
            this.treeview_left.ContextMenuStrip = conMenuStr_tree_1;
            conMenuStr_tree_1.Items.Clear();
            //创建一个矩形Rect，对初始化Rect的位置和大小
            switch(splitcon1.Tag.ToString())
            {
                case "sy":
                    ToolStripMenuItem addkaifashang = new ToolStripMenuItem("添加开发商");
                    addkaifashang.Click += new EventHandler(添加开发商toolStripMenuItem_Click);
                    conMenuStr_tree_1.Items.Add(addkaifashang);
                    break;
                case "yg":
                    ToolStripMenuItem addgangwei = new ToolStripMenuItem("添加岗位");
                    addgangwei.Click += new EventHandler(添加岗位toolStripMenuItem_Click);
                    conMenuStr_tree_1.Items.Add(addgangwei);
                    ToolStripMenuItem revisebumen = new ToolStripMenuItem("修改部门");
                    ToolStripMenuItem deletebumen = new ToolStripMenuItem("删除部门");
                    revisebumen.Click += new EventHandler(修改部门toolStripMenuItem_Click);
                    deletebumen.Click += new EventHandler(删除部门toolStripMenuItem_Click);
                    conMenuStr_tree_1.Items.Add(revisebumen);
                    conMenuStr_tree_1.Items.Add(deletebumen);
                    break;
            }
            Rectangle Rect = new Rectangle(SelectNode.Bounds.X, SelectNode.Bounds.Y, SelectNode.Bounds.Width, SelectNode.Bounds.Height);
            if (Rect.Contains(e.X, e.Y))     //如果鼠标停留在矩形内
            {
                //把treeview的右键菜单设置为contextMenuStrip
                switch (splitcon1.Tag.ToString())
                {
                    case "sy":
                        //ToolStripMenuItem addkaifashang = new ToolStripMenuItem("添加开发商");
                        //addkaifashang.Click += new EventHandler(添加开发商toolStripMenuItem_Click);
                        //conMenuStr_tree_1.Items.Add(addkaifashang);
                        DataSet DSet = SQLClass.getDataSet("select id from kaifashang where id = '" + treeview_left.SelectedNode.Name + "' and gongsi = '" + treeview_left.SelectedNode.Text + "'", "开发商信息表");
                        DataTable dt = DSet.Tables["开发商信息表"];
                        if (dt.Rows.Count > 0)
                        {
                            ToolStripMenuItem revisekaifashang = new ToolStripMenuItem("修改开发商");
                            ToolStripMenuItem lookkaifashang = new ToolStripMenuItem("查看开发商");
                            ToolStripMenuItem deletekaifashang = new ToolStripMenuItem("删除开发商");
                            revisekaifashang.Click += new EventHandler(修改开发商toolStripMenuItem_Click);
                            lookkaifashang.Click += new EventHandler(查看开发商toolStripMenuItem_Click);
                            deletekaifashang.Click += new EventHandler(删除开发商toolStripMenuItem_Click);
                            conMenuStr_tree_1.Items.Add(revisekaifashang);
                            conMenuStr_tree_1.Items.Add(lookkaifashang);
                            conMenuStr_tree_1.Items.Add(deletekaifashang);
                            ToolStripMenuItem addloupan = new ToolStripMenuItem("添加楼盘");
                            addloupan.Click += new EventHandler(添加楼盘toolStripMenuItem_Click);
                            conMenuStr_tree_1.Items.Add(addloupan);
                        }
                        else
                        {
                            ToolStripMenuItem addloupan = new ToolStripMenuItem("添加楼盘");
                            ToolStripMenuItem reviseloupan = new ToolStripMenuItem("修改楼盘");
                            ToolStripMenuItem lookloupan = new ToolStripMenuItem("查看楼盘");
                            ToolStripMenuItem deleteloupan = new ToolStripMenuItem("删除楼盘");
                            addloupan.Click += new EventHandler(添加楼盘toolStripMenuItem_Click);
                            reviseloupan.Click += new EventHandler(修改楼盘toolStripMenuItem_Click);
                            lookloupan.Click += new EventHandler(查看楼盘toolStripMenuItem_Click);
                            deleteloupan.Click += new EventHandler(删除楼盘toolStripMenuItem_Click);
                            conMenuStr_tree_1.Items.Add(addloupan);
                            conMenuStr_tree_1.Items.Add(reviseloupan);
                            conMenuStr_tree_1.Items.Add(lookloupan);
                            conMenuStr_tree_1.Items.Add(deleteloupan);
                        }
                        break;
                    case "yz":
                        //this.treeview_left.ContextMenuStrip = conMenuStr_yz_1;
                        break;
                    case "yg":
                        //this.treeview_left.ContextMenuStrip = conMenuStr_yg_1;
                        DataSet bmDSet = SQLClass.getDataSet("select bumen from gangwei where bumen = '" + treeview_left.SelectedNode.Text + "'", "部门信息表");
                        DataTable bmdt = bmDSet.Tables["部门信息表"];
                        if (bmdt.Rows.Count > 0)
                        {
                        }
                        else
                        {
                            ToolStripMenuItem revisegangwei = new ToolStripMenuItem("修改岗位");
                            ToolStripMenuItem deletegangwei = new ToolStripMenuItem("删除岗位");
                            ToolStripMenuItem revisebumen = new ToolStripMenuItem("修改部门");
                            ToolStripMenuItem deletebumen = new ToolStripMenuItem("删除部门");
                            revisegangwei.Click += new EventHandler(修改岗位toolStripMenuItem_Click);
                            deletegangwei.Click += new EventHandler(删除岗位toolStripMenuItem_Click);
                            revisebumen.Click += new EventHandler(修改部门toolStripMenuItem_Click);
                            deletebumen.Click += new EventHandler(删除部门toolStripMenuItem_Click);
                            conMenuStr_tree_1.Items.Add(revisegangwei);
                            conMenuStr_tree_1.Items.Add(deletegangwei);
                            conMenuStr_tree_1.Items.Add(revisebumen);
                            conMenuStr_tree_1.Items.Add(deletebumen);
                        }
                        break;
                    case "yw":
                        //this.treeview_left.ContextMenuStrip = conMenuStr_yw_1;
                        break;
                }
            }
            //else
            //{
            //    this.treeview_left.ContextMenuStrip = null;     //treeview的右键菜单为空
            //}
            ToolStripMenuItem refresh = new ToolStripMenuItem("刷新");
            refresh.Click += new EventHandler(刷新树toolStripMenuItem_Click);
            conMenuStr_tree_1.Items.Add(refresh);
        }

        //treeview节点右键菜单动作
        private void 添加开发商toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kfs_Form kfs = new Kfs_Form();
            kfs.Form_Type = 0;
            kfs.Text = "添加开发商";
            kfs.ShowDialog();
            if (kfs.Form_OK == 1)
            {
                UpdateTreeview();       //更新树节点
                MessageBox.Show("添加开发商成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 修改开发商toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kfs_Form kfs = new Kfs_Form();
            kfs.kfsid = treeview_left.SelectedNode.Name;
            kfs.Form_Type = 1;
            kfs.Text = "修改开发商";
            kfs.ShowDialog();
            if (kfs.Form_OK == 1)
            {
                UpdateTreeview();       //更新树节点
                MessageBox.Show("修改添加开发商成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 查看开发商toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kfs_Form kfs = new Kfs_Form();
            kfs.kfsid = treeview_left.SelectedNode.Name;
            kfs.Form_Type = 2;
            kfs.Text = "查看开发商";
            kfs.ShowDialog();
        }
        private void 删除开发商toolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = SQLClass.getcom("select id from fangchan where kaifashangid = '" + treeview_left.SelectedNode.Name + "'");
            bool ifcom = dr.Read();
            if (ifcom)
            {
                MessageBox.Show("该开发商下有房产，无法删除！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (DialogResult.OK == MessageBox.Show("确定删除（" + treeview_left.SelectedNode.Text + "）的所有信息吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    //确认删除数据
                    SQLClass.getsqlcom("delete from kaifashang where id = '" + treeview_left.SelectedNode.Name + "' and gongsi = '" + treeview_left.SelectedNode.Text + "'");
                    UpdateTreeview();
                    SQLClass.con_close();       //关闭数据库连接，释放资源
                    MessageBox.Show("删除开发商成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void 添加楼盘toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fangchan_Form fc = new Fangchan_Form();
            fc.Form_Type = 0;
            fc.kfsname = treeview_left.SelectedNode.Text;
            fc.Text = "添加楼盘";
            fc.ShowDialog();
            if (fc.Form_OK == 1)
            {
                UpdateTreeview();       //更新树节点
                MessageBox.Show("添加楼房成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 修改楼盘toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fangchan_Form fc = new Fangchan_Form();
            fc.fcid = treeview_left.SelectedNode.Name;
            fc.Form_Type = 1;
            fc.Text = "修改楼盘";
            fc.ShowDialog();
            if (fc.Form_OK == 1)
            {
                UpdateTreeview();       //更新树节点
                MessageBox.Show("修改楼房成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 查看楼盘toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fangchan_Form fc = new Fangchan_Form();
            fc.fcid = treeview_left.SelectedNode.Name;
            fc.Form_Type = 2;
            fc.Text = "查看楼盘";
            fc.ShowDialog();
        }
        private void 删除楼盘toolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = SQLClass.getcom("select id from zhufang where fangchanid = '" + treeview_left.SelectedNode.Name + "'");
            bool ifcom = dr.Read();
            if (ifcom)
            {
                MessageBox.Show("该栋建筑还存在住房，请先清空住房后再试！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (DialogResult.OK == MessageBox.Show("确定删除（" + treeview_left.SelectedNode.Text + "）的所有信息吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    //确认删除数据
                    SQLClass.getsqlcom("delete from fangchan where id = '" + treeview_left.SelectedNode.Name + "' and jianzu = '" + treeview_left.SelectedNode.Text + "'");
                    UpdateTreeview();
                    SQLClass.con_close();       //关闭数据库连接，释放资源
                    MessageBox.Show("删除楼房成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void 添加岗位toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gangwei_Form gw = new Gangwei_Form();
            gw.Form_Type = 0;
            gw.Text = "添加岗位";
            gw.ShowDialog();
            if (gw.Form_OK == 1)
            {
                UpdateTreeview();       //更新树节点
                MessageBox.Show("添加岗位成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 修改岗位toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gangwei_Form gw = new Gangwei_Form();
            gw.gwid = treeview_left.SelectedNode.Name;
            gw.bmname = treeview_left.SelectedNode.Parent.Text;
            gw.Form_Type = 1;
            gw.Text = "添加岗位";
            gw.ShowDialog();
            if (gw.Form_OK == 1)
            {
                UpdateTreeview();       //更新树节点
                MessageBox.Show("修改岗位成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 修改部门toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bumen_Form bm = new Bumen_Form();
            bm.bmname = treeview_left.SelectedNode.Text;
            //bm.Form_Type = 1;
            bm.Text = "修改部门";
            bm.ShowDialog();
            if (bm.Form_OK == 1)
            {
                UpdateTreeview();       //更新树节点
                MessageBox.Show("修改部门成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 删除部门toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("确定删除（" + treeview_left.SelectedNode.Text + "）的所有信息吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                DataSet gwDSet = SQLClass.getDataSet("select id from gangwei where bumen = '" + treeview_left.SelectedNode.Text + "'", "岗位信息表");
                DataTable gwdt = gwDSet.Tables["岗位信息表"];
                if(gwdt.Rows.Count > 0)
                {
                    for (int i = 0; i < gwdt.Rows.Count; i++)
                    {
                        DataSet DSet = SQLClass.getDataSet("select id from yuangong where gangweiid = '" + gwdt.Rows[i][0].ToString() + "'", "员工信息表");
                        DataTable dt = DSet.Tables["员工信息表"];
                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("该节点中有员工，不能删除（" + treeview_left.SelectedNode.Text + ")的所有信息。", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {

                        }
                    }
                }
                else
                {

                }
                //确认删除数据
                SQLClass.getsqlcom("delete from gangwei where bumen = '" + treeview_left.SelectedNode.Text + "'");
                UpdateTreeview();
                SQLClass.con_close();       //关闭数据库连接，释放资源
                MessageBox.Show("删除岗位成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 删除岗位toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("确定删除（" + treeview_left.SelectedNode.Text + "）的所有信息吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                DataSet DSet = SQLClass.getDataSet("select id from yuangong where gangweiid = '" + treeview_left.SelectedNode.Name + "'", "员工信息表");
                DataTable dt = DSet.Tables["员工信息表"];
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("该节点中有员工，不能删除（" + treeview_left.SelectedNode.Text + ")的所有信息。", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    //确认删除数据
                    SQLClass.getsqlcom("delete from gangwei where id = '" + treeview_left.SelectedNode.Name + "' and gangwei = '" + treeview_left.SelectedNode.Text + "'");
                    UpdateTreeview();
                    SQLClass.con_close();       //关闭数据库连接，释放资源
                    MessageBox.Show("删除岗位成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void 刷新树toolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTreeview();
            treeview_left_AfterSelect(sender, e);
        }
        private void 刷新列toolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeview_left_AfterSelect(sender, e);
        }

        private void listview_right_MouseDown(object sender, MouseEventArgs e)
        {
            this.listview_right.ContextMenuStrip = conMenuStr_list_1;
            conMenuStr_list_1.Items.Clear();
            switch (splitcon1.Tag.ToString())
            {
                case "sy":
                    ToolStripMenuItem addzhufang = new ToolStripMenuItem("添加住房");
                    addzhufang.Click += new EventHandler(添加住房toolStripMenuItem_Click);
                    conMenuStr_list_1.Items.Add(addzhufang);
                    break;
                case "yz":
                    ToolStripMenuItem addyezhu = new ToolStripMenuItem("添加业主");
                    addyezhu.Click += new EventHandler(添加业主toolStripMenuItem_Click);
                    conMenuStr_list_1.Items.Add(addyezhu);
                    break;
                case "yg":
                    ToolStripMenuItem addyuangong = new ToolStripMenuItem("添加员工");
                    addyuangong.Click += new EventHandler(添加员工toolStripMenuItem_Click);
                    conMenuStr_list_1.Items.Add(addyuangong);
                    break;
                case "yw":
                    if (treeview_left.SelectedNode == null)      //判断是否选中了树节点
                    {
                        return;
                    }
                    switch (treeview_left.SelectedNode.Name)
                    {
                        case "1":
                            ToolStripMenuItem addrichang = new ToolStripMenuItem("添加日常");
                            addrichang.Click += new EventHandler(添加日常toolStripMenuItem_Click);
                            conMenuStr_list_1.Items.Add(addrichang);
                            break;
                        case "2":
                            ToolStripMenuItem addshenqing = new ToolStripMenuItem("添加申请");
                            addshenqing.Click += new EventHandler(添加申请toolStripMenuItem_Click);
                            conMenuStr_list_1.Items.Add(addshenqing);
                            break;
                        case "3":
                            ToolStripMenuItem addshoufei = new ToolStripMenuItem("添加收费");
                            addshoufei.Click += new EventHandler(添加收费toolStripMenuItem_Click);
                            conMenuStr_list_1.Items.Add(addshoufei);
                            break;
                    }
                    break;
            }
            if (listview_right.SelectedItems.Count <= 0 || listview_right.SelectedItems[0].SubItems[1].Text == "")
            {

            }
            else
            {
                switch (splitcon1.Tag.ToString())
                {
                    case "sy":
                        ToolStripMenuItem revisezhufang = new ToolStripMenuItem("修改住房");
                        ToolStripMenuItem deletezhufang = new ToolStripMenuItem("删除住房");
                        ToolStripMenuItem inzhufang = new ToolStripMenuItem("业主入住");
                        ToolStripMenuItem outzhufang = new ToolStripMenuItem("业主迁出");
                        ToolStripMenuItem rezhufang = new ToolStripMenuItem("退款迁出");
                        revisezhufang.Click += new EventHandler(修改住房toolStripMenuItem_Click);
                        deletezhufang.Click += new EventHandler(删除住房toolStripMenuItem_Click);
                        inzhufang.Click += new EventHandler(业主入住toolStripMenuItem_Click);
                        outzhufang.Click += new EventHandler(业主迁出toolStripMenuItem_Click);
                        rezhufang.Click += new EventHandler(退款迁出toolStripMenuItem_Click);
                        conMenuStr_list_1.Items.Add(revisezhufang);
                        conMenuStr_list_1.Items.Add(deletezhufang);
                        conMenuStr_list_1.Items.Add(inzhufang);
                        conMenuStr_list_1.Items.Add(outzhufang);
                        conMenuStr_list_1.Items.Add(rezhufang);
                        break;
                    case "yz":
                        ToolStripMenuItem reviseyezhu = new ToolStripMenuItem("修改业主");
                        ToolStripMenuItem deleteyezhu = new ToolStripMenuItem("删除业主");
                        ToolStripMenuItem passyezhu = new ToolStripMenuItem("审核通过");
                        ToolStripMenuItem cancelyezhu = new ToolStripMenuItem("取消审核");
                        reviseyezhu.Click += new EventHandler(修改业主toolStripMenuItem_Click);
                        deleteyezhu.Click += new EventHandler(删除业主toolStripMenuItem_Click);
                        passyezhu.Click += new EventHandler(审核通过toolStripMenuItem_Click);
                        cancelyezhu.Click += new EventHandler(取消审核toolStripMenuItem_Click);
                        conMenuStr_list_1.Items.Add(reviseyezhu);
                        conMenuStr_list_1.Items.Add(deleteyezhu);
                        conMenuStr_list_1.Items.Add(passyezhu);
                        conMenuStr_list_1.Items.Add(cancelyezhu);
                        ToolStripMenuItem addshoufei = new ToolStripMenuItem("添加收费");
                        addshoufei.Click += new EventHandler(添加收费toolStripMenuItem_Click);
                        conMenuStr_list_1.Items.Add(addshoufei);
                        break;
                    case "yg":
                        ToolStripMenuItem reviseyuangong = new ToolStripMenuItem("修改员工");
                        ToolStripMenuItem deleteyuangong = new ToolStripMenuItem("删除员工");
                        reviseyuangong.Click += new EventHandler(修改员工toolStripMenuItem_Click);
                        deleteyuangong.Click += new EventHandler(删除员工toolStripMenuItem_Click);
                        conMenuStr_list_1.Items.Add(reviseyuangong);
                        conMenuStr_list_1.Items.Add(deleteyuangong);
                        if(glyqx == 2)
                        {
                            ToolStripMenuItem sheyuangong = new ToolStripMenuItem("设为管理员");
                            ToolStripMenuItem quyuangong = new ToolStripMenuItem("设为普通员工");
                            sheyuangong.Click += new EventHandler(设为管理员toolStripMenuItem_Click);
                            quyuangong.Click += new EventHandler(设为普通员工toolStripMenuItem_Click);
                            conMenuStr_list_1.Items.Add(sheyuangong);
                            conMenuStr_list_1.Items.Add(quyuangong);
                        }
                        break;
                    case "yw":
                        if (treeview_left.SelectedNode == null)      //判断是否选中了树节点
                        {
                            return;
                        }
                        switch (treeview_left.SelectedNode.Name)
                        {
                            case "1":
                                ToolStripMenuItem reviserichang = new ToolStripMenuItem("修改日常");
                                ToolStripMenuItem deleterichang = new ToolStripMenuItem("删除日常");
                                ToolStripMenuItem overrichang = new ToolStripMenuItem("设为已完成");
                                ToolStripMenuItem cancelrichang = new ToolStripMenuItem("设为未完成");
                                reviserichang.Click += new EventHandler(修改日常toolStripMenuItem_Click);
                                deleterichang.Click += new EventHandler(删除日常toolStripMenuItem_Click);
                                overrichang.Click += new EventHandler(设为已完成toolStripMenuItem_Click);
                                cancelrichang.Click += new EventHandler(设为未完成toolStripMenuItem_Click);
                                conMenuStr_list_1.Items.Add(reviserichang);
                                conMenuStr_list_1.Items.Add(deleterichang);
                                conMenuStr_list_1.Items.Add(overrichang);
                                conMenuStr_list_1.Items.Add(cancelrichang);
                                break;
                            case "2":
                                ToolStripMenuItem reviseshenqing = new ToolStripMenuItem("修改申请");
                                ToolStripMenuItem deleteshenqing = new ToolStripMenuItem("删除申请");
                                ToolStripMenuItem acceptshenqing = new ToolStripMenuItem("受理申请");
                                ToolStripMenuItem cancelacceptshenqing = new ToolStripMenuItem("取消受理");
                                ToolStripMenuItem overshenqing = new ToolStripMenuItem("完成申请");
                                ToolStripMenuItem cancelovershenqing = new ToolStripMenuItem("取消完成");
                                reviseshenqing.Click += new EventHandler(修改申请toolStripMenuItem_Click);
                                deleteshenqing.Click += new EventHandler(删除申请toolStripMenuItem_Click);
                                acceptshenqing.Click += new EventHandler(受理申请toolStripMenuItem_Click);
                                cancelacceptshenqing.Click += new EventHandler(取消受理toolStripMenuItem_Click);
                                overshenqing.Click += new EventHandler(完成申请toolStripMenuItem_Click);
                                cancelovershenqing.Click += new EventHandler(取消完成toolStripMenuItem_Click);
                                conMenuStr_list_1.Items.Add(reviseshenqing);
                                conMenuStr_list_1.Items.Add(deleteshenqing);
                                conMenuStr_list_1.Items.Add(acceptshenqing);
                                conMenuStr_list_1.Items.Add(cancelacceptshenqing);
                                conMenuStr_list_1.Items.Add(overshenqing);
                                conMenuStr_list_1.Items.Add(cancelovershenqing);
                                break;
                            case "3":
                                ToolStripMenuItem reviseshoufei = new ToolStripMenuItem("修改收费");
                                ToolStripMenuItem deleteshoufei = new ToolStripMenuItem("删除收费常");
                                reviseshoufei.Click += new EventHandler(修改收费toolStripMenuItem_Click);
                                deleteshoufei.Click += new EventHandler(删除收费toolStripMenuItem_Click);
                                conMenuStr_list_1.Items.Add(reviseshoufei);
                                conMenuStr_list_1.Items.Add(deleteshoufei);
                                ToolStripMenuItem yishoufei = new ToolStripMenuItem("设为已缴费");
                                ToolStripMenuItem weishoufei = new ToolStripMenuItem("设为未缴费");
                                yishoufei.Click += new EventHandler(设为已缴费toolStripMenuItem_Click);
                                weishoufei.Click += new EventHandler(设为未缴费toolStripMenuItem_Click);
                                conMenuStr_list_1.Items.Add(yishoufei);
                                conMenuStr_list_1.Items.Add(weishoufei);
                                break;
                        }
                        break;
                }
            }
            ToolStripMenuItem daochuexcel = new ToolStripMenuItem("导出Excel");
            daochuexcel.Click += new EventHandler(导出ExceltoolStripMenuItem_Click);
            conMenuStr_list_1.Items.Add(daochuexcel);
            ToolStripMenuItem refresh = new ToolStripMenuItem("刷新");
            refresh.Click += new EventHandler(刷新列toolStripMenuItem_Click);
            conMenuStr_list_1.Items.Add(refresh);
        }
        
        //listview列表右键菜单
        private void 导出ExceltoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listview_right.Items.Count <= 0)
            {
                MessageBox.Show("列表为空，不能导出！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                export.ExportToExecl(listview_right);
            }
        }
        private void 添加住房toolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataReader DR = SQLClass.getcom("select id from fangchan");
            bool ifcom = DR.Read();
            if(!ifcom)
            {
                MessageBox.Show("你还没有添加房产不能进行该操作！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Zhufang_Form zf = new Zhufang_Form();
            zf.Form_Type = 0;
            if(treeview_left.SelectedNode == null)
            {
                zf.fcname = null;
            }
            else
            {
                zf.fcname = treeview_left.SelectedNode.Text;
            }
            zf.Text = "添加住房";
            zf.ShowDialog();
            if (zf.Form_OK == 1)
            {
                treeview_left_AfterSelect(sender, e);
                //treeview_left_AfterSelect(sender, e);
                MessageBox.Show("添加住房成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 修改住房toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listview_right.SelectedItems[0].SubItems[5].Text == "已入住")
            {
                if (DialogResult.OK == MessageBox.Show("住房处于入住状态，修改可能会出现错误，确定要继续吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {

                }
                else
                {
                    MessageBox.Show("操作已取消！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {

            }
            Zhufang_Form zf = new Zhufang_Form();
            if (treeview_left.SelectedNode == null)
            {
                zf.fcname = null;
            }
            else
            {
                zf.fcname = treeview_left.SelectedNode.Text;
            }
            zf.zfid = listview_right.SelectedItems[0].SubItems[1].Text;
            zf.Form_Type = 1;
            zf.Text = "修改住房";
            zf.ShowDialog();
            if (zf.Form_OK == 1)
            {
                treeview_left_AfterSelect(sender, e);
                MessageBox.Show("修改住房成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 删除住房toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listview_right.SelectedItems[0].SubItems[5].Text == "已入住")
            {
                MessageBox.Show("已有业主入住，无法删除！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (DialogResult.OK == MessageBox.Show("确定删除（" + treeview_left.SelectedNode.Text + "的" + listview_right.SelectedItems[0].SubItems[1].Text + "号住房）的所有信息吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    //确认删除数据
                    SQLClass.getsqlcom("delete from zhufang where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                    treeview_left_AfterSelect(sender, e);
                    SQLClass.con_close();       //关闭数据库连接，释放资源
                    MessageBox.Show("删除住房成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void 业主入住toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zhufang_Form zf = new Zhufang_Form();
            if (treeview_left.SelectedNode == null)
            {
                zf.fcname = null;
            }
            else
            {
                zf.fcname = treeview_left.SelectedNode.Text;
            }
            if(listview_right.SelectedItems[0].SubItems[5].Text == "已入住")
            {
                MessageBox.Show("已有用户入住，未迁出之前不得再入住！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                zf.zfid = listview_right.SelectedItems[0].SubItems[1].Text;
                zf.Form_Type = 3;
                zf.Text = "业主入住";
                zf.ShowDialog();
                if (zf.Form_OK == 1)
                {
                    treeview_left_AfterSelect(sender, e);
                    MessageBox.Show("设置入住成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }
        private void 业主迁出toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview_right.SelectedItems[0].SubItems[5].Text == "已入住")
            {
                if (DialogResult.OK == MessageBox.Show("确定设置（" + treeview_left.SelectedNode.Text + "的" + listview_right.SelectedItems[0].SubItems[1].Text + "号住房)的业主迁出吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    SQLClass.getsqlcom("update zhufang set yezhuid = '',zhuangtai = '0' where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                    treeview_left_AfterSelect(sender, e);
                    MessageBox.Show("设置迁出成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("暂无用户入住，无需迁出！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 退款迁出toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview_right.SelectedItems[0].SubItems[5].Text == "已入住")
            {
                if (DialogResult.OK == MessageBox.Show("确定设置（" + treeview_left.SelectedNode.Text + "的" + listview_right.SelectedItems[0].SubItems[1].Text + "号住房)的业主迁出吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    DataSet zfDSet = SQLClass.getDataSet("select yezhuid,shoufei from zhufang where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'","住房信息表");
                    DataTable zfdt = zfDSet.Tables["住房信息表"];
                    if(zfdt.Rows.Count > 0)
                    {
                        DataSet yzDSet = SQLClass.getDataSet("select feiyong from yezhu where id = '" + zfdt.Rows[0][0].ToString() + "'", "业主信息表");
                        DataTable yzdt = yzDSet.Tables["业主信息表"];
                        if(yzdt.Rows.Count > 0)
                        {
                            int yzfy = Convert.ToInt32(yzdt.Rows[0][0].ToString()) - Convert.ToInt32(zfdt.Rows[0][1].ToString());
                            SQLClass.getsqlcom("update yezhu set feiyong = '" + yzfy + "' where id = '" + zfdt.Rows[0][0].ToString() + "'");
                            SQLClass.getsqlcom("update zhufang set yezhuid = '',zhuangtai = '0' where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                            treeview_left_AfterSelect(sender, e);
                            MessageBox.Show("设置迁出成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("业主好像消失了，找不到了呀！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("不用迁啦，好像真没人住耶！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("暂无用户入住，无需迁出！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 添加业主toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reg_Form yz = new Reg_Form();
            yz.Text = "添加业主";
            yz.Form_Type = 0;
            yz.ShowDialog();
            if (yz.Form_OK == 1)
            {
                treeview_left_AfterSelect(sender, e);
                MessageBox.Show("添加业主成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 修改业主toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reg_Form yz = new Reg_Form();
            yz.yzid = listview_right.SelectedItems[0].SubItems[1].Text;
            yz.Form_Type = 1;
            yz.Text = "修改业主信息";
            yz.ShowDialog();
            if (yz.Form_OK == 1)
            {
                treeview_left_AfterSelect(sender, e);
                MessageBox.Show("修改业主信息成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 删除业主toolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataSet 
            if (DialogResult.OK == MessageBox.Show("确定删除（" + listview_right.SelectedItems[0].SubItems[2].Text + "）的所有信息吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                DataSet DSet = SQLClass.getDataSet("select id from zhufang where yezhuid = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'", "住房信息表");
                DataTable dt = DSet.Tables["住房信息表"];
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("该业主尚入住，请等待业主迁出后再试！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                    //for (int i = 0; i < dt.Rows.Count; i++)
                    //{
                    //    SQLClass.getsqlcom("update zhufang set zhuangtai = '0', yezhuid = '' where id = '" + dt.Rows[i][0].ToString() + "'");
                    //}
                }
                else
                {
                    //SqlDataReader DR = SQLClass.getcom("select id from yezhu where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "' and feiyong = '" + listview_right.SelectedItems[0].SubItems[8].Text + "'");
                    if(listview_right.SelectedItems[0].SubItems[8].Text.ToString().Trim() != "0元")
                    {
                        MessageBox.Show("业主费用尚未结清，不能进行删除！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        SQLClass.getsqlcom("delete from yezhu where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                    }
                    //DataSet yzDSet = SQLClass.getDataSet("select feiyong from zhufang where yezhuid = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'", "业主信息表");
                    //DataTable yzdt = DSet.Tables["业主信息表"];
                    //if(dt.Rows.Count > 0)
                    //{
                    //    if (Convert.ToInt32(dt.Rows[0][0].ToString()) > 0)
                    //    {
                    //        MessageBox.Show("该业主费用状态不为0元，不能进行删除！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        return;
                    //    }
                    //    else
                    //    {
                    //        SQLClass.getsqlcom("delete from yezhu where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("发生未知错误！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    return;
                    //}

                }
                treeview_left_AfterSelect(sender, e);
                SQLClass.con_close();       //关闭数据库连接，释放资源
                MessageBox.Show("删除业主成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //SQLClass.getsqlcom("update yezhu set quanxian = '2' where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                //MessageBox.Show("删除业主成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("删除操作已取消！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 审核通过toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listview_right.SelectedItems[0].SubItems[7].Text == "未审核")
            {
                if (DialogResult.OK == MessageBox.Show("确定审核（" + listview_right.SelectedItems[0].SubItems[2].Text + "）的所有信息吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    SQLClass.getsqlcom("update yezhu set quanxian = '1' where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                    treeview_left_AfterSelect(sender, e);
                    MessageBox.Show("审核通过成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("该用户已审核通过，无需再次审核！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 取消审核toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listview_right.SelectedItems[0].SubItems[7].Text == "已审核")
            {
                if (DialogResult.OK == MessageBox.Show("确定取消（" + listview_right.SelectedItems[0].SubItems[2].Text + ")的审核吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    SQLClass.getsqlcom("update yezhu set quanxian = '0' where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                    treeview_left_AfterSelect(sender, e);
                    MessageBox.Show("取消审核成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("该用户已为未审核状态，无需再次取消！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 添加员工toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yuangong_Form yg = new Yuangong_Form();
            DataSet bmDSet = SQLClass.getDataSet("select bumen from gangwei", "部门信息表");
            DataTable bmdt = bmDSet.Tables["部门信息表"];
            if(treeview_left.SelectedNode == null)
            {
                yg.bmname = bmdt.Rows[0][0].ToString();
            }
            else
            {
                DataSet DSet = SQLClass.getDataSet("select bumen from gangwei where gangwei = '" + treeview_left.SelectedNode.Text + "'", "岗位信息表");
                DataTable dt = DSet.Tables["岗位信息表"];
                if(dt.Rows.Count > 0)
                {
                    yg.bmname = dt.Rows[0][0].ToString();
                    yg.gwname = treeview_left.SelectedNode.Text;
                }
                else
                {
                    yg.bmname = treeview_left.SelectedNode.Text;
                }
            }
            yg.Text = "添加员工";
            yg.Form_Type = 0;
            yg.ShowDialog();
            if (yg.Form_OK == 1)
            {
                treeview_left_AfterSelect(sender, e);
                MessageBox.Show("添加员工成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 修改员工toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yuangong_Form yg = new Yuangong_Form();
            DataSet gwDSet = SQLClass.getDataSet("select gangwei,bumen from gangwei where gangwei = '" + listview_right.SelectedItems[0].SubItems[4].Text + "'", "部门信息表");
            DataTable gwdt = gwDSet.Tables["部门信息表"];
            if (treeview_left.SelectedNode == null)
            {
                yg.gwname = gwdt.Rows[0][0].ToString();
                yg.bmname = gwdt.Rows[0][1].ToString();
            }
            else
            {
                DataSet DSet = SQLClass.getDataSet("select bumen from gangwei where gangwei = '" + treeview_left.SelectedNode.Text + "'", "岗位信息表");
                DataTable dt = DSet.Tables["岗位信息表"];
                if (dt.Rows.Count > 0)
                {
                    yg.bmname = dt.Rows[0][0].ToString();
                    yg.gwname = treeview_left.SelectedNode.Text;
                }
                else
                {
                    yg.bmname = treeview_left.SelectedNode.Text;
                    yg.gwname = listview_right.SelectedItems[0].SubItems[4].Text;
                }
            }
            yg.ygid = listview_right.SelectedItems[0].SubItems[1].Text;
            yg.Text = "修改员工";
            yg.Form_Type = 1;
            yg.ShowDialog();
            if (yg.Form_OK == 1)
            {
                treeview_left_AfterSelect(sender, e);
                MessageBox.Show("修改员工成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 删除员工toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview_right.SelectedItems[0].SubItems[7].Text == "超级管理员")
            {
                MessageBox.Show("超级管理员不能被删除！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (listview_right.SelectedItems[0].SubItems[7].Text == "管理员")
            {
                MessageBox.Show("请设置为普通员工再尝试！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (DialogResult.OK == MessageBox.Show("确定删除（" + listview_right.SelectedItems[0].SubItems[2].Text + "）的所有信息吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    //确认删除数据
                    SQLClass.getsqlcom("delete from yuangong where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                    treeview_left_AfterSelect(sender, e);
                    SQLClass.con_close();       //关闭数据库连接，释放资源
                    MessageBox.Show("删除员工成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void 设为管理员toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (glyqx == 2)
            {
                if (listview_right.SelectedItems[0].SubItems[7].Text == "超级管理员")
                {
                    MessageBox.Show("超级管理员不能被更改！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (listview_right.SelectedItems[0].SubItems[7].Text == "管理员")
                    {
                        MessageBox.Show("该员工已是管理员，无需修改！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (DialogResult.OK == MessageBox.Show("确定设置（[" + listview_right.SelectedItems[0].SubItems[1].Text + "]" + listview_right.SelectedItems[0].SubItems[2].Text + ")为管理员吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                        {
                            SQLClass.getsqlcom("update yuangong set quanxian = '1' where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                            treeview_left_AfterSelect(sender, e);
                            MessageBox.Show("设置操作成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("只有超级管理员才可进行此操作！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 设为普通员工toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (glyqx == 2)
            {
                if (listview_right.SelectedItems[0].SubItems[7].Text == "超级管理员")
                {
                    MessageBox.Show("超级管理员不能被更改！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (listview_right.SelectedItems[0].SubItems[7].Text == "普通员工")
                    {
                        MessageBox.Show("该员工已是普通员工，无需修改！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (DialogResult.OK == MessageBox.Show("确定设置（[" + listview_right.SelectedItems[0].SubItems[1].Text + "]" + listview_right.SelectedItems[0].SubItems[2].Text + ")为普通员工吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                        {
                            SQLClass.getsqlcom("update yuangong set quanxian = '0' where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                            treeview_left_AfterSelect(sender, e);
                            MessageBox.Show("设置操作成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("只有超级管理员才可进行此操作！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void 添加日常toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Richang_Form rc = new Richang_Form();
            rc.Text = "添加日常任务";
            rc.Form_Type = 0;
            rc.ShowDialog();
            if (rc.Form_OK == 1)
            {
                treeview_left_AfterSelect(sender, e);
                MessageBox.Show("添加日常任务成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 修改日常toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Richang_Form rc = new Richang_Form();
            rc.rcid = listview_right.SelectedItems[0].SubItems[1].Text;
            rc.Text = "修改日常任务";
            rc.Form_Type = 1;
            rc.ShowDialog();
            if (rc.Form_OK == 1)
            {
                treeview_left_AfterSelect(sender, e);
                MessageBox.Show("修改日常任务成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 删除日常toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("确定删除（[" + listview_right.SelectedItems[0].SubItems[1].Text + "]" + listview_right.SelectedItems[0].SubItems[2].Text + "）的所有信息吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                //确认删除数据
                SQLClass.getsqlcom("delete from richang where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                treeview_left_AfterSelect(sender, e);
                SQLClass.con_close();       //关闭数据库连接，释放资源
                MessageBox.Show("删除日常任务成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 设为已完成toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview_right.SelectedItems[0].SubItems[4].Text == "未完成")
            {
                if (DialogResult.OK == MessageBox.Show("确定已完成（[" + listview_right.SelectedItems[0].SubItems[1].Text + "]" + listview_right.SelectedItems[0].SubItems[2].Text + ")的日常任务吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    SQLClass.getsqlcom("update richang set zhuangtai = '1' where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                    treeview_left_AfterSelect(sender, e);
                    MessageBox.Show("设置操作成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("该日常已为完成状态，无需修改！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 设为未完成toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview_right.SelectedItems[0].SubItems[4].Text == "未完成")
            {
                MessageBox.Show("该日常处于未完成状态，无需修改！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (DialogResult.OK == MessageBox.Show("确定重设为未完成（[" + listview_right.SelectedItems[0].SubItems[1].Text + "]" + listview_right.SelectedItems[0].SubItems[2].Text + ")的日常任务吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    SQLClass.getsqlcom("update richang set zhuangtai = '0' where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                    treeview_left_AfterSelect(sender, e);
                    MessageBox.Show("设置操作成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void 添加申请toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fuwu_Form fw = new Fuwu_Form();
            fw.Text = "添加服务申请";
            fw.Form_Type = 0;
            fw.ShowDialog();
            if (fw.Form_OK == 1)
            {
                treeview_left_AfterSelect(sender, e);
                MessageBox.Show("添加服务申请成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 修改申请toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview_right.SelectedItems[0].SubItems[5].Text == "未处理")
            {
                Fuwu_Form fw = new Fuwu_Form();
                fw.fwid = listview_right.SelectedItems[0].SubItems[1].Text;
                fw.Text = "修改服务申请";
                fw.Form_Type = 1;
                fw.ShowDialog();
                if (fw.Form_OK == 1)
                {
                    treeview_left_AfterSelect(sender, e);
                    MessageBox.Show("修改服务申请成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("该服务申请处于已受理或已完成状态，不能更改！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 删除申请toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview_right.SelectedItems[0].SubItems[5].Text == "已受理" || listview_right.SelectedItems[0].SubItems[5].Text == "已完成")
            {
                MessageBox.Show("该记录处于受理或完成状态，无法进行删除动作！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (DialogResult.OK == MessageBox.Show("确定删除（[" + listview_right.SelectedItems[0].SubItems[1].Text + "]" + listview_right.SelectedItems[0].SubItems[2].Text + "）的所有信息吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    //SqlDataReader dr = SQLClass.getcom("select id from yezhu where xingming = '" + listview_right.SelectedItems[0].SubItems[3].Text + "'");
                    //bool ifcom = dr.Read();
                    //if (ifcom)
                    //{

                    //}
                    //else
                    //{
                    //    if (DialogResult.OK == MessageBox.Show("确定删除的信息所属业主已不存在，确定继续删除记录吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                    //    {
                    //    }
                    //    else
                    //    {
                    //        return;
                    //    }
                    //}
                    //确认删除数据
                    SQLClass.getsqlcom("delete from fuwu where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                    treeview_left_AfterSelect(sender, e);
                    SQLClass.con_close();       //关闭数据库连接，释放资源
                    MessageBox.Show("删除服务申请成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("操作已取消！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void 受理申请toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview_right.SelectedItems[0].SubItems[5].Text == "未处理")
            {
                if (DialogResult.OK == MessageBox.Show("确定受理（[" + listview_right.SelectedItems[0].SubItems[1].Text + "]" + listview_right.SelectedItems[0].SubItems[2].Text + ")的服务申请吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    Fuwu_Form fw = new Fuwu_Form();
                    fw.fwid = listview_right.SelectedItems[0].SubItems[1].Text;
                    fw.Text = "受理服务申请";
                    fw.Form_Type = 2;
                    fw.ShowDialog();
                    if (fw.Form_OK == 1)
                    {
                        treeview_left_AfterSelect(sender, e);
                        MessageBox.Show("受理服务申请成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("操作已取消！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("该服务申请已被受理或已完成！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 取消受理toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview_right.SelectedItems[0].SubItems[5].Text == "已完成")
            {
                MessageBox.Show("该服务申请已完成，无需再次受理！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(listview_right.SelectedItems[0].SubItems[5].Text == "未处理")
            {
                MessageBox.Show("该服务申请尚未受理，无法取消！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (DialogResult.OK == MessageBox.Show("确定取消受理（[" + listview_right.SelectedItems[0].SubItems[1].Text + "]" + listview_right.SelectedItems[0].SubItems[2].Text + ")的服务申请吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    SQLClass.getsqlcom("update fuwu set yuangongid = '', queren = '', zhuangtai = '0' where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                    treeview_left_AfterSelect(sender, e);
                    MessageBox.Show("取消受理操作成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("操作已取消！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void 完成申请toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview_right.SelectedItems[0].SubItems[5].Text == "已受理")
            {
                if (DialogResult.OK == MessageBox.Show("确定已完成（[" + listview_right.SelectedItems[0].SubItems[1].Text + "]" + listview_right.SelectedItems[0].SubItems[2].Text + ")的服务申请吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    Fuwu_Form fw = new Fuwu_Form();
                    fw.fwid = listview_right.SelectedItems[0].SubItems[1].Text;
                    fw.Text = "完成服务申请";
                    fw.Form_Type = 3;
                    fw.ShowDialog();
                    if (fw.Form_OK == 1)
                    {
                        treeview_left_AfterSelect(sender, e);
                        MessageBox.Show("设置完成服务申请成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("操作已取消！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("该服务申请尚未受理或已完成！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 取消完成toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview_right.SelectedItems[0].SubItems[5].Text == "已完成")
            {
                if (DialogResult.OK == MessageBox.Show("确定取消已完成的（[" + listview_right.SelectedItems[0].SubItems[1].Text + "]" + listview_right.SelectedItems[0].SubItems[2].Text + ")的服务申请吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    int yzfy;
                    DataSet fwDSet = SQLClass.getDataSet("select yezhuid,shoufei from fuwu where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'", "服务信息表");
                    DataTable fwdt = fwDSet.Tables["服务信息表"];
                    DataSet yzDSet = SQLClass.getDataSet("select feiyong from yezhu where id = '" + fwdt.Rows[0][0].ToString() + "'","业主信息表");
                    DataTable yzdt = yzDSet.Tables["业主信息表"];
                    if(yzdt.Rows.Count > 0)
                    {
                        yzfy = Convert.ToInt32(yzdt.Rows[0][0].ToString()) - Convert.ToInt32(fwdt.Rows[0][1].ToString());
                        SQLClass.getsqlcom("update yezhu set feiyong = '" + yzfy + "' where id = '" + fwdt.Rows[0][0].ToString() + "'");
                    }
                    else
                    {
                        if (DialogResult.OK == MessageBox.Show("该记录的所属业主已被删除，确定取消完成该条记录吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                        {

                        }
                        else
                        {
                            return;
                        }
                    }
                    SQLClass.getsqlcom("update fuwu set shoufei = '', wancheng = '', zhuangtai = '1' where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                    treeview_left_AfterSelect(sender, e);
                    MessageBox.Show("已成功取消已完成的服务申请状态！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("操作已取消！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("该服务申请尚未完成，无法进行取消完成操作！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 添加收费toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shoufei_Form sf = new Shoufei_Form();
            if (splitcon1.Tag.ToString() == "yz")
            {
                if (listview_right.SelectedItems.Count <= 0 || listview_right.SelectedItems[0].SubItems[1].Text == "")
                {
                    //MessageBox.Show("添加收费项目成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    sf.yzid = listview_right.SelectedItems[0].SubItems[1].Text;
                }
            }
            sf.Form_Type = 0;
            sf.Text = "添加收费项目";
            sf.ShowDialog();
            if (sf.Form_OK == 1)
            {
                treeview_left_AfterSelect(sender, e);
                MessageBox.Show("添加收费项目成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 修改收费toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview_right.SelectedItems[0].SubItems[4].Text == "未缴费")
            {
                Shoufei_Form sf = new Shoufei_Form();
                sf.sfid = listview_right.SelectedItems[0].SubItems[1].Text;
                sf.Text = "修改收费项目";
                sf.Form_Type = 1;
                sf.ShowDialog();
                if (sf.Form_OK == 1)
                {
                    treeview_left_AfterSelect(sender, e);
                    MessageBox.Show("修改日常任务成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("已设置为已缴费，不能进行修改！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 设为已缴费toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview_right.SelectedItems[0].SubItems[4].Text == "未缴费")
            {
                Shoufei_Form sf = new Shoufei_Form();
                sf.sfid = listview_right.SelectedItems[0].SubItems[1].Text;
                sf.Text = "设为已缴费";
                sf.Form_Type = 3;
                sf.ShowDialog();
                if (sf.Form_OK == 1)
                {
                    treeview_left_AfterSelect(sender, e);
                    MessageBox.Show("设置已缴费操作成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("已为已缴费状态！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void 设为未缴费toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listview_right.SelectedItems[0].SubItems[4].Text == "未缴费")
            {
                MessageBox.Show("已为未缴费状态，无需重新设置！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataSet sfDSet = SQLClass.getDataSet("select yezhuid,jine from shoufei where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'", "收费信息表");
                DataTable sfdt = sfDSet.Tables["收费信息表"];
                if(sfdt.Rows.Count > 0)
                {
                    DataSet yzDSet = SQLClass.getDataSet("select id,feiyong from yezhu where id = '" + sfdt.Rows[0][0].ToString() + "'","业主信息表");
                    DataTable yzdt = yzDSet.Tables["业主信息表"];
                    if(yzdt.Rows.Count > 0)
                    {
                        int sfje = Convert.ToInt32(yzdt.Rows[0][1].ToString()) + Convert.ToInt32(sfdt.Rows[0][1].ToString());
                        SQLClass.getsqlcom("update yezhu set feiyong = '" + sfje + "' where id = '" + yzdt.Rows[0][0].ToString() + "'");
                        SQLClass.getsqlcom("update shoufei set leixing = '0',yuangongid = '' where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                        treeview_left_AfterSelect(sender, e);
                        MessageBox.Show("修改缴费设置成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("该业主不存在，有可能是管理员删除了用户！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("设置失败，请稍后重试！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void 删除收费toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listview_right.SelectedItems[0].SubItems[4].Text == "未缴费")
            {
                if (DialogResult.OK == MessageBox.Show("确定删除（[" + listview_right.SelectedItems[0].SubItems[1].Text + "]" + listview_right.SelectedItems[0].SubItems[2].Text + "）的所有信息吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    //确认删除数据
                    SQLClass.getsqlcom("delete from shoufei where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                    treeview_left_AfterSelect(sender, e);
                    SQLClass.con_close();       //关闭数据库连接，释放资源
                    MessageBox.Show("删除收费项目成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if(listview_right.SelectedItems[0].SubItems[6].Text == "")
                {
                    if (DialogResult.OK == MessageBox.Show("确定删除（[" + listview_right.SelectedItems[0].SubItems[1].Text + "]" + listview_right.SelectedItems[0].SubItems[2].Text + "）的所有信息吗？", "询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                    {
                        //确认删除数据
                        SQLClass.getsqlcom("delete from shoufei where id = '" + listview_right.SelectedItems[0].SubItems[1].Text + "'");
                        treeview_left_AfterSelect(sender, e);
                        SQLClass.con_close();       //关闭数据库连接，释放资源
                        MessageBox.Show("删除收费项目成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("该项目处于成功缴费状态不可删除！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //关闭和最小化操作-----------------------------------------------------------------------------
        private void picbox_close_MouseHover(object sender, EventArgs e)
        {
            picbox_close.Image = Image.FromFile("images/close_mouse.png");
        }

        private void picbox_close_MouseLeave(object sender, EventArgs e)
        {
            picbox_close.Image = Image.FromFile("images/close.png");
        }

        private void picbox_min_MouseHover(object sender, EventArgs e)
        {
            picbox_min.Image = Image.FromFile("images/min_mouse.png");
        }

        private void picbox_min_MouseLeave(object sender, EventArgs e)
        {
            picbox_min.Image = Image.FromFile("images/min.png");
        }

        private void picbox_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picbox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //以下是导航图标动作---------------------------------------------------------------------------------------
        private void picbox_shouye_MouseHover(object sender, EventArgs e)
        {
            if (picbox_shouye.Tag.ToString() == "0")
            {
                picbox_shouye.Image = Image.FromFile("images/sy_mouse.png");
            }
        }
        private void picbox_shouye_MouseLeave(object sender, EventArgs e)
        {
            if(picbox_shouye.Tag.ToString() == "0")
            {
                picbox_shouye.Image = Image.FromFile("images/sy.png");
            }
        }

        private void picbox_shouye_Click(object sender, EventArgs e)
        {
            picbox_shouye.Tag = "1";
            picbox_shouye.Image = Image.FromFile("images/sy_select.png");
            picbox_yezhu.Tag = "0";
            picbox_yezhu.Image = Image.FromFile("images/yz.png");
            picbox_yuangong.Tag = "0";
            picbox_yuangong.Image = Image.FromFile("images/yg.png");
            picbox_yewu.Tag = "0";
            picbox_yewu.Image = Image.FromFile("images/yw.png");
            picbox_guanyu.Tag = "0";
            picbox_guanyu.Image = Image.FromFile("images/gy.png");
            splitcon1.Tag = "sy";
            UpdateComboBox();
            UpdateTreeview();
            treeview_left_AfterSelect(sender, e);
        }

        private void picbox_yezhu_MouseHover(object sender, EventArgs e)
        {
            if (picbox_yezhu.Tag.ToString() == "0")
            {
                picbox_yezhu.Image = Image.FromFile("images/yz_mouse.png");
            }
        }

        private void picbox_yezhu_MouseLeave(object sender, EventArgs e)
        {
            if (picbox_yezhu.Tag.ToString() == "0")
            {
                picbox_yezhu.Image = Image.FromFile("images/yz.png");
            }
        }

        private void picbox_yezhu_Click(object sender, EventArgs e)
        {
            picbox_shouye.Tag = "0";
            picbox_shouye.Image = Image.FromFile("images/sy.png");
            picbox_yezhu.Tag = "1";
            picbox_yezhu.Image = Image.FromFile("images/yz_select.png");
            picbox_yuangong.Tag = "0";
            picbox_yuangong.Image = Image.FromFile("images/yg.png");
            picbox_yewu.Tag = "0";
            picbox_yewu.Image = Image.FromFile("images/yw.png");
            picbox_guanyu.Tag = "0";
            picbox_guanyu.Image = Image.FromFile("images/gy.png");
            splitcon1.Tag = "yz";
            UpdateComboBox();
            UpdateTreeview();
            treeview_left_AfterSelect(sender, e);
        }

        private void picbox_yuangong_MouseHover(object sender, EventArgs e)
        {
            if (picbox_yuangong.Tag.ToString() == "0")
            {
                picbox_yuangong.Image = Image.FromFile("images/yg_mouse.png");
            }
        }

        private void picbox_yuangong_MouseLeave(object sender, EventArgs e)
        {
            if (picbox_yuangong.Tag.ToString() == "0")
            {
                picbox_yuangong.Image = Image.FromFile("images/yg.png");
            }
        }

        private void picbox_yuangong_Click(object sender, EventArgs e)
        {
            picbox_shouye.Tag = "0";
            picbox_shouye.Image = Image.FromFile("images/sy.png");
            picbox_yezhu.Tag = "0";
            picbox_yezhu.Image = Image.FromFile("images/yz.png");
            picbox_yuangong.Tag = "1";
            picbox_yuangong.Image = Image.FromFile("images/yg_select.png");
            picbox_yewu.Tag = "0";
            picbox_yewu.Image = Image.FromFile("images/yw.png");
            picbox_guanyu.Tag = "0";
            picbox_guanyu.Image = Image.FromFile("images/gy.png");
            splitcon1.Tag = "yg";
            UpdateComboBox();
            UpdateTreeview();
            treeview_left_AfterSelect(sender, e);
        }

        private void picbox_yewu_MouseHover(object sender, EventArgs e)
        {
            if (picbox_yewu.Tag.ToString() == "0")
            {
                picbox_yewu.Image = Image.FromFile("images/yw_mouse.png");
            }
        }

        private void picbox_yewu_MouseLeave(object sender, EventArgs e)
        {
            if (picbox_yewu.Tag.ToString() == "0")
            {
                picbox_yewu.Image = Image.FromFile("images/yw.png");
            }
        }

        private void picbox_yewu_Click(object sender, EventArgs e)
        {
            picbox_shouye.Tag = "0";
            picbox_shouye.Image = Image.FromFile("images/sy.png");
            picbox_yezhu.Tag = "0";
            picbox_yezhu.Image = Image.FromFile("images/yz.png");
            picbox_yuangong.Tag = "0";
            picbox_yuangong.Image = Image.FromFile("images/yg.png");
            picbox_yewu.Tag = "1";
            picbox_yewu.Image = Image.FromFile("images/yw_select.png");
            picbox_guanyu.Tag = "0";
            picbox_guanyu.Image = Image.FromFile("images/gy.png");
            splitcon1.Tag = "yw";
            UpdateTreeview();
        }

        private void picbox_guanyu_MouseHover(object sender, EventArgs e)
        {
            if (picbox_guanyu.Tag.ToString() == "0")
            {
                picbox_guanyu.Image = Image.FromFile("images/gy_mouse.png");
            }
        }

        private void picbox_guanyu_MouseLeave(object sender, EventArgs e)
        {
            if (picbox_guanyu.Tag.ToString() == "0")
            {
                picbox_guanyu.Image = Image.FromFile("images/gy.png");
            }
        }

        private void picbox_guanyu_Click(object sender, EventArgs e)
        {
            //picbox_shouye.Tag = "0";
            picbox_shouye.Image = Image.FromFile("images/sy.png");
            //picbox_yezhu.Tag = "0";
            picbox_yezhu.Image = Image.FromFile("images/yz.png");
            //picbox_yuangong.Tag = "0";
            picbox_yuangong.Image = Image.FromFile("images/yg.png");
            //picbox_yewu.Tag = "0";
            picbox_yewu.Image = Image.FromFile("images/yw.png");
            //picbox_guanyu.Tag = "1";
            picbox_guanyu.Image = Image.FromFile("images/gy_select.png");
            //splitcon1.Tag = "gy";
            About aboutme = new About();        //新建关于本软件的窗体类
            aboutme.ShowDialog();       //运行新创建的窗体
            picbox_guanyu.Image = Image.FromFile("images/gy.png");
            if (picbox_yezhu.Tag.ToString() == "1")
            {
                picbox_yezhu.Image = Image.FromFile("images/yz_select.png");
            }
            else if (picbox_yuangong.Tag.ToString() == "1")
            {
                picbox_yuangong.Image = Image.FromFile("images/yg_select.png");
            }
            else if (picbox_yewu.Tag.ToString() == "1")
            {
                picbox_yewu.Image = Image.FromFile("images/yw_select.png");
            }
            else
            {
                picbox_shouye.Image = Image.FromFile("images/sy_select.png");
            }
        }
        private int Iskaifashang()
        {
            if (treeview_left.SelectedNode == null)      //判断是否选中了树节点
            {
                return -1;
            }
            int iskaifashang;
            DataSet DSet = SQLClass.getDataSet("select id from kaifashang where id = '" + treeview_left.SelectedNode.Name + "' and gongsi = '" + treeview_left.SelectedNode.Text + "'", "开发商信息表");
            DataTable dt = DSet.Tables["开发商信息表"];
            if(dt.Rows.Count > 0)
            {
                iskaifashang = 1;
            }
            else
            {
                iskaifashang = 0;
            }
            return iskaifashang;
        }

        public void UpdateComboBox()
        {
            combox.Items.Clear();
            switch(splitcon1.Tag.ToString())
            {
                case "sy":
                    combox.Items.Add("住房编号");
                    combox.Items.Add("楼层");
                    combox.Items.Add("住房配置");
                    combox.Items.Add("业主名称");
                    combox.Items.Add("状态");
                    combox.Items.Add("所属房产");
                    combox.Items.Add("开发商");
                    combox.SelectedIndex = 0;
                    break;
                case "yz":
                    combox.Items.Add("业主编号");
                    combox.Items.Add("姓名");
                    combox.Items.Add("性别");
                    combox.Items.Add("身份证号");
                    combox.Items.Add("权限");
                    combox.Items.Add("用户名");
                    combox.SelectedIndex = 0;
                    break;
                case "yg":
                    combox.Items.Add("员工编号");
                    combox.Items.Add("姓名");
                    combox.Items.Add("性别");
                    combox.Items.Add("部门");
                    combox.Items.Add("岗位");
                    combox.Items.Add("权限");
                    combox.Items.Add("用户名");
                    combox.SelectedIndex = 0;
                    break;
                case "yw":
                    if(treeview_left.SelectedNode == null)
                    {
                        return;
                    }
                    else
                    {
                        switch(treeview_left.SelectedNode.Name)
                        {
                            case "1":
                                combox.Items.Add("事务编号");
                                combox.Items.Add("事务名称");
                                combox.Items.Add("状态");
                                combox.Items.Add("负责人");
                                combox.SelectedIndex = 0;
                                break;
                            case "2":
                                combox.Items.Add("申请编号");
                                combox.Items.Add("申请名称");
                                combox.Items.Add("申请人");
                                combox.Items.Add("状态");
                                combox.Items.Add("负责人");
                                combox.SelectedIndex = 0;
                                break;
                            case "3":
                                combox.Items.Add("收费编号");
                                combox.Items.Add("收费事项");
                                combox.Items.Add("状态");
                                combox.Items.Add("缴费业主");
                                combox.Items.Add("负责人");
                                combox.SelectedIndex = 0;
                                break;
                        }
                    }
                    break;
            }
        }

        public string givetempsql(string sql)
        {
            if (checkbox.Checked)
            {
                if(isonce)
                {
                    isonce = false;
                    needwhere = true;
                    if (splitcon1.Tag.ToString() == "yw")
                    {
                        if (treeview_left.SelectedNode == null)
                        {
                            MessageBox.Show("你当前的位置需要选中树节点后查询！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            sql = search.newsql(splitcon1.Tag.ToString(), treeview_left.SelectedNode.Name);
                            sql = search.Searchsql(sql, combox.Text, txt_context.Text.Trim(), splitcon1.Tag.ToString(), treeview_left.SelectedNode.Name, needwhere);
                        }
                    }
                    else
                    {
                        sql = search.newsql(splitcon1.Tag.ToString(), "0");
                        sql = search.Searchsql(sql, combox.Text, txt_context.Text.Trim(), splitcon1.Tag.ToString(), "0", needwhere);
                    }
                }
                else
                {
                    isonce = false;
                    needwhere = false;
                    if (splitcon1.Tag.ToString() == "yw")
                    {
                        if (treeview_left.SelectedNode == null)
                        {
                            MessageBox.Show("你当前的位置需要选中树节点后查询！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            sql = search.Searchsql(sql, combox.Text, txt_context.Text.Trim(), splitcon1.Tag.ToString(), treeview_left.SelectedNode.Name, needwhere);
                        }
                    }
                    else
                    {
                        sql = search.Searchsql(sql, combox.Text, txt_context.Text.Trim(), splitcon1.Tag.ToString(), "0", needwhere);
                    }
                }
            }
            else
            {
                if (isonce)
                {

                    isonce = false;
                    needwhere = true;
                    if (splitcon1.Tag.ToString() == "yw")
                    {
                        if (treeview_left.SelectedNode == null)
                        {
                            MessageBox.Show("你当前的位置需要选中树节点后查询！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            sql = search.newsql(splitcon1.Tag.ToString(), treeview_left.SelectedNode.Name);
                            sql = search.Searchsql(sql, combox.Text, txt_context.Text.Trim(), splitcon1.Tag.ToString(), treeview_left.SelectedNode.Name, needwhere);
                        }
                    }
                    else
                    {
                        sql = search.newsql(splitcon1.Tag.ToString(), "0");
                        sql = search.Searchsql(sql, combox.Text, txt_context.Text.Trim(), splitcon1.Tag.ToString(), "0", needwhere);
                    }
                }
                else
                {

                    isonce = false;
                    needwhere = true;
                    if (splitcon1.Tag.ToString() == "yw")
                    {
                        if (treeview_left.SelectedNode == null)
                        {
                            MessageBox.Show("你当前的位置需要选中树节点后查询！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            sql = search.newsql(splitcon1.Tag.ToString(), treeview_left.SelectedNode.Name);
                            sql = search.Searchsql(sql, combox.Text, txt_context.Text.Trim(), splitcon1.Tag.ToString(), treeview_left.SelectedNode.Name, needwhere);
                        }
                    }
                    else
                    {
                        sql = search.newsql(splitcon1.Tag.ToString(), "0");
                        sql = search.Searchsql(sql, combox.Text, txt_context.Text.Trim(), splitcon1.Tag.ToString(), "0", needwhere);
                    }
                }
            }
            return sql;
        }

        private void txt_context_Enter(object sender, EventArgs e)
        {
            txt_context.Tag = txt_context.Text;
            txt_context.Text = "";
            txt_context.ForeColor = Color.Black;
        }

        private void txt_context_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                picbox_search_Click(sender, e);
                e.Handled = true;
            }
        }

        private void picbox_search_Click(object sender, EventArgs e)
        {
            listview_columns();
            tempsql = givetempsql(tempsql);
            tempint = 0;
            UpdateListview(tempsql);
        }

        private void combox_TextChanged(object sender, EventArgs e)
        {
            switch(splitcon1.Tag.ToString())
            {
                case "sy":
                    switch(combox.Text)
                    {
                        case "住房编号":
                            txt_context.Text = "请输入住房编号！";
                            break;
                        case "楼层":
                            txt_context.Text = "请输入楼层！";
                            break;
                        case "住房配置":
                            txt_context.Text = "请输入住房配置！";
                            break;
                        case "业主名称":
                            txt_context.Text = "请输入业主名称！";
                            break;
                        case "状态":
                            txt_context.Text = "0:未入住 1:已迁入";
                            break;
                        case "所属房产":
                            txt_context.Text = "请输入所属房产的名称！";
                            break;
                        case "开发商":
                            txt_context.Text = "请输入开发商名称！";
                            break;
                    }
                    break;
                case "yz":
                    switch(combox.Text)
                    {
                        case "业主编号":
                            txt_context.Text = "请输入业主编号！";
                            break;
                        case "业主姓名":
                            txt_context.Text = "请输入业主姓名！";
                            break;
                        case "性别":
                            txt_context.Text = "请输入业主性别！";
                            break;
                        case "身份证号":
                            txt_context.Text = "请输入身份证号！";
                            break;
                        case "权限":
                            txt_context.Text = "0:未审核 1:已审核";
                            break;
                        case "用户名":
                            txt_context.Text = "请输入业主用户名！";
                            break;
                    }
                    break;
                case "yg":
                    switch(combox.Text)
                    {
                        case "员工编号":
                            txt_context.Text = "请输入员工编号！";
                            break;
                        case "员工姓名":
                            txt_context.Text = "请输入员工姓名！";
                            break;
                        case "性别":
                            txt_context.Text = "男 或 女！";
                            break;
                        case "部门":
                            txt_context.Text = "请输入部门名称！";
                            break;
                        case "岗位":
                            txt_context.Text = "请输入岗位名称！";
                            break;
                        case "权限":
                            txt_context.Text = "0:普通员工 1:管理员 2:超级管理员";
                            break;
                        case "用户名":
                            txt_context.Text = "请输入员工用户名！";
                            break;
                    }
                    break;
                case "yw":
                    if(treeview_left.SelectedNode == null)
                    {
                        return;
                    }
                    switch(treeview_left.SelectedNode.Name)
                    {
                        case "1":
                            switch(combox.Text)
                            {
                                case "事务编号":
                                    txt_context.Text = "请输入事务编号！";
                                    break;
                                case "事务名称":
                                    txt_context.Text = "请输入事项名称！";
                                    break;
                                case "状态":
                                    txt_context.Text = "0:未完成 1:已完成";
                                    break;
                                case "负责人":
                                    txt_context.Text = "请输入员工姓名！";
                                    break;
                            }
                            break;
                        case "2":
                            switch(combox.Text)
                            {
                                case "申请编号":
                                    txt_context.Text = "请输入申请编号！";
                                    break;
                                case "申请名称":
                                    txt_context.Text = "请输入申请名称！";
                                    break;
                                case "申请人":
                                    txt_context.Text = "请输入业主姓名！";
                                    break;
                                case "状态":
                                    txt_context.Text = "0:未处理 1:已处理: 2:已完成";
                                    break;
                                case "负责人":
                                    break;
                            }
                            break;
                        case "3":
                            switch(combox.Text)
                            {
                                case "收费编号":
                                    txt_context.Text = "请输入收费编号！";
                                    break;
                                case "收费事项":
                                    txt_context.Text = "请输入收费事项！";
                                    break;
                                case "状态":
                                    txt_context.Text = "0:未缴费 1:已缴费";
                                    break;
                                case "缴费业主":
                                    txt_context.Text = "请输入业主名称！";
                                    break;
                                case "负责人":
                                    txt_context.Text = "请输入员工名称！";
                                    break;
                            }
                            break;
                    }
                    break;
            }
            txt_context.ForeColor = Color.Gray;
        }

        private void txt_context_Leave(object sender, EventArgs e)
        {
            if(txt_context.Text == "")
            {
                txt_context.Text = txt_context.Tag.ToString();
                txt_context.ForeColor = Color.Gray;
            }
        }



        //统计代码
        public void Tongji()
        {
            if(treeview_left.SelectedNode == null)
            {
                switch(splitcon1.Tag.ToString())
                {
                    case "sy":
                        DataSet kfsDSet = SQLClass.getDataSet("select count(id) from kaifashang", "查询信息表");
                        DataTable kfsdt = kfsDSet.Tables["查询信息表"];
                        DataSet fcDSet = SQLClass.getDataSet("select count(id) from fangchan", "查询信息表");
                        DataTable fcdt = fcDSet.Tables["查询信息表"];
                        DataSet zfDSet = SQLClass.getDataSet("select count(id) from zhufang", "查询信息表");
                        DataTable zfdt = zfDSet.Tables["查询信息表"];
                        MessageBox.Show("开发商" + kfsdt.Rows[0][0].ToString() + "家,楼房" + fcdt.Rows[0][0].ToString() + "栋,住房" + zfdt.Rows[0][0].ToString() + "间", "查询结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "yz":
                        DataSet yzDSet = SQLClass.getDataSet("select count(id),quanxian from yezhu group by quanxian", "查询信息表");
                        DataTable yzdt = yzDSet.Tables["查询信息表"];
                        int yznum = Convert.ToInt32(yzdt.Rows[0][0].ToString()) + Convert.ToInt32(yzdt.Rows[1][0]);
                        MessageBox.Show("共计已注册业主" + yznum + "人,已审核" + yzdt.Rows[1][0].ToString() + "人，未审核" + yzdt.Rows[0][0].ToString() + "人", "查询结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "yg":

                        DataSet ygDSet = SQLClass.getDataSet("select count(id),quanxian from yezhu group by quanxian", "查询信息表");
                        DataTable ygdt = ygDSet.Tables["查询信息表"];

                        //int ygnum = Convert.ToInt32(ygdt.Rows[0][0].ToString()) + Convert.ToInt32(ygdt.Rows[1][0].ToString()) + Convert.ToInt32(ygdt.Rows[2][0].ToString());
                        MessageBox.Show(ygdt.Rows.Count.ToString(), "查询结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            else
            {
                switch(splitcon1.Tag.ToString())
                {
                    case "sy":
                        break;
                    case "yz":
                        break;
                    case "yg":
                        break;
                    case "yw":
                        break;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            changeuser = true;
            this.Close();
        }

        private void picbox_search_MouseHover(object sender, EventArgs e)
        {
            picbox_search.Image = Image.FromFile("images/search_mouse.png");
        }

        private void picbox_search_MouseLeave(object sender, EventArgs e)
        {
            picbox_search.Image = Image.FromFile("images/search.png");
        }

        //public void Chaxun(string sql)
        //{
        //    DataSet DSet = SQLClass.getDataSet(sql, "查询信息表");
        //    DataTable dt = DSet.Tables["查询信息表"];
        //    if(dt.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {

        //        }
        //    }
        //}


    }
}
