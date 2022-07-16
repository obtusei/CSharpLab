// use of abstract class

namespace Program
{
          abstract class AbstractClass
          {
                    public abstract void show();
          }

          class AChild : AbstractClass
          {
                    public override void show()
                    {
                              Console.WriteLine("Child class");
                    }
          }

          class Q10
          {
                    public Q10()
                    {
                              AbstractClass a = new AChild();
                              a.show();
                    }
          }
}