using JSON.Research.Domain;

namespace JSON.Research.Benchmark.Util
{
    public static class PersonBuilder
    {
        private readonly static School DemoSchool = new School()
        {
            Name = "Anytown Elementary",
            Address = new Address()
            {
                Street = "456 Elm St",
                City = "Anytown",
                State = "CA",
                Zip = "12345"
            }
        };
        public static Person GetDemoPerson() => new Person()
        {
            Name = "John Doe",
            Age = 35,
            Address = new Address()
            {
                Street = "123 Main St",
                City = "Anytown",
                State = "CA",
                Zip = "12345"
            },
            PhoneNumbers = new List<PhoneNumber>
            {
                new PhoneNumber() { Type = "home", Number = "555-1234" },
                new PhoneNumber() { Type = "work", Number = "555-5678" },
                new PhoneNumber() { Type = "mobile", Number = "555-9012" }
            },
            Email = "john.doe@example.com",
            IsMarried = true,
            Children = new List<Child>
            {
                new Child()
                {
                    Name = "Jane",
                    Age = 7,
                    School = DemoSchool
                },
                new Child()
                {
                    Name = "Jack",
                    Age = 5,
                    School = DemoSchool
                }
            }
        };
    }
}
