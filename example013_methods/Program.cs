//vid1
// void Method1()
// {
//     Console.WriteLine("Author...");
// }
// Method1();




//vid2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Text");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//     Console.WriteLine(msg);
//     i++;
//     }
// }
// Method21(msg: "text", count: 4);





// vid3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);






// vid4

//(for)

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//        result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);



//(while)

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     int i = 0;
//     while(i < count)
//     {
//       result = result + text;
//       i++;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);



//(таблица умножения)
// for(int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }




// Дан текст. В тексте нужно все пробелы заменить заменить черточками,
// маленькие буквы "к" заменить большими "К", а большие "С" на маленькие "с"

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";


// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int lenght = text.Lenght;
    
//     for(int i = 0; i < lenght; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', "|");
// Console.WriteLine(newText);





// int[] arr = {1, 5, 4, 6, 5, 3, 2, 8, 99, 4, 1, 6};

// void PrintArray(int[] array)
// {
//     int count = array.Length;
    
//     for(int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }

//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for(int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
        
//         for(int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) 
//             {
//             minPosition = j;
//             }
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;

//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);