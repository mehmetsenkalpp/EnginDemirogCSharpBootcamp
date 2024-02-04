using Bootcamp_1.Gün.Entities;

Console.WriteLine("Hello, World!");

//Değişkenler
string message1 = "Krediler";
int term = 12;
double amount = 100000;
//camelCase yazım tipi
bool isAuthenicated = false;

//condition
if (isAuthenicated == true)
{
    Console.WriteLine("Buton-->Hoşgeldin Mehmet");
}
else
{
    Console.WriteLine("Buton-->Sisteme Giriş Yap");
}


//arrays
string[] loans = { "kredi1" ,"kredi2","kredi3"};

//loops
for (int i = 0; i <= loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

//oop
Course course1 = new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = "C# kursu";

Course course2 = new Course();
course2.Id = 1;
course2.Name = "Python";
course2.Description = "python kursu";

Course[] courses = { course1, course2 };

for(int c = 0; c <= courses.Length; c++)
{
    Console.WriteLine(courses[c].Name);
}