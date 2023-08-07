// See https://aka.ms/new-console-template for more information
using MacheteBang.Playground.Console.Services;

int value = 10;
Console.WriteLine($"Value after Conversion: {ConversionService.I2A(value)}");
Console.WriteLine($"Value before Conversion: {value} (confirming no mutation)");

