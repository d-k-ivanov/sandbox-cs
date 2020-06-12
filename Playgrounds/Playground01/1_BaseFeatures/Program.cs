using System;

namespace _1_BaseFeatures
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine('\n');

            PrintDataTypes();
            Console.WriteLine('\n');
        }

        private static void PrintDataTypes()
        {
            Console.WriteLine("Data types:");

            Console.WriteLine("\tSByte Min:    " + sbyte.MinValue      + "\t\t\t\tSByte Max:     "    + sbyte.MaxValue);
            Console.WriteLine("\tByte Min:     " + byte.MinValue       + "\t\t\t\t\tByte Max:      "  + byte.MaxValue);
            Console.WriteLine();

            Console.WriteLine("\tInt16 Min:    " + short.MinValue      + "\t\t\t\tInt16 Max:     "    + short.MaxValue);
            Console.WriteLine("\tUInt16 Min:   " + ushort.MinValue     + "\t\t\t\t\tUInt16 Max:    "  + ushort.MaxValue);
            Console.WriteLine();

            Console.WriteLine("\tInt32 Min:    " + int.MinValue        + "\t\t\tInt32 Max:     "      + int.MaxValue);
            Console.WriteLine("\tUInt32 Min:   " + uint.MinValue       + "\t\t\t\t\tUInt32 Max:    "  + uint.MaxValue);
            Console.WriteLine();

            Console.WriteLine("\tInt64 Min:    " + long.MinValue       + "\t\tInt64 Max:     "        + long.MaxValue);
            Console.WriteLine("\tUInt64 Min:   " + ulong.MinValue      + "\t\t\t\t\tUInt64 Max:    "  + ulong.MaxValue);
            Console.WriteLine();

            Console.WriteLine("\tDecimal Min:  " + decimal.MinValue    + "\tDecimal Max:   "          + decimal.MaxValue);
            Console.WriteLine();

            Console.WriteLine("\tSingle Min:   " + float.MinValue      + "\t\t\tSingle Max:    "      + float.MaxValue);
            Console.WriteLine("\tDouble Min:   " + double.MinValue     + "\t\tDouble Max:    "        + double.MaxValue);
            Console.WriteLine();

            Console.WriteLine("\tChar Min:     " + (int) char.MinValue + "\t\t\t\t\tChar Max:      "  + (int) char.MaxValue);
            Console.WriteLine("\tBoolean True: " + bool.TrueString     + "\t\t\t\tBoolean False: "    + bool.FalseString);
            Console.WriteLine();

            Console.WriteLine("\tDateTime Min: " + DateTime.MinValue   + "\t\tDateTime Max:  "      + DateTime.MaxValue);
            Console.WriteLine("\tTimeSpan Min: " + TimeSpan.MinValue   + "\tTimeSpan Max:  "        + TimeSpan.MaxValue);
            Console.WriteLine();

            Console.WriteLine("\tGuid:         " + Guid.NewGuid());
            Console.WriteLine("\tString        " + "string".GetType());
            Console.WriteLine("\tObject:       " + new object());
            Console.WriteLine();

            Console.WriteLine("Data type sizes:");
            Console.WriteLine("\tsizeof(bool):     " + sizeof(bool));
            Console.WriteLine("\tsizeof(sbyte):    " + sizeof(sbyte));
            Console.WriteLine("\tsizeof(byte):     " + sizeof(byte));
            Console.WriteLine("\tsizeof(short):    " + sizeof(short));
            Console.WriteLine("\tsizeof(ushort):   " + sizeof(ushort));
            Console.WriteLine("\tsizeof(int):      " + sizeof(int));
            Console.WriteLine("\tsizeof(uint):     " + sizeof(uint));
            Console.WriteLine("\tsizeof(long):     " + sizeof(long));
            Console.WriteLine("\tsizeof(ulong):    " + sizeof(ulong));
            Console.WriteLine("\tsizeof(char):     " + sizeof(char));
            Console.WriteLine("\tsizeof(float):    " + sizeof(float));
            Console.WriteLine("\tsizeof(double):   " + sizeof(double));
            Console.WriteLine("\tsizeof(decimal):  " + sizeof(decimal));
            Console.WriteLine("\t------------------");
            Console.WriteLine("\tsizeof(TimeSpan): " + sizeof(long));        // Fake, just to print proper size
            Console.WriteLine("\tsizeof(DateTime): " + sizeof(ulong));       // Fake, just to print proper size
            Console.WriteLine("\tsizeof(object):   " + sizeof(long));        // Fake, just to print proper size
            Console.WriteLine("\tsizeof(Guid):     " + sizeof(decimal));     // Fake, just to print proper size

        }
    }
}
