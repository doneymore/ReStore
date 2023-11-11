using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public class DbInitializer
    {
        public static void Initalize(StoreContext content)
        {
            if(content.Products.Any()) return;
            var products = new List<Product>
            {
                  new Product
    {
        Name = "Product 1",
        Description = "Description for Product 1",
        Price = 1099L,
        PictureUrl = "image1.jpg",
        Brand = "Brand A",
        Type = "Type X",
        QuantityInStock = 50
    },
    new Product
    {
        Name = "Product 2",
        Description = "Description for Product 2",
        Price = 1599L,
        PictureUrl = "image2.jpg",
        Brand = "Brand B",
        Type = "Type Y",
        QuantityInStock = 30
    },
    new Product
    {
        Name = "Product 3",
        Description = "Description for Product 3",
        Price = 1299L,
        PictureUrl = "image3.jpg",
        Brand = "Brand C",
        Type = "Type Z",
        QuantityInStock = 25
    },
    new Product
    {
        Name = "Product 4",
        Description = "Description for Product 4",
        Price = 1499L,
        PictureUrl = "image4.jpg",
        Brand = "Brand D",
        Type = "Type X",
        QuantityInStock = 40
    },
    new Product
    {
        Name = "Product 5",
        Description = "Description for Product 5",
        Price = 999L,
        PictureUrl = "image5.jpg",
        Brand = "Brand E",
        Type = "Type Y",
        QuantityInStock = 20
    },
    new Product
    {
        Name = "Product 6",
        Description = "Description for Product 6",
        Price = 1799L,
        PictureUrl = "image6.jpg",
        Brand = "Brand F",
        Type = "Type Z",
        QuantityInStock = 35
    },
    new Product
    {
        Name = "Product 7",
        Description = "Description for Product 7",
        Price = 1199L,
        PictureUrl = "image7.jpg",
        Brand = "Brand G",
        Type = "Type X",
        QuantityInStock = 60
    },
    new Product
    {
        Name = "Product 8",
        Description = "Description for Product 8",
        Price = 1299L,
        PictureUrl = "image8.jpg",
        Brand = "Brand H",
        Type = "Type Y",
        QuantityInStock = 15
    },
    new Product
    {
        Name = "Product 9",
        Description = "Description for Product 9",
        Price = 999L,
        PictureUrl = "image9.jpg",
        Brand = "Brand I",
        Type = "Type Z",
        QuantityInStock = 10
    },
    new Product
    {
        Name = "Product 10",
        Description = "Description for Product 10",
        Price = 1999L,
        PictureUrl = "image10.jpg",
        Brand = "Brand J",
        Type = "Type X",
        QuantityInStock = 45
    },
    new Product
    {
        Name = "Product 11",
        Description = "Description for Product 11",
        Price = 1499L,
        PictureUrl = "image11.jpg",
        Brand = "Brand K",
        Type = "Type Y",
        QuantityInStock = 22
    },
    new Product
    {
        Name = "Product 12",
        Description = "Description for Product 12",
        Price = 1199L,
        PictureUrl = "image12.jpg",
        Brand = "Brand L",
        Type = "Type Z",
        QuantityInStock = 18
    },
    new Product
    {
        Name = "Product 13",
        Description = "Description for Product 13",
        Price = 1799L,
        PictureUrl = "image13.jpg",
        Brand = "Brand M",
        Type = "Type X",
        QuantityInStock = 28
    },
    new Product
    {
        Name = "Product 14",
        Description = "Description for Product 14",
        Price = 1299L,
        PictureUrl = "image14.jpg",
        Brand = "Brand N",
        Type = "Type Y",
        QuantityInStock = 32
    },
    new Product
    {
        Name = "Product 15",
        Description = "Description for Product 15",
        Price = 1499L,
        PictureUrl = "image15.jpg",
        Brand = "Brand O",
        Type = "Type Z",
        QuantityInStock = 24
    }
    
        };
             foreach (var product in products)
            {
                content.Products.Add(product);
            }
        }
    }
}