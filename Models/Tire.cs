using System.ComponentModel.DataAnnotations.Schema;

namespace Lager
{
    public enum TireType
    {
        Sommer,
        Winter,
        Ganzjahr
    }

    public enum TireVehicle
    {
        Motorrad,
        Auto,
        Kastenwagen,
        Lastkraftwagen
    }

    public class Tire
    {
        public string TireId {get; set;} = default!;
        public virtual TireBrand Brand {get; set;} = default!;
        [Column(TypeName = "nvarchar(50)")]
        public TireType TireType {get; set;}
        [Column(TypeName = "nvarchar(50)")]
        public TireVehicle TireVehicle {get; set;}
        public int Width {get; set;}
        public int Height {get; set;}
        public double RimSize {get; set;}
        public int LoadIndex {get; set;}
        public char SpeedIndex {get; set;}
        public string Description {get; set;} = default!;
        public double PurchasingPrice {get; set;}
        public double SellingPrice {get; set;}
    }
}