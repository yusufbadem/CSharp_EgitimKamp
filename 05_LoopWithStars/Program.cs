



#region Alt alta 10 tane yıldız oluşturma


//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine("*");
//}

#endregion

#region yan yana 10 tane yıldız oluşturma

//for (int i = 0; i <= 10; i++)
//{
//    Console.Write("*");
//}

#endregion



#region yan yana ve Alt alta 10 tane yıldız oluşturma


//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine("**********");
//}
#endregion

#region Yıldızlarla dik üçgen oluşturma
//for (int i = 0; i <= 5; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

#endregion

#region Yıldızlarla ters dik üçgen oluşturma
//for (int i = 5; i >= 1; i--)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
//for (int u = 1; u <= -5; u++)
//{
//    for (int m = 1; m <= u; m++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}
#endregion



#region Pramit desenli yıldız
//int n = 5;
//for (int i = 1; i <= n; i++)
//{
//    //boşlık bırakma
//    for (int j = n - i; j > 0; j--)
//    {
//        Console.WriteLine(" ");
//    }

//    //yıldızlar
//    for (int k = 1; k <= 2 * i - 1; k++)
//    {
//        Console.WriteLine("*");
//    }
//    Console.WriteLine();
//}

#endregion

#region Ters Piramit

int n = 5;
for (int i = n; i >=1; i--)
{
    //boşluklar
    for (int j = n-i;  j >0;  j--)
    {
        Console.Write(" ");
    }

    //yıldızlar
    for (int k = 0; k < 2 * i - 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}


#endregion
Console.Read();