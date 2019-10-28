using System;
using Xunit;
using Xunit.Extensions;
using BitFlagger;
namespace BitFlaggerTests
{
    public class BitFlaggerTest
    {
        [Fact]
        public void SingleStateTest()
        {
            USStateBitFlags uSStateBitFlags = new USStateBitFlags();
            uSStateBitFlags.Set("CA");
            Assert.True(uSStateBitFlags.Check("CA"));
            Console.Write("Single State Test Passed");
            
        }
        [Fact]
        public void TwoStateTest()
        {
            USStateBitFlags uSStateBitFlags = new USStateBitFlags();
            Assert.False(uSStateBitFlags.Check("NV"));
            Assert.False(uSStateBitFlags.Check("CA"));
            uSStateBitFlags.Set("CA");
            uSStateBitFlags.Set("NV");
            Assert.True(uSStateBitFlags.Check("NV"));
            Assert.True(uSStateBitFlags.Check("CA"));
            Assert.False(uSStateBitFlags.Check("NJ"));
            Console.Write("Two State Test Passed");

        }

    }
}
