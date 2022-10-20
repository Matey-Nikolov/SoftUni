namespace MusicHub.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class SongPerformer
    {
        [Key]
        public int SongId { get; set; }

        [Required]
        public Song Song { get; set; } // ???

        [Key]
        public int PerformerId { get; set; }

        //[Required]
        // Performer – the song’s Performer (required) ???
        [Required]
        public Performer Performer { get; set; }
    }
}