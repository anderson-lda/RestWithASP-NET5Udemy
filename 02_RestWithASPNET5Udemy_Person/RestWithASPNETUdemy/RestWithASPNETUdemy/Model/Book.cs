using RestWithASPNETUdemy.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("books")]
    public class Book: BaseEntity
    {
        [Column("author")]
        public string author { get; set; }
        [Column("launch_date")]
        public DateTime launch_date { get; set; }
        [Column("price")]
        public decimal price { get; set; }
        [Column("title")]
        public string title { get; set; }
    }
}
