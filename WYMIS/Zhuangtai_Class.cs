using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WYMIS
{
    class Zhuangtai_Class
    {
        SQL_Class SQLClass = new SQL_Class();
        public string Zhufang(string num)
        {
            string zhuangtai = "0";
            if(num == "0")
            {
                zhuangtai = "未入住";
            }
            else if(num == "1")
            {
                zhuangtai = "已入住";
            }
            else
            {
                zhuangtai = "空";
            }
            return zhuangtai;
        }
        public string YezhuQuanxian(string num)
        {
            string quanxian = "0";
            if(num == "0")
            {
                quanxian = "未审核";
            }
            else if(num == "1")
            {
                quanxian = "已审核";
            }
            else
            {
                quanxian = "已删除";
            }
            return quanxian;
        }
        public string YuangongQuanxian(string num)
        {
            string quanxian = "0";
            if(num == "0")
            {
                quanxian = "普通员工";
            }
            else if(num == "1")
            {
                quanxian = "管理员";
            }
            else if(num == "2")
            {
                quanxian = "超级管理员";
            }
            else
            {
                quanxian = "离岗员工";
            }
            return quanxian;
        }
        public string Richang(string num)
        {
            string zhuangtai = "0";
            if(num == "0")
            {
                zhuangtai = "未完成";
            }
            else
            {
                zhuangtai = "已完成";
            }
            return zhuangtai;
        }
        public string Fuwu(string num)
        {
            string zhuangtai = "0";
            if(num == "0")
            {
                zhuangtai = "未处理";
            }
            else if (num == "1")
            {
                zhuangtai = "已受理";
            }
            else
            {
                zhuangtai = "已完成";
            }
            return zhuangtai;
        }
        public string Yewu(string num)
        {
            string zhuangtai = "0";
            if(num == "1")
            {
                zhuangtai = "日常事务";
            }
            else if(num == "2")
            {
                zhuangtai = "业主申请";
            }
            else if(num == "3")
            {
                zhuangtai = "收费信息";
            }
            return zhuangtai;
        }
        public string Shoufei_leixing(string num)
        {
            string leixing = "0";
            if(num == "0")
            {
                leixing = "未缴费";
            }
            else if(num == "1")
            {
                leixing = "已缴费";
            }
            return leixing;
        }
        public string KaifashangName(string num,bool isname)
        {
            string kaifashang;
            if (isname)
            {
                DataSet DSet = SQLClass.getDataSet("select gongsi from kaifashang where id = '" + num + "'", "开发商信息表");
                DataTable dt = DSet.Tables["开发商信息表"];
                if (dt.Rows.Count > 0)
                {
                    kaifashang = dt.Rows[0][0].ToString();
                }
                else
                {
                    kaifashang = null;
                }
            }
            else
            {
                DataSet DSet = SQLClass.getDataSet("select id from kaifashang where gongsi = '" + num + "'", "开发商信息表");
                DataTable dt = DSet.Tables["开发商信息表"];
                if (dt.Rows.Count > 0)
                {
                    kaifashang = dt.Rows[0][0].ToString();
                }
                else
                {
                    kaifashang = null;
                }
            }
            SQLClass.con_close();
            return kaifashang;
        }

        public string FangchanName(string num, bool isname)
        {
            string fangchan;
            if(isname)
            {
                DataSet DSet = SQLClass.getDataSet("select jianzu from fangchan where id = '" + num + "'", "房产信息表");
                DataTable dt = DSet.Tables["房产信息表"];
                if (dt.Rows.Count > 0)
                {
                    fangchan = dt.Rows[0][0].ToString();
                }
                else
                {
                    fangchan = null;
                }
            }
            else
            {
                DataSet DSet = SQLClass.getDataSet("select id from fangchan where jianzu = '" + num + "'", "房产信息表");
                DataTable dt = DSet.Tables["房产信息表"];
                if (dt.Rows.Count > 0)
                {
                    fangchan = dt.Rows[0][0].ToString();
                }
                else
                {
                    fangchan = null;
                }
            }
            return fangchan;
        }

        public string YezhuName(string num, bool isname)
        {
            string yezhu;
            if (isname)
            {
                DataSet DSet = SQLClass.getDataSet("select xingming from yezhu where id = '" + num + "'", "业主信息表");
                DataTable dt = DSet.Tables["业主信息表"];
                if (dt.Rows.Count > 0)
                {
                    yezhu = dt.Rows[0][0].ToString();
                }
                else
                {
                    yezhu = "";
                }
            }
            else
            {
                DataSet DSet = SQLClass.getDataSet("select id from yezhu where xingming = '" + num + "'", "业主信息表");
                DataTable dt = DSet.Tables["业主信息表"];
                if (dt.Rows.Count > 0)
                {
                    yezhu = dt.Rows[0][0].ToString();
                }
                else
                {
                    yezhu = "";
                }
            }
            return yezhu;
        }

        public string YuangongName(string num, bool isname)
        {
            string yuangong;
            if (isname)
            {
                DataSet DSet = SQLClass.getDataSet("select xingming from yuangong where id = '" + num + "'", "员工信息表");
                DataTable dt = DSet.Tables["员工信息表"];
                if (dt.Rows.Count > 0)
                {
                    yuangong = dt.Rows[0][0].ToString();
                }
                else
                {
                    yuangong = "";
                }
            }
            else
            {
                DataSet DSet = SQLClass.getDataSet("select id from yuangong where xingming = '" + num + "'", "员工信息表");
                DataTable dt = DSet.Tables["员工信息表"];
                if (dt.Rows.Count > 0)
                {
                    yuangong = dt.Rows[0][0].ToString();
                }
                else
                {
                    yuangong = "";
                }
            }
            return yuangong;
        }

        public string GangweiName(string num, bool isname)
        {
            string gangwei;
            if(isname)
            {
                DataSet DSet = SQLClass.getDataSet("select gangwei from gangwei where id = '" + num + "'", "岗位信息表");
                DataTable dt = DSet.Tables["岗位信息表"];
                if (dt.Rows.Count > 0)
                {
                    gangwei = dt.Rows[0][0].ToString();
                }
                else
                {
                    gangwei = "";
                }
            }
            else
            {
                DataSet DSet = SQLClass.getDataSet("select id from gangwei where gangwei = '" + num + "'", "岗位信息表");
                DataTable dt = DSet.Tables["岗位信息表"];
                if (dt.Rows.Count > 0)
                {
                    gangwei = dt.Rows[0][0].ToString();
                }
                else
                {
                    gangwei = "";
                }
            }
            return gangwei;
        }

    }

}
