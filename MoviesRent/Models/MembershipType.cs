﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;
namespace MoviesRent.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public short SignUpFee  { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
       }
}