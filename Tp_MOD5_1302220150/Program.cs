// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

public class HaloGeneric
{
    public void sapaUser(String nama)
    {
        
        Console.WriteLine($"Halo user {nama}");
    }
}

public class DataGeneric<T>
{
    public T data { get; set; }

    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void printData()
    {
        Console.WriteLine($"Data Yang Tersimpan Adalah: {data}");
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

        DataGeneric<String> data_haikal = new DataGeneric<String>("1302220150");
        data_haikal.printData();
    }
}