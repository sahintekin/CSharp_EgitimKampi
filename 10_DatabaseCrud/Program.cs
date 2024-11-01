﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Console.WriteLine("***** Menü Sipariş İşlem Paneli");
            Console.WriteLine();

            Console.WriteLine("------------------------------------");

            #region Kategori Ekleme İşlemei
            // Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            // string categoryName = Console.ReadLine();

            // SqlConnection connection =new SqlConnection("Data Source=AHMET\\SQLEXPRESS; initial Catalog=EgitimKampi; integrated security=true");
            // connection.Open();

            // SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);

            //command.Parameters.AddWithValue("@p1",categoryName);

            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi..");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=AHMET\\SQLEXPRESS; initial Catalog=EgitimKampi; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (productName,productPrice,productStatus) values(@p1,@p2,@p3)",connection);

            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün Eklendi...");




            #endregion

            #region Ürün Listeleme İşlemi


            //SqlConnection connection = new SqlConnection("Data Source=AHMET\\SQLEXPRESS; initial Catalog=EgitimKampi; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * from TblProduct",connection);

            //SqlDataAdapter adapter= new SqlDataAdapter(command);

            //DataTable dataTable= new DataTable();

            //adapter.Fill(dataTable);

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();


            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Id: ");
            //int productId=int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=AHMET\\SQLEXPRESS; initial Catalog=EgitimKampi; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete from TblProduct where ProductID=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme İşlemi Yapıldı..");
            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice=decimal.Parse(Console.ReadLine()); 


            //SqlConnection connection = new SqlConnection("Data Source=AHMET\\SQLEXPRESS; initial Catalog=EgitimKampi; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update  TblProduct set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("ProductName", productName);
            //command.Parameters.AddWithValue("ProductPrice", productPrice);
            //command.Parameters.AddWithValue("ProductId", productId);

            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün Güncellendi..");

            #endregion


            Console.Read();
        }
    }
}
