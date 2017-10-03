using System;
using Xunit;
using C_PE1;
namespace PE_ts
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Palindrome P = new Palindrome();
            int result= P.Palindromeyo(454);
            Assert.Equal(8,result);

        }
    }
}
