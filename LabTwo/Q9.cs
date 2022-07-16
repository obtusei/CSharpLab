// showing inheritance
namespace Program
{

          class Parent
          {
                    public void show()
                    {
                              Console.WriteLine("Parent class");
                    }
          }
          class Child : Parent
          {
                    public void show2()
                    {
                              Console.WriteLine("Child class");
                    }
          }

          class SecondChild : Parent
          {
                    public void show3()
                    {
                              Console.WriteLine("Second Child class");
                    }
          }

          class GrandChild : Child
          {
                    public void show4()
                    {
                              Console.WriteLine("Grand Child class");
                    }
          }



          class Q9
          {
                    public Q9()
                    {
                              Parent p = new Parent();
                              Child c = new Child();
                              p.show();
                              c.show();
                    }
          }
}
