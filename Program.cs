namespace Job
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Brown", "Roxy", 25000);
            Boss boss = new Boss("Audy", "Amina", "Plieva", 31000);
            EmployeesTrainees employeesTrainees = new EmployeesTrainees(5, 6, "Mustik", "Ganiev", 2000);
            employee.Work();
            employee.Pause();
            boss.Lead();
            employeesTrainees.Work();
            employeesTrainees.Learn();

        }
    }
}