﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Dto.TagCloudDtos
{
    public class GetByBlokIdTagCloudDto
    {
        public int TagCloudID { get; set; }
        public string Title { get; set; }
        public int BlokID { get; set; }
    }
}