using System;
using Adapter;

public class Program
{
    public static void Main(string[] args)
    {
        INowyOdtwarzacz odtwarzacz = new OdtwarzaczAdapter(new StaryOdtwarzacz());
        odtwarzacz.OdtworzDzwiek();
    }
}
