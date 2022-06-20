using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Petmall.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string HeaderLogo { get; set; }
        public string Brand { get; set; }
        public List<Icon> Icons { get; set; }
    }
}
