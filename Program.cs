using System;
using System.Text;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Question 1:
            Console.WriteLine("Question 1:");
            int[] nums1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int numberOfUniqueNumbers = RemoveDuplicates(nums1);
            Console.WriteLine(numberOfUniqueNumbers);

            //Question 2:
            Console.WriteLine("Question 2:");
            int[] nums2 = { 0, 1, 0, 3, 12 };
            IList<int> resultAfterMovingZero = MoveZeroes(nums2);
            string combinationsString = ConvertIListToArray(resultAfterMovingZero);
            Console.WriteLine(combinationsString);

            //Question 3:
            Console.WriteLine("Question 3:");
            int[] nums3 = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> triplets = ThreeSum(nums3);
            string tripletResult = ConvertIListToNestedList(triplets);
            Console.WriteLine(tripletResult);

            //Question 4:
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 1, 0, 1, 1, 1 };
            int maxOnes = FindMaxConsecutiveOnes(nums4);
            Console.WriteLine(maxOnes);

            //Question 5:
            Console.WriteLine("Question 5:");
            int binaryInput = 101010;
            int decimalResult = BinaryToDecimal(binaryInput);
            Console.WriteLine(decimalResult);

            //Question 6:
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 6, 9, 1 };
            int maxGap = MaximumGap(nums5);
            Console.WriteLine(maxGap);

            //Question 7:
            Console.WriteLine("Question 7:");
            int[] nums6 = { 2, 1, 2 };
            int largestPerimeterResult = LargestPerimeter(nums6);
            Console.WriteLine(largestPerimeterResult);

            //Question 8:
            Console.WriteLine("Question 8:");
            string result = RemoveOccurrences("daabcbaabcbc", "abc");
            Console.WriteLine(result);
        }

        /*
        
        Question 1:
        Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

        Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

        Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
        Return k.

        Example 1:

        Input: nums = [1,1,2]
        Output: 2, nums = [1,2,_]
        Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
        Example 2:

        Input: nums = [0,0,1,1,1,2,2,3,3,4]
        Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
        Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
 

        Constraints:

        1 <= nums.length <= 3 * 104
        -100 <= nums[i] <= 100
        nums is sorted in non-decreasing order.
        */

        public static int RemoveDuplicates(int[] nums)
        {
            try
            {
                if (nums == null || nums.Length == 0)
                    return 0;

                int k = 1; // Initializing with one since the first element is always unique
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] != nums[i - 1]) // Checking if the current element is different from the previous one
                    {
                        nums[k] = nums[i]; // Moving the unique element to the next position
                        k++; // Increase the count of unique elements
                    }
                }
                return k;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
         * 
         * Self-Reflection :
         
           This question made by me with the manipulation of arrays most efficiently, especially in-place modifications like removing duplicates without using extra space.

           I implemented the solution and in the process revisited the array to check on the rest of the adjacent elements, hence repeating a review on concepts of traversing an array.

           From here, I have also learned the necessity to take care of such edge cases, empty arrays or when an array consists of just one element. Thus, I have been able to learn the importance of how to make sure that the function behaves rightly under each condition.

           This has been helpful in the sense that it further shows how conditional checks helped ensure that it does not The solution is efficient when it comes to time complexity, since it runs on a linear time. It may require performance implications in some aspects of array operations in big datasets, or when efficiency is quite important for real-time applications.

        /*
        
        Question 2:
        Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        Note that you must do this in-place without making a copy of the array.

        Example 1:

        Input: nums = [0,1,0,3,12]
        Output: [1,3,12,0,0]
        Example 2:

        Input: nums = [0]
        Output: [0]
 
        Constraints:

        1 <= nums.length <= 104
        -231 <= nums[i] <= 231 - 1
        */

        public static IList<int> MoveZeroes(int[] nums)
        {
            try
            {
                if (nums == null || nums.Length <= 1)
                    return nums.ToList();

                int nonZeroIndex = 0; // keep track of position for non-zero elements
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != 0)
                    {
                        nums[nonZeroIndex] = nums[i];
                        nonZeroIndex++;
                    }
                }
                for (int i = nonZeroIndex; i < nums.Length; i++) // Fill the remaining positions from nonZeroIndex to last of array length with zeroes
                {
                    nums[i] = 0;
                }              
                return nums.ToList(); // Convert array to list and return
            }
            catch (Exception)
            {
                throw;
            }
        }
        /*
         * Self-Reflection :
         
         * This question helps practice moving elements within an array with no extra space, which is a basic idea for many array manipulations.

            The solution implementation had traversing the array twice to shift nonzero elements to the front, and then to fill up the remaining locations with zeroes. This reinforced the array traversal methods.

            It was necessary to take care of edge cases, such as arrays with fewer than two elements or an array comprised only of zeros, in order that the function should be made to perform well within any set of test cases.

            The solution optimally handles array operations, such that it achieves the desired result without copies, whether in place or space. Purely inclined at efficiency in array manipulation.

            The relative order in which the movement of zeros to the end took place shows a way of preserving the original sequence and, therefore, gives more light into the underlining manipulation of the array techniques.
         */

        /*

        Question 3:
        Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

        Notice that the solution set must not contain duplicate triplets.

 

        Example 1:

        Input: nums = [-1,0,1,2,-1,-4]
        Output: [[-1,-1,2],[-1,0,1]]
        Explanation: 
        nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
        nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
        nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        The distinct triplets are [-1,0,1] and [-1,-1,2].
        Notice that the order of the output and the order of the triplets does not matter.
        Example 2:

        Input: nums = [0,1,1]
        Output: []
        Explanation: The only possible triplet does not sum up to 0.
        Example 3:

        Input: nums = [0,0,0]
        Output: [[0,0,0]]
        Explanation: The only possible triplet sums up to 0.
 

        Constraints:

        3 <= nums.length <= 3000
        -105 <= nums[i] <= 105

        */

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            try
            {
                IList<IList<int>> result = new List<IList<int>>();
                Array.Sort(nums); // Sort the array

                for (int i = 0; i < nums.Length - 2; i++)
                {
                    // Skip duplicates
                    if (i > 0 && nums[i] == nums[i - 1])
                        continue;

                    int left = i + 1;
                    int right = nums.Length - 1;

                    while (left < right)
                    {
                        int sum = nums[i] + nums[left] + nums[right];
                        if (sum == 0)
                        {
                            // Found a triplet
                            result.Add(new List<int> { nums[i], nums[left], nums[right] });

                            // Skip duplicates
                            while (left < right && nums[left] == nums[left + 1])
                                left++;
                            while (left < right && nums[right] == nums[right - 1])
                                right--;

                            left++;
                            right--;
                        }
                        else if (sum < 0)
                        {
                            left++; // Move left pointer to increase sum
                        }
                        else
                        {
                            right--; // Move right pointer to decrease sum
                        }
                    }
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Self-Reflection :
         
         * This problem was solved using some advanced array manipulation methods, for example, sorting and the use of multiple pointers to find the triplets equating to zero.

            The implementation needed great attention, especially in corner cases, so as to avoid recomputation and hence run fast.

            The answer involved the use of conditional statements for skip duplicates and adjusting the pointers based on the sum of the elements, reinforcing my skills in the use of conditional logic in algorithmic solutions.

            The use of data structures, like the list for storing and returning the result set, really makes me appreciate all years that data structures were stressed with advice on making the right choice of data structures for the accomplishment of efficient problem solutions.

            There was continuous effort maintained during the course of implementation to minimize the redundant computations and focus on improving the overall efficiency of the solution; hence, great focus has been given to algorithm optimization for improved performance.
         */

        /*

        Question 4:
        Given a binary array nums, return the maximum number of consecutive 1's in the array.

        Example 1:

        Input: nums = [1,1,0,1,1,1]
        Output: 3
        Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
        Example 2:

        Input: nums = [1,0,1,1,0,1]
        Output: 2
 
        Constraints:

        1 <= nums.length <= 105
        nums[i] is either 0 or 1.

        */

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            try
            {
                int mC = 0; // Maximum consecutive count of 1's
                int cC = 0; // Current consecutive count of 1's

                foreach (int num in nums)
                {
                    if (num == 1)
                    {
                        // Increment current count for consecutive 1's
                        cC++;
                    }
                    else
                    {
                        // Update maximum count and reset current count when encounter 0
                        mC = Math.Max(mC, cC);
                        cC = 0;
                    }
                }

                // Update mC for the last sequence of consecutive 1's
                mC = Math.Max(mC, cC);

                return mC;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Self-Reflection :
         
         * The solution required smart traversal through the array while updating the count of elements that are encountered, and it is then that this part of the lesson really made me master the techniques of how to traverse an array.

            Understanding the outcome in simpler terms, this result managed to hold and keep track of all the consecutive occurrences of the 1s in the binary array. Indeed, it's this realization that underlaid the counting of elements consecutively with great precision in algorithmic solutions.

            Where the solution was simple and brief, it keeps things simple and clear—not to be misunderstood or not even mismanaged.

            As for example, an array consisting of only one element or an array with all zeros has been specially taken into concern during the processing of the solution so that the function cares for all those edge cases.

            We are able to achieve time complexity best by efficiently updating the counts during array traversal, bringing out the point that due importance must be given to the fact that algorithms designed are very efficient.
         */

        /*

        Question 5:
        You are tasked with writing a program that converts a binary number to its equivalent decimal representation without using bitwise operators or the `Math.Pow` function. You will implement a function called `BinaryToDecimal` which takes an integer representing a binary number as input and returns its decimal equivalent. 

        Requirements:
        1. Your program should prompt the user to input a binary number as an integer. 
        2. Implement the `BinaryToDecimal` function, which takes the binary number as input and returns its decimal equivalent. 
        3. Avoid using bitwise operators (`<<`, `>>`, `&`, `|`, `^`) and the `Math.Pow` function for any calculations. 
        4. Use only basic arithmetic operations such as addition, subtraction, multiplication, and division. 
        5. Ensure the program displays the input binary number and its corresponding decimal value.

        Example 1:
        Input: num = 101010
        Output: 42


        Constraints:

        1 <= num <= 10^9

        */

        public static int BinaryToDecimal(int binary)
        {
            try
            {
                int decimalVal = 0; // Initialize the decimal value to 0
                int baseVal = 1; // Initialize the base value to 1

                while (binary != 0)
                {
                    int lDigit = binary % 10; // Extract the last digit of the binary number
                    binary /= 10; // Remove the last digit from the binary number

                    decimalVal += lDigit * baseVal; // Update the decimal value
                    baseVal *= 2; // Update the base value (power of 2)
                }

                return decimalVal;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Self-Reflection :
         
         * Implementation of the solution required me to know how a binary number is converted into a number of decimal representation by simple arithmetic operations, which deepened my knowledge toward the number systems.

            This solution is simple, clear, and presented with using few basic arithmetic operations to obtain the required conversion without depending on the operations of the bit operator set or functions using exponentiation.

            Highlighting that while loop with binary digits is updating decimal value at every iteration of the loop, it reiterates the three major activities being displayed and reinforces the efficiency of algorithms in problem-solving.

            In this case, manipulation of the binary number was aiding in the effects on the process of changing, and at the same time, gave rise to the importance of numerical operations in algorithmic solutions.

            This creativity in solving really drove home the importance of thinking about things like those when it came to designing the algorithm and how to avoid various functions and operators.
         */

        /*

        Question:6
        Given an integer array nums, return the maximum difference between two successive elements in its sorted form. If the array contains less than two elements, return 0.
        You must write an algorithm that runs in linear time and uses linear extra space.

        Example 1:

        Input: nums = [3,6,9,1]
        Output: 3
        Explanation: The sorted form of the array is [1,3,6,9], either (3,6) or (6,9) has the maximum difference 3.
        Example 2:

        Input: nums = [10]
        Output: 0
        Explanation: The array contains less than 2 elements, therefore return 0.
 

        Constraints:

        1 <= nums.length <= 105
        0 <= nums[i] <= 109

        */

        public static int MaximumGap(int[] nums)
        {
            try
            {
                if (nums == null || nums.Length < 2)
                    return 0;

                // Find minimum and maximum elements in the array
                int minN = int.MaxValue;
                int maxN = int.MinValue;
                foreach (int num in nums)
                {
                    minN = Math.Min(minN, num);
                    maxN = Math.Max(maxN, num);
                }

                // Calculate the minimum possible gap
                int minGap = (int)Math.Ceiling((double)(maxN - minN) / (nums.Length - 1));

                // Create buckets to store elements
                int numB = (maxN - minN) / minGap + 1;
                int[] minBucket = new int[numB];
                int[] maxBucket = new int[numB];
                Array.Fill(minBucket, int.MaxValue);
                Array.Fill(maxBucket, int.MinValue);

                // Distribute numbers into buckets
                foreach (int num in nums)
                {
                    int index = (num - minN) / minGap;
                    minBucket[index] = Math.Min(minBucket[index], num);
                    maxBucket[index] = Math.Max(maxBucket[index], num);
                }

                // Find the maximum gap between successive non-empty buckets
                int maxGap = 0;
                int prevMax = maxBucket[0];
                for (int i = 1; i < numB; i++)
                {
                    if (minBucket[i] != int.MaxValue)
                    {
                        maxGap = Math.Max(maxGap, minBucket[i] - prevMax);
                        prevMax = maxBucket[i];
                    }
                }

                return maxGap;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*public static int MaximumGap(int[] nums)
        {
            int[] Arr = nums;
            int max = 0;
            try
            {
                if (nums == null || nums.Length < 2)
                    return 0;

                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = i + 1; j < Arr.Length; j++)
                    {
                        if ((Arr[j] - Arr[i]) > max && Arr[j] == Arr[i + 1])
                        {
                            max = (Arr[j] - Arr[i]);
                        }
                        else if ((Arr[j] - Arr[i]) >= max && Arr[j] == Arr[i + 1]) // This method is for checking the same max value for different values
                        {
                            max = (Arr[j] - Arr[i]);
                        }
                    }
                }
                return max;
            }
            catch(Exception)
            {
                throw;
            }
        }*/

        /*
         * Self-Reflection :
         
         * The implementation of the solution in this case called for mathematical concepts, such as calculation of space between elements and distribution of numbers into the buckets. It also helped me understand how mathematical concepts need to be put in use while coming up with an algorithmic solution.

            The approach should ensure that the time complexity produced by it is linear, and the extra space used by it should also be linear. Above all, the emphasis is laid on efficiency in algorithms.

            The solution dealt with edge cases properly, e.g., when arrays contained less than two elements, hence ensuring that the function works perfect under any conditions, as most often, such cases will be thought over during algorithm design.

            The manipulation with the array for the distribution of elements in the buckets and the computation of gap between the elements gave an idea about how the manipulation is important.

            Weight was brought out in the work and highlighted careful design of the algorithm that implements adherence to the constraints more than bringing out the importance of constraint-aware problem-solving, like linear time complexity and linear extra space usage.
         */

        /*

        Question:7
        Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. If it is impossible to form any triangle of a non-zero area, return 0.

        Example 1:

        Input: nums = [2,1,2]
        Output: 5
        Explanation: You can form a triangle with three side lengths: 1, 2, and 2.
        Example 2:

        Input: nums = [1,2,1,10]
        Output: 0
        Explanation: 
        You cannot use the side lengths 1, 1, and 2 to form a triangle.
        You cannot use the side lengths 1, 1, and 10 to form a triangle.
        You cannot use the side lengths 1, 2, and 10 to form a triangle.
        As we cannot use any three side lengths to form a triangle of non-zero area, we return 0.

        Constraints:

        3 <= nums.length <= 104
        1 <= nums[i] <= 106

        */

        public static int LargestPerimeter(int[] nums)
        {
            try
            {
                Array.Sort(nums); // Sort the array in non-decreasing order              
                for (int i = nums.Length - 1; i >= 2; i--) // Iterate from right to left
                {
                    int a = nums[i - 2];
                    int b = nums[i - 1];
                    int c = nums[i];                  
                    if (a + b > c) // Check if a valid triangle can be formed
                    {                      
                        return a + b + c; // Return the perimeter of the triangle
                    }
                }              
                return 0; // No valid triangle can be formed
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Self-Reflection :
         
         * I was implementing the solution understandingly with the use of the triangle inequality theorem to ascertain if, with such lengths of sides presented, it is possible for a triangle of non-zero area to be formed. This helped me in relating the geometric understanding of concepts in algorithmic solutions.

            It was very simple and efficient, using an easily approached way of iterating through the sorted array to check for valid triangles, with clean and efficient design of the algorithm.

            The key use of these geometric ideas had shown the light to the fact that efficient algorithm design will be interdisciplinary and the mathematical ideas are to be used without fail.
         */

        /*

        Question:8

        Given two strings s and part, perform the following operation on s until all occurrences of the substring part are removed:

        Find the leftmost occurrence of the substring part and remove it from s.
        Return s after removing all occurrences of part.

        A substring is a contiguous sequence of characters in a string.

 

        Example 1:

        Input: s = "daabcbaabcbc", part = "abc"
        Output: "dab"
        Explanation: The following operations are done:
        - s = "daabcbaabcbc", remove "abc" starting at index 2, so s = "dabaabcbc".
        - s = "dabaabcbc", remove "abc" starting at index 4, so s = "dababc".
        - s = "dababc", remove "abc" starting at index 3, so s = "dab".
        Now s has no occurrences of "abc".
        Example 2:

        Input: s = "axxxxyyyyb", part = "xy"
        Output: "ab"
        Explanation: The following operations are done:
        - s = "axxxxyyyyb", remove "xy" starting at index 4 so s = "axxxyyyb".
        - s = "axxxyyyb", remove "xy" starting at index 3 so s = "axxyyb".
        - s = "axxyyb", remove "xy" starting at index 2 so s = "axyb".
        - s = "axyb", remove "xy" starting at index 1 so s = "ab".
        Now s has no occurrences of "xy".

        Constraints:

        1 <= s.length <= 1000
        1 <= part.length <= 1000
        s​​​​​​ and part consists of lowercase English letters.

        */

        public static string RemoveOccurrences(string s, string part)
        {
            try
            {
                int index;
                while ((index = s.IndexOf(part)) != -1)
                {
                    // Remove the leftmost occurrence of the substring part
                    s = s.Remove(index, part.Length);
                }
                return s;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Self-Reflection :
         
         * The implementation of the solution exposed me to using string manipulation methods like IndexOf and Remove, while locating and removing occurrences of a substring, basically reinforcing how strings are handled in algorithmic solutions.

            This solution employs a while loop to find and remove occurrences of the substring from the input string continuously from left to right. This approach displays efficiency in providing a solution to repetitive tasks in an efficient manner.

            This ensures that the function works fine and robustly, and thus it would require even more robust error handling in algorithm design. String manipulation errors can be avoided by handling exceptions that can be raised while manipulating strings, for example, index out-of-range errors.

            They followed ways of using built-in methods that manipulate strings in removing substrings, thus highly considered making full use of the optimized language features during the implementation of efficient algorithms.

            It had a very simple and clear solution that had clearly understandable code on how to remove occurrences of the substring to illustrate how the written code must be readable in algorithmic problem solutions.
         */


        /* Inbuilt Functions - Don't Change the below functions */
        static string ConvertIListToNestedList(IList<IList<int>> input)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("["); // Add the opening square bracket for the outer list

            for (int i = 0; i < input.Count; i++)
            {
                IList<int> innerList = input[i];
                sb.Append("[" + string.Join(",", innerList) + "]");

                // Add a comma unless it's the last inner list
                if (i < input.Count - 1)
                {
                    sb.Append(",");
                }
            }

            sb.Append("]"); // Add the closing square bracket for the outer list

            return sb.ToString();
        }


        static string ConvertIListToArray(IList<int> input)
        {
            // Create an array to hold the strings in input
            string[] strArray = new string[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                strArray[i] = "" + input[i] + ""; // Enclose each string in double quotes
            }

            // Join the strings in strArray with commas and enclose them in square brackets
            string result = "[" + string.Join(",", strArray) + "]";

            return result;
        }
    }
}
