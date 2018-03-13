using System;
using System.Collections;

public class RandomList : ArrayList
{
    public string RandomString()
    {
        Random random = new Random();
        int index = random.Next(0, this.Count - 1);
        return (string)this[index];
    }
}