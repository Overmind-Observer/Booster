namespace Booster
{
    class Reader
    {
        public static string Get()
        {
            ///Reading stream and transfer it to the string
            ///
            var stream = new CodingTest.Library.WordStream();
            stream.ReadByte();
            string text = stream.ToString();
            return text;
        }
        
    }
}
