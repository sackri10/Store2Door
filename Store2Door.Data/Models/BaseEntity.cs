using System;
namespace Store2Door.Data.Models
{
    public class BaseEntity
    {
        public Int64 Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CreatedUser { get; set; }
        public string UpdatedUser { get; set; }
    }
}