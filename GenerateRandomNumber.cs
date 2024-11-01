using System.Net;

namespace RandomNumber;

public class GenerateRandomNumber
{
    public static int GenerateNumber()
    {
        Random random = new Random();
        return random.Next(1000, 10000);
    }
}
