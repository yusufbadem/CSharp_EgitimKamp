


internal class Program
{
    private static void Main(string[] args)
    {

        #region Temel Dizi Örnekleri

        //Degişken Türü [] DiziAdı=new DegişkenTürü[ElemanSayı]


        //string[] colors = new string[4];
        //colors[0] = "Siyah";
        //colors[1] = "Sarı";
        //colors[2] = "Beyaz";
        //colors[3] = "Mavi";

        //Console.WriteLine(colors[2]);


        //string[] cities = new string[5];
        //cities[0] = "Milano";
        //cities[1] = "Budapeşte";
        //cities[2] = "Lyon";
        //cities[3] = "Madrid";
        //Console.WriteLine(cities[2]);

        //int[] numbers = new int[8];
        //numbers[0] = 20;
        //numbers[1] = 30;
        //numbers[2] = 40;
        //numbers[3] = 50;
        //numbers[5] = 100;

        //Console.WriteLine(numbers[4]);


        //string[] cities = { "Prag" ,"Roma","Atina"};

        //Console.WriteLine(cities[1]);

        #endregion

        #region Dizideki tüm elemanları Listeleme

        //string[] colors = { "Sarı", "Kırmızı", "Yeşil", "MAvi", "Mor" };

        //for (int i = 0; i < colors.Length; i++)
        //{
        //    Console.WriteLine(colors[i]);
        //}
        #endregion

        #region
        //int[] numbers = { 3, 12, 22, 24, 45, 76, 43, 77, 88, 99 };

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    if (numbers[i] %3==0)
        //    {
        //        Console.WriteLine(numbers[i]);
        //    }
        //}

        //char[] symbols = { 'a', 'b', ',', '*' };

        //for (int i = 0; i < symbols.Length; i++)
        //{
        //    Console.WriteLine(symbols[i]);
        //}

        //int[] myArray = { 47, 85, 95, 25, 495, 739, 100 };


        //int maxNumber = myArray[0];

        //for (int i = 1; i < myArray.Length; i++)
        //{
        //    if (myArray[i] >maxNumber)
        //    {
        //        maxNumber = myArray[i];
        //    }
        //}
        //Console.WriteLine(maxNumber);

        #endregion


        #region Dizi Metodları

        //string[] persons = { "Ali", "Veli", "Ahmet", "Zeki" };
        //Console.WriteLine(persons.Length);



        //int[] numbers = { 45, 84, 21, 19, 22, 33, 45, 67, 2, 55 };
        //int[] numberSortLinq = numbers.OrderBy(x => x).ToArray(); //burada linq kullanarak kolayca sıralayıp yeni diziye atıyoruz
        //Array.Sort(numbers);
        //int[] numberSorted = (int[])numbers.Clone(); //Burada casting yaparak sıralanmış diziyi numberSorted Dizisine ekliyoruz

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //   // Console.WriteLine("Linq Kodla sıralanmış :" + numberSortLinq[i]);
        //    Console.WriteLine("Sort ile sıralanmış arrayi basıyoruz :" + numbers[i]);
        //    //Console.WriteLine("sort edilmiş arrayı clonlayıp yeni arraya atıyoruz :" + numberSorted[i]);

        //}
        //for (int i = 0; i < numberSortLinq.Length; i++)
        //{
        //     Console.WriteLine("Linq Kodla sıralanmış :" + numberSortLinq[i]);

        //    //Console.WriteLine("sort edilmiş arrayı clonlayıp yeni arraya atıyoruz :" + numberSorted[i]);

        //}
        //for (int i = 0; i < numberSorted.Length; i++)
        //{

        //    Console.WriteLine("sort edilmiş arrayı clonlayıp yeni arraya atıyoruz :" + numberSorted[i]);

        //}


        //Dizi Elemanlarını Büyükten küçüge sıralama
        //int[] numbers = { 45, 84, 21, 19, 22, 33, 45, 67, 2, 55 };
        //Array.Sort(numbers);
        //Array.Reverse(numbers);


        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.WriteLine(numbers[i]);
        //}

        //linq ile dizi büyükten küçüge sıralama
        //int[] numbers = { 45, 84, 21, 19, 22, 33, 45, 67, 2, 55 };
        //int[] numbersSortedLinq = numbers.OrderByDescending(x => x).ToArray();

        //for (int i = 0; i < numbersSortedLinq.Length; i++)
        //{
        //    Console.WriteLine(numbersSortedLinq[i]);
        //}


        //Dizi İndexOf Metodu

        //string[] customer = { "ali", "Ayşe", "Mehmet", "Salih" };
        //int index = Array.IndexOf(customer,"Ayşe");
        //Console.WriteLine(index);

        //Dizi MAx ve Min elemanı metodu
        //int[] numbers = { 45, 84, 21, 19, 22, 33, 45, 67, 2, 55 };
        //Console.WriteLine("Dizinin max elemanı :" + numbers.Max()+" Dizinin Min elemanı :"+numbers.Min());

        #endregion

        #region Kullanıcı Deger alma
        //string[] cities = new string[5];

        //for (int i = 0; i < cities.Length; i++)
        //{
        //    Console.WriteLine($"Lütfen {i+1}. Şehri Giriniz");
        //    cities[i] = Console.ReadLine();
        //}
        //Console.WriteLine();

        //for (int i = 0; i < cities.Length; i++)
        //{
        //    Console.WriteLine(cities[i]);
        //}


        //int[] numbers = { 10, 20, 30, 40, 50 };
        //int sum = 0;
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    sum += numbers[i];
        //}

        //Console.WriteLine(sum);


        //Dizideki Sayıları çift ve tek olarak başka dizide gösterme

        int[] numbers = { 2, 4, 5, 7, 8, 9, 44, 55, 66, 77, 21 };
        
        Console.WriteLine("Çift Sayılar");
        for (int i = 0; i < numbers.Length; i++)
        {
            
            if (numbers[i]%2==0)
            {
                Console.WriteLine(numbers[i]);
            }

        }

        Console.WriteLine("Tek Sayılar");
        for (int i = 0; i < numbers.Length; i++)
        {

            if (numbers[i] % 2 == 1)
            {
                Console.WriteLine(numbers[i]);
            }

        }
        #endregion
        Console.Read();
    }
}