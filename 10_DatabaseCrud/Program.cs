using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud --> Create-Read-Update-Delete


            // kategori Ekleme işlemş gerçekleştirme
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("----------------");
            //Console.Write("Eklemek İstediginiz Kategori Adı");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0ESM5CG; initial Catalog=EgKAmpDb; integrated security=true;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();


            //Console.WriteLine("Kategori Başarıyla eklendi");


            //Ürün ekeleme Kısmı
            Console.WriteLine("Product Ekleme Menüsü");
            Console.WriteLine();
            Console.WriteLine("---------");
            Console.WriteLine("Eklemek İstediginiz Ürünün Adını yazınız");
            string productName=Console.ReadLine();
            Console.WriteLine("Ürünün Ücretini Yaınız");
            double productPrice=double.Parse(Console.ReadLine());
            Console.WriteLine("Ürün Stokta varmı");
            bool productStatus=bool.Parse(Console.ReadLine());


            SqlConnection connection=new SqlConnection("Data Source=DESKTOP-0ESM5CG; initial Catalog=EgKAmpDb; integrated security=true;");
            connection.Open();

            SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", connection);
            command.Parameters.AddWithValue("@p1", productName);
            command.Parameters.AddWithValue("@p2", productPrice);
            command.Parameters.AddWithValue("@p3", productStatus);
            command.ExecuteNonQuery();  

            connection.Close();

            Console.WriteLine();
            Console.WriteLine("Ürünler Başarıyla eklendi");





            Console.ReadLine(); 






        }
    }
}
