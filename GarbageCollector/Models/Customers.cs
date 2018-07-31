﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GarbageCollector.Models
{
    public class Customers
    {
        
        [ForeignKey("")]
        public virtual ApplicationUser user { get; set; }
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime? DateExclusionStart { get; set; }
        public DateTime? DateExclusionEnd { get; set; }
        public double CurrentBill { get; set; }
    }
}