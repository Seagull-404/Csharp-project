namespace EF1to1Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var ctx=new MyDBContext())
            {
                Order o1 = new Order();
                o1.Name = "C#图解";
                Delivery d1 = new Delivery();
                d1.CompanyName = "顺丰";
                d1.Number = "SF001";
                d1.Order = o1;

                ctx.Orders.Add(o1);
                ctx.Deliveries.Add(d1);

                ctx.SaveChanges();
            }
        }
    }
}
