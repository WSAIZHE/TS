using HPIT.Data.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Test.EF.DAL
{
    public class StudentPageDal
    {
        public static StudentPageDal Instance = new StudentPageDal();

        public Student context { get; set; }

        public StudentPageDal()
        {
            this.context = new Student();
        }

        public object GetPageData(SearchModel<Student> search, out int count)
        {
            GetPageListParameter<Student, int> parameter = new GetPageListParameter<Student, int>();
            parameter.isAsc = true;
            parameter.orderByLambda = t => t.Id;
            parameter.pageIndex = search.PageIndex;
            parameter.pageSize = search.PageSize;
            parameter.whereLambda = t => t.Id != 0;
            Model1 Instance = new Model1();
            DBBaseService baseService = new DBBaseService(Instance);
            List<Student> list = baseService.GetSimplePagedData<Student, int>(parameter, out count);
            return list;
        }
    }
}