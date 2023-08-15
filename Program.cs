namespace VinosBlancos
{
    internal class Program
    {
        static void Main()
        {
            //Opgave1();
            //Opgave2();
            Opgave3();
        }

        // Outputting each year as a percentage of stars where 175388 is the maximum value
        static void Opgave1()
        {
            const int max = 175388;
            const byte maxStar = 100;

            int[] vinos = new int[] { 175134, 175388, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };

            for (int i = 0; i < vinos.Length; i++)
            {
                int star = maxStar * vinos[i] / max;
                Console.WriteLine(string.Concat(Enumerable.Repeat("*", star)));
            }
        }

        // Year 2014 is off by 35432, so identify the key being 2014 and then add it to its value
        static void Opgave2()
        {
            const int max = 175388;
            const byte maxStar = 100;

            Dictionary<int, int> vinos = new() { { 2009, 175134 }, { 2010, 175388 }, { 2011, 172818 }, { 2012, 142709 }, { 2013, 151437 }, { 2014, 152620 }, { 2015, 150979 }, { 2016, 152210 }, { 2017, 149450 }, { 2018, 154398 }, { 2019, 150160 }, };

            foreach (int year in vinos.Keys.ToList())
            {
                if (year == 2014)
                {
                    vinos[year] += 35432;
                }
                int star = maxStar * vinos[year] / max;
                Console.WriteLine(string.Concat(Enumerable.Repeat("*", star)));
            }
        }

        // Same as assignment 1 but sorting the array first
        static void Opgave3()
        {
            const int max = 175388;
            const byte maxStar = 100;

            int[] vinos = new int[] { 175134, 175388, 172818, 142709, 151437, 152620, 150979, 152210, 149450, 154398, 150160 };

            Array.Sort(vinos);

            for (int i = 0; i < vinos.Length; i++)
            {
                int star = maxStar * vinos[i] / max;
                Console.WriteLine(string.Concat(Enumerable.Repeat("*", star)));
            }
        }
    }
}