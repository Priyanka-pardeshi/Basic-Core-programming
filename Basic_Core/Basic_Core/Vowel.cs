using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core
{
    class Vowel
    {
        public void CheckVowel(char alphabet)
        {
            if (alphabet == 'a' | alphabet == 'e' | alphabet == 'i' | alphabet == 'o' | alphabet == 'u' | alphabet == 'A' | alphabet == 'E' | alphabet == 'I' | alphabet == 'O' | alphabet == 'U')
            {
                Console.WriteLine(alphabet + " is vowel");
            }
            else
            {
                Console.WriteLine(alphabet + " is consonant");
            }
        }
    }
}
