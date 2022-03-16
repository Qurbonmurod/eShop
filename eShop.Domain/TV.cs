using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Domain
{
   public class TV
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Short { get; set; }
        public string Long { get; set; }
        public string Img { get; set; }
        public uint Price { get; set; }
        public bool Exist { get; set; }
        public bool Thumbnail { get; set; }
        public virtual User user { get; set; }
    }
}
