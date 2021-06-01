using AmazonWeb.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonWeb.Core.Entities
{
    public class Specification : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
