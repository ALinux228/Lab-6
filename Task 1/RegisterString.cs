internal class RegisterString : StringWrapper
{
    private string originalValue;
    private bool isUpper;

    public RegisterString(string originalValue, bool isUpper) : base(originalValue)
    {
        this.originalValue = originalValue;
        this.isUpper = isUpper;
    }

    public RegisterString(RegisterString anyString) : base(anyString)
    {
        this.originalValue = anyString.originalValue;
        this.isUpper = anyString.isUpper;
    }

    public void ToUpper()
    {
        isUpper = true;
        UpdateStringValue();
    }

    public void ToLower()
    {
        isUpper = false;
        UpdateStringValue();
    }

    private void UpdateStringValue()
    {
        if (isUpper)
            stringValue = originalValue.ToUpper();
        else
            stringValue = originalValue.ToLower();
    }

    public override string ToString()
    {
        string s = "Изначальное значение строки - " + originalValue + ", новое значение строки - " + stringValue;

        if (isUpper)
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
