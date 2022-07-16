namespace Program
{
          class ContructorDemo
          {
                    public ContructorDemo()
                    {
                              Console.WriteLine("Hello World");
                    }
          }

          class Q2
          {
                    public Q2()
                    {
                              ContructorDemo d = new ContructorDemo();
                    }
          }
}