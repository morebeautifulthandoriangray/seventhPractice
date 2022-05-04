using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _7PracticeExample.Entities
{
    public class Guest
    {
        [Key, Required]
        public string Phone { get; set;}
        public string Name { get; set; }
        public string Email { get; set; }
        public string Agreement { get; set; }
    }
}