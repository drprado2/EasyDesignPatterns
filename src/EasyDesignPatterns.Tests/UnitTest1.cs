using System;
using FluentAssertions;
using Xunit;

namespace EasyDesignPatterns.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void meu_teste_top()
        {
            var a= 245;
            a.Should().Be(245);
        }
        [Fact]
        public void outro_teste_maluco()
        {
            var a= 245;
            a.Should().Be(245);
        }
        [Fact]
        public void mais_um_teste()
        {
            var a= 245;
            a.Should().Be(245);
        }
    }
}
