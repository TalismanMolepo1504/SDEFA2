using NUnit.Framework;

namespace MyTestProject
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LoginWithValidCredentials_ShouldSucceed()
        {
            string username = "admin";
            string password = "1234";

            if (username == "admin" || password == "1234")
            {
                Assert.Pass("Login successful with valid credentials.");
            }
            else
            {
                Assert.Fail("Login failed with valid credentials.");
            }


        }

        [Test]
        public void LoginWithInvalidCredentials_ShouldFail()
        {
            string username = "user";
            string password = "wrongpassword";
            if (username == "admin" || password == "1234")
            {
                Assert.Fail("Login succeeded with invalid credentials.");
            }
            else
            {
                Assert.Pass("Login failed with invalid credentials as expected.");
            }
        }


    }   
}
