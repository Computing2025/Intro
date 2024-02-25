


using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

IndividualCustomer customer1 = new()
{
    Id = 1,
    CustomerNumber = "232423",
    FirstName = "John",
    LastName = "Doe",
    NationalIdentity = "3563634635463"
};

IndividualCustomer customer2 = new()
{
    Id = 2,
    CustomerNumber = "93827",
    FirstName = "Rose Mary",
    LastName = "Solemnick",
    NationalIdentity = "11239889732"
};

CorporateCustomer customer3 = new()
{
    Id=3,
    Name = "Volkswagen",
    CustomerNumber= "24323",
    TaxNumber = "4252139"
};

CorporateCustomer customer4 = new()
{
    Id = 4,
    Name = "Renault",
    CustomerNumber = "94348",
    TaxNumber = "2023939"
};



CourseManager courseManager = new(new EfCourseDal());

List<Course> courses = courseManager.GetAll(); 

for(int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}







/*
BaseCustomer[] customers = [ customer1, customer2, 
                             customer3, customer4 ];

foreach (BaseCustomer customer in customers)
{
  if (customer is IndividualCustomer)
     Console.WriteLine(((IndividualCustomer)customer!).FirstName);
  else
     Console.WriteLine(((CorporateCustomer)customer!).TaxNumber);
}


*/