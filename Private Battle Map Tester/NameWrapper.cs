public class NameWrapper
{
    public string ingameName;
    public decimal dataName;
    public NameWrapper(string iname, decimal dname)
    {
        ingameName = iname;
        dataName = dname;
    }

    public override string ToString()
    {
        return ingameName;
    }
}