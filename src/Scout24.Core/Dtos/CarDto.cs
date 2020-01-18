using System;
using System.Collections.Generic;
using System.Text;

namespace Scout24.Core.Dtos
{
  public  class CarDto
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
