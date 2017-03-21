using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class BusinessCard
{
    private int number;
    private DateTime date;
    private int CVV;


	public BusinessCard()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public BusinessCard(int number, DateTime date, int CVV)
    {
        this.number = number;
        this.date = date;
        this.CVV = CVV;
    }

   
}
