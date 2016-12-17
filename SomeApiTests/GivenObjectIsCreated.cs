using System;
using NUnit.Framework;

namespace SomeApiTests
{
    [TestFixture]
    public class GivenObjectIsCreated
    {
        public Person _subject;

        [SetUp]
        public void WhenTheNameIsSet()
        {
            _subject = new Person
            {
                Name = "Milosz",
                DateOfBirth = new DateTime(1996, 10, 10)
            };
        }

        [Test]
        public void ThenTheNameIsSetCorrectly()
        {
            Assert.That(_subject.Name, Is.EqualTo("Milosz"));
        }

        [Test]
        public void ThenTheDateOfBirthIsSetCorrectly()
        {
            Assert.That(_subject.Name, Is.EqualTo(new DateTime(1996, 10, 10)));
        }
    }
}