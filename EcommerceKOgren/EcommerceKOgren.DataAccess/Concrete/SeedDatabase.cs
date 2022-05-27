//using EcommerceKOgren.Entities.Entities;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Bogus;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//namespace EcommerceKOgren.DataAccess.Concrete
//{
//    public class SeedDatabase
//    {
//        public static void Seed(IApplicationBuilder app)
//        {
//            var scope = app.ApplicationServices.CreateScope();
//            var context = scope.ServiceProvider.GetService<Context>();
//            //context.Database.Migrate();


//            if (context.Database.GetPendingMigrations().Count() == 0)
//            {

//                if (context.Categories.Count() == 0)
//                {
//                    context.Categories.AddRange(
//                            new List<Category>()
//                            {
//                                new Category() {Id=1, CategoryName="Cold Drinks"},
//                                new Category() {Id=2, CategoryName = "Hot Drinks"},
//                                new Category() {Id=3, CategoryName = "Meals"},
//                                new Category() {Id=4, CategoryName = "Desserts"}
//                            }
//                        );
//                }

//                if (context.Products.Count() == 0)
//                {
//                    context.Products.AddRange(
//                        new List<Product>()
//                        {
//                            new Product() {CategoryId=1, ProductName="Water",  Stock=100, UnitPrice=10,Picture="1.jpg"},
//                            new Product() {CategoryId=1, ProductName = "Cola",  Stock=100, UnitPrice=10,Picture="2.jpg"},
//                            new Product() {CategoryId=1, ProductName = "Soda",  Stock=100, UnitPrice=10,Picture="3.jpg"},
//                            new Product() {CategoryId=2, ProductName = "Tea",  Stock=100, UnitPrice=10,Picture="4.jpg"},
//                            new Product() {CategoryId=2, ProductName = "Coffee",  Stock=100, UnitPrice=10,Picture="5.jpg"},
//                            new Product() {CategoryId=3, ProductName = "Manti",  Stock=100, UnitPrice=50,Picture="6.jpg"},
//                            new Product() {CategoryId=3, ProductName = "Beef",  Stock=100, UnitPrice=50,Picture="7.jpg"},
//                            new Product() {CategoryId=4, ProductName = "Cake",  Stock=100, UnitPrice=30,Picture="8.jpg"}
//                        }
//                        );
//                }

//                context.SaveChanges();
//            }



//        }



//        //Product[] productFaker = new Faker<Product>[] 
//        //         .RuleFor(i => i.ProductName, i => i.Commerce.Product())
//        //         .RuleFor(i => i.CategoryId, i => i.Random.Int(1, 10))
//        //         .RuleFor(i => i.ColorId, i => i.Random.Int(1, 10))
//        //         .RuleFor(i => i.SupplierId, i => i.Random.Int(1, 10))
//        //         .RuleFor(i => i.ProductDescription, i => i.Lorem.Paragraph())
//        //         .RuleFor(i => i.Picture, i => i.Image.LoremPixelUrl())
//        //         .RuleFor(i => i.SizeId, i => i.Random.Int(1, 10))
//        //         .RuleFor(i => i.Stock, i => i.Random.Int(1, 10))
//        //         .RuleFor(i => i.SupplierId, i => i.Random.Int(1, 10))
//        //         .RuleFor(i => i.UnitId, i => i.Random.Int(1, 10))
//        //         .RuleFor(i => i.UnitPrice, i => i.Random.Int(100, 1000)).Generate(10);



//    }
//}
