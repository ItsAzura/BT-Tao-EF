﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tao_EF
{
    public class Faculty
    {
        public int FacultyId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Department { get; set; }
    }
}
