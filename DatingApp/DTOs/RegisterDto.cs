﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppAPI.DTOs
{
    public class RegisterDto
    {
        [Required]
        //[MinLength(4)]
        //[MaxLength(20)]
        public string Username { get; set; }
        [Required]
        //[MinLength(6)]
        //[MaxLength(25)]
        public string Password { get; set; }
    }
}
