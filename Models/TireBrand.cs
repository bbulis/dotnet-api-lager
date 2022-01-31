using System.ComponentModel.DataAnnotations.Schema;

namespace Lager
{
    public class TireBrand
    {
        public string TireBrandId {get; set;} = default!;
        public string TireBrandDisplayName {get; set;} = default!;
        public string TireBrandName {get; set;} = default!;
    }
}