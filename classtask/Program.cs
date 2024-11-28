namespace classtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.id = 12;
            p1.name = "RTX 3060 TI";
            p1.price = 3200f;
            p1.description = "best GPU Ever Made";
            p1.print();

            Product p2 = new Product();
            p2.id = 1313;
            p2.name = "i5 12400f";
            p2.price = 700f;
            p2.description = "hope it never burn";
            p2.print();

            Product p3 = new Product();
            p3.id = 12;
            p3.name = "Case NX800";
            p3.price = 400f;
            p3.description = "NO!";
            p3.print();
        }
    }
}
