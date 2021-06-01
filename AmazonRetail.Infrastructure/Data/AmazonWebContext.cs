using AmazonWeb.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonRetail.Infrastructure.Data
{
    public class AmazonWebContext:IdentityDbContext<IdentityUser>
    {
        public AmazonWebContext(DbContextOptions<AmazonWebContext> options): base(options)
        {
        }

       /* public DbSet<Blog> Blogs { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Compare> Compares { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }*/
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        /*public DbSet<Review> Reviews { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        //aggregates
        public DbSet<ProductCompare> ProductCompares { get; set; }
        public DbSet<ProductList> ProductLists { get; set; }
        public DbSet<ProductRelatedProduct> ProductRelatedProducts { get; set; }
        public DbSet<ProductWishlist> ProductWishlists { get; set; }*/

       /* protected override void OnModelCreating(ModelBuilder builder)
        {
           *//* builder.Entity<Blog>().ToTable("Blogs");
            builder.Entity<Wishlist>().ToTable("Carts");
            builder.Entity<CartItem>().ToTable("CartItems");
            builder.Entity<Category>().ToTable("Categories");
            builder.Entity<Compare>().ToTable("Compares");
            builder.Entity<Contact>().ToTable("Contacts");
            builder.Entity<List>().ToTable("Lists");
            builder.Entity<Order>().ToTable("Orders");
            builder.Entity<OrderItem>().ToTable("OrderItems");*//*
            builder.Entity<Product>().ToTable("Products");
           *//* builder.Entity<ProductCompare>().ToTable("ProductCompares");
            builder.Entity<ProductList>().ToTable("ProductLists");
            builder.Entity<ProductRelatedProduct>().ToTable("ProductRelatedProducts");
            builder.Entity<ProductWishlist>().ToTable("ProductWishlists");
            builder.Entity<Review>().ToTable("Reviews");
            builder.Entity<Specification>().ToTable("Specifications");
            builder.Entity<Tag>().ToTable("Tags");
            builder.Entity<Wishlist>().ToTable("Wishlists");*//*
        }*/
    }
}
