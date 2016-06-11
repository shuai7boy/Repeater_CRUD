using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rep.DAL;
using Rep.Model;

namespace Rep.BLL
{
    public class RepStuBLL
    {
        //调用数据访问层 并实现逻辑处理
        RepStuDal dal = new RepStuDal();
        public List<Student> SelectByPage(int pageIndex, int pageSize, out int pageCount,out  int recordCount)
        {
            return dal.SelectByPage(pageIndex, pageSize,out pageCount,out recordCount);
        }
        public Student SelectStu(int id)
        {
            return dal.SelectStu(id);
        }
        public bool UpdateStu(Student s)
        {
            return dal.UpdateStu(s) > 0;
        }
        public bool DeleteById(int id)
        {
            return dal.DeleteById(id) > 0;
        }
        public bool AddStu(Student stu)
        {
            return dal.AddStu(stu) > 0;
        }
    }
}
