using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWithUnity.Domain
{
    public class OtherItemClass
    {
        [Key]
        public int Id { get; set; }
        public string OtherItemName { get; set; }
        public string OtherItemPrice { get; set; }
    }
}
