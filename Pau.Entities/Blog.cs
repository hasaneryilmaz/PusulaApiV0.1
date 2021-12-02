using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pau.Entities
{
    public class Blog
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Title { get; set; }

        [StringLength(50)]
        [Required]
        public string Content { get; set; }

        [StringLength(50)]
        [Required]
        public string User_id { get; set; }
    }
}
