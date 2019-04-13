using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    class Program
    {
        public struct Student
        {
            private string _Name;
            private string _Sex;
            private int _Age;
            public string Name
            {
                get { return _Name;}
                set { _Name = value; }
            }
            public string Sex
            {
                get { return _Sex; }
                set
                {
                    if (value != "男" && value != "女")
                        _Sex = "男";
                    else
                        _Sex = value;
                }
            }
            public int Age
            {
                get { return _Age; }
                set
                {
                    if (value >= 0 && value <= 100)
                        _Age = value;
                    else
                        _Age = 18;
                }
            }
            //使用了构造函数，就必须要使用带参构造函数来使用结构体。
            public Student(string name, string sex, int age)
            {
                _Name = name;
                _Sex = sex;
                _Age = age;
            }
            public void Show()
            {
                Console.WriteLine("姓名:{0} 性别:{1} 年龄:{2}", Name, Sex, Age);
            }
        }
        static void Main(string[] args)
        {
            Student stu=new Student("spring","男",19);
            stu.Show();
            Console.ReadKey();

            /*
             * 使用如下代码即报错
             *Student stu1;
             *stu1.Name = "spring";
             *stu1.Age = 19;
             *stu1.Sex = "男";
            */
        }
    }
}
