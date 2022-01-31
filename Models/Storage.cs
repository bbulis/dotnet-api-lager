using System.ComponentModel.DataAnnotations.Schema;

namespace Lager
{
    public class Storage
    {
        public string StorageId {get; set;} = default!;
        public string StorageName {get; set;} = default!;
    }
}