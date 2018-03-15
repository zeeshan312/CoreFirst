using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreFirstPrimer.Models.NHL
{
    public class Player
    {

        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }



        public int TeamID { get; set; }
        public Team Team { get; set; }

    }
}




