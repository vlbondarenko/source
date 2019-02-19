﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportStore.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public bool Shipped { get; set; }

        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage ="Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter the first adress line")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Pleaseenter a city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Pleaseenter a state name")]
        public string State { get; set; }
        public string Zip { get; set; }

        [Required(ErrorMessage ="Please enter a country name")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}