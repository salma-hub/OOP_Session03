#region Video1
// PhoneBook  PhoneBook = new  PhoneBook(3);
// PhoneBook.AddPerson("bob", 01234555, 0);
////using indexer property
//PhoneBook["Ahmed"] = 9886543;

////Console.WriteLine( PhoneBook.GetPhoneNumber("cc"));
////Console.WriteLine(PhoneBook["Ahmed"]);
//Console.WriteLine(PhoneBook[1]);
#endregion
#region video2
//Car car = new Car(10, "tesla", 200);
#endregion
#region video3
//Child c = new Child(12, 13, 13);
//Console.WriteLine(c.Product());
#endregion
//Assignment

Employee[] EmpArr = new Employee[3];
        EmpArr[0] = new Employee(1, "Ali", Gender.M, SecurityLevel.DBA, 20000, new HiringDate(1, 1, 2000));
        EmpArr[1] = new Employee(2, "Sara", Gender.F, SecurityLevel.guest, 6000, new HiringDate(15, 3, 2001));
        EmpArr[2] = new Employee(3, "Omar", Gender.M, SecurityLevel.securityOfficer, 25000, new HiringDate(5, 7, 20021));
        foreach (Employee emp in EmpArr)
        {
            Console.WriteLine(emp);
        }
   

