﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManager.Shared
{
    public class Paragraph
    {
        [Key]
        public int Id { get; set; }

        public int ArticleId { get; set; }

        public string? Header { get; set; }

        public string? Content { get; set; }
    }
}
