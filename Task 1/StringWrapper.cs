internal class StringWrapper
{
    protected string stringValue;

    public StringWrapper(string value) 
    {
        if (value != null) 
        { 
            this.stringValue = value; 
        }
        else
        {
            this.stringValue = "";
        }
    }

    public StringWrapper(StringWrapper anyString)
    {
        this.stringValue = anyString.stringValue;
    }

    public void Exclamation()
    {
        stringValue = "!!!" + stringValue;
    }

    public override string ToString()
    {
        string s = stringValue;
        if (s == null)
        {
            s = "Пустая строка";
        }
        return s;
    }
}