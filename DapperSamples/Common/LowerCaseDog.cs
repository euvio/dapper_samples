using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class LowerCaseDog
    {
        public int? age { get; set; }
        public Guid id { get; set; }
        public string name { get; set; }

        public int ignoredProperty
        { get { return 1; } }
    }
}