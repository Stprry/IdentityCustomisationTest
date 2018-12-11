using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCustomisationTest.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string ThreeSixtyImage { get; set; }

        /*
         * Should really setup a Floor class and link Rooms to Floors
         * Properties will then be linked to Rooms via Floors
         * */
    }
}