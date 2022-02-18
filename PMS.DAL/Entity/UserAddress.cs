﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.DAL.Entity
{
    public class UserAddress
    {
        public int Id { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string CountryCode { get; set; }

        public int? UserId { get; set; }

    }
}
