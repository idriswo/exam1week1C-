
// // task1.
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }


// int max = int.MinValue;
// for (int i = 0; i < arr.Length; i++)
// {
//     int cnt = 0;
//     for (int j = 1; j < arr.Length; j++)
//     {
//         if (arr[i] == arr[j])
//         {
//             cnt++;
//         }
//     }
//     if (cnt > max)
//     {
//         max = cnt;
//     }
// }
// System.Console.WriteLine(max); 




// task2.
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// string str = "";
// string str1 = "";

// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// System.Console.WriteLine(n);

// for (int i = 0; i < arr.Length - 1; i++)
// {
//     str += arr[i];
// }
// for (int j = arr.Length - 1; j > 0; j--)
// {
//     str1 += arr[j];
// }
// if (str == str1)
// {
//     System.Console.WriteLine("Yes");
// }
// else
// {
//     System.Console.WriteLine("No");
// }


//task3.
// string str = Console.ReadLine();
// display(str);
// void display(string str)
// {
//     int cnt1 = 0;
//     int cnt2 = 0;
//     for (int i = str.Length - 1; i > 0; i--)
//     {
//         if (str[i] == 'A' || str[i] == 'I' || str[i] == 'E' || str[i] == 'O' || str[i] == 'U' || str[i] == 'Y' || str[i] == 'a' || str[i] == 'i' || str[i] == 'e' || str[i] == 'o' || str[i] == 'u' || str[i] == 'y')
//         {
//             cnt1++;
//         }
//         else
//         {
//             cnt2++;
//         }
//     }
//     System.Console.WriteLine($"Wovels : {cnt1}");
//     System.Console.WriteLine($"Consonants : {cnt2}");
// }



// task4.
// string str = Console.ReadLine();

// System.Console.WriteLine(program(str));

// int program(string str)
// {
//     char str1 = ' ';
//     int cnt=1;
//     for(int i = str.Length - 1; i > 0; i--)
//     {
//         if(str[i] == str1)
//         {
//             cnt++;
//         }
//     }
//     return cnt;
// }




// //task5.+
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for(int i=0; i<n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// System.Console.WriteLine(n);

// int max  = int.MinValue;
// for(int i=0; i < arr.Length-1; i++)
// {
//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
// }






//task7.
// System.Console.Write("a = ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("b = ");
// int b = Convert.ToInt32(Console.ReadLine());
// Multiply(ref a,ref b);


// void Multiply(ref int a, ref int b)
// {
//     System.Console.WriteLine($"a = {a*2}");
//     System.Console.WriteLine($"a = {b*2}");
// }



//task8.+
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// System.Console.WriteLine(CountEvenNumbers(arr));

// int CountEvenNumbers(int[] arr)
// {
//     int cnt=0;
//     for(int i=0; i<arr.Length-1; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             cnt++;
//         }
//     }
//     return cnt;
// }





//task9.+
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// System.Console.WriteLine(SumOfMassiv(arr));

// int SumOfMassiv(int[] arr)
// {
//     int sum = 0;
//     int cnt = 0;
//     int cnt1 = 0;
//     for (int i = 1; i < arr.Length - 1; i++)
//     {
//         sum += arr[i];
//         cnt++;
//         int sum1 = sum / cnt;

//         if (arr[i] > sum1)
//         {
//             cnt1++;
//         }
//     }
//     return cnt1;
// }





//task10.+
// int n = Convert.ToInt32(Console.ReadLine());
// display(n);

// void display(int num)
// {
//     if (num <1)
//      return;
//     System.Console.Write($"{num} ");
//     display(num - 1);

// }