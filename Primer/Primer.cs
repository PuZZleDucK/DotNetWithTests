using System;

namespace Primer.Services
{
    public class PrimerService
    {
        public bool isPrime(int candidate)
        {
            if(candidate < 2)
            {
                return false;
            }
            if(candidate %2 == 0)
            {
                return false;
            }
            throw new NotImplementedException("TDD man");
        }
    }
}
