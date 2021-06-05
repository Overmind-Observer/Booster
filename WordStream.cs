using NLipsum.Core;
using Booster.CodingTest.Library;
using System.Text;
using System.Collections.Generic;

namespace Booster
{
    class WordStream 
    {
        static readonly CodingTest.Library.WordStream stream = new();
        public static char Get()
        {          
            ///Reading stream and transfer it to the string
            ///
            int Byte;
            var bytes = new byte[1];
            Byte = stream.ReadByte();
            if (Byte == -1) return '\0'; 
            //char c = '\''; 
            bytes[0] = (byte)Byte;
            
            char[] chars = Encoding.UTF8.GetChars(bytes, 0, 1);
            return chars[0];
            
        }
    }
}
