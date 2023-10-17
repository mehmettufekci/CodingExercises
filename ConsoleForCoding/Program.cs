using ConsoleForCoding.AdjacentElementsProduct;
using ConsoleForCoding.AlmostIncreasingSequence;
using ConsoleForCoding.ConsecutiveArray;
using ConsoleForCoding.InterestingPolygon;
using ConsoleForCoding.MatrixElementsSum;
using ConsoleForCoding.Palindrome;
using ConsoleForCoding.TakeCenturyFromYear;
using ConsoleForCoding.TwoSum;

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
//ConsecutiveArray consecutiveArray  = new();
//int[] statues = { 6, 2, 3, 8 };
//Console.Write("Missing elements number of the Consecutive Array is: " + consecutiveArray.GetMissingElementsNumberOfConsecutiveArray(statues));

//Finding the AlmostIncreasingSequence
//AlmostIncreasingSequence almostIncreasingSequence  = new();
//int[] sequnce = { 0, -2, 5, 6 };
//Console.Write("The sequence Almost Increasing Sequence status is: " + almostIncreasingSequence.IsAlmostIncreasingSequence(sequnce));

//Finding the Two Sum of the array for target
TwoSum twoSum = new();
int[] nums = { 1, 3, 4, 2 };
int target = 6;
int[] result = twoSum.GetTwoSum(nums, target);
Console.Write("Target: " + target.ToString() + " for two sum of the array elements are: [" + result[0].ToString() + "," + result[1].ToString() + "]");

//Finding the MatrixElementsSum
//MatrixElementsSum matrixElementsSum = new();
//int[] matrix = {[0, 1, 1, 2],
//          [0, 5, 0, 0],
//          [2, 0, 3, 3]};
//Console.Write("The sequence Almost Increasing Sequence status is: " + almostIncreasingSequence.IsAlmostIncreasingSequence(sequnce));