namespace Program
{

          public class ClassDemo
          {
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