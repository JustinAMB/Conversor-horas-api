using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConversorHoras.Models
{
    public class Resp
    {
        public int status { get; set; }
        public string msg { get; set; }
        public Object data { get; set; }
    }
}
