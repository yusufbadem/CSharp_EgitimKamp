



{
    #region For döngüsü
    //int i;
    //for ( i = 0; i < 5; i++)
    //{
    //    Console.WriteLine("C# egitim kampı");
    //}


    //for (int i = 0;i<20;i++)
    //{
    //    Console.WriteLine(i);
    //}

    //Console.WriteLine("Lütfen ekrana yazılması istediginiz adedi giriniz");
    //int finishValue=int.Parse(Console.ReadLine());

    //for(int i=0; i<=finishValue;i++)
    //{
    //    Console.WriteLine("Merhaba Dünya");
    //}
    #endregion

    #region for döngüsü ile karar yapıları

    //for (int i = 1; i < 100; i++)
    //{
    //    if (i % 5 == 0)
    //    {
    //        Console.WriteLine(i);
    //    }
    //}


    //int totalValue = 0;

    //for ( int i = 1; i<=10;i++ )
    //{
    //    totalValue += i;

    //}

    //Console.WriteLine(totalValue);



    //int totalValue = 0;

    //for ( int i = 0;i<20;i++)
    //{
    //    if (i % 2==0 )
    //    {
    //        totalValue += i;
    //        Console.WriteLine(i);
    //    }
    //}

    //Console.WriteLine("--------");
    //Console.WriteLine(totalValue);


    //int count = 0;

    //for (int i = 1; i <=50; i++)
    //{
    //    if (i%7==0)
    //    {
    //        count++;
    //    }
    //}

    //Console.WriteLine(count);

    //int bactery = 1;
    //for (int i = 1; i <= 24; i++)
    //{
    //    bactery *= 2;

    //    Console.WriteLine(i+".Saatin sonunda oluşan bacteri : "+ bactery);
    //}
    #endregion


    #region While Döngüsü

    //int i = 1;

    //while ( i <= 10 )
    //{
    //    Console.WriteLine( "merhaba");
    //    i++;
    //}

    //int i = 1;
    //while ( i <=10 )
    //{
    //    if (i%3==0)
    //    {
    //        Console.WriteLine(i);
    //        i++;
    //    }

    //}

    //int i = 1;
    //int sum = 0;

    //while(i<=10)
    //{
    //    sum += i;
    //    i++;
    //}

    //Console.WriteLine(sum);

    //Klavyeden girlen 3 basamaklı sayıların rakamları toplamı

    Console.WriteLine("Lütfen üç basamaklı sayı giriniz");
    int number=int.Parse(Console.ReadLine());

    int ones, tens, hundereds,sum;

    ones = number % 10;
    tens = (number % 100)/10;
    hundereds = number / 100;

    sum = ones + tens + hundereds;

    Console.WriteLine(ones+"-"+tens+"-"+hundereds+"-"+sum);
    


    #endregion


    Console.Read();
}