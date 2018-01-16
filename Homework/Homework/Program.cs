using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        const string ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=homework1_16;Integrated Security=true;";
        static void Main(string[] args)
        {
            try
            {
                using(DataClasses1DataContext aDataContext=new DataClasses1DataContext(ConnectionString))
                {
                    if (!aDataContext.DatabaseExists())
                    {
                        aDataContext.CreateDatabase();
                        Console.WriteLine("数据库已经创建！");
                    }
                    else
                    {
                        Console.WriteLine("数据库已经存在！");
                    }
                    var aPersons = from r in aDataContext.Person select r;
                    foreach(Person aPerson in aPersons)
                    {
                        Console.WriteLine($"{aPerson.Name}:{aPerson.Number}");
                    }
                    if (aPersons == null)
                    {
                        Console.WriteLine("插入新记录……");
                        Person aNewPerson = new Person {Id="001", Name = "张三", Number = "13000000000", Memo = "Nothing" };
                        aDataContext.Person.InsertOnSubmit(aNewPerson);

                    }

                    Console.WriteLine("提交数据……");
                    aDataContext.SubmitChanges();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("按回车键退出……");
            Console.ReadLine();
        }
    }
}
