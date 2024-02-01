namespace Valeter.API.Models
{
    public class JobType
    {
        public int JobTypeId { get; set; }
        public string JobTypeCode { get; set; }
        public string JobTypeName { get; set; }
        public string JobTypeDescription { get; set; }
        public DateTime DtCreation { get; set; }
    }
}
