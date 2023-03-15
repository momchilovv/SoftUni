using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace P01_HospitalDatabase.Data.Models
{
    public class Diagnose
    {
        [Key]
        public int DiagnoseId { get; set; }

        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; } = null!;

        [MaxLength(250)]
        [Unicode(true)]
        public string Comments { get; set; } = null!;

        public int PatientId { get; set; }

        public Patient Patient { get; set; } = null!;
    }
}