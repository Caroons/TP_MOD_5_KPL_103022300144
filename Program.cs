using MyGeneric;

internal class Program
{
    private static string? nama { get; set; }
    private static int? nim {  get; set; }

    public static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Bagian HaloGeneric:");
        Console.WriteLine("");

        Console.Write("Siapa nama anda? ");
        nama = Console.ReadLine()?.ToUpper();

        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(nama);

        Console.WriteLine("");
        Console.WriteLine("Bagian DataGeneric:");
        Console.WriteLine("");

        Console.Write("Berapa nim anda? ");
        nim = (int?) Convert.ToInt64(Console.ReadLine());

        DataGeneric<int?> dataGeneric = new DataGeneric<int?>(nim);
        dataGeneric.PrintData();
    }
}