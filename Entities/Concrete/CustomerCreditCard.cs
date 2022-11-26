﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class CustomerCreditCard : IEntity
    {
        [Key]
        public int CardId { get; set; }
        public int CustomerId { get; set; }

    }
}