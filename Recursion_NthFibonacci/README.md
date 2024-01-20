# Short Intro

## 🔍 Problem Overview:

The task is to find the nth number in the Fibonacci sequence, where the sequence is defined as 0, 1, 1, 2, 3, 5, 8, ... with each number being the sum of the two preceding ones. The first Fibonacci number is 0 and the second is 1.

## 🌟 Example:

Input: 5
Solution: 3 (The 5th number in the Fibonacci sequence)

the problem wants us to make a function that should return an int that is the nth element in the fibonacci sequence.

# Simple Walkthrough

## Recursive Solution (Brute Force)

📝 Description:

- Base Cases: The function immediately returns 0 for n = 1, and 1 for n = 2.
- Recursive Calls: For n > 2, the function calls itself twice once for n-1 and once for n-2.
- Summation: The results of these two calls are summed up to get the current Fibonacci number.
- Repeated Work: This method recalculates the same Fibonacci numbers multiple times.

🧠 Technique: The function recursively calls itself to calculate the previous two Fibonacci numbers until it reaches the base cases.
🕒 Time Complexity: O(2^n)
📚 Space Complexity: O(n)

## Recursive Solution With Memoization (Caching)

📝 Description:

- Initialization: A hashtable or array is initialized to store computed Fibonacci numbers.
- Base Cases: Returns 0 for n = 1, and 1 for n = 2.
- Memoization Check: Before recursion, checks if the Fibonacci number for n is already computed.
- Recursive Calls: If not already computed, the function calls itself for n-1 and n-2.
- Storing Results: The sum is stored in the hashtable or array.
- Return: Returns the stored value for n.

🧠 Technique: Utilizes a hashtable or array for memoization, reducing redundant calculations.
🕒 Time Complexity: O(n)
📚 Space Complexity: O(n)

## 3. Iterative Solution (Optimal)

📝 Description:

- Initialization: Two variables are initialized to hold the last two Fibonacci numbers (initially 0 and 1).
- Iteration: A loop starts from 3 to n.
- Updating Variables: In each iteration, the next Fibonacci number is calculated by summing the two variables.
- Shifting: The values of the two variables are updated for the next iteration.
- Efficient: Avoids the overhead of recursive calls and does not require additional space for storing intermediate results.

🧠 Technique: Uses a loop and two variables to store the last two Fibonacci numbers, updating them with each iteration.
🕒 Time Complexity: O(n)
📚 Space Complexity: O(1)

# Analysis

- The recursive solution is simple but inefficient for large n due to exponential time complexity.
- Memoization significantly improves the recursive approach, making it feasible for larger n.
- The iterative solution is the most efficient, particularly in terms of space complexity, as it avoids the overhead of recursive calls.
