// demonstrate exception handling
namespace Program
{
          class Q15
          {

                    public Q15()
                    {
                              try
                              {
                                        int a = 10;
                                        int b = 0;
                                        int c = a / b;
                                        Console.WriteLine("The value of c is:" + c);
                              }
                              catch (Exception e)
                              {
                                        Console.WriteLine("Exception is:" + e);
                              }
                    }
          }
}