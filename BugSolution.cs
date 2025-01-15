public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize MyProperty to 0

    public ExampleClass()
    {
        // Initialize MyProperty in the constructor. This is a good practice.
        MyProperty = 10; 
    }
    public void MyMethod()
    {
        int value = MyProperty * 2; // No longer a potential error
    }
}