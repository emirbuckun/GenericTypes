// Declare the generic class

namespace GenericTypes
{
  public class GenericList<T>
  {
    public void Add(T input) { }
  }
  public class ExampleClass { }

  internal class Program
  {
    static void Main()
    {
      // Declare a list of type int.
      GenericList<int> list1 = new();
      list1.Add(1);

      // Declare a list of type string.
      GenericList<string> list2 = new();
      list2.Add("");

      // Declare a list of type ExampleClass.
      GenericList<ExampleClass> list3 = new();
      list3.Add(new ExampleClass());
    }
  }
}