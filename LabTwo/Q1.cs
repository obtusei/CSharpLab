namespace Program
{

          class Demo
          {
                    public void demoMethod()
                    {
                              Console.WriteLine("Hello World");
                    }
          }

          class Q1
          {
                    public Q1()
                    {
                              Demo d = new Demo();
                              d.demoMethod();
                    }
          }


}