﻿namespace MusicHub.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Album
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        // Price – calculated property (the sum of all song prices in the album)
        //[Required]
        //public decimal Price { get; set; }

        [ForeignKey("Producer")]
        public int? ProducerId { get; set; }

        public string Producer { get; set; }

        // Songs – collection of all Songs in the Album
        public ICollection<Song> Songs { get; set; }
    }
}