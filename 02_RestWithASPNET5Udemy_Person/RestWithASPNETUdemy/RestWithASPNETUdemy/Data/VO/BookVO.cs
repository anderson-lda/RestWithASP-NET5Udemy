using System;

namespace RestWithASPNETUdemy.Data.VO
{
    public class BookVO
    {
        public long Id { get; set; }
        public string author { get; set; }
        public DateTime launch_date { get; set; }
        public decimal price { get; set; }
        public string title { get; set; }
    }
}
