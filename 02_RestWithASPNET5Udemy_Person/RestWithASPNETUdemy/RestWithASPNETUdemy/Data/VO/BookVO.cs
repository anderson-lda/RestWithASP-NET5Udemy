using RestWithASPNETUdemy.Hypermedia;
using RestWithASPNETUdemy.Hypermedia.Abstract;
using System;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Data.VO
{
    public class BookVO: ISupportsHyperMedia
    {
        public long Id { get; set; }
        public string author { get; set; }
        public DateTime launch_date { get; set; }
        public decimal price { get; set; }
        public string title { get; set; }
        public List<HyperMediaLink> Links { get; set; }
        = new List<HyperMediaLink>();
    }
}
