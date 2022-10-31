using Fredproj.WebApi.Models;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Testing BAD SECRET COMMIT!!!!
            // PAT doesnt work btw, get out!
            const string blah = "76t4sexvo775bxymc2k65kimgtooua5dgjjs3nilpbv2ipnn4iea"
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Person_exists_when_added()
        {
            SillyPersonRegister r = new();

            var p = new Person();
            p.Name = "Fred";


            r.AddPerson(p);

            Assert.True(p.Exists);
        }
    }
}
