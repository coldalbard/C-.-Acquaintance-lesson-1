﻿// string path = @"D:/c# + git/Examples";
// DirectoryInfo di = new DirectoryInfo(path);
// Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();






// for(int i = 0; i < fi.Length; i++)
// {
//     Console.WriteLine(fi[i].Name);
// }

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for(int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }
// }

// FileInfo[] files = catalog.GetFiles();

// for(int i = 0; i < files.Length; i++)
// {
//     Console.WriteLine($"{indent}{files[i].Name}");
// }

// string path = @"D:/c# + git/Examples";
// CatalogInfo(path);






// void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
// {
//     if(count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if(count > 1) Towers(some, on, with, count - 1);
// }

// Towers();




// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// //                 0    1     2    3    4    5     6   7    8    9    10   11
// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//     int left = 2 * pos;
//     int right = 2 * pos + 1;
//     if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//     Console.WriteLine(tree[pos]);
//     if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }
// InOrderTraversal();
