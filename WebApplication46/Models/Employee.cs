﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication46.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string descr { get; set; }
        public cataegory category { get; set; }
    }

}