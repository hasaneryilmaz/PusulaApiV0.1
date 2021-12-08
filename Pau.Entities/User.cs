using Pau.Core.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pau.Entities
{
    public class User:IEntity
    {

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Username { get; set; }

        [StringLength(50)]
        [Required]
        public string Usermail { get; set; }

        [StringLength(50)]
        [Required]
        public string Userpass { get; set; }


    }
}
