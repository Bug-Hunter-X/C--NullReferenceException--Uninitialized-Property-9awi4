public class MyClass {
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public MyClass() {
        MyProperty = 0; // Or another default value
    }

    public void MyMethod() {
        int value = MyProperty * 2; 
    }
}