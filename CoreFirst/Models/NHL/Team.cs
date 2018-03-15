using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoreFirst.Models.NHL
{
    public class Team
    {
        // [Key]
       //  [MaxLength(50)]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }


        public List<Player> Players { get; set; }
        public int country { get; set; }
        public Country countries { get; set; }
      
    }
}