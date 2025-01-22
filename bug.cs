public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        //This will throw a NullReferenceException if MyProperty is not initialized.
        Console.WriteLine(MyProperty.ToString()); 
    }
}