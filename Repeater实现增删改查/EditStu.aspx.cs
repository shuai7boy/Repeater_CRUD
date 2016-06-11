using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rep.BLL;
using Rep.Model;

namespace Repeater实现增删改查
{
    public partial class EditStu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //页面加载时 将数据显示到页面上
            if (!IsPostBack)
            {
           if (!String.IsNullOrEmpty(Request.QueryString["id"]))
            {
                int id = int.Parse(Request.QueryString["id"]);
                RepStuBLL bll = new RepStuBLL();
                Student s = bll.SelectStu(id);
                this.txtName.Text = s.StuName;
                this.txtAge.Text = s.StuAge.ToString();
                ViewState["ID"] = s.StuId;
            }
            else
            {
                Response.Write("该数据不存在");
            }
            }
         
        }
        //更新编辑数据
        protected void Button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            string strName =this.txtName.Text.Trim();
            string strAge = this.txtAge.Text.Trim();
            s.StuId=Convert.ToInt32(ViewState["ID"]);           
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtAge.Text))
            {
                Context.Response.Write("不能保存空数据，请填好值后再更新~");
                return;
            }
            else
            {
                s.StuName = txtName.Text;
                s.StuAge = int.Parse(txtAge.Text);
                RepStuBLL bll = new RepStuBLL();
                if (bll.UpdateStu(s))
                {
                    Response.Redirect("Main.aspx");
                }
                else
                {
                    Response.Write("更新失败!");
                }
            }
        }
    }
}