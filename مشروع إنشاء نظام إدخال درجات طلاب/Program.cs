using System;

namespace مشروع_إنشاء_نظام_إدخال_درجات_طلاب
{
    class MainClass
    {
        public static void Main(string[] args)
        {
                string continu = "Y";

                while(continu == "Y")
            {
                student student = new student();
                Console.WriteLine("Please enter the name?");
                student.name = Console.ReadLine();
                Console.WriteLine("Please enter a grade?");
                student.grade = int.Parse(Console.ReadLine());


                Console.WriteLine(student + " is " + student.PassedorNot);

                Console.WriteLine("do you need add more?");
                continu = Console.ReadLine().ToUpper();
            }

            
        }
    }
    class student
        {
          public string name { get; set; }
          public int grade { get; set; }
          public string PassedorNot { get { string result = (grade <= 60) ?  "faild" : "passed"; return result; } }

    }
    }

