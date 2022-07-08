using System;

class IntelliSenseDemo : TimeZone
{
    public override string DayLightName
    {
        get
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }

    public override System.Globalization.DayLightTime GetDayLightChanges(int year)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override TimeSpan GetUtcOffset(DateTime time)
    {
        throw new Exception("The method or operation is not implemented.");
    }

    public override string StandardName
    {
        get { throw new Exception("The method or operation is not implemented.");
        }
    }
}