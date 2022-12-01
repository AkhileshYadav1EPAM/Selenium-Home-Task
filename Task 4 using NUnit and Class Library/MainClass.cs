

using Task_4_NUnit;

namespace Task_4_using_NUnit_and_Class_Library
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            PasswordTests p = new PasswordTests();
            p.Setup();
            p.ValidationForLessThan8();
            p.ValidationForEqualsTo8();
            p.ValidationForBetween8And12();
            p.ValidationForEqualsTo12();
            p.ValidationForGreaterThan12();
        }
    }
}