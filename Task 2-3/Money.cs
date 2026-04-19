internal class Money
{
    private uint rubles;
    private byte kopeks;

    public Money(uint rubles, byte kopeks)
    {
        this.rubles = rubles;
        this.kopeks = kopeks;
    }

    public Money(int totalKopeks)
    {
        if (totalKopeks < 0)
        {
            totalKopeks = 0;
        }
        this.rubles = (uint)(totalKopeks / 100);
        this.kopeks = (byte)(totalKopeks % 100);
    }

    public static Money operator ++(Money m)
    {
        Money result = new Money(m.rubles, m.kopeks);
        result = result.Add(1);
        return result;
    }

    public static Money operator --(Money m)
    {
        Money result = new Money(m.rubles, m.kopeks);
        result = result.Subtract(1);
        return result;
    }

    public static explicit operator uint(Money m)
    {
        return m.rubles;
    }

    public static implicit operator double(Money m)
    {
        return m.kopeks / 100.0;
    }

    public static Money operator +(Money m, uint rub)
    {
        return new Money(m.rubles + rub, m.kopeks);
    }

    public static Money operator -(Money m, uint rub)
    {
        if (m.rubles < rub)
        {
            Console.WriteLine("Недостаточно рублей для вычитания");
            return new Money(m.rubles, m.kopeks);
        }
        else
        {
            return new Money(m.rubles - rub, m.kopeks);
        }
    }

    public Money Add(int kop)
    {
        int total = (int)(rubles * 100 + kopeks + kop);
        if (total < 0) total = 0;
        return new Money(total);
    }

    public Money Subtract(int kop)
    {
        int total = (int)(rubles * 100 + kopeks - kop);
        if (total < 0) total = 0;
        return new Money(total);
    }

    public override string ToString()
    {
        return $"{rubles} руб. {kopeks:D2} коп.";
    }
}
