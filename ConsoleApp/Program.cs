using WithIO = System.ObsoleteAttribute;
using static Domain.Operations;
#pragma warning disable CS0618 // Type is marked as IO
using static Services.ConsoleService;
#pragma warning restore CS0618 // Type is marked as IO

namespace ConsoleApp
{
    class Program
    {
        // enable next line to suppress these stupid emoji-containing errors
        // [WithIO]
        static void Main(string[] args)
        {
            Write("enter first line:");
            var first = Read();
            Write(null);

            Write("enter second line:");
            var second = Read();
            Write(null);

            Write($"here is `{nameof(Concat)}` result:");
            var final = Concat(first, second);
            Write(final);
            Write("   ＼( -_-)");
        }
    }
}
