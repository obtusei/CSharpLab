// use of array datatype
namespace Program
{
          class Q4
          {
                    public Q4()
                    {
                              int[] arr = new int[5];
                              arr[0] = 1;
                              arr[1] = 2;
                              arr[2] = 3;
                              arr[3] = 4;
                              arr[4] = 5;
                              Console.WriteLine("The array is:");
                              for (int i = 0; i < arr.Length; i++)
                              {
                                        Console.WriteLine(arr[i]);
                              }
                    }

          }
}