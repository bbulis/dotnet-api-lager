using System;
using System.Text;

namespace Lager
{
    
    public class Program
    {
        
        public static void Main()
        {
            // new StartUp().InitStart();

            using(var context = new DatabaseContext())
            {
                var brands = context.TireBrand.ToList();
                Console.Write(brands);
                foreach(var brand in brands)
                {
                    var data = new StringBuilder();
                    data.AppendLine($"ID: {brand.TireBrandId}");
                    data.AppendLine($"Display Name: {brand.TireBrandDisplayName}");
                    data.AppendLine($"Name: {brand.TireBrandName}");
                    Console.WriteLine(data.ToString());
                }
            }
        }
    }

}