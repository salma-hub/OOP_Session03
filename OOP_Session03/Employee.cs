

    public class Employee
    {
    //define attributes
    public int Id { get; set; }
    public string name { get; set; }
    SecurityLevel security_level;
    Gender gender;
    decimal salary;
    HiringDate hiring_date;
    //constructor
    public Employee(int id, string name, Gender gender, 
        SecurityLevel level, decimal salary, HiringDate hireDate)
    {
        Id = id;
        this.name = name;
        this.gender = gender;
        security_level = level;
        this.salary = salary;
        hiring_date = hireDate;
    }
    //override toString func
    public override string ToString()
    {
        return $"The date of Employe is\n Id is :{Id},Name {name},gender {gender}," +
            $" SecurityLevel {security_level}, hiringDate {hiring_date} and salary {String.Format("{0:C}", salary)}";
    }
   
}
