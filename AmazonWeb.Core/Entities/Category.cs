using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using AmazonWeb.Core.Entities.Base;

namespace AmazonWeb.Core.Entities
{
    public class Category : Entity
    {
        [Required,StringLength(80)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }

        public static Category Create(int categoryId, string name, string description = null)
        {
            var category = new Category
            {
                Id = categoryId,
                Name = name,
                Description = description
            };
            return category;
        }
    }
}
