using System.Collections.Generic;

namespace JSON.Research.Domain
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
        public string Email { get; set; }
        public bool IsMarried { get; set; }
        public List<Child> Children { get; set; }
    }
}
