using System;
using System.Linq;

namespace RomanDate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date in M/D/Y format!");
            var entry = Console.ReadLine();
            var date = DateTime.Parse(entry);
            Console.WriteLine($"The Roman date is: {ConvertToRomanNumeral(date.Month)}.{ConvertToRomanNumeral(date.Day)}.{ConvertToRomanNumeral(date.Year)}");
            Console.ReadLine();
        }

        static public string ConvertToRomanNumeral(int value)
        {
            var ones = RomanDigit(value % 10, "I", "V", "X");
            var tens = RomanDigit(value / 10 % 10, "X", "L", "C");
            var hundreds = RomanDigit(value / 100 % 10, "C", "D", "M");
            var thousands = RomanDigit(value / 1000 % 10, "M", "\u0305V", "\u0305X");
            var tenthousands = RomanDigit(value / 10000 % 10, "\u0305X", "\u0305L", "\u0305C");

            return tenthousands + thousands + hundreds + tens + ones;
        }


        static protected string RomanDigit(int value, string single, string five, string ten)
        {
            var suffix = string.Concat(Enumerable.Repeat(single, (value % 5) % 4));
            var prefix = ((value + 2) % 5) == 1 ? $"{single}" : "";
            var fives = (value + 1) / 5;
            var main = fives == 0 ? "" : fives == 1 ? $"{five}" : $"{ten}";
            return $"{prefix}{main}{suffix}";
        }

    }
}