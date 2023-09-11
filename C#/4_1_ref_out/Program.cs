namespace zad1
{
    internal class Program
    {
        static void rangeByte(byte min, byte max)
        {
            min = byte.MinValue;
            max = byte.MaxValue;
            Console.WriteLine($"min={min}, max={max}");
        }
        static void rangeByte(ref byte min, ref byte max)
        {
            min = byte.MinValue;
            max = byte.MaxValue;
            Console.WriteLine($"min={min}, max={max}");
        }
        static void rangeByteOut(out byte min, out byte max)
        {
            min = byte.MinValue;
            max = byte.MaxValue;
            Console.WriteLine($"min={min}, max={max}");
        }

        static void Main(string[] args)
        {
            byte x = 1, y = 2;
            rangeByte(x, y);
            Console.WriteLine($"x={x}, y={y}");
            rangeByte(ref x, ref y);
            Console.WriteLine($"x={x}, y={y}");

            x = 1;
            y = 2;

            rangeByteOut(out x, out y);
            Console.WriteLine($"x={x}, y={y}");
        }
    }
}