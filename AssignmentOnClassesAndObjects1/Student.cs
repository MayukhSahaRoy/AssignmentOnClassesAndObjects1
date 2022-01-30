using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnClassesAndObjects1
{
    class Student
    {
        public string rollno;
        public string name;
        public string Class;
        public string SEM;
        public string branch;
        public int[] marks= new int[5];

        public void displayresult()
        {
            int total = 0;
            foreach(int i in marks)
            {
                total = total + i;
            }
            int avg = total / 5;
            int flag = 0;
            foreach(int i in marks)
            {
                if (i < 35)
                    flag = 1;
            }
            if (flag == 1)
                Console.WriteLine("Failed");
            else if (avg < 50)
                Console.WriteLine("Failed");
            else
                Console.WriteLine("Passed");
        }

        public Student(string rollno, string name, string Class, string SEM, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.Class = Class;
            this.SEM = SEM;
            this.branch = branch;
        }

        public void display_data()
        {
            Console.WriteLine("The roll number is: " + rollno);
            Console.WriteLine("The name of the student is: " + name);
            Console.WriteLine("The student is in class: " + Class);
            Console.WriteLine("The student is in semester: " + SEM);
            Console.WriteLine("The branch of the student is: " + branch);
        }
    }

    class Test_Student
    {
        static void Main()
        {
            Student p1 = new Student("1804447","Mayukh","lastyear","8th","ETC");
            Console.WriteLine("Enter marks of 5 subjects:");
            for(int a=0;a<5;a++)
            {
                p1.marks[a] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The result is: ");
            p1.displayresult();
            Console.WriteLine("The information details of the student:");
            p1.display_data();
            Console.ReadKey();
        }
    }
}
