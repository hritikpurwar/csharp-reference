// See https://aka.ms/new-console-template for more information


using csharp;

Console.WriteLine("Hello, World!");
Dictionary<ResourceType, int> newDictionary = new ()
{
    { ResourceType.wood, 25 },
    { ResourceType.gold, 10 }
};
foreach (var dict in newDictionary)
{
    Console.WriteLine($"{dict.Key} : {dict.Value}");
}
Console.WriteLine(newDictionary[ResourceType.gold]);
Console.WriteLine(newDictionary.ContainsKey(ResourceType.stone));
var succeeded = newDictionary.TryGetValue(ResourceType.stone, out var value);
Console.WriteLine(succeeded ? $"value is {value}" : "no value found");
newDictionary[ResourceType.plastic] = 5;
newDictionary.Remove(ResourceType.wood);
foreach (var key in newDictionary.Keys)
{
    Console.WriteLine($"{key} : {newDictionary[key]}");
}
Console.WriteLine("-------------------------------------");
Implements myClass = new ();
I1 i1 = new Implements();
I2 i2 = new Implements();
((I1)myClass).InterfaceMethod();
((I2)myClass).InterfaceMethod();
i1.InterfaceMethod();
i2.InterfaceMethod();
Console.WriteLine("-------------------------------------");
AB ab = new();
ab.AMethod();
ab.BMethod();
Console.WriteLine("-------------------------------------");
DelegatesClass a = new();
a.Call();

Console.WriteLine("-------------------------------------");
List<Employee> employeesList = new();
employeesList.Add(new Employee(){ ID = 1, Experience = 3, Name = "Eren Jaeger", Salary = 50000});
employeesList.Add(new Employee(){ ID = 2, Experience = 6, Name = "Armin Arlelt", Salary = 45000});
employeesList.Add(new Employee(){ ID = 3, Experience = 3, Name = "Mikasa Ackermann", Salary = 45000});
employeesList.Add(new Employee(){ ID = 4, Experience = 10, Name = "Levi Ackermann", Salary = 60000});

Employee.PromoteEmployee(employeesList, emp => emp.Experience >= 5);

// IsPromotable isPromotable = new IsPromotable(PromoteEmployee); 
// Employee.PromoteEmployee(employeesList, isPromotable);

// bool PromoteEmployee(Employee emp)
// {
//     return emp.Experience >= 5;
// }

internal enum ResourceType
{
    stone,
    wood,
    gold,
    plastic
};