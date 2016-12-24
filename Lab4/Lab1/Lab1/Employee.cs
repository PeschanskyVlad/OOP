using System;


namespace Lab1
{
    [Serializable]
    public class Employee : Adult, UsefulActivity, Relax , IComparable<Employee> , IDisposable
    {

        public Employee()
        {

        }

        public Employee(string name, int age, double mass, string sex) : base(name, age, mass, sex)
        {

        }

        public string working()
        {
            return "salary";
        }

        public string spendMoney()
        {
            Console.WriteLine("Spending money...");
            return "Successfully spent!";
        }

        public void learnMatan()
        {
            Console.WriteLine("Life is pointless.");
            degrade();
        }

        public void writeLabs()
        {
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i + "...");
            }
            Console.WriteLine("All done.");
        }

      


        public void elevateMind()
        {
            Console.WriteLine("Read some useful information");
        }


        public int CompareTo(Employee obj)
        {        
            return this.age.CompareTo(obj.age);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }


}
