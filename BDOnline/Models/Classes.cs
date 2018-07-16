using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BDOnline.Models
{
    public class Classes
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Ch_image_fullBody { get; set; }
        public string Ch_Symbol { get; set; }
        [ForeignKey("Resource")]
        public int ResourceFK { get; set; }
        public virtual Resource Resource  { get; set; }
       
    }
}