// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

public class HaloGeneric
{
    public void sapaUser(String nama)
    {
        
        Console.WriteLine("Halo User " + nama);
    }
}

class program()
{
    static void Main(String[] args)
    {
        HaloGeneric haikal = new HaloGeneric();
        Console.Write("Nama: ");
        String nama = Console.ReadLine();
        haikal.sapaUser(nama);
    }
}