using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rep.Model;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Rep.DAL
{
    public class RepStuDal
    {
        //分页查询 根据id进行查询 跟新 根据id删除 增加
        //----分页查询
        public List<Student> SelectByPage(int pageIndex,int pageSize,out int pageCount,out int recordCount)
        {
            string sql = "usp_FenYe";           
            SqlParameter[] pms = new SqlParameter[] { 
            new SqlParameter("@pageIndex",SqlDbType.Int){Value=pageIndex},
            new SqlParameter("@pageSize",SqlDbType.Int){Value=pageSize},
            new SqlParameter("@pageCount",SqlDbType.Int){Direction=ParameterDirection.Output},
            new SqlParameter("@recordCount",SqlDbType.Int){Direction=ParameterDirection.Output}
            };
            List<Student> list = new List<Student>();
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, CommandType.StoredProcedure, pms))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Student s = new Student();
                        s.StuId=reader.GetInt32(0);
                        s.StuName=reader.GetString(1);
                        s.StuAge=reader.GetInt32(2);
                        list.Add(s);
                    }
                }
            }
            pageCount = Convert.ToInt32(pms[2].Value);
            recordCount = Convert.ToInt32(pms[3].Value);
            return list;

        }
        //---根据id进行查询
        public Student SelectStu(int id)
        {
            string sql = "select *from Student where StuId=@id;";
            SqlParameter pms = new SqlParameter("@id", SqlDbType.Int) { Value = id };
            Student s = new Student();
            using (SqlDataReader reader=SqlHelper.ExecuteReader(sql, CommandType.Text, pms))
            {
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        s.StuId = reader.GetInt32(0);
                        s.StuName = reader.GetString(1);
                        s.StuAge = reader.GetInt32(2);
                    }
                }
            }
            return s;
        }
        //---更新语句
        public int UpdateStu(Student s)
        {
            string sql = "update Student set StuName=@name,StuAge=@age where StuId=@id;";
            SqlParameter[] pms = new SqlParameter[]{
                new SqlParameter("@name",SqlDbType.NVarChar,8){Value=s.StuName},
                new SqlParameter("@age",SqlDbType.Int){Value=s.StuAge},
                new SqlParameter("@id",SqlDbType.Int){Value=s.StuId}
            };
           return SqlHelper.ExecuteNonquery(sql, CommandType.Text, pms);
        }
        //---根据id进行删除
        public int DeleteById(int id)
        {
            string sql = "delete Student where StuId=@id;";
            SqlParameter pms = new SqlParameter("@id", SqlDbType.Int) { Value = id };
            return SqlHelper.ExecuteNonquery(sql, CommandType.Text, pms);
        }
        //---增加一条语句
        public int AddStu(Student stu)
        {
            string sql = "insert into Student values(@name,@age)";
            SqlParameter[] pms = new SqlParameter[]{                
                new SqlParameter("@name",SqlDbType.NVarChar,8){Value=stu.StuName},
                new SqlParameter("@age",SqlDbType.Int){Value=stu.StuAge}
            };
            return SqlHelper.ExecuteNonquery(sql, CommandType.Text, pms);
        }
    }
}
