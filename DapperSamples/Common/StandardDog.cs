using System;

namespace Common
{
    public class StandardDog
    {
        public int? Age { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int IgnoredProperty
        { get { return 1; } }
    }
}