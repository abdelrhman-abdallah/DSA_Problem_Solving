using System;
using System.Collections.Generic;

List<int> inputArray = new List<int>() { 2, 1, 2, 2, 2, 3, 4, 2 };
int toMove = 2;

static List<int> MoveElementToEnd(List<int> array, int toMove)
    {
        int strtIdx = 0;
        int endIdx = array.Count - 1;
        while (strtIdx < endIdx) 
        {
            while (strtIdx < endIdx && array[endIdx] == toMove) { endIdx--; }
            if (array[strtIdx] == toMove) { Swap(strtIdx, endIdx, array); }
            strtIdx++;
        }
        return array;
    }

static void Swap(int idxOne, int idxTwo, List<int> array) 
{
    int temp = array[idxOne];
    array[idxOne] = array[idxTwo];
    array[idxTwo] = temp;
}

MoveElementToEnd(inputArray, toMove);