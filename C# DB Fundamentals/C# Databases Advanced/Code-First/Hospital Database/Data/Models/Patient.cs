using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_HospitalDatabase.Data.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [MaxLength(50)]
        [Unicode(true)]
        public string FirstName { get; set; } = null!;

        [MaxLength(50)]
        [Unicode(true)]
        public string LastName { get; set; } = null!;

        [MaxLength(250)]
        [Unicode(true)]
        public string Address { get; set; } = null!;

        [MaxLength(80)]
        [Unicode(false)]
        public string Email { get; set; } = null!;

        [Column(TypeName = "bit")]
        public bool HasInsurance { get; set; }

        public ICollection<Visitation> Visitations { get; set; } = null!;

        public ICollection<Diagnose> Diagnoses { get; set; } = null!;

        public ICollection<PatientMedicament> Prescriptions { get; set; } = null!;
    }
}