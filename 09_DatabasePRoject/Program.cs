using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabasePRoject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ado .NET
            Console.WriteLine("*** ÜRün Veri Tabanlı Ürün-Kategori Bilgi Sistemi");
            string tableNumber;
            Console.WriteLine("---------------");
            Console.WriteLine("Lütfen getimek istediginiz tablo numarasını giriniz");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");

            Console.WriteLine("Lütfen getirmek istediginiz tablo numarasını giriniz");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0ESM5CG; initial Catalog=EgKAmpDb; integrated security=true;");
            connection.Open();

            SqlCommand command = new SqlCommand("select * from Tbl_CAtegory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dataTable=new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }



            Console.Read();
        }
    }
}
