using System;
using System.Collections.Generic;

namespace PrimeLooker
{
    class Prime
    {
        private int _input;

        public Prime(int input)
        {
            _input = input;
        }

        public string PrimeChecker()
        {
            List<int> PrimeFinder = new List<int>();
            string results = "";
            for (int x = 2; x<_input; x++)
            {
                PrimeFinder.Add(x);
            }
            for (int i = 0; i<PrimeFinder.Count; i++)
            {
                for (int j = i+ 1; j < PrimeFinder.Count;j++)
                {
                    if (PrimeFinder[j]%PrimeFinder[i]==0)
                    {
                        PrimeFinder.RemoveAt(j);
                    }
                }
                results +=PrimeFinder[i].ToString() + " ";

            }
            return results;
        }
    }
}