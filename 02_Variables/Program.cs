

//#region double degişkenler
////double number;

////number = 4.85;
////Console.WriteLine(number);




//Console.WriteLine("*******Fiyat Listesi");

//Console.WriteLine();

//double applePrice, orangePRice, strawberryPrice, tomatoPrice, patatoPrice;

//applePrice = 14.43;
//orangePRice = 12.23;
//strawberryPrice = 11.12;
//patatoPrice = 23.11;
//tomatoPrice = 23.11 ;

//Console.WriteLine("--Elma Birim Fiyatı "+applePrice +" TL");
//Console.WriteLine("--Portakal Birim Fiyatı "+ orangePRice+ " TL");
//Console.WriteLine("--Çilek Birim Fiyatı "+ strawberryPrice+" TL");
//Console.WriteLine("--Patates Birim Fiyatı "+ patatoPrice + " TL");
//Console.WriteLine("--Domates Birim Fiyatı "+ tomatoPrice + " TL");


//double sterberryGram, orangeGram, appleGram, PatetoGram, tomatoGram;

//appleGram = 1.235;
//orangeGram = 2.650;
//sterberryGram = 0.750;
//PatetoGram = 4.234;
//tomatoGram = 3.126;

//double appleTotalPrice = appleGram * applePrice;
//double orangeTotalPrice=orangePRice * orangeGram;
//double strawberryTotalPRice=strawberryPrice * sterberryGram;
//double patetoTotalPRice=patatoPrice * PatetoGram;
//double tomatoTotalPRice=tomatoPrice * tomatoGram;

//Console.WriteLine("Alınan Ürün =Elman "+"-Birim Fiyat :"+applePrice +"-Alınan Gramaj :" +appleGram+"-Toplam Maliyet :"+appleTotalPrice);
//Console.WriteLine("Alınan Ürün =Portakal "+"-Birim Fiyat :"+orangePRice +"-Alınan Gramaj :" +orangeGram+"-Toplam Maliyet :"+orangeTotalPrice);
//Console.WriteLine("Alınan Ürün =Çilek "+"-Birim Fiyat :"+strawberryPrice +"-Alınan Gramaj :" +sterberryGram+"-Toplam Maliyet :"+ strawberryTotalPRice);
//Console.WriteLine("Alınan Ürün =Patates "+"-Birim Fiyat :"+patatoPrice +"-Alınan Gramaj :" +PatetoGram+"-Toplam Maliyet :"+patetoTotalPRice);
//Console.WriteLine("Alınan Ürün =Domates "+"-Birim Fiyat :"+tomatoPrice +"-Alınan Gramaj :" +tomatoGram+"-Toplam Maliyet :"+tomatoTotalPRice);

//Console.WriteLine("**********");
//Console.WriteLine();
//double totalProductPrice=(appleTotalPrice + orangeTotalPrice+strawberryPrice+patetoTotalPRice+tomatoTotalPRice);

//Console.WriteLine("Alınan Ürünlerin Toplma Tutarı :"+totalProductPrice+" TL");
//#endregion


#region Char Degişkenler


char symbol;
symbol = 'a';

#endregion


#region Klavyeden Veri Girişleri

//Console.WriteLine("**** Hava Yolu yolcu bilgileri");
//Console.WriteLine();

//string passengerName,passengerSurname,passengerDistrict,passengerCity,passengerAge,passengerId;


//Console.Write("Yolcu Adı: ");
//passengerName=Console.ReadLine();

//Console.Write("Yolcu Soyadı: ");
//passengerSurname=Console.ReadLine();

//Console.Write("İlçe Bilgisi: ");
//passengerDistrict=Console.ReadLine();

//Console.Write("Şehir Bilgisi: ");
//passengerCity=Console.ReadLine();

//Console.Write("Yolcu Yaşı: ");
//passengerAge=Console.ReadLine();

//Console.Write("Yolcu Tc KimlikNo");
//passengerId=Console.ReadLine();




//Console.WriteLine();
//Console.WriteLine("-----------------------");
//Console.WriteLine(passengerId+ "-Yolcu :" +passengerName+" " +passengerSurname+" "+passengerDistrict+"/"+passengerCity);

#endregion



#region Klavyeden Tam sayı girişim ve dönüşümleri

//int shoesPrice, computerPrice, chairPRice, tvPrice;

//shoesPrice = 1000;
//computerPrice = 2000;
//chairPRice = 5000;
//tvPrice = 24000;

//int sheosCount, computerCount, chairCount, tvCount;

//Console.WriteLine("Lütfen aldıgınız ayakkabı sayısını giriniz: ");
//sheosCount=int.Parse(Console.ReadLine());

//Console.WriteLine("Lütfen aldıgınız bilgisayar sayısını giriniz: ");
//computerCount = int.Parse(Console.ReadLine());


//Console.WriteLine("Lütfen aldıgınız sandalye sayısını giriniz: ");
//chairCount = int.Parse(Console.ReadLine());


//Console.WriteLine("Lütfen aldıgınız tv sayısını giriniz: ");
//tvCount = int.Parse(Console.ReadLine());


//int totalPrice=shoesPrice*sheosCount+computerCount*computerPrice+chairCount*chairPRice+tvPrice*tvCount;

//Console.WriteLine("Toplam Tutar :"+ totalPrice);
#endregion


#region Klavyeden Ondalıklı SAyı işlemleri

//double exam1, exam2,exam3,result;

//Console.WriteLine("Lütfen 1. sınav notunu giriniz: ");
//exam1 =double.Parse(Console.ReadLine());

//Console.WriteLine("Lütfen 2. sınav notunu giriniz: ");
//exam2 = double.Parse(Console.ReadLine());

//Console.WriteLine("Lütfen 3. sınav notunu giriniz: ");
//exam3 = double.Parse(Console.ReadLine());

//result=(exam1 + exam2+exam3)/3;

//Console.WriteLine("Sınav sonucunuz :" +result);
#endregion


#region Klavvyeden Karakter Girişler

char gender;

Console.WriteLine("Lütfen Karakter Seciniz :");
gender= char.Parse(Console.ReadLine());

Console.WriteLine("Sectiginiz Karakter :"+gender);
#endregion

Console.Read();