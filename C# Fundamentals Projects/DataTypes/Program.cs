/* 
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
 */
//Signed integral types:
//sbyte  : -128 to 127
//short  : -32768 to 32767
//int    : -2147483648 to 2147483647
//long   : -9223372036854775808 to 9223372036854775807


/* 
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
 */
//Unsigned integral types:
//byte   : 0 to 255
//ushort : 0 to 65535
//uint   : 0 to 4294967295
//ulong  : 0 to 18446744073709551615


/* 
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
 */
//Floating point types:
//float  : -3.4028235E+38 to 3.4028235E+38 (with ~6-9 digits of precision)
//double : -1.7976931348623157E+308 to 1.7976931348623157E+308 (with ~15-17 digits of precision)
//decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precisio//n)

//////////////////////////////

/* The new keyword informs.NET Runtime to create an instance of int array, and then coordinate with the operating system to store the array sized for three int values in memory.The.NET Runtime complies, and returns a memory address of the new int array.Finally, the memory address is stored in the variable data.The int array's elements default to the value 0, because that is the default value of an int. */
int[] data = new int[3];


/* The string data type is also a reference type. You might be wondering why a new operator wasn't used when declaring a string. This is purely a convenience afforded by the designers of C#. Because the string data type is used so frequently. Behind the scenes, however, a new instance of System.String is created and initialized to "Hello World!". */
string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);