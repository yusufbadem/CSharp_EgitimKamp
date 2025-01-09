



#region Foreach Döngüsü 

//string[] cities = { "istanbul", "milano", "budapeşte", "roma" };

//foreach (var city in cities)
//{
//    Console.WriteLine(city);
//}
//int[] numbers = { 1, 2, 4, 5, 6, 7, 8, 9, 23, 2, 3, 23, 23, 66};

//foreach (var number in numbers)
//{
//    Console.WriteLine(number);
//}

//int[] numbers = { 1, 2, 4, 5, 6, 7, 8, 9, 23, 2, 3, 23, 23, 66 };

//foreach (var number in numbers)
//{
//    if (number %2 == 0)
//    {
//        Console.WriteLine(number);
//    }
//}

//int[] numbers = { 1, 2, 4, 5, 6, 7, 8, 9, 23, 2, 3, 23, 23, 66 };
//int total = 0;
//foreach (var i in numbers)
//{
//    total += i;
//}
//Console.WriteLine(total);
#endregion

#region Liste Yapısı
//List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

//foreach (int item in numbers)
//{
//    Console.WriteLine(item);
//}


//string word = "MErhaba";
//foreach (char c in word)
//{
//    Console.WriteLine(c);
//}
#endregion


#region Örnek Sınav Sistemi Uygulaması

Console.WriteLine("** C# egitim kampı uygulaması");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("---------------------------");
Console.WriteLine("Sınıfınızda kaç ögrenci var");
int studentCount=int.Parse(Console.ReadLine());

Console.WriteLine("-------------------------");

//ögrenci isimlerini ve not ortalamalarını saklayacak diziler
string[] studentNames=new string[studentCount];
double[] studentExamAvg=new double[studentCount];

for (int i = 0; i < studentCount; i++)
{
    Console.Write($"{i+1}. ögrencinin ismini giriniz :");
    studentNames[i] = Console.ReadLine();

    double totalExamResult = 0;

    //her ögrenci için 3 sınav notu girişi
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{studentNames[i]} adlı ögrencinin {j+1}.ci notunu giriniz :");
        double value=double.Parse(Console.ReadLine());
        totalExamResult += value; //notları topluyoruz
    }
    Console.WriteLine();
    studentExamAvg[i] = totalExamResult/3;
}
//ögrencinin ortalamsı hesabı
for (int i = 0; i < studentCount; i++)
{
    Console.WriteLine($"{studentNames[i]} adlı ögrencinin ortalaması : {studentExamAvg[i]}" );
    //ögrencilerin ortalaması ve geçip geçmediginin durumları

    if (studentExamAvg[i]>=50)
    {
        Console.WriteLine($"{studentNames[i]} adlı ögrenci dersi geçti :");
    }
    else
    {
        Console.WriteLine($"{studentNames[i]} adlı ögrenci dersten kaldı :");
    }
    Console.WriteLine("-----------------");

}


#endregion
