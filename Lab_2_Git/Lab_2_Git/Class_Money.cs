using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Money
{
    public int momey;
    public sting currency;

	public Money(int money)
	{
        this.money = money;
	}

    void GetInformation()
    {
        Console.WriteLine("Youn have money = {0}", money);
    }
}
