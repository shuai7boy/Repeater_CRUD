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
    public partial class AddStu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //增加一个学生
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Student s=new Student();
            s.StuName = this.TextBox1.Text;
            s.StuAge = int.Parse(this.TextBox2.Text);
            RepStuBLL bll = new RepStuBLL();
            bool b=bll.AddStu(s);
            if (b)
            {
                Response.Redirect("Main.aspx");
            }
            else
            {
                Response.Write("添加失败！");
            }
        }
    }
}