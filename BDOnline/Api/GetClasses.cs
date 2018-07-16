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
        public string Ch_image_fullBody { get; set; }
        public string Ch_Symbol { get; set; }
        public virtual Resor Resource { get; set; }
        public class Resor
        {
            public int ID { get; set; }
            public int Name { get; set; }

        }


    }
}