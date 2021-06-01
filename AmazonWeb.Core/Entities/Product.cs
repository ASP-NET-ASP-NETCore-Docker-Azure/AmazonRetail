using AmazonWeb.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AmazonWeb.Core.Entities
{
    public class Product : Entity
    {
        //properties of the product
        //Required to make Entry of name compulsary, StringLength(80)-nVarChar(80) in SQL
        [Required,StringLength(80)]
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public int? UnitsInStock { get; set; }
        public double Star { get; set; }
        public decimal UnitPrice { get; set; }

   /*     //relations n-1
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //retaions 1-n
        public List<Specification> Specifications { get; set; } = new List<Specification>();
        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<Tag> Tags { get; set; } = new List<Tag>();

        //relation n-n
        public List<ProductWishlist> ProductWishlists { get; set; } = new List<ProductWishlist>();
        public List<ProductCompare> ProductCompares { get; set; } = new List<ProductCompare>();
        public List<ProductList> ProductLists { get; set; } = new List<ProductList>();
        public List<ProductRelatedProduct> ProductRelatedProducts { get; set; } = new List<ProductRelatedProduct>();*/

        //create method to create new products
      /*  public static Product Create(int productId, int categoryId, string name, decimal unitPrice = 0, short? unitsInStock = null)
        {
            var product = new Product
            {
                Id = productId,
                CategoryId=categoryId,
                Name=name,
                UnitPrice=unitPrice,
                UnitsInStock=unitsInStock
            };
            return product;
        }*/
    }
}
