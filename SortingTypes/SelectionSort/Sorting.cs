public static class Sorting
{
    /// <summary>
    /// Сортировка методом выбора
    /// </summary>
    /// <param name="collection">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] SortSelection(this int[] collection)
    {
        int size = collection.Length;
        for (int i = 0; i < size - 1; i++)
        {
            int pos = i;
            for (int j = i + 1; j < size; j++)
            {
                if (collection[j] < collection[pos]) pos = j;
            }
            int temp = collection[i];
            collection[i] = collection[pos];
            collection[pos] = temp;
        }
        return collection;
    }

    /// <summary>
    /// Сортировка методом пузырька
    /// </summary>
    /// <param name="collection">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] BubbleSorting(this int[] collection)
    {
        int size = collection.Length;
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (collection[i] > collection[j])
                {
                    int temp = collection[i];
                    collection[i] = collection[j];
                    collection[j] = temp;
                }
            }
        }
        return collection;
    }

    /// <summary>
    /// Сортировка быстрая
    /// </summary>
    /// <param name="collection">Исходный массив</param>
    /// <param name="left">первый индекс массива</param>
    /// <param name="right">последний индекс массива</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] SortQuick(this int[] collection, int left, int right)
    {
        int i = left;
        int j = right;

        int pivot = collection[Random.Shared.Next(left, right)];
        while (i <= j)
        {
            while (collection[i] < pivot) i++;
            while (collection[j] > pivot) j--;

            if (i <= j)
            {
                int t = collection[i];
                collection[i] = collection[j];
                collection[j] = t;
                i++;
                j--;
            }
        }
        if (i < right) SortQuick(collection, i, right);
        if (left < j) SortQuick(collection, left, j);
        return collection;
    }
}