﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CoffeePicker.Shared
{
    public class Coffee
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
