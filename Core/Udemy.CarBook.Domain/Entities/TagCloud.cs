﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.CarBook.Domain.Entities
{
    public class TagCloud
    {
        public int TagCloudID { get; set; }
        public string Title { get; set; }
        public int BlokID { get; set; }
        public Blok Blok { get; set; }

    }
}
