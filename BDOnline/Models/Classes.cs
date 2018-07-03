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
        public string Play_Style { get; set; }
        public string History { get; set; }
        public string Ab_graph { get; set; }
        public string Ch_image_fullBody { get; set; }
        public string Ch_Symbol { get; set; }
        public string Fight_style { get; set; }
        public string Aweking_weapon { get; set; }
         public string Weapon { get; internal set; }
        public string Secondary_weapon { get; internal set; }

        [ForeignKey("Resource")]
        public int ResourceFK { get; set; }
        public virtual Resource Resource  { get; set; }
       
    }
}