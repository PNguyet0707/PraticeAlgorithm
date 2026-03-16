public class Problem006_MergeTwoSortedArray
{
    //public int[] Solve(int[] Arr1, int[] Arr2)
    //{
    //    int length = Arr1.Length + Arr2.Length;
    //    int[] result = new int[length];
    //    int i = 0;
    //    int j = 0;
    //    int k = 0;
    //    while( k < length )
    //    {
    //        if (i < Arr1.Length  &&  Arr1[i] < Arr2[j])
    //        {
    //            result[k] = Arr1[i];
    //            i++;
    //        }
    //        else
    //        {
    //            result[k] = Arr2[j];
    //            if (j < Arr2.Length - 1)
    //                j++;
    //        }
    //        k++;
    //    }
    //    return result;
    //}
    public int[] Solve(int[] Arr1, int[] Arr2)
    {
        int length = Arr1.Length + Arr2.Length;
        int[] result = new int[length];
        int i = 0, j = 0, k = 0;

        while (i < Arr1.Length && j < Arr2.Length)
        {
            if (Arr1[i] < Arr2[j])
            {
                result[k++] = Arr1[i++];
            }
            else
            {
                result[k++] = Arr2[j++];
            }
        }

        // copy remaining items in Arr1
        while (i < Arr1.Length)
        {
            result[k++] = Arr1[i++];
        }
        // copy remaining items in Arr2
        while (j < Arr2.Length)
        {
            result[k++] = Arr2[j++];
        }
        return result;
    }

}
