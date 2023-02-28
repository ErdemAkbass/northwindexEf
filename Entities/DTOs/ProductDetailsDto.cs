using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailsDto:IDto
    {
        public int Id { get; set; }
        public string  ProductName { get; set; }
        public int CategoryId { get; set; }
        
    }
}
