using eShop.Data.Interfaces;
using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Data
{
    public class TVRepository : ITVRepository
    {
        private List<TV> TVs = null;
        public TVRepository()
        {
            TVs = new List<TV>()
        {
                    new TV() {Id=1,
                    Name = "Samsung",
                    Short = "32 chanels",
                    Long = "Samsung 32 HD",
                    Img = "~/img/1.png",
                    Price = 500,
                    Exist = true,
                    Thumbnail = true
                },new TV() {Id=2,
                    Name = "Hairun",
                    Short = "32 chanels",
                    Long = "Hairun 32 HD",
                    Img = "~/img/2.png",
                    Price = 600,
                    Exist = true,
                    Thumbnail = true},
                new TV() {Id=3,
                    Name = "LG",
                    Short = "32 chanels",
                    Long = "LG 32 HD",
                    Img = "~/img/3.png",
                    Price = 700,
                    Exist = true,
                    Thumbnail = true}
        };
        }

        public TV Creat(TV tv)
        {
            tv.Id = TVs.Max(s => s.Id) + 1;
                 TVs.Add(tv);
            return tv;
        }

        public TV Delete(int id)
        {
            var tv = TVs.FirstOrDefault(s => s.Id.Equals(id));
            if(tv!=null){ TVs.Remove(tv); }
            return tv;
        }

      
        public IEnumerable<TV> GetAll()
        {
            return TVs;
        }

        public TV getbyid(int TVid)
        {
           return TVs.FirstOrDefault(tv => tv.Id.Equals(TVid));

        }

        public TV Update(TV updateTV)
        {
            var tv = TVs.FirstOrDefault(s => s.Id.Equals(updateTV.Id ));
            TVs.Remove(tv);
            TVs.Insert(0, updateTV);
            return tv;
        }

        
    }
}
