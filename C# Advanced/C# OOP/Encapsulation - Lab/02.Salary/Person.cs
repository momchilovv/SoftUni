namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public string FirstName
        {
            get { return firstName; }
            private set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            private set { lastName = value; }
        }
        public int Age  
        {
            get { return age; }
            private set { age = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            private set { salary = value; }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (age > 30)
            {
                salary += (salary * percentage) / 100;
            }
            else
            {
                salary += (salary * percentage) / 200;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {salary:f2} leva.";
        }
    }
}