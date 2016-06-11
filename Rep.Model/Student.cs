using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rep.Model
{
   public class Student
    {
       private int _stuId;
       public int StuId
       {
           get { return _stuId; }
           set { _stuId = value; }
       }
       private string _stuName;
       public string StuName 
       {
           get { return _stuName; }
           set { _stuName = value; }
       }     
       public int _stuAge;
       public int StuAge
       {
           get { return _stuAge; }
           set { _stuAge = value; }
       }
    }
}
