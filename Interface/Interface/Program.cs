using System;

public interface ILoyaltyCardHolder
{
    int TotalPoints
    {
        get;
    }
    int AddPoints(decimal transactionValue);
    void ResetPoints();
}

public class Customer : ILoyaltyCardHolder
{
    private int totalPoints;
    public int TotalPoints
    {
        get { return totalPoints; }
    }
    public int AddPoints(decimal transactionValue)
    {
        int points = Decimal.ToInt32(transactionValue);
        totalPoints += points;
        return totalPoints;
    }
    public void ResetPoints()
    {
        totalPoints = 0;
    }
}