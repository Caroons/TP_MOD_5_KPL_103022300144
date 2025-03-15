using MyGeneric;

internal class Program
{
    private static string? nama { get; set; }
    
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        Console.Write("Siapa nama anda? ");
        nama = Console.ReadLine()?.ToUpper();
        halo.SapaUser(nama);
    }
}