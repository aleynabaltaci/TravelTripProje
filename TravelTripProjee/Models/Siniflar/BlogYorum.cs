using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProjee.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Değer1 { get; set; }
        public IEnumerable<Yorumlar> Değer2 { get; set; }
        public IEnumerable<Blog> Değer3 { get; set; }
    }
}