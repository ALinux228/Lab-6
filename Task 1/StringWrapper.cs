internal class StringWrapper
{
    protected string _stringValue;

    public StringWrapper(string value) 
    {
        if (value != null) 
        { 
            _stringValue = value; 
        }
        else
        {
            _stringValue = " ";
        }
    }

    public StringWrapper(StringWrapper anyString)
    {
        _stringValue = anyString._stringValue;
    }

    public void Exclamation()
    {
        _stringValue = "!!!" + _stringValue;
    }

    public override string ToString()
    {
        string s = _stringValue;
        if (_stringValue == " ")
        {
            s = "Пустая строка";
        }
        return s;
    }
}
