using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF2
{
    class Test
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public string Name2 { get; set; }
    }
}
