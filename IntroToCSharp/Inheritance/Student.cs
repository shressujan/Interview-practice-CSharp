namespace Inheritance
{
    public class Student: Employee
    {
        private int studentId;
        private string department;

        public int StudentId
        {
            get => studentId;
            set => studentId = value;
        }

        public string Department
        {
            get => department;
            set => department = value;
        }

        public override string ToString()
        {
            return base.ToString() + "\nStudentID: " + studentId +"\n" +
                   "Department: " + department;
        }
    }
}