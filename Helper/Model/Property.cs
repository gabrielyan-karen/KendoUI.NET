namespace Helper.Model;

public class Property<T>
{
    public string name { get; private set; }
    public T value;

    public Property(string name, T value)
    {
        this.name = name;
        this.value = value;
    }
    // public T Value
    // {
    //     get { return value; }
    //     set { this.value = value; }
    // }
}
