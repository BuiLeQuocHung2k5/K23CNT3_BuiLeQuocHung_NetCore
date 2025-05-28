using System.ComponentModel.DataAnnotations;

namespace BlqhLab06.Models
{
    public class BlqhEmployee
    {
        public int BlqhId { get; set; }
        public string BlqhName { get; set; }
        public DateTime BlqhBirthDay { get; set; }
        public string BlqhEmail { get; set; }
        public string BlqhPhone { get; set; }
        public decimal BlqhSalary { get; set; }
        public bool BlqhStatus { get; set; }
    }
}