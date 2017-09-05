using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CookingSite.Models
{
    public class TermsIdexViewModel
    {
        public AspNetUser UserID { get; set; }
        public Term TermID { get; set; }
        public Favorite FavoriteID { get; set; }
    }
}