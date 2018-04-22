using System;
using FluentAssertions;
using Xunit;

namespace EasyDesignPatterns.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a= 245;
            a.Should().Be(255);
        }
    }
}
