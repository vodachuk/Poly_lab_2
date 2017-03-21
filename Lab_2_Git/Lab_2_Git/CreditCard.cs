using System;

public class CreditCard
{
    private string number;
    private DateTime date;
    private int CVV;
    private string currency;

	public CreditCard()
	{
	}

    public CreditCard(string number = "", DateTime date = new DateTime(), int CVV = 0, string currency = "")
    {
        this.number = number;
        this.date = date;
        this.CVV = CVV;
        this.currency = currency;
    }
}
