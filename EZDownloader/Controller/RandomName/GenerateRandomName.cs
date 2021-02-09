using System;

class GenerateRandomName
{
    public static string Generate()
    {
        Random random = new Random();
        int randomNumber = random.Next(1000, 10000);
        return randomNumber.ToString();
    }
}
