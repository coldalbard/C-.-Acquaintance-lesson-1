using static Sorting;
using static System.Console;
using static infrastucture;

int size = 10;
int[] arr = size.CreateArray(min: -1, max: 15)
  .ShowArray()
  .SortQuick(left: 0,  right: size - 1)
  .ShowArray(", ");