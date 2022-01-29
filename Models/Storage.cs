namespace Lager.Models
{
    public class Storage
    {
        [Key]
        public string StorageId {get; set;} = default!;
        public string StorageName {get; set;} = default!;
    }
}