namespace Program
{
          class Coverloading
          {
                    private int a;
                    public void CoverloadingMethod()
                    {
                              Console.WriteLine("Hello World");
                    }

                    public void CoverloadingMethod(int a)
                    {
                              this.a = a;
                    }
          }


          class Q3
          {
                    public Q3()
                    {
                              Coverloading c = new Coverloading();
                              c.CoverloadingMethod();
                              c.CoverloadingMethod(10);
                    }
          }
}