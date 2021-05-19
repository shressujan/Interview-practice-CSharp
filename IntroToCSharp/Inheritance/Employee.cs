namespace Inheritance
{
    public class Employee
    {
        protected string firstName;

        protected string lastName;

        protected char sex;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public char Sex
        {
            get => sex;
            set => sex = value;
        }

        public override string ToString()
        {
            return "FirstName: " + firstName +
                   " LastName: " + lastName +
                   "\nSex: " + sex;
        }
    }
}