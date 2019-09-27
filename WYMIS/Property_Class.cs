using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WYMIS
{
    class Property_Class
    {
        private string id;
        private string jianzu;
        //private string kaifashang;
        //private string shijian;
        //private string beizhu;
        private string gongsi;
        private string dizhi;
        private string lianxi;
        private string fuzeren;
        [CategoryAttribute("开发商基本属性"),DescriptionAttribute("显示开发商编号")]
        public string 开发商编号
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        [CategoryAttribute("开发商基本属性"),DescriptionAttribute("显示开发商名称")]
        public string 开发商名称
        {
            get
            {
                return gongsi;
            }
            set
            {
                gongsi = value;
            }
        }
        [CategoryAttribute("基本属性"),DescriptionAttribute("显示开发商联系方式")]
        public string 开发商联系方式
        {
            get
            {
                return lianxi;
            }
            set
            {
                lianxi = value;
            }
        }
        [CategoryAttribute("开发商基本属性"), DescriptionAttribute("显示开发商地址")]
        public string 开发商地址
        {
            get
            {
                return dizhi;
            }
            set
            {
                dizhi = value;
            }
        }
        [CategoryAttribute("基本属性"),DescriptionAttribute("显示开发商负责人")]
        public string 开发商负责人
        {
            get
            {
                return fuzeren;
            }
            set
            {
                fuzeren = value;
            }
        }
        [CategoryAttribute("房产基本属性"),DescriptionAttribute("显示房产编号")]
        public string 房产编号
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        [CategoryAttribute("房产基本属性"),DescriptionAttribute("显示房产名称")]
        public string 房产名称
        {
            get
            {
                return jianzu;
            }
            set
            {
                jianzu = value;
            }
        }
        [CategoryAttribute("房产基本属性"), DescriptionAttribute("显示房产地址")]
        public string 房产地址
        {
            get
            {
                return dizhi;
            }
            set
            {
                dizhi = value;
            }
        }
        [CategoryAttribute("房产基本属性"), DescriptionAttribute("显示房产开发商")]
        public string 房产开发商
        {
            get
            {
                return gongsi;
            }
            set
            {
                gongsi = value;
            }
        }
        //void setToolStripMenuItem(int count ,string roadName)
        //{
        //    if(count>=1)
        //    {
        //        intarry;
        //        if((count%16!=0)&&(count>=16))
        //            arry=count/16;
        //        else
        //            arry=count/16-1;
        //        ToolStripMenuItem s=new ToolStripMenuItem ();
        //        s.Name=roadName;     s.Text=roadName+"信号通道";
        //        contextMenuStrip1.Items.Add(s);
        //        if(arry>=1){ inti=1;
        //            for(intsi=0;si<=arry;si++){
        //                ToolStripMenuItemss=new ToolStripMenuItem ();
        //                ss.Name=roadName+si;
        //                ss.Text=roadName+"信号通道"+(16*(si)+1)+"-"+16*(si+1);
        //                s.DropDownItems.Add(ss);
        //                if(si<arry)
        //                    for( (i<=16*(si+1));i++)
        //                    {
        //                        ToolStripMenuItemsss=new ToolStripMenuItem ();
        //                        sss.Name=roadName+i;
        //                        sss.Click+= new EventHandler(show );
        //                        sss.Text=roadName+"信号通道"+i;
        //                        ss.DropDownItems.Add (sss);
        //                    }
        //                else
        //                    for(int j=1;(j<=count%16);j++,i++)
        //                    {
        //                        ToolStripMenuItemsss=new ToolStripMenuItem ();
        //                        sss.Name=roadName+i;
        //                        sss.Text=roadName+"信号通道"+i;
        //                        sss.Click+= new EventHandler(show);
        //                        ss.DropDownItems.Add (sss);
        //                    }
        //            }
        //        }
        //        else
        //        {
        //            for(intsi=1;si<=count;si++)
        //            {
        //                ToolStripMenuItemss=new ToolStripMenuItem ();
        //                ss.Name=roadName+si;
        //                ss.Text=roadName+"信号通道"+si;
        //                s.DropDownItems.Add(ss);
        //            }
        //        }
        //    }
        //} 
    }
}
