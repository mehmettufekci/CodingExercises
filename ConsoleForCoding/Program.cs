using ConsoleForCoding.AddBorder;
using ConsoleForCoding.AdjacentElementsProduct;
using ConsoleForCoding.AlmostIncreasingSequence;
using ConsoleForCoding.AlternatingSum;
using ConsoleForCoding.ArcadeGame;
using ConsoleForCoding.CommonCharacterCount;
using ConsoleForCoding.ConsecutiveArray;
using ConsoleForCoding.InterestingPolygon;
using ConsoleForCoding.IsLucky;
using ConsoleForCoding.LongestString;
using ConsoleForCoding.MatrixElementsSum;
using ConsoleForCoding.Palindrome;
using ConsoleForCoding.ReverseInParentheses;
using ConsoleForCoding.SortByHeight;
using ConsoleForCoding.TakeCenturyFromYear;
using ConsoleForCoding.TwoSum;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net.Sockets;

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
//TwoSum twoSum = new();
//int[] nums = { 1, 3, 4, 2 };
//int target = 6;
//int[] result = twoSum.GetTwoSum(nums, target);
//Console.Write("Target: " + target.ToString() + " for two sum of the array elements are: [" + result[0].ToString() + "," + result[1].ToString() + "]");

//Finding the MatrixElementsSum --> Instructions are in the below
//After becoming famous, the CodeBots decided to move into a new building together.Each of the rooms has a different cost, and some of them are free, but there's a rumour that all the free rooms are haunted! Since the CodeBots are quite superstitious, they refuse to stay in any of the free rooms, or any of the rooms below any of the free rooms.

//Given matrix, a rectangular matrix of integers, where each value represents the cost of the room, your task is to return the total sum of all rooms that are suitable for the CodeBots (ie: add up all the values that don't appear below a 0).
//MatrixElementsSum matrixElementsSum = new();
//int[][] matrix = {
//                    new int[]{ 1,1,1,0 },
//                    new int[]{ 0,5,0,1 },
//                    new int[]{ 2, 1, 3, 10 }
//                };
//Console.Write("The matrix elements of the sum is: " + matrixElementsSum.GetMatrixElementsSum(matrix));


//An arcade game player wants to climb to the top of the leaderboard and track their ranking. The game uses Dense Ranking, so its leaderboard works like this:
//The player with the highest score is ranked number  on the leaderboard.
//Players who have equal scores receive the same ranking number, and the next player(s) receive the immediately following ranking number.

//int rankedCount = 7;

//List<int> ranked = new List<int> { 100, 100, 50, 40, 40, 20, 10 };

//int playerCount = 4;

//List<int> player = new List<int> { 5 ,25 ,50 ,120 };

//List<int> result = ArcadeGame.ClimbingLeaderboard(ranked, player);

//Console.WriteLine(String.Join("\n", result));

//Given an array of strings, return another array containing all of its longest strings.
//LongestString longestString = new();
//string[] inputString = new string[] { "a",
// "abc",
// "cbd",
// "zzzzzz",
// "a",
// "abcdef",
// "asasa",
// "aaaaaa" };
//string[] outputString = longestString.GetLongestStringsOfArray(inputString);
//Console.Write("The longest strings of the array is: " + string.Join("\n", outputString));

// Given two strings, find the number of common characters between them.
//string s1 = "a";
//string s2 = "aaa";
//CommonCharacterCount commonCharacterCount = new();
//Console.Write("Common character count is: " + commonCharacterCount.GetCommonCharacterCount(s1, s2));

//Ticket numbers usually consist of an even number of digits. A ticket number is considered lucky if the sum of the first half of the digits is equal to the sum of the second half.
//IsLucky lucky = new();
//int n = 134008;
//Console.Write("The ticket number lucky state is: " + lucky.GetIsLucky(n));

//Some people are standing in a row in a park. There are trees between them which cannot be moved. Your task is to rearrange the people by their heights in a non-descending order without moving the trees. People can be very tall!
//SortByHeight sortByHeight = new();
//int[] a = { -1, 150, 190, 170, -1, -1, 160, 180 };
//Console.Write("The rearranged the people by their heights are: [" + string.Join(", ", sortByHeight.GetSortByHeight(a)));

//Write a function that reverses characters in (possibly nested) parentheses in the input string.
//ReverseInParentheses reverseInParentheses = new ReverseInParentheses();
//string inputString = "foo(bar(baz))blim";
//Console.Write("This string: " + inputString + " of reverse in parentheses is: " + reverseInParentheses.GetReverseInParentheses(inputString));


//Several people are standing in a row and need to be divided into two teams. The first person goes into team 1, the second goes into team 2, the third goes into team 1 again, the fourth into team 2, and so on.
//You are given an array of positive integers - the weights of the people. Return an array of two integers, where the first element is the total weight of team 1, and the second element is the total weight of team 2 after the division is complete.
//AlternatingSum alternatingSum = new();
//int[] a = { 100, 50 };
//int[] result = alternatingSum.GetAlternatingSum(a);
//Console.Write("Alternating sum of the array elements are: [" + result[0].ToString() + "," + result[1].ToString() + "]");


//Given a rectangular matrix of characters, add a border of asterisks(*) to it.
AddBorder addBorder = new();
string[] picture = new string[] {"abcde",
 "fghij",
 "klmno",
 "pqrst",
 "uvwxy" };
string[] outputString = addBorder.GetBordertoPicture(picture);
Console.Write("The border of the picture is: " + string.Join("\n", outputString));