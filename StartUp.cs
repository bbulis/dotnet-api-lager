using System;
using System.Diagnostics;

namespace Lager
{
    public class StartUp
    {
        public void InitStart()
        {
            using(var connection = new DatabaseContext())
            {
                connection.Database.EnsureCreated();

                var falken = new TireBrand
                {
                    TireBrandId =  Guid.NewGuid().ToString(),
                    TireBrandDisplayName = "Falken",
                    TireBrandName = "falken"
                };

                var dunlop = new TireBrand
                {
                    TireBrandId = Guid.NewGuid().ToString(),
                    TireBrandDisplayName = "Dunlop",
                    TireBrandName = "dunlop"
                };

                connection.TireBrand.Add(falken);
                connection.TireBrand.Add(dunlop);

                connection.SaveChanges();
            }
        }
    }
}