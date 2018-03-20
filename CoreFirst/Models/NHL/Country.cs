

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoreFirst.Models.NHL
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int TeamId { get; set; }
        public int PlayerId { get; set; }
    }


}