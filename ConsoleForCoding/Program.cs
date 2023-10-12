using ConsoleForCoding.AdjacentElementsProduct;
using ConsoleForCoding.ConsecutiveArray;
using ConsoleForCoding.InterestingPolygon;
using ConsoleForCoding.Palindrome;
using ConsoleForCoding.TakeCenturyFromYear;

//Centruy From Year tests
//CenturyFromYear ins = new();
//int year = 1905;
//Console.Write("This is the century:" + ins.GetCentury(year) + " of the year: " + year.ToString());

//Palindrome tests
//Palindrome palindrome = new();
//string inputString = "abac";
//Console.Write("This string: " + inputString + " plaindrome status: " + palindrome.CheckPalindrome(inputString));

//Adjacent Elements Product tests
//AdjacentElementsProduct adjacentElements = new();
//int[] inputArray = { -23, 4, -3, 8, -12 };
//Console.Write("Adjacent Elements Product is: " + adjacentElements.GetAdjacentElementLargestProduct(inputArray));

//Get Area of the Interesting Polygon
//InterestingPolygon polygon = new();
//int n = 3;
//Console.Write("The are of the n: " + n.ToString() + " interesting polygon is: " + polygon.GetInterestingPolygonArea(n).ToString());

//Finding the Consecutive Array elements
ConsecutiveArray consecutiveArray  = new();
int[] statues = { 6, 2, 3, 8 };
Console.Write("Missing elements number of the Consecutive Array is: " + consecutiveArray.GetMissingElementsNumberOfConsecutiveArray(statues));