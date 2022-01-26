using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormEntityFrameworkCodeFirstMySQL.Models
{
    class Personel
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumYili { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
    }
}
