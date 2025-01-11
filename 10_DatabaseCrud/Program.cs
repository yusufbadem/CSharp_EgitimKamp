using System;
using System.Collections.Generic;
using System.Data;
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


            #region Ürün ekeleme Kısmı
            //Console.WriteLine("Product Ekleme Menüsü");
            //Console.WriteLine();
            //Console.WriteLine("---------");
            //Console.WriteLine("Eklemek İstediginiz Ürünün Adını yazınız");
            //string productName=Console.ReadLine();
            //Console.WriteLine("Ürünün Ücretini Yaınız");
            //double productPrice=double.Parse(Console.ReadLine());
            ////Console.WriteLine("Ürün Stokta varmı");
            ////bool productStatus=bool.Parse(Console.ReadLine());


            //SqlConnection connection=new SqlConnection("Data Source=DESKTOP-0ESM5CG; initial Catalog=EgKAmpDb; integrated security=true;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();  

            //connection.Close();

            //Console.WriteLine();
            //Console.WriteLine("Ürünler Başarıyla eklendi");

            #endregion


            #region Ürün Listeleme
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0ESM5CG; initial Catalog=EgKAmpDb; integrated security=true;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * from TblProduct",connection);

            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion


            #region Ürün Silme  işlemi
            //Console.WriteLine("Silinecek Ürün Id :");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0ESM5CG; initial Catalog=EgKAmpDb; integrated security=true;");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete from TblProduct where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("Silme İşlemi Gerçekleşti");
            #endregion

            #region Ürün Güncelleme
            Console.WriteLine("Güncelenecek Ürün Id :");
            int productId = int.Parse(Console.ReadLine());
            Console.WriteLine("Güncelenecek Ürün Adı :");
            string productName = Console.ReadLine();
            Console.WriteLine("Güncelenecek Ürün Fiyatı :");
            decimal productPrice = decimal.Parse(Console.ReadLine());


            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0ESM5CG; initial Catalog=EgKAmpDb; integrated security=true;");

            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId",connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice",productPrice);
            command.Parameters.AddWithValue("@productId", productId);

            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Ürün Güncelleme Başarılı");

            #endregion
            Console.ReadLine(); 






        }
    }
}
