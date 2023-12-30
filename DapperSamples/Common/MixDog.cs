using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class MixDog
    {
        public int? AgE { get; set; }
        public Guid Id { get; set; }
        public string naME { get; set; }
        public int IgnoredProperty
        { get { return 1; } }
    }
}
