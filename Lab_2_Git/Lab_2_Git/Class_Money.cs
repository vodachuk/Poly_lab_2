using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Money
{
    public int money;
    public string currency;

	public Money(int money)
	{
        this.money = money;
	}

    public void GetInformation()
    {
        Console.WriteLine("Youn have money = {0}", money);
    }
}
