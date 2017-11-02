using System;
using Xunit;
using Primer.Services;

namespace Primer.Tests.Services
{
    public class Primer_IsPrimeShould
    {
        private readonly PrimerService _primer;
        public Primer_IsPrimeShould()
        {
            _primer = new PrimerService();
        }

        [Fact]
        public void FalseIfGiven1()
        {
            var result = _primer.isPrime(1);
            Assert.False(result, "1 should not be prime");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(2000)]
        [InlineData(24680)]
        public void FalseIfGivenEven (int candidate)
        {
            var result = _primer.isPrime(candidate);
            Assert.False(result, "evens should never be prime");
        }
    }
}
