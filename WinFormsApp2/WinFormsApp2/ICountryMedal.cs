using System;
using System.Windows.Forms;

public interface ICountryMedal
{
    string GetInfo();
}

public class CountryMedal : ICountryMedal
{
    public string Country { get; set; }
    public int Athletes { get; set; }
    public int GoldMedals { get; set; }
    public int SilverMedals { get; set; }
    public int BronzeMedals { get; set; }

    public CountryMedal(string country, int athletes, int gold, int silver, int bronze)
    {
        Country = country;
        Athletes = athletes;
        GoldMedals = gold;
        SilverMedals = silver;
        BronzeMedals = bronze;
    }

    public string GetInfo()
    {
        return $"Страна: {Country}: Спортсменов: {Athletes}, Золотых медалей: {GoldMedals}, Серебрянных медалей: {SilverMedals}, Бронзовых медалей: {BronzeMedals}";
    }
}