using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDOnline.Api
{
    public class GetClass
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string Ch_image_fullBody { get; set; }
        public string Ch_Symbol { get; set; }
        public int resource_type { get; set; }
    }
}