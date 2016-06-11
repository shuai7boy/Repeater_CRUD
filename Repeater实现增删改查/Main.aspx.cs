using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Rep.Model;
using Rep.BLL;

namespace Repeater实现增删改查
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
      //首先判断是否是首次加载 如果是 则根据分页加载数据
            if (!IsPostBack)
            {
                int pageIndex = String.IsNullOrEmpty(Request.QueryString["pageIndex"]) ? 1 : int.Parse(Request.QueryString["pageIndex"]);
                int pageSize = String.IsNullOrEmpty(Request.QueryString["pageSize"]) ? 4 : int.Parse(Request.QueryString["pageSize"]);
                int pageCount,recordCount;
                RepStuBLL bll = new RepStuBLL();
                List<Student> list = bll.SelectByPage(pageIndex, pageSize,out pageCount,out recordCount);
                Repeater1.DataSource = list;
                Repeater1.DataBind();
                //利用PageHelper实现分页
                string pageStr = PagerHelper.strPage(recordCount, pageSize, pageCount, pageIndex, "Main.aspx?pageSize=4&pageIndex=");
                Literal1.Text = pageStr;              
            }
        }
        //Repeater控件中的服务器端回发事件
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName=="delete")
            {
                int id =Convert.ToInt32(e.CommandArgument);
                //调用业务逻辑层执行删除语句
                RepStuBLL bll=new RepStuBLL();
                if (bll.DeleteById(id))
                {
                    Response.Redirect("Main.aspx");
                }
                else
                {
                    Response.Write("删除失败!");
                }
            }
        }
    }
}