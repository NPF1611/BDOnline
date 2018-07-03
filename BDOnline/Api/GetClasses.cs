using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDOnline.Api
{
    public class GetClassByClass
    {
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

        public virtual Resor Resource { get; set; }
        public class Resor
        {
            public int ID { get; set; }
            public int Name { get; set; }

        }


    }
}