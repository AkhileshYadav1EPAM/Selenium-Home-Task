namespace Task_4_NUnit
{
    public class PasswordTests
    {
        String[] Passwords;
        bool PasswordValidation(String p)
        {
            int PasswordLength = p.Length;

            if (PasswordLength >= 8 && PasswordLength <= 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [SetUp]
        public void Setup()
        {
            Passwords = new String[5] { "abc", "abcdefgh", "abcdefghi", "123456789101", "123456789htkjdb" };
        }

        [Test]
        public void ValidationForLessThan8()
        {
            var expectedResult = PasswordValidation(Passwords[0]);
            Assert.IsFalse(expectedResult, "invalid password", Passwords[0]);
        }

        [Test]
        public void ValidationForEqualsTo8()
        {
            var expectedResult = PasswordValidation(Passwords[1]);
            Assert.IsTrue(expectedResult, "valid password", Passwords[1]);
        }
        [Test]
        public void ValidationForBetween8And12()
        {
            var expectedResult = PasswordValidation(Passwords[2]);
            Assert.IsTrue(expectedResult, "valid password", Passwords[2]);
        }
        [Test]
        public void ValidationForEqualsTo12()
        {
            var expectedResult = PasswordValidation(Passwords[3]);
            Assert.IsTrue(expectedResult, "valid password", Passwords[3]);
        }
        
        [Test]
        public void ValidationForGreaterThan12()
        {
            var expectedResult = PasswordValidation(Passwords[4]);
            Assert.IsFalse(expectedResult, "invalid password", Passwords[4]);
        }
    }

}