using System;
using System.Security.Cryptography;

string validChars = "";

Console.WriteLine("Do you want include numbers");
var includeNumbers = Console.ReadLine();
if (includeNumbers.StartsWith("y"))
{
    validChars += "1234567890";
}

Console.WriteLine("Do you want include lowercase characters");
var includeLowercaseCharacters = Console.ReadLine();
if (includeLowercaseCharacters.StartsWith("y"))
{
    validChars += "abcdefghijklmnopqrstuvwxyz";
}

Console.WriteLine("Do you want include uppercase characters");
var includeUppercaseCharacters = Console.ReadLine();
if (includeUppercaseCharacters.StartsWith("y"))
{
    validChars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
}

Console.WriteLine("Do you want include special characters");
var includeSpecialCharacters = Console.ReadLine();
if (includeSpecialCharacters.StartsWith("y"))
{
    validChars += "!@#$%^&*()_-+=[]{}|;':\",.<>?";
}

Console.WriteLine("How long do you want to keep your password length");
var length = int.Parse(Console.ReadLine());

byte[] data = new byte[length];
using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
{
    crypto.GetBytes(data);
}

string result = "";

foreach (byte b in data)
{
    result += validChars[b % (validChars.Length)];
}

Console.WriteLine("------------------------------------------------------");
Console.WriteLine(result);
Console.WriteLine("------------------------------------------------------");