namespace csharp;

public delegate bool IsPromotable(Employee employee);
public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; } = "";
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach (var employee in employeeList)
        {
            if (IsEligibleToPromote(employee))
            {
                Console.WriteLine($"{employee.Name} promoted");
            }
        }
    }
}