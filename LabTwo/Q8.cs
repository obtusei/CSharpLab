// use of method overloading
namespace Program
{

          class MethodOverloading
          {
                    public void Add(int a, int b)
                    {
                              Console.WriteLine("Addition of two numbers is:" + (a + b));
                    }
                    public void Add(int a, int b, int c)
                    {
                              Console.WriteLine("Addition of three numbers is:" + (a + b + c));
                    }
                    public void Add(int a, int b, int c, int d)
                    {
                              Console.WriteLine("Addition of four numbers is:" + (a + b + c + d));
                    }
          }

          class Q8
          {
                    public Q8()
                    {
                              MethodOverloading m = new MethodOverloading();
                              m.Add(1, 2);
                              m.Add(1, 2, 3);
                              m.Add(1, 2, 3, 4);
                    }
          }
}
