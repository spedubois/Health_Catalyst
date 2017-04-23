using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace people.Models
{
    [Table("people")]
    public class People
    {
        [Key]
        [DisplayName("Perosns first name")]
        public string first { get; set; }
        [DisplayName("Perosns last name")]
        public string last { get; set; }
        [DisplayName("Perosns address")]
        public string address { get; set; }
        [DisplayName("Perosns age")]
        public int age { get; set; }
        [DisplayName("Perosns phone number")]
        public string phone { get; set; }
        [DisplayName("Perosns photo")]
        public Byte[] photo { get; set; }
    }

}