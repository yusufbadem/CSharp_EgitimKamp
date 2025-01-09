internal class Program
{
    private static void Main(string[] args)
    {
        #region Void Metodlar
        //void CustomerList()
        //{
        //    Console.WriteLine("Ali Sarı");
        //    Console.WriteLine("Mehmet Beyaz");
        //    Console.WriteLine("Salih Kara");
        //}

        //CustomerList();
        //CustomerList();

        //void Sum()
        //{
        //    int x = 3;
        //    int y = 5;
        //    int Sum = x+y;
        //    Console.WriteLine(x+y);
        //}

        //Sum();

        #endregion

        #region Geriye deger döndürmeyen string Parametreli Metodlar

        //void WriteMEthod(string customerName)
        //{
        //    Console.WriteLine(customerName);
        //}

        //WriteMEthod("MEhmet Yıldız");


        //void CustomerCard(string name,string Surname)
        //{
        //    Console.WriteLine("Müşteri :" + name + " " + Surname);
        //}

        //CustomerCard("Mehmet","Yıldız");
        //CustomerCard("Ali","Kaya");
        #endregion

        #region Geriye deger döndürmeyen int Parametreli Metodlar
        //void Sum(int number1 ,int number2,int number3)
        //{
        //    int result = number1 + number2 + number3;
        //    Console.WriteLine(result);
        //}

        //Sum(2,3,4);

        #endregion


        #region Geriye deger Döndüren metotlar
        //string CustomerName()
        //{
        //    return "Buse Yıldız";
        //}
        //CustomerName(); // Burada deger döner ama yazdıramayız


        //string CustomerName()
        //{
        //    string name = "Ali";
        //    string surname = "Kaya";

        //    return name+" "+surname;
        //}

        //Console.WriteLine(CustomerName());
        #endregion

        #region Geriye Deger Döndüren PArametreli MEtodlar

        //string CountryCard(string countryName,string capital,string flagColor)
        //{
        //    string cardInfo="Ülke :"+countryName + " - Başkent :" + capital + " -Bayrak Rengi :" + flagColor;

        //    return cardInfo;
        //}

        //// Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı Beyaz"));

        //Console.Write("Ülke adı giriniz :");
        //string x= Console.ReadLine();

        //Console.Write("Başkenti giriniz :");
        //string y= Console.ReadLine();

        //Console.Write("Bayrak Rengi Giriniz :");
        //string z= Console.ReadLine();

        //Console.WriteLine(CountryCard(x,y,z));
        #endregion

        #region Geriye Deger Döndüren Int PArametreli MEtodlar

        //int Sum(int number1,int number2)
        //{
        //    int result=number1 + number2;
        //    return result;
        //}

        //Console.WriteLine(Sum(45,50));
        //Console.WriteLine(Sum(100,50));
        #endregion

        #region Örnek Uyglulama
        //string ExamREsult(string student,int exam1,int exam2,int exam3)
        //{
        //    int result = (exam1 + exam2 + exam3) / 3;

        //    if (result>=50)
        //    {
        //        return $"Ögrenci: {student} sınavı geçti. Ortalaması :{result}" ;
        //    }
        //    return $"Ögrenci :{student} başarısız oldu.Ortalamsı {result}";

        //}

        //Console.WriteLine(ExamREsult("Ali",24,45,44));
        //Console.WriteLine(ExamREsult("Ayşe",44,55,98));



        #endregion

        Console.Read();
    }
}