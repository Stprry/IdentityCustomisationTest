using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCustomisationTest.Models
{
    public class Property
    {
        public int ID { get; set; }
        public string HouseNum { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        [MaxLength(10)]
        public string PostCode { get; set; }
        public string MainImage { get; set; }

        public ICollection<Room> Rooms { get; set; }

    }
}
