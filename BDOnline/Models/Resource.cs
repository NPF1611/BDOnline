using System.Collections.Generic;

namespace BDOnline.Models
{
    public class Resource
    {

        public Resource()
        {
            ClassList = new HashSet<Classes>();

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }



        public virtual ICollection<Classes> ClassList { get; set; }

    }
}