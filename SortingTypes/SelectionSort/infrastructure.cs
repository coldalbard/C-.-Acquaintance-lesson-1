using static System.Console;
public static class infrastucture

{
    /// <summary>
    /// Метод, создания массива и заполнения массива
    /// </summary>
    /// <param name="size">Размер новго массива</param>
    /// <param name="min">Нижняя граница заполнения</param>
    /// <param name="max">Верхняя граница заполнения</param>
    /// <returns>Новый массив</returns>
    public static int[] CreateArray(this int size, int min = 0, int max = 10){
        return Enumerable.Range(1, size)
                .Select(item => Random.Shared.Next(min, max))
                .ToArray();
    }
    /// <summary>
    /// Метод, для вывода массива в консоль
    /// </summary>
    /// <param name="array">Исходный массив</param>
    /// <param name="separator">Символ-разделитель</param>
    /// <returns>Исходный массив</returns>
    public static int[] ShowArray(this int[] array, string separator = ","){
        string output = String.Join(separator, array);
        WriteLine($"[{output}]");
        return array;
    }
}