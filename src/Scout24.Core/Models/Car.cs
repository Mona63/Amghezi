using System;
using System.Collections.Generic;

namespace Scout24.Core.Models
{
    public partial class Car
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Fuel { get; set; }
        public int Price { get; set; }
        public bool New { get; set; }
        public int? Mileage { get; set; }
        public DateTime? FirstRegistration { get; set; }
    }
}
