using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace EfCorePractice
{
    public class Product
    {
        [Key]
        public int Id{get;set;}
        public string Name{get;set;}
    }
    public class ProductContext:DbContext
    {
        private const string cs="Host=localhost;Port=5432;User ID=postgres;Password=Divya123;Database=Practicedb;Pooling=true";
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            dbContextOptions.UseNpgsql(cs);
        }

      
      public DbSet<Product> products{get;set;}// table name will be in database Products
    }
    public class ProductOperation
    {
        ProductContext productContext = new ProductContext();
        public void FetchProduct(string str)
        {
          var temp= productContext.products.Where(s => s.Name =="Divya").FirstOrDefault();
          Console.WriteLine(temp.Id);
          
        
        }
        public void Insert()
        {
            var  std = new Product()
            {
                Id = 105,
                Name = "Geetika"
            };
                productContext.products.Add(std);
                productContext.SaveChanges();      
        }
      public void updateProduct(int ID,string n)
        {
            var productss = productContext.products
                  .Where(s => s.Id == ID)
                  .FirstOrDefault<Product>();
            productss.Name=n;
            productContext.SaveChanges();
            Console.WriteLine("Update successfully !!!!");
        }
        public void Delete(int ID)
        {
            var std=productContext.products.Find(ID);
            if(std!=null)
            {
                productContext.products.Remove(std);
                productContext.SaveChanges();
            }
        }
        
    }


    class Program
    {
        public static void Main()
        {
          {
              ProductOperation productOperation=new ProductOperation();
             // productOperation.FetchProduct();
              //productOperation.Insert();
              productOperation.updateProduct(105,"Deepu");
              //productOperation.Delete(101);
          }  
        }
    }
}
