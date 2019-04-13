using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        public class Student
        {
            private string _Name;
            private string _Sex;
            private int _Age;
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
            public string Sex
            {
                get { return _Sex; }
                set 
                {
                    if (value != "男" || value != "nv")
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
            public Student() { }
            public Student(string name)
            {
                Name=name;
                Sex = "男";
                Age = 0;
            }
            public Student(string name, string sex)
            {
                Name = name;
                Sex = sex;
                Age = 0;
            }
            public Student(string name, string sex, int age)
            {
                Name = name;
                Sex = sex;
                Age = age;
            }
            public void Show()
            {
                Console.WriteLine("姓名：{0}   性别：{1}   年龄：{2}", Name, Sex, Age);
            }
        }
        static void Main(string[] args)
        {
            Student stu1 = new Student("cherry", "女", 21);
            Student stu = new Student();
            stu.Name = "spring";
            stu.Sex = "男";
            stu.Age = 19;
            stu.Show();
            stu1.Show();
            Console.ReadKey();
        }
    }
}
