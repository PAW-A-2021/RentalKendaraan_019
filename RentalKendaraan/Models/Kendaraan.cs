using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RentalKendaraan.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjamen = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }
        [Required(ErrorMessage = "Nama Kendaraan Tidak Boleh Kosong")]
        public string NamaKendaraan { get; set; }
        [Required(ErrorMessage = "Nomer Polisi Tidak Boleh Kosong")]
        public string NoPolisi { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya Boleh Angka")]
        public string NoStnk { get; set; }
        public int? IdJenisKendaraan { get; set; }
        [Required(ErrorMessage = "Ketersediaan Tidak Boleh Kosong")]
        public string Ketersediaan { get; set; }


        public virtual JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public virtual ICollection<Peminjaman> Peminjamen { get; set; }
    }
}
