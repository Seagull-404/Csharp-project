namespace OrgTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
           OrgUnit ouRoot = new OrgUnit { Name = "总公司" };
            
            OrgUnit ouAsia = new OrgUnit { Name = "亚洲分部", Parent = ouRoot };

                OrgUnit ouAmerica = new OrgUnit { Name = "美洲分部", Parent = ouRoot };
                    OrgUnit ouChina = new OrgUnit { Name = "中国区", Parent = ouAsia };
                    OrgUnit ouJapan = new OrgUnit { Name = "日本区", Parent = ouAsia };
                    OrgUnit ouUSA = new OrgUnit { Name = "美国区", Parent = ouAmerica };
                    OrgUnit ouCanada = new OrgUnit { Name = "加拿大区", Parent = ouAmerica };


                ouRoot.Children.Add(ouAsia);
             ouRoot.Children.Add(ouAmerica);
                ouAsia.Children.Add(ouChina);
                ouAsia.Children.Add(ouJapan);
                ouAmerica.Children.Add(ouUSA);
                ouAmerica.Children.Add(ouCanada);

            using (MyDBContext ctx = new MyDBContext())
            {
                ctx.OrgUnits.Add(ouRoot);
                 ctx.SaveChanges();
            }

        }   
    }
}
