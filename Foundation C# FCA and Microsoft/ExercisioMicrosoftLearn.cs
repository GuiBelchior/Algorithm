//string[] values = { "12.3", "45", "ABC", "11", "DEF" };
//decimal total = 0m;
//string message = "";
//foreach (var value in values)
////{
//decimal number; //Guarda o Tryparse de um valor "OUT" ( que passa de int para decimal)
//string currentValue = name;
//if (decimal.TryParse(value,out number))
////    total += number;
//    }
//    else
//{
//message += value;
//    }
//}
//
//Console.WriteLine($"Message: {message}");
//Console.WriteLine($"Total: {total}");

//int value1 = 12;
//decimal value2 = 6.2m;
//float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
//decimal result1Decimal = value1 / value2;
// result1 = (int)Math.Round(result1Decimal);
//.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2

// result2Decimal = value2 / value3;
// result2 =(decimal)Math.Round(result2Decimal)
//.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
//.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}