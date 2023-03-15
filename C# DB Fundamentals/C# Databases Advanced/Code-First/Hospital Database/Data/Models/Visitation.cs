using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_HospitalDatabase.Data.Models
{
    public class Visitation
    {
        [Key]
        public int VisitationId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        [MaxLength(250)]
        [Unicode(true)]
        public string Comments { get; set; } = null!;

        public int PatientId { get; set; }

        public Patient Patient { get; set; } = null!;

        public int DoctorId { get; set; }

        public Doctor Doctor { get; set; } = null!;
    }
}