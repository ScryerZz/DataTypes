﻿using System;


/*
 * Типы данных в C#
 */


namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Тип {0,8} |\t .Net {1,8} |\t Размер = {2} |\t MIN = {3,30} |\t MAX = {4}";

            Console.Title = "Типы данных в C#";

            Console.WriteLine("\n \t \t \t \t \t ЧИСЛОВЫЕ (целочисленные) ТИПЫ: \n");

            Console.WriteLine(string.Format(msg, "byte", typeof(byte).Name, sizeof(byte), byte.MinValue, byte.MaxValue));

            Console.WriteLine(string.Format(msg, "sbyte", typeof(sbyte).Name, sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));

            Console.WriteLine(string.Format(msg, "short", typeof(short).Name, sizeof(short), short.MinValue, short.MaxValue));

            Console.WriteLine(string.Format(msg, "ushort", typeof(ushort).Name, sizeof(ushort), ushort.MinValue, ushort.MaxValue));

            Console.WriteLine(string.Format(msg, "int", typeof(int).Name, sizeof(int), int.MinValue, int.MaxValue));

            Console.WriteLine(string.Format(msg, "uint", typeof(uint).Name, sizeof(uint), uint.MinValue, uint.MaxValue));

            Console.WriteLine(string.Format(msg, "long", typeof(long).Name, sizeof(long), long.MinValue, long.MaxValue));

            Console.WriteLine(string.Format(msg, "ulong", typeof(ulong).Name, sizeof(ulong), ulong.MinValue, ulong.MaxValue));

            Console.WriteLine("\n \t \t \t \t \t ЧИСЛОВЫЕ (с плавующей точкой) ТИПЫ: \n");

            Console.WriteLine(string.Format(msg, "float", typeof(float).Name, sizeof(float), float.MinValue, float.MaxValue));

            Console.WriteLine(string.Format(msg, "double", typeof(double).Name, sizeof(double), double.MinValue, double.MaxValue));

            Console.WriteLine(string.Format(msg, "decimal", typeof(decimal).Name, sizeof(decimal), decimal.MinValue, decimal.MaxValue));

            Console.WriteLine("\n \t \t \t \t \t СИМВОЛЬНЫЕ ТИПЫ: \n");

            Console.WriteLine(string.Format(msg, "char", typeof(char).Name, sizeof(char), char.MinValue, char.MaxValue));

            Console.WriteLine(string.Format(msg, "string", typeof(string).Name, "N/A", "N/A", "N/A"));

            Console.WriteLine("\n \t \t \t \t \t ЛОГИЧЕСКИЙ ТИП: \n");

            Console.WriteLine(string.Format(msg, "bool", typeof(bool).Name, sizeof(bool), "False", "True"));

            Console.WriteLine("\n \t \t \t \t \t ОСОБЫЕ ТИПЫ: \n");

            Console.WriteLine(string.Format(msg, "object", typeof(object).Name, "N/A", "N/A", "N/A"));

            Console.WriteLine(string.Format(msg, "dynamic", "N/A", "N/A", "N/A", "N/A"));
        }
    }
}
