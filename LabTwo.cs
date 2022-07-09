namespace Program
{
          // 1. Use of Class and Object
          // 2. Use of Constructor`
          // 3. Use of Constructor overloading
          public class ClassDemo // use of new class
          {
                    private int a, b;
                    public ClassDemo()
                    { // Creating a constructor
                              Console.WriteLine("Hello World");
                    }

                    public ClassDemo(int a, int b)
                    { // creating another constructor
                              this.a = a;
                              this.b = b;
                    }
                    public void NumberSix()
                    {
                              Console.WriteLine("Number Six");
                    }
          }
          public class LabTwo
          {
                    public LabTwo()
                    {
                              ClassDemo obj = new ClassDemo();
                              obj.NumberSix();
                    }


          }
}