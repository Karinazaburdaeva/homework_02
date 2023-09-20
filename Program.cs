namespace Homework_02
{
    class Programm
    {
        static void Main()
        {
            byte B = 41;
            sbyte SB = 41;
            short S = 41;
            ushort US = 41;
            int I = 41;
            uint UI = 41;
            long L = 41;
            ulong UL = 41;
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", "Type", "Size", "Example", "Maximum value", "Minimal value");
            Console.WriteLine("|{0}|{0}|{0}|{0}|{0}|", "----------");
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (byte), sizeof (byte), B, byte.MinValue, byte.MaxValue);
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (sbyte), sizeof (sbyte), SB, sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (short), sizeof (short), S, short.MinValue, short.MaxValue);
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (ushort), sizeof (ushort), US, ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (int), sizeof (int), I, int.MinValue, int.MaxValue);
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (uint), sizeof (uint), UI, uint.MinValue, uint.MaxValue);
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (long), sizeof (long), L, long.MinValue, long.MaxValue);
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|", typeof (ulong), sizeof (ulong), UL, ulong.MinValue, ulong.MaxValue);
        }
    }
}
