using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Student
    {
        string studentID;
        string fullName;
        float averageScore;
        string faculty;

        public string StudentID { get => studentID; set => studentID = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Faculty { get => faculty; set => faculty = value; }

        public Student()
        {

        }
        public Student(string studentID, string fullName, float averageScore, string faculty)
        {
            this.studentID = studentID;
            this.fullName = fullName;
            this.averageScore = averageScore;
            this.faculty = faculty;
        }
        public void Input()
        {
            Console.Write("Nhap MSSV: ");
            StudentID = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            FullName = Console.ReadLine();
            Console.Write("Nhap diem trung binh: ");
            AverageScore = float.Parse(Console.ReadLine());
            Console.Write("Nhap khoa: ");
            Faculty = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("MSSV: {0}\t Ho ten: {1}\t Khoa: {2}\t Diem TB: {3}",
                this.StudentID, this.FullName, this.Faculty, this.AverageScore);
        }
    }
}
