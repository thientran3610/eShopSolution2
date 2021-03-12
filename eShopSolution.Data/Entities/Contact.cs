﻿using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber{ get; set; }
        public string Email { get; set; }

        public string Message { set; get; }
        public Status Status { set; get; }
    }
}
