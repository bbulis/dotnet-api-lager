using System.ComponentModel.DataAnnotations.Schema;

namespace Lager.DbController
{

    public class TireBrand
    {
        public string TireBrandId {get; set;}
        public string TireBrandName {get; set;}
    }

    public enum TireType
    {
        Sommer,
        Winter,
        Ganzjahr,
        Motorrad_Sommer,
        Motorrad_Ganzjahr
    }

    public class Tire
    {
        public string TireId {get; set;}
        public virtual TireBrand Brand {get; set;}
        [Column(TypeName = "nvarchar(30)")]
        public TireType TireType {get; set;}
        public int Width {get; set;}
        public int Height {get; set;}
        public double RimSize {get; set;}   
        public int LoadIndex {get; set;}
        public char SpeedIndex {get; set;}
        public string Description {get; set;} 
    }
}