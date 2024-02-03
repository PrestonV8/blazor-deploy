﻿namespace PrestonViadoBlazorApp.Models;

public class WeatherModel
{
    public float latitude { get; set; }
    public float longitude { get; set; }
    public string timezone { get; set; }
    public float offset { get; set; }
    public int elevation { get; set; }
    public Currently currently { get; set; }
    public Minutely minutely { get; set; }
    public Hourly hourly { get; set; }
    public Daily daily { get; set; }
    public object[] alerts { get; set; }

}

public class Currently
{
    public int time { get; set; }
    public string summary { get; set; }
    public string icon { get; set; }
    public int nearestStormDistance { get; set; }
    public int nearestStormBearing { get; set; }
    public float precipIntensity { get; set; }
    public float precipProbability { get; set; }
    public float precipIntensityError { get; set; }
    public string precipType { get; set; }
    public float temperature { get; set; }
    public float apparentTemperature { get; set; }
    public float dewPoint { get; set; }
    public float humidity { get; set; }
    public float pressure { get; set; }
    public float windSpeed { get; set; }
    public float windGust { get; set; }
    public int windBearing { get; set; }
    public float cloudCover { get; set; }
    public float uvIndex { get; set; }
    public float visibility { get; set; }
    public float ozone { get; set; }
}

public class Minutely
{
    public string summary { get; set; }
    public string icon { get; set; }
    public Datum[] data { get; set; }
}

public class Datum
{
    public int time { get; set; }
    public float precipIntensity { get; set; }
    public float precipProbability { get; set; }
    public float precipIntensityError { get; set; }
    public string precipType { get; set; }
}

public class Hourly
{
    public string summary { get; set; }
    public string icon { get; set; }
    public PerHourData[] data { get; set; }
}

public class PerHourData
{
    public int time { get; set; }
    public string icon { get; set; }
    public string summary { get; set; }
    public float precipIntensity { get; set; }
    public float precipProbability { get; set; }
    public float precipIntensityError { get; set; }
    public float precipAccumulation { get; set; }
    public string precipType { get; set; }
    public float temperature { get; set; }
    public float apparentTemperature { get; set; }
    public float dewPoint { get; set; }
    public float humidity { get; set; }
    public float pressure { get; set; }
    public float windSpeed { get; set; }
    public float windGust { get; set; }
    public int windBearing { get; set; }
    public float cloudCover { get; set; }
    public float uvIndex { get; set; }
    public float visibility { get; set; }
    public float ozone { get; set; }
}

public class Daily
{
    public string summary { get; set; }
    public string icon { get; set; }
    public PerDayData[] data { get; set; }
}

public class PerDayData
{
    public int time { get; set; }
    public string icon { get; set; }
    public string summary { get; set; }
    public int sunriseTime { get; set; }
    public int sunsetTime { get; set; }
    public float moonPhase { get; set; }
    public float precipIntensity { get; set; }
    public float precipIntensityMax { get; set; }
    public int precipIntensityMaxTime { get; set; }
    public float precipProbability { get; set; }
    public float precipAccumulation { get; set; }
    public string precipType { get; set; }
    public float temperatureHigh { get; set; }
    public int temperatureHighTime { get; set; }
    public float temperatureLow { get; set; }
    public int temperatureLowTime { get; set; }
    public float apparentTemperatureHigh { get; set; }
    public int apparentTemperatureHighTime { get; set; }
    public float apparentTemperatureLow { get; set; }
    public int apparentTemperatureLowTime { get; set; }
    public float dewPoint { get; set; }
    public float humidity { get; set; }
    public float pressure { get; set; }
    public float windSpeed { get; set; }
    public float windGust { get; set; }
    public int windGustTime { get; set; }
    public int windBearing { get; set; }
    public float cloudCover { get; set; }
    public float uvIndex { get; set; }
    public int uvIndexTime { get; set; }
    public float visibility { get; set; }
    public float temperatureMin { get; set; }
    public int temperatureMinTime { get; set; }
    public float temperatureMax { get; set; }
    public int temperatureMaxTime { get; set; }
    public float apparentTemperatureMin { get; set; }
    public int apparentTemperatureMinTime { get; set; }
    public float apparentTemperatureMax { get; set; }
    public int apparentTemperatureMaxTime { get; set; }
}

