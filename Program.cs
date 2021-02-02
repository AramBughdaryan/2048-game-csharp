using System;
using static System.Console;

namespace proj_2
{
    class Program
    {



        static void Main(string[] args)
        {
            int n = 4;
            int m = 4;
            int[,] arr = create_arr(n, m);
            int move = Convert.ToInt32(ReadLine());
            arr = rotate_arr1(arr, move);

            // if (move == 0)
            // {
            //     arr = solution_0(arr);
            // }
            // else if (move == 1)
            // {
            //     arr = rotate_arr(arr);
            //     arr = solution_0(arr);
            //     for (int k = 0; k < arr.GetLength(0) - 1; k++)
            //     {
            //         arr = correct_arr0(arr);
            //     }

            //     arr = rotate_arr(arr);
            //     arr = rotate_arr(arr);
            //     arr = rotate_arr(arr);
            // }
            // else if (move == 2)
            // {
            //     arr = solution_2(arr);
            // }
            // else if (move == 3)//aj
            // {
            //     arr = rotate_arr(arr);
            //     arr = solution_2(arr);

            //     for (int k = 0; k < arr.GetLength(0) - 1; k++)
            //     {
            //         arr = correct_arr2(arr);
            //     }
            //     arr = rotate_arr(arr);
            //     arr = rotate_arr(arr);
            //     arr = rotate_arr(arr);
            // }
            print_arr(arr);


        }
        static void print_arr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    System.Console.Write(arr[i, j] + " ");

                }
                System.Console.WriteLine();
            }
        }
        static int[,] solution_0(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int n = 1;
                for (int j = 0; j < arr.GetLength(1) && n < arr.GetLength(1);)
                {
                    if (arr[i, j] != 0 && arr[i, n] != 0)
                    {
                        if (arr[i, j] == arr[i, n])
                        {
                            arr[i, j] = (arr[i, n]) * 2;

                            arr[i, n] = 0;
                            j += 2;
                            n += 2;
                        }
                        else
                        {
                            j++;
                            n++;
                        }
                    }
                    else if (arr[i, j] != 0 && arr[i, n] == 0)
                    {
                        n++;
                    }
                    else if (arr[i, j] == 0 && arr[i, n] != 0)
                    {
                        j++;
                        n++;
                    }
                    else if (arr[i, j] == 0 && arr[i, n] == 0)
                    {
                        n += 2;
                        j += 2;
                    }
                }
            }
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                arr = correct_arr0(arr);
            }

            return arr;
        }
        static int[,] correct_arr0(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == 0 && j != 3)
                    {
                        a[i, j] = a[i, j + 1];
                        a[i, j + 1] = 0;
                    }
                }
            }
            return a;
        }
        static int[,] solution_2(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int n = 2;
                for (int j = 3; j >= 0 && n >= 0;)
                {
                    if (arr[i, j] != 0 && arr[i, n] != 0)
                    {
                        if (arr[i, j] == arr[i, n])
                        {
                            arr[i, j] = (arr[i, n]) * 2;

                            arr[i, n] = 0;
                            j -= 2;
                            n -= 2;
                        }
                        else
                        {
                            j--;
                            n--;
                        }
                    }
                    else if (arr[i, j] != 0 && arr[i, n] == 0)
                    {
                        n--;
                    }
                    else if (arr[i, j] == 0 && arr[i, n] != 0)
                    {
                        j--;
                        n--;
                    }
                    else if (arr[i, j] == 0 && arr[i, n] == 0)
                    {
                        n -= 2;
                        j -= 2;
                    }
                }
            }
            for (int k = 0; k < arr.GetLength(0) - 1; k++)
            {
                arr = correct_arr2(arr);
            }
            return arr;
        }
        static int[,] correct_arr2(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 3; j >= 0; j--)
                {
                    if (a[i, j] == 0 && j != 0)
                    {
                        a[i, j] = a[i, j - 1];
                        a[i, j - 1] = 0;
                    }
                }
            }
            return a;
        }
        static int[,] rotate_arr(int[,] a, int n = 1)
        {
            int[,] arr = new int[a.GetLength(0), a.GetLength(1)];


            for (int p = 0; p < n; p++)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        arr[i, j] = a[j, i];
                    }
                }

                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        a[i, j] = arr[i, j];
                    }
                }
            }

            return arr;
        }
        static int[,] rotate_arr1(int[,] a, int n = 1)
        {
            int[,] arr = CopyArray(a);
            // int[,] arr = new int[a.GetLength(0), a.GetLength(1)];
            // Array.Copy(a, 0, arr, 0, a.Length);

            for (int p = 0; p < n; p++)
            {
                int[,] tmp = CopyArray(arr);
                System.Console.WriteLine("AAAAAAAAAAAAAAAAAAAAA");
                print_arr(tmp);
                System.Console.WriteLine("BBBBBBBBB");
                // int[,] tmp = new int[a.GetLength(0), a.GetLength(1)];
                // arr.CopyTo(tmp, 0);
                // Array.Copy(arr, 0, tmp, 0, a.Length);
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        arr[i, j] = tmp[j, i];
                    }
                }
            }

            return arr;
        }

        static int[,] CopyArray(int[,] arr)
        {
            int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    newArr[i, j] = arr[i, j];
                }
            }

            return newArr;
        }


        static int[,] create_arr(int n, int m)
        {
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] inp_string = ReadLine().Split(' ');
                if (inp_string.Length != m)
                {
                    System.Console.WriteLine("Enter {0} numbers.", m);
                    i--;
                }
                else
                {
                    for (int j = 0; j < m; j++)
                    {
                        arr[i, j] = Convert.ToInt32(inp_string[j]);
                    }
                }
            }

            return arr;
        }
    }

}


