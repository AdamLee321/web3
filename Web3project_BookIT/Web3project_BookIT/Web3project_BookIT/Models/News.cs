using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web3project_BookIT.Models
{
    public class News
    {
        [ScaffoldColumn(false)]
        public int NewsID { get; set; }
        public string NewsTitle { get; set; }
        public string NewsBody { get; set; }
}
}