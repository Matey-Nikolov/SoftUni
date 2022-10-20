namespace MusicHub.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public DateTime Duration { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        //[Required]
        //public string Genre { get; set; }

        [ForeignKey("Album")]
        public int AlbumId { get; set; }

        public List<Album> Albums { get; set; } // ??

        [Required]
        [ForeignKey("Writer")]
        public int WriterId { get; set; }

        public string Writer { get; set; }

        [Required]
        public decimal Price { get; set; }

        //public List<> SongPerformers { get; set; } ????????
        public ICollection<SongPerformer> SongPerformers { get; set; }
    }
}
