using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chon;
            List<Student> studentList = new List<Student>();
            //DSSV DSStudent = new DSSV();
            do
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Hien thi danh sach sinh vien");
                Console.WriteLine("3. Thong tin sinh vien thuoc khoa CNTT");
                Console.WriteLine("4. Thong tin sinh vien co diem TB lon hon bang 5");
                Console.WriteLine("5. Danh sach sinh vien sap xep theo diem trung binh tang dan");
                Console.WriteLine("6. Danh sach sinh vien co diem trung binh lon hon bang 5 va thuoc khoa CNTT");
                Console.WriteLine("7. Danh sach sinh vien co diem trung binh cao nhat va thuoc khoa CNTT");
                Console.WriteLine("8. So luong cua tung xep loai trong danh sach theo thang diem 10");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon chuc nang (1-8): ");

                Student a = new Student();

                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        AddStudent(studentList);
                        break;
                    case 2:
                        DisplayStudentList(studentList);
                        break;
                    case 3:
                        DisplayStudentsByFaculty(studentList, "CNTT");
                        
                        break;
                    case 4:
                        DisplayStudentsWithHightAverageScore(studentList, 5);
                        break;
                    case 5:
                        SortStudentsByAverageScore(studentList);
                        break;
                    case 6:
                        DisplayStudentsByFacultyAndScore(studentList, "CNTT", 5);
                        break;
                    case 7:
                        DisplayStudentsWithHightestAverageScoreByFaculty(studentList, "CNTT");
                        break;
                    /*case "8":
                        SoLuongOfXepLoai();
                        break;*/
                    case 0:
                        Console.WriteLine("Ket thuc chuong trinh");
                        break;
                }
                Console.WriteLine();
            } while (chon != 9);
            
        }

        //Console.WriteLine("1. Them sinh vien");
        static void AddStudent(List<Student> studentList)
        {
            Console.WriteLine("=== Nhap thong tin sinh vien ===");
            Student student = new Student();
            student.Input();
            studentList.Add(student);
            Console.WriteLine("Them sinh vien thanh cong!");
        }

        //Console.WriteLine("2. Hien thi danh sach sinh vien");
        static void DisplayStudentList(List<Student> studentList)
        {
            Console.WriteLine("=== Danh sach chi tiet thong tin sinh vien ===");
            foreach (Student student in studentList)
            {
                student.Output();
            }
        }

        //Console.WriteLine("3. Thong tin sinh vien thuoc khoa CNTT");
        static void DisplayStudentsByFaculty(List<Student> studentList, string faculty)
        {
            Console.WriteLine("=== Danh sach sinh vien thuoc khoa {0} ===", faculty);
            var students = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayStudentList(students);
        }

        //Console.WriteLine("4. Thong tin sinh vien co diem TB lon hon bang 5");      
        static void DisplayStudentsWithHightAverageScore(List<Student> studentList, float minDTB)
        {
            Console.WriteLine("=== Danh sach sinh vien co diem TB >= {0} ===", minDTB);
            var students = studentList.Where(s => s.AverageScore >= minDTB).ToList();
            DisplayStudentList(students);
        }

        //Console.WriteLine("5. Danh sach sinh vien sap xep theo diem trung binh tang dan");
        static void SortStudentsByAverageScore(List<Student> studentList)
        {
            Console.WriteLine("=== Danh sach sinh vien duoc sap xep theo diem TB tang dan ===");
            var sortedStudents = studentList.OrderBy(s => s.AverageScore).ToList();
            DisplayStudentList(sortedStudents);
        }

        //Console.WriteLine("6. Danh sach sinh vien co diem trung binh lon hon bang 5 va thuoc khoa CNTT");
        static void DisplayStudentsByFacultyAndScore(List<Student> studentList, string faculty, float minDTB)
        {
            Console.WriteLine("=== Danh sach sinh vien co diem TB >= {0} va thuoc khoa {1} ===", minDTB, faculty);
            var students = studentList.Where(s => s.AverageScore >= minDTB && s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayStudentList(students);
        }

        //Console.WriteLine("7. Danh sach sinh vien co diem trung binh cao nhat va thuoc khoa CNTT");
        static void DisplayStudentsWithHightestAverageScoreByFaculty(List<Student> studentList, string faculty)
        {
            float maxDTB = 0;
            Console.WriteLine("=== Danh sach sinh vien co diem TB cao nhat >= {0} va thuoc khoa {1} ===", maxDTB, faculty);
            var students = studentList.Where(s => s.AverageScore >= maxDTB && s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayStudentList(students);
        }

        //Console.WriteLine("8. So luong cua tung xep loai trong danh sach theo thang diem 10");
    }
}
