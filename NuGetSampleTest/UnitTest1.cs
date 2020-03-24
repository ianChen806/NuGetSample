using System;
using NuGetSample;
using Xunit;

namespace NuGetSampleTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var myClass = new MyClass();
            var info = myClass.Info();
            
            Assert.Equal("Hello world",info);
        }
    }
}