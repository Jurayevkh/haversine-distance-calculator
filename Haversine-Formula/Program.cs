using System;

public class HaversineFormula
{
    public const double EarthRadiusKm = 6371.0;

    // Converts degrees to radians
    private static double ToRadians(double angle)
    {
        return Math.PI * angle / 180.0;
    }

    // Calculates the distance between two points using the Haversine formula
    public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
    {
        double dLat = ToRadians(lat2 - lat1);
        double dLon = ToRadians(lon2 - lon1);

        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                   Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                   Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return EarthRadiusKm * c;
    }

    public static void Main(string[] args)
    {
        double lat1 = 40.7128; 
        double lon1 = -74.0060;
        double lat2 = 34.0522;
        double lon2 = -118.2437;

        double distance = CalculateDistance(lat1, lon1, lat2, lon2);
        Console.WriteLine($"Distance between two location is {distance} km");
    }
}
