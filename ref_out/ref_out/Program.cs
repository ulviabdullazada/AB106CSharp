namespace ref_out
{
    internal class Program
    {
        static void Main()
        {
            #region Foreach, var, dynamic
            //string str = "Salam";
            //int[] arr = { 10, 3, 22, 76, 90 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    var shahin = arr[i];
            //    Console.WriteLine(shahin);
            //}
            //foreach (var shahin in str)
            //{
            //    Console.WriteLine(shahin);
            //}
            //string str = "Salam";
            ////Console.WriteLine(str.Substring(2));
            //dynamic num = "Salam";
            ////Console.WriteLine(num.Substring(2));
            //num = "123";
            //Console.WriteLine(num.Substring(2));
            #endregion

            #region Value, reference types
            //int a = 5;
            //int b = a;
            //b += 10;
            //Console.WriteLine(a);

            //int[] arr = { 10, 21, 4, 7 };
            //int[] nums = arr;
            //int num = 22;
            //int a = 10;
            //int b = 21;
            ////nums[0] = 77;
            //Console.WriteLine("Nums => " + nums[0]);
            //Console.WriteLine("Arr => " + arr[0]);
            #endregion

            //int[] nums = { 25, 2, 6, 0, 11, -1, 23 };
            //SwapMinAndMax(nums);
            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}
            //int a = 15;
            //int a = 5;
            //Calc(out int a);
            //int a = 60;
            //Calc(a);
            //Console.WriteLine(a);
            //int num = 7;
            //if (!int.TryParse(Console.ReadLine(), out num))
            //{
            //    num = 7;
            //}
            //Console.WriteLine(num * 20);
            int[] arr = { 1, 2, 3 };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Add(ref arr, 10);
            Add(ref arr, 11);
            Add(ref arr, 12);
            Add(ref arr, 13);
            Console.WriteLine("---------------------");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void Add(ref int[] arr, int num)
        {
            int[] newArr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[^1] = num;
            arr = newArr; //fixed length
        }


        //static void Calc(in int b)
        //{
        //    int c = b * 100;
        //    Console.WriteLine(c);
        //}

        //static void SwapMinAndMax(int[] arr)
        //{
        //    int minI = 0, maxI = 0;
        //    for (int i = 1; i< arr.Length; i++)
        //    {
        //        if (arr[minI] > arr[i])
        //        {
        //            minI = i;
        //        }
        //        else if (arr[maxI] < arr[i])
        //        {
        //            maxI = i;
        //        }
        //    }
        //    arr[maxI] = arr[minI] + arr[maxI];
        //    arr[minI] = arr[maxI] - arr[minI];
        //    arr[maxI] = arr[maxI] - arr[minI];
        //}
    }
}
