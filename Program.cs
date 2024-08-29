namespace NumberAppearsOnce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 1, 2, 3, 3, 4, 4 };
            Console.WriteLine(FindNumber3(myArray));
        }

        static int FindNumber3(int[] a)
        {
            int xor = 0;
            for(int i = 0; i< a.Length; i++)
            {
                xor = xor ^ a[i];
            }
            return xor;
        }


        static int FindNumber2(int[] a)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();
            for(int i = 0; i< a.Length; i++)
            {
                if (dict.ContainsKey(a[i]))
                    dict[a[i]]++;
                else
                    dict.Add(a[i], 1);
            }

            foreach(var item in dict)
            {
                if(item.Value == 1)
                    return item.Key;
            }
            return -1;
        }

        static int FindNumber(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int count = 0;
                int num = array[i];
                for(int j = 0; j < array.Length; j++)
                {
                    if (array[j] == num)
                        count++;
                }

                if (count == 1)
                    return num;
            }

            return -1;
        }
    }
}