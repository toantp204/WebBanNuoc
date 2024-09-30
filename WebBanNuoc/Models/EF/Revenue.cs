using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanNuoc.Models.EF
{
    public class Revenue
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
    }

}