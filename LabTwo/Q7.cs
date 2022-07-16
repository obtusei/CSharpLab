namespace Program
{

          class AccessSpecifer
          {
                    public void publicMethod()
                    {
                              Console.WriteLine("Public Method");
                    }
                    private void privateMethod()
                    {
                              Console.WriteLine("Private Method");
                    }
                    protected void protectedMethod()
                    {
                              Console.WriteLine("Protected Method");
                    }
                    internal void internalMethod()
                    {
                              Console.WriteLine("Internal Method");
                    }
                    protected internal void protectedInternalMethod()
                    {
                              Console.WriteLine("Protected Internal Method");
                    }
                    private protected void privateProtectedMethod()
                    {
                              Console.WriteLine("Private Protected Method");
                    }
                    public static void publicStaticMethod()
                    {
                              Console.WriteLine("Public Static Method");
                    }
                    private static void privateStaticMethod()
                    {
                              Console.WriteLine("Private Static Method");
                    }
                    protected static void protectedStaticMethod()
                    {
                              Console.WriteLine("Protected Static Method");
                    }
                    internal static void internalStaticMethod()
                    {
                              Console.WriteLine("Internal Static Method");
                    }
                    protected internal static void protectedInternalStaticMethod()
                    {
                              Console.WriteLine("Protected Internal Static Method");
                    }
                    private protected static void privateProtectedStaticMethod()
                    {
                              Console.WriteLine("Private Protected Static Method");
                    }

          }

          class Q7
          {

                    public Q7()
                    {
                              AccessSpecifer obj = new AccessSpecifer();
                              obj.publicMethod();
                              // obj.privateMethod();
                              // obj.protectedMethod();
                    }
          }
}