﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Limitless_Care_Website.Data
{
    public class Providers
    {
        [Key]
        public int Id { get; set; }
        public string Detail { get; set; }
    }
}
