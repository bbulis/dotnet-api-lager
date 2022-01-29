namespace Lager.Models
{
    public class TireBrand
    {
        [Key]
        public string TireBrandId {get; set;} = default!;
        public string TireBrandDisplayName {get; set;} = default!;
        public string TireBrandName {get; set;} = default!;
    }
}