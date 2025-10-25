using ConsoleApp2.classes;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students do you want to enter? ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            GraduateStudent[] students = new GraduateStudent[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"\nEntering details for student {i + 1}:");
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Surname: ");
                string surname = Console.ReadLine();
                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter GPA: ");
                double gpa = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Thesis Title: ");
                string thesisTitle = Console.ReadLine();
                students[i] = new GraduateStudent(name, surname, age, gpa, thesisTitle);
            }

            bool isworking = true;

            while (isworking)
            {
                Console.Write("\nWhat do you want to do?\n1. Filter based on GPA \n2. Show all students \n3. Update GPA for a student\n0. Quit  (1 or 2 or 3 or 0): ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nFiltered students:\n");
                        for (int i = 0; i < numberOfStudents; i++)
                        {
                            for (int j = i + 1; j < numberOfStudents; j++)
                            {
                                if (students[i].GPA < students[j].GPA)
                                {
                                    var temp = students[i];
                                    students[i] = students[j];
                                    students[j] = temp;
                                }
                            }
                        }

                        foreach (var student in students)
                        {
                            GraduateStudent.GraduateDetails(student);
                        }
                        break;

                    case 2:
                        Console.WriteLine("\nAll Students:\n");
                        foreach (var student in students)
                        {
                            GraduateStudent.GraduateDetails(student);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nEnter the name of the student whose GPA you want to update: \n");
                        int counter = 1;
                        foreach (var student in students)
                        {
                            Console.WriteLine($"{counter})Name:{student.Name}, Surname:{student.Surname}, GPA:{student.GPA}");
                            counter++;
                        }

                        var chosenStudent = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the new GPA: ");
                        double newGPA = Convert.ToDouble(Console.ReadLine());

                        students[chosenStudent - 1].UpdateGPA(newGPA);

                        Console.WriteLine("Modified successfully");
                        break;

                    case 0:
                        Console.WriteLine("Exiting the program.");
                        isworking = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Exiting the program.");
                        break;
                }
            }
            
        }
    }
}
