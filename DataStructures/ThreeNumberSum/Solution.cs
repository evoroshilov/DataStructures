using System;
using System.Collections.Generic;

namespace ThreeNumberSum
{
    public class Solution
    {
		/*
		 Three Number Sum
         Write a function that takes in a non-empty array of distinct integers and an integer representing a target sum. 
		 The function should find all triplets in the array that sum up to the target sum and return a two-dimensional array of all these triplets. 
		 The numbers in each triplet should be ordered in ascending order, and the triplets themselves should be ordered in ascending order with respect to the numbers they hold.
	     If no three numbers sum up to the target sum, the function should return an empty array.

	   	 Sample input array = [12, 3, 1, 2, -6, 5, -8, 6],targetSum = 0
		 Sample Output [[-8, 2, 6], [-8, 3, 5], [-6, 1, 5]]

		 Hints:
		 Using three for loops to calculate the sums of all possible triplets in the array would generate an algorithm that runs in O(n^3) time, where n is the length of the input array. Can you come up with something faster using only two for loops?

		 Try sorting the array and traversing it once. At each number, place a left pointer on the number immediately to the right of your current number and a right pointer on the final number in the array. Check if the current number, the left number, and the right number sum up to the target sum. How can you proceed from there, remembering the fact that you sorted the array?

		 Since the array is now sorted (see Hint #2), you know that moving the left pointer mentioned in Hint #2 one place to the right will lead to a greater left number and thus a greater sum. Similarly, you know that moving the right pointer one place to the left will lead to a smaller right number and thus a smaller sum. This means that, depending on the size of each triplet's (current number, left number, right number) sum relative to the target sum, you should either move the left pointer, the right pointer, or both to obtain a potentially valid triplet.

		 Time complexity O(n^2) time | O(n) space - where n is the length of the input array
		 */

		public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
		{
			var list = new List<int[]>();

			Array.Sort(array);			

			for (int i = 0; i < array.Length; i++)
			{
				int leftIdx = i + 1;
				int rightIdx = array.Length - 1;

				while (leftIdx < rightIdx)
				{
					var idxVal = array[i];
					var leftVal = array[leftIdx];
					var rightVal = array[rightIdx];

					var result = idxVal + leftVal + rightVal;

					if (result > targetSum)
						rightIdx--;
					else if (result < targetSum)
						leftIdx++;
					else
					{
						list.Add(new int[3] { idxVal, leftVal, rightVal });
						rightIdx--;
						leftIdx++;
					}
				}
			}

			return list;
		}
	}
}
