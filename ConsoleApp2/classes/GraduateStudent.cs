namespace ConsoleApp2.classes
{
    internal class GraduateStudent : Student
    {
        public string ThesisTitle;
        public GraduateStudent(string name, string surname, int age, double gpa, string thesisTitle)
            : base(name, surname, age, gpa)
        {
            ThesisTitle = thesisTitle;
        }

        public GraduateStudent(string thesisTitle)
        {
            ThesisTitle = ThesisTitle;
        }



        public static void GraduateDetails(GraduateStudent gradStudent)
        {
            Console.WriteLine($"Name: {gradStudent.Name}, Surname: {gradStudent.Surname}, Age: {gradStudent.Age}, GPA: {gradStudent.GPA}, Thesis Title: {gradStudent.ThesisTitle}");
        }
    }
}
