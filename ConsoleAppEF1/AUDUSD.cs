namespace ConsoleAppEF1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AUDUSD")]
    public partial class AUDUSD
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public double OpenPrice { get; set; }

        [Key]
        [Column(Order = 2)]
        public double HighPrice { get; set; }

        [Key]
        [Column(Order = 3)]
        public double LowPrice { get; set; }

        [Key]
        [Column(Order = 4)]
        public double ClosePrice { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long TimeTick { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime TradingTime { get; set; }

        public string Tag1 { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(10)]
        public string Type { get; set; }
    }
}
