using ConsoleForCoding.Palindrome;
using ConsoleForCoding.TakeCenturyFromYear;

//CenturyFromYear ins = new();
//int year = 1905;
//Console.Write("This is the century:" + ins.GetCentury(year) + " of the year: " + year.ToString());

Palindrome palindrome = new();

string inputString = "";

Console.Write("This string: " + inputString + " plaindrome status: " + palindrome.CheckPalindrome(inputString));
