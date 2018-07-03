using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDOnline.Api
{
    public class GetResources
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }



        public virtual ICollection<Classes_List> Class_List { get; set; }

        public class Classes_List {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Ch_Symbol { get; set; }

        }
    }
}