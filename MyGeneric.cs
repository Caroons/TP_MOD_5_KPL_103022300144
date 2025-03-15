using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyGeneric
{
    public class HaloGeneric
    {
        public void SapaUser<X>(X nama)
        {
            Console.WriteLine($"Halo, selamat pagi {nama}");
        }
    }

    public class DataGeneric<T>
    {
        public T? Data { get; set; }

        public DataGeneric(T data)
        {
            this.Data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Nim kamu adalah: {Data}");
        }
    }
}
