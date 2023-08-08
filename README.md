# Short Intro

This Problem wants to find out if the sequence inside the given array exists inside of a bigger given array, so validate that the sequence given is a subsequnce inside the bigger array.

For Example:

input array = [5,1,22,23,6,-1,7,10]
sequence = [1,6,-1,10]

# Simple walk through:

Sequential Element Detection:

- Loop through the input array once.
- Maintain a pointer pointing at the start of the sequence array.
- For each iteration:

  - Check if the value at the pointer matches an element inside the input array.
  - If it matches, increment the pointer to move through the sequence.
  - If not, continue the loop.
  - Stop looping when the pointer exceeds the length of the sequence array or when the loop completes.

- If the pointer equals the length of the sequence array then it is a sub sequence of the input array, else it isnot
- This Solution has a Time Complexity of Big O (N) where N is the Length of the input array.
- This Solution has Space COmplexity of Big O (1) because we didn't use any auxilary space in relation to N.

  This approach aims to detect a sequential sequence of elements within the input array by iterating through it only once. The pointer helps track the progress within the sequence, and each step ensures that the corresponding element is found in the input array. This method is efficient as it reduces unnecessary comparisons and avoids redundant iterations.
