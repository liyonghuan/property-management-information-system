using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WYMIS
{
    class Search_Class
    {
        SQL_Class SQLClass = new SQL_Class();
        public string Searchsql(string searchsql, string combox, string context, string splitcon, string son, bool needwhere)
        {
            switch (splitcon)
            {
                case "sy":
                    if (needwhere)        //值为假则表示语句含有where，为真则不含有where
                    {
                        switch (combox)
                        {
                            case "住房编号":
                                searchsql = searchsql + " where id like '%" + context + "%'";
                                break;
                            case "楼层":
                                searchsql = searchsql + " where louceng like '%" + context + "%'";
                                break;
                            case "住房配置":
                                searchsql = searchsql + " where peizhi like '%" + context + "%'";
                                break;
                            case "业主名称":        //此处需添加查询业主ID语句
                                searchsql = searchsql + SearchYezhuName(context, needwhere, splitcon);
                                break;
                            case "状态":
                                searchsql = searchsql + " where zhuangtai like '%" + context + "%'";
                                break;
                            case "所属房产":
                                searchsql = searchsql + SearchFangchanName(context, needwhere, splitcon);
                                break;
                            case "开发商":
                                searchsql = searchsql + SearchKaifashangName(context, needwhere, splitcon);
                                break;
                        }
                    }
                    else
                    {
                        switch (combox)
                        {
                            case "住房编号":
                                searchsql = searchsql + " and id like '%" + context + "%'";
                                break;
                            case "楼层":
                                searchsql = searchsql + " and louceng like '%" + context + "%'";
                                break;
                            case "住房配置":
                                searchsql = searchsql + " and peizhi like '%" + context + "%'";
                                break;
                            case "业主名称":        //此处需添加查询业主ID语句
                                searchsql = searchsql + SearchYezhuName(context, needwhere, splitcon);
                                break;
                            case "状态":
                                searchsql = searchsql + " and zhuangtai like '%" + context + "%'";
                                break;
                            case "所属房产":
                                searchsql = searchsql + SearchFangchanName(context, needwhere, splitcon);
                                break;
                            case "开发商":
                                searchsql = searchsql + SearchKaifashangName(context, needwhere, splitcon);
                                break;
                        }
                    }
                    break;
                case "yz":
                    if (needwhere)        //值为假则表示语句含有where，为真则不含有where
                    {
                        switch (combox)
                        {
                            case "业主编号":
                                searchsql = searchsql + " where id like '%" + context + "%'";
                                break;
                            case "姓名":
                                searchsql = searchsql + SearchYezhuName(context, needwhere, splitcon);
                                break;
                            case "性别":
                                searchsql = searchsql + " where xingbie like '%" + context + "%'";
                                break;
                            case "身份证号":        //此处需添加查询业主ID语句
                                searchsql = searchsql + " where shenfenzheng like '%" + context + "%'";
                                break;
                            case "权限":
                                searchsql = searchsql + " where quanxian like '%" + context + "%'";
                                break;
                            case "用户名":
                                searchsql = searchsql + " where username like '%" + context + "%'";
                                break;
                        }
                    }
                    else
                    {
                        switch (combox)
                        {
                            case "业主编号":
                                searchsql = searchsql + " and id like '%" + context + "%'";
                                break;
                            case "姓名":
                                searchsql = searchsql + SearchYezhuName(context, needwhere, splitcon);
                                break;
                            case "性别":
                                searchsql = searchsql + " and xingbie like '%" + context + "%'";
                                break;
                            case "身份证号":        //此处需添加查询业主ID语句
                                searchsql = searchsql + " and shenfenzheng like '%" + context + "%'";
                                break;
                            case "权限":
                                searchsql = searchsql + " and quanxian like '%" + context + "%'";
                                break;
                            case "用户名":
                                searchsql = searchsql + " and username like '%" + context + "%'";
                                break;
                        }
                    }
                    break;
                case "yg":
                    if (needwhere)        //值为假则表示语句含有where，为真则不含有where
                    {
                        switch (combox)
                        {
                            case "员工编号":
                                searchsql = searchsql + " where id like '%" + context + "%'";
                                break;
                            case "姓名":
                                searchsql = searchsql + SearchYuangongName(context, needwhere, splitcon);
                                break;
                            case "性别":
                                searchsql = searchsql + " where xingbie like '%" + context + "%'";
                                break;
                            case "部门":
                                searchsql = searchsql + SearchBumenName(context, needwhere, splitcon);
                                break;
                            case "岗位":        //此处需添加查询业主ID语句
                                searchsql = searchsql + SearchGangweiName(context, needwhere, splitcon);
                                break;
                            case "权限":
                                searchsql = searchsql + " where quanxian like '%" + context + "%'";
                                break;
                            case "用户名":
                                searchsql = searchsql + " where username like '%" + context + "%'";
                                break;
                        }
                    }
                    else
                    {
                        switch (combox)
                        {
                            case "员工编号":
                                searchsql = searchsql + " and id like '%" + context + "%'";
                                break;
                            case "姓名":
                                searchsql = searchsql + SearchYuangongName(context, needwhere, splitcon);
                                break;
                            case "性别":
                                searchsql = searchsql + " and xingbie like '%" + context + "%'";
                                break;
                            case "部门":
                                searchsql = searchsql + SearchBumenName(context, needwhere, splitcon);
                                break;
                            case "岗位":        //此处需添加查询岗位ID语句
                                searchsql = searchsql + SearchGangweiName(context, needwhere, splitcon);
                                break;
                            case "权限":
                                searchsql = searchsql + " and quanxian like '%" + context + "%'";
                                break;
                            case "用户名":
                                searchsql = searchsql + " and username like '%" + context + "%'";
                                break;
                        }
                    }
                    break;
                case "yw":
                    switch (son)
                    {
                        case "1":
                            if (needwhere)        //值为假则表示语句含有where，为真则不含有where
                            {
                                switch (combox)
                                {
                                    case "事务编号":
                                        searchsql = searchsql + " where id like '%" + context + "%'";
                                        break;
                                    case "事务名称":
                                        searchsql = searchsql + " where shixiang like '%" + context + "%'";
                                        break;
                                    case "状态":
                                        searchsql = searchsql + " where zhuangtai like '%" + context + "%'";
                                        break;
                                    case "负责人":        //此处需添加查询业主ID语句
                                        searchsql = searchsql + SearchYuangongName(context, needwhere, splitcon);
                                        break;
                                }
                            }
                            else
                            {
                                switch (combox)
                                {
                                    case "事务编号":
                                        searchsql = searchsql + " and id like '%" + context + "%'";
                                        break;
                                    case "事务名称":
                                        searchsql = searchsql + " and shixiang like '%" + context + "%'";
                                        break;
                                    case "状态":
                                        searchsql = searchsql + " and zhuangtai like '%" + context + "%'";
                                        break;
                                    case "负责人":        //此处需添加查询业主ID语句
                                        searchsql = searchsql + SearchYuangongName(context, needwhere, splitcon);
                                        break;
                                }
                            }
                            break;
                        case "2":
                            if (needwhere)        //值为假则表示语句含有where，为真则不含有where
                            {
                                switch (combox)
                                {
                                    case "申请编号":
                                        searchsql = searchsql + " where id like '%" + context + "%'";
                                        break;
                                    case "申请名称":
                                        searchsql = searchsql + " where shixiang like '%" + context + "%'";
                                        break;
                                    case "申请人":
                                        searchsql = searchsql + SearchYezhuName(context, needwhere, splitcon);
                                        break;
                                    case "状态":        //此处需添加查询业主ID语句
                                        searchsql = searchsql + " where zhuangtai like '%" + context + "%'";
                                        break;
                                    case "负责人":
                                        searchsql = searchsql + SearchYuangongName(context, needwhere, splitcon);
                                        break;
                                }
                            }
                            else
                            {
                                switch (combox)
                                {
                                    case "申请编号":
                                        searchsql = searchsql + " and id like '%" + context + "%'";
                                        break;
                                    case "申请名称":
                                        searchsql = searchsql + " and shixiang like '%" + context + "%'";
                                        break;
                                    case "申请人":
                                        searchsql = searchsql + SearchYezhuName(context, needwhere, splitcon);
                                        break;
                                    case "状态":        //此处需添加查询业主ID语句
                                        searchsql = searchsql + " and zhuangtai like '%" + context + "%'";
                                        break;
                                    case "负责人":
                                        searchsql = searchsql + SearchYuangongName(context, needwhere, splitcon);
                                        break;
                                }
                            }
                            break;
                        case "3":
                            if (needwhere)        //值为假则表示语句含有where，为真则不含有where
                            {
                                switch (combox)
                                {
                                    case "收费编号":
                                        searchsql = searchsql + " where id like '%" + context + "%'";
                                        break;
                                    case "收费名称":
                                        searchsql = searchsql + " where shixiang like '%" + context + "%'";
                                        break;
                                    case "缴费业主":
                                        searchsql = searchsql + SearchYezhuName(context, needwhere, splitcon);
                                        break;
                                    case "状态":        //此处需添加查询业主ID语句
                                        searchsql = searchsql + " where leixing like '%" + context + "%'";
                                        break;
                                    case "负责人":
                                        searchsql = searchsql + SearchYuangongName(context, needwhere, splitcon);
                                        break;
                                }
                            }
                            else
                            {
                                switch (combox)
                                {
                                    case "收费编号":
                                        searchsql = searchsql + " and id like '%" + context + "%'";
                                        break;
                                    case "收费名称":
                                        searchsql = searchsql + " and shixiang like '%" + context + "%'";
                                        break;
                                    case "缴费业主":
                                        searchsql = searchsql + SearchYezhuName(context, needwhere, splitcon);
                                        break;
                                    case "状态":        //此处需添加查询业主ID语句
                                        searchsql = searchsql + " and leixing like '%" + context + "%'";
                                        break;
                                    case "负责人":
                                        searchsql = searchsql + SearchYuangongName(context, needwhere, splitcon);
                                        break;
                                }
                            }
                            break;
                    }
                    break;
            }
            return searchsql;
        }

        public string SearchYezhuName(string name, bool needwhere, string splitcon)
        {
            string link = "";
            DataSet DSet = SQLClass.getDataSet("select id from yezhu where xingming like '%" + name + "%'", "业主信息表");
            DataTable dt = DSet.Tables["业主信息表"];
            if(dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    switch(splitcon)
                    {
                        case "yz":
                            if(needwhere)
                            {
                                needwhere = false;
                                link += " where ( id = '" + dt.Rows[i][0].ToString() + "'";
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    link += " and ( id = '" + dt.Rows[i][0].ToString() + "'";
                                }
                                else
                                {
                                    link += " or id = '" + dt.Rows[i][0].ToString() + "'";
                                }
                            }
                            break;
                        default :
                            if(needwhere)
                            {
                                needwhere = false;
                                link += " where ( yezhuid = '" + dt.Rows[i][0].ToString() + "'";
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    link += " and ( yezhuid = '" + dt.Rows[i][0].ToString() + "'";
                                }
                                else
                                {
                                    link += " or yezhuid = '" + dt.Rows[i][0].ToString() + "'";
                                }
                            }
                            break;
                    }
                }
                link += " )";
            }
            else
            {
                link = "";
            }
            return link;
        }

        public string SearchYuangongName(string name, bool needwhere, string splitcon)
        {
            string link = "";
            DataSet DSet = SQLClass.getDataSet("select id from yuangong where xingming like '%" + name + "%'", "员工信息表");
            DataTable dt = DSet.Tables["员工信息表"];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    switch (splitcon)
                    {
                        case "yg":
                            if (needwhere)
                            {
                                needwhere = false;
                                link += " where ( id = '" + dt.Rows[i][0].ToString() + "'";
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    link += " and ( id = '" + dt.Rows[i][0].ToString() + "'";
                                }
                                else
                                {
                                    link += " or id = '" + dt.Rows[i][0].ToString() + "'";
                                }
                            }
                            break;
                        default:
                            if (needwhere)
                            {
                                needwhere = false;
                                link += " where ( yuangongid = '" + dt.Rows[i][0].ToString() + "'";
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    link += " and ( yuangongid = '" + dt.Rows[i][0].ToString() + "'";
                                }
                                else
                                {
                                    link += " or yuangongid = '" + dt.Rows[i][0].ToString() + "'";
                                }
                            }
                            break;
                    }
                }
                link += " )";
            }
            else
            {
                link = "";
            }
            return link;
        }

        public string SearchFangchanName(string name, bool needwhere, string splitcon)
        {
            string link = "";
            DataSet DSet = SQLClass.getDataSet("select id from fangchan where jianzu like '%" + name + "%'", "房产信息表");
            DataTable dt = DSet.Tables["房产信息表"];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    switch (splitcon)
                    {
                        default:
                            if (needwhere)
                            {
                                needwhere = false;
                                link += " where ( fangchanid = '" + dt.Rows[i][0].ToString() + "'";
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    link += " and ( fangchanid = '" + dt.Rows[i][0].ToString() + "'";
                                }
                                else
                                {
                                    link += " or fangchanid = '" + dt.Rows[i][0].ToString() + "'";
                                }
                            }
                            break;
                    }

                }
                link += " )";
            }
            else
            {
                link = "";
            }
            return link;
        }

        public string SearchKaifashangName(string name, bool needwhere, string splitcon)
        {
            string link = "";
            DataSet DSet = SQLClass.getDataSet("select id from kaifashang where gongsi like '%" + name + "%'", "开发商信息表");
            DataTable dt = DSet.Tables["开发商信息表"];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataSet fcDSet = SQLClass.getDataSet("select id from fangchan where kaifashangid = '" + dt.Rows[i][0].ToString() + "'", "房产信息表");
                    DataTable fcdt = fcDSet.Tables["房产信息表"];
                    if (fcdt.Rows.Count > 0)
                    {
                        for (int j = 0; j < fcdt.Rows.Count; j++)
                        {
                            switch (splitcon)
                            {
                                default:
                                    if (needwhere)
                                    {
                                        needwhere = false;
                                        link += " where ( fangchanid = '" + fcdt.Rows[i][0].ToString() + "'";
                                    }
                                    else
                                    {
                                        if (i == 0 && j == 0)
                                        {
                                            link += " and ( fangchanid = '" + fcdt.Rows[i][0].ToString() + "'";
                                        }
                                        else
                                        {
                                            link += " or fangchanid = '" + fcdt.Rows[i][0].ToString() + "'";
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                    else
                    {
                        link = "";
                    }
                }
                link += " )";
            }
            else
            {
                link = "";
            }
            return link;
        }

        public string SearchBumenName(string name, bool needwhere, string splitcon)
        {
            string link = "";
            DataSet DSet = SQLClass.getDataSet("select id from gangwei where bumen like '%" + name + "%'", "岗位信息表");
            DataTable dt = DSet.Tables["岗位信息表"];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    switch (splitcon)
                    {
                        default:
                            if (needwhere)
                            {
                                needwhere = false;
                                link += " where ( gangweiid = '" + dt.Rows[i][0].ToString() + "'";
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    link += " and ( gangweiid = '" + dt.Rows[i][0].ToString() + "'";
                                }
                                else
                                {
                                    link += " or gangweiid = '" + dt.Rows[i][0].ToString() + "'";
                                }
                            }
                            break;
                    }

                }
                link += " )";
            }
            else
            {
                link = "";
            }
            return link;
        }

        public string SearchGangweiName(string name, bool needwhere, string splitcon)
        {
            string link = "";
            DataSet DSet = SQLClass.getDataSet("select id from gangwei where gangwei like '%" + name + "%'", "岗位信息表");
            DataTable dt = DSet.Tables["岗位信息表"];
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    switch (splitcon)
                    {
                        default:
                            if (needwhere)
                            {
                                needwhere = false;
                                link += " where ( gangweiid = '" + dt.Rows[i][0].ToString() + "'";
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    link += " and ( gangweiid = '" + dt.Rows[i][0].ToString() + "'";
                                }
                                else
                                {
                                    link += " or gangweiid = '" + dt.Rows[i][0].ToString() + "'";
                                }
                            }
                            break;
                    }

                }
                link += " )";
            }
            else
            {
                link = "";
            }
            return link;
        }


        public string newsql(string splitcon, string son)
        {
            string newsql = "";
            switch(splitcon)
            {
                case "sy":
                    newsql = "select * from zhufang";
                    break;
                case "yz":
                    newsql = "select * from yezhu";
                    break;
                case "yg":
                    newsql = "select * from yuangong";
                    break;
                case "yw":
                    switch(son)
                    {
                        case "1":
                            newsql = "select * from richang";
                            break;
                        case "2":
                            newsql = "select * from fuwu";
                            break;
                        case "3":
                            newsql = "select * from shoufei";
                            break;
                    }
                    break;
            }
            return newsql;
        }
    }
}
