// After the namespace you add a semicolon, and not an opening curly like with a classic namespace declaration
namespace FileScopedNamespaceSample;
    
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

// Cannot add the namespace more than one time, and also cannot be at the end of the class.
//namespace FileScopedNamespaceSample;