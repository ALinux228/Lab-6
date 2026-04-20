internal class RegisterString : StringWrapper
{
    private string _originalValue;
    private bool _isUpper;

    public RegisterString(string originalValue, bool isUpper) : 
        base(originalValue)
    {
        _originalValue = originalValue;
        _isUpper = isUpper;
        UpdateStringValue();
    }

    public RegisterString(RegisterString anyString) : 
        base(anyString)
    {
        _originalValue = anyString._originalValue;
        _isUpper = anyString._isUpper;
        UpdateStringValue();
    }

    public void ToUpper()
    {
        _isUpper = true;
        UpdateStringValue();
    }

    public void ToLower()
    {
        _isUpper = false;
        UpdateStringValue();
    }

    private void UpdateStringValue()
    {
        if (_isUpper)
        {
            _stringValue = _originalValue.ToUpper();
        }   
        else
        {
            _stringValue = _originalValue.ToLower();
        }       
    }

    public override string ToString()
    {
        string s = $"Изначальное значение строки - " +
            $"{_originalValue}, " +
            $"новое значение строки - {_stringValue}";

        if (_isUpper)
        {
            s += ", режим - верхний регистр.";
        }
        else
        {
            s += ", режим - нижний регистр.";
        }

        return s;
    }
}
