// use of interface
namespace Program
{
          interface I1
          {
                    void show();
          }
          interface I2
          {
                    void show1();
          }
          class IChild : I1, I2
          {
                    public void show()
                    {
                              Console.WriteLine("I1");
                    }
                    public void show1()
                    {
                              Console.WriteLine("I2");
                    }
          }

          class Q11
          {
                    public Q11()
                    {
                              I1 i = new IChild();
                              I2 i1 = new IChild();
                              i.show();
                              i1.show1();
                    }
          }
}
