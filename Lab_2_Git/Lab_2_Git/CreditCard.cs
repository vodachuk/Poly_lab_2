using System;

public class CreditCard
{
    private string number;
    private DateTime date;
    private int CVV;
    private string currency;
    private int PIN;

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

	public void ChangePin(int PIN)
	{
		this.PIN = PIN;
	}
}
