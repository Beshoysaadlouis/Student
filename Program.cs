using System;

namespace A1_C_sharp
{
    //Beshoy Saad  Louis


    class Student
    {

        public string name;
        public int Age;
        public int ID;
        public double[] courses = new double[6];
        public int level;
        public int age
        {
            get { return 2022 - Age; }
        }
        public double GPA
        {
            get
            {
                double s = 0;
                foreach (double var in courses)
                {
                    s += var;
                }
                return (s * 3) / 3;
            }
        }
        static void Main()
        {
            Student[] s1 = new Student[10];
            for (int i = 0; i < 10; i++)
            {
                s1[i] = new Student();
                Console.WriteLine("Please Enter your Name");
                s1[i].name = Console.ReadLine();
                Console.WriteLine("Please Enter your ID");
                s1[i].ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter your level");
                s1[i].level = int.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter your year of birth");
                s1[i].Age = int.Parse(Console.ReadLine());
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine("Enter your Course points");
                    s1[i].courses[j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("---------------------" + "Student " + i + "---------------------");
                Console.WriteLine("Student Name: " + s1[i].name);

                Console.WriteLine("Student ID: " + s1[i].ID);

                Console.WriteLine("Student level");

                Console.WriteLine("Student AGE: " + s1[i].age);
                Console.WriteLine("Student GPA: " + s1[i].GPA);
                Console.WriteLine("/n_____________________/n");
            }
        }
    }

}



