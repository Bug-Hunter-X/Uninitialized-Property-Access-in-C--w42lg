public class MyClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property in declaration

    public MyClass() // or Initialize it in a constructor
    {
        MyProperty = 0; 
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty.ToString());
    }
}