








#region if else
//Console.WriteLine("lütfen şifreyi giriniz :");
//string password;
//password = Console.ReadLine();
//if (password == "abcd") 
//{
//    Console.WriteLine("Şifre Dogru");
//}
//else
//{
//    Console.WriteLine("Şifre Yanlış");
//}


//string capital, country;
//Console.WriteLine("Başkenti giriniz");
//capital =Console.ReadLine();

//Console.WriteLine("Ülkeyi Giriniz");
//country = Console.ReadLine();

//if (capital=="Ankara" & country=="türkiye")
//{
//    Console.WriteLine("veriler hatalı");
//}
//else
//{
//    Console.WriteLine("veriler hatalı");
//}

//int number;
//Console.WriteLine("SAyıyı giriniz");
//number =int.Parse(Console.ReadLine());

//if (number == 5)
//{
//    Console.WriteLine("sayi dogru");
//}
//else
//{
//    Console.WriteLine("sayı hatalı");
//}


//int exam1, exam2, exam3, avarage;
//string result="hata";
//Console.WriteLine("Sınav1:");
//exam1=int.Parse(Console.ReadLine());
//Console.WriteLine("Sınav2:");
//exam2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Sınav3:");
//exam3 = int.Parse(Console.ReadLine());


//avarage=(exam1+exam2 + exam3)/3;
//Console.WriteLine("Sınavların ortalaması :"+ avarage);

//if (avarage>0 & avarage<=50)
//{
//    result = "sonuç vasat";
//}
//if (avarage > 50 & avarage <= 70)
//{
//    result = "sonuç normal";
//}
//if (avarage > 70 & avarage <= 80)
//{
//    result = "sonuç iyi";
//}
//if (avarage > 80 & avarage <= 90)
//{
//    result = "sonuç cok iyi";
//}
//if (avarage > 90 & avarage <= 100)
//{
//    result = "sonuç mükemmel";
//}

//Console.WriteLine(result);


//string city;
//Console.WriteLine("lütfen şehir bilgisi giriniz");
//city=Console.ReadLine();

//if (city=="adana" | city=="ankara" | city=="istanbul")
//{
//    Console.WriteLine("şehir mevcut");
//}
//else
//{
//    Console.WriteLine("şehir mevcut degil");
//}

//Console.WriteLine("lütfen kullanıcı adı giriniz");
//string userName=Console.ReadLine();
//if (userName != "Admin")
//{
//    Console.WriteLine("bu kullanıcı kabul dilemez");
//}
//else
//{ 
//    Console.WriteLine("Hoş geldiniz");
//}

#endregion

#region Mod işlemeleri
//int number;
//number = 26;
//int result = number % 5;
//Console.WriteLine(result);

//Console.WriteLine("Lütfen 1 sayı giriniz");
//int number=int.Parse(Console.ReadLine());

//Console.WriteLine("lütfen 2. sayıyı giriniz");
//int number2=int.Parse(Console.ReadLine());

//int result = number % number2;

//Console.WriteLine("sayı 1 in sayı 2 ye bölümünden kalan :" +result);

//Console.WriteLine("lütfen sayıyı giriniz");
//int number=int.Parse(Console.ReadLine());

//if (number % 2 == 0)
//{
//    Console.WriteLine("sayı çifttir");
//}
//else
//{
//    Console.WriteLine("sayı tektir");
//}

//char team;
//Console.WriteLine("lütfen takım sembolunü giriz");
//team=char.Parse(Console.ReadLine());

//if (team=='f' | team=='F')
//{
//    Console.WriteLine("Fenerbahçe");
//}
//if (team == 'g' | team == 'G')
//{
//    Console.WriteLine("Galatasaray");
//}
//if (team == 'b' | team == 'B')
//{
//    Console.WriteLine("Beşiktaş");
//}
#endregion

#region  örnek proje
//Console.WriteLine("***** REstorant menü *****");
//Console.WriteLine();
//Console.WriteLine("1-Ana yemekler");
//Console.WriteLine("2-Çorbalar");
//Console.WriteLine("3-Pizzlara");
//Console.WriteLine("4-İçecekler");
//Console.WriteLine("5-Tatlılar");

//Console.WriteLine("-----------");
//Console.WriteLine();

//string menuItem;
//Console.WriteLine("DEtayını görmek istediginiz menüyü seçiniz");

//menuItem = Console.ReadLine();

//if (menuItem == "1")
//{
//    Console.WriteLine();
//    Console.WriteLine("-------Ana yemekler------");
//    Console.WriteLine("1-Fırında tavuk");
//    Console.WriteLine("1-Patlıcan musakka");
//}
//if (menuItem == "2")
//{
//    Console.WriteLine();
//    Console.WriteLine("-------Çorbalar------");
//    Console.WriteLine("1-Ezogelin");
//    Console.WriteLine("1-MErcimek");
//}
//if (menuItem == "3")
//{
//    Console.WriteLine();
//    Console.WriteLine("-------Pizzalar------");
//    Console.WriteLine("1-Margaria");
//    Console.WriteLine("1-Tavuklu");
//}
//if (menuItem == "4")
//{
//    Console.WriteLine();
//    Console.WriteLine("-------İçecekler------");
//    Console.WriteLine("1-Kola");
//    Console.WriteLine("1-Su");
//}
//if (menuItem == "5")
//{
//    Console.WriteLine();
//    Console.WriteLine("-------Tatlılar------");
//    Console.WriteLine("1-Triliçe");
//    Console.WriteLine("1-Kazandibi");
//}


#endregion


#region Switch Case

//Console.WriteLine("Lütfen Ay girşi yapınız");
//int monthNumber=int.Parse(Console.ReadLine());

//switch(monthNumber)
//{
//    case 1: Console.WriteLine("Ocak"); break;
//    case 2: Console.WriteLine("Şubat"); break;
//    case 3: Console.WriteLine("Mart"); break;
//    case 4: Console.WriteLine("Nisan"); break;
//    case 5: Console.WriteLine("Mayıs"); break;
//    case 6: Console.WriteLine("Haziran"); break;
//    case 7: Console.WriteLine("Temmuz"); break;
//    case 8: Console.WriteLine("Agustos"); break;
//    case 9: Console.WriteLine("Eylül"); break;
//    case 10: Console.WriteLine("Ekim"); break;
//    case 11: Console.WriteLine("Kasım"); break;
//    case 12: Console.WriteLine("Aralık"); break;
//    default: Console.WriteLine("Hatalı giriş");break ;
//}
#endregion



#region Hesap Makinası Switchcase

//int number1, number2, result;

//char sembol;
//Console.WriteLine("1.sayıyı giriniz");
//number1 =int.Parse(Console.ReadLine());

//Console.WriteLine("2.sayıyı giriniz");
//number2 = int.Parse(Console.ReadLine());

//Console.WriteLine("Lütfen yapmak istediginiz işlemi giriniz");
//sembol=char.Parse(Console.ReadLine());

//switch(sembol)
//{
//    case '+':
//        result=number1 + number2;
//        Console.WriteLine("Toplam"+result);
//        break;
//    case '-':
//        result = number1 - number2;
//        Console.WriteLine("Fark" + result);
//        break;
//    case '*':
//        result = number1 * number2;
//        Console.WriteLine("Çarpım" + result);
//        break;
//    case '/':
//        result = number1 / number2;
//        Console.WriteLine("Bölüm" + result);
//        break;
//    default: Console.WriteLine("hatalı işlem");break;
//}

#endregion


Console.Read();