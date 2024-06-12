﻿using System;

namespace SignalRApiForSQL.DAL
{
  
        public enum ECity
        {
            İstanbul = 1,
            Ankara = 2,
            İzmir = 3,
            Antalya = 4,
            Bursa = 5
        }
        public class Visitor
        {
            public int Id { get; set; }
            public ECity City { get; set; }
            public int CityVisitCount { get; set; }
            public DateTime VisitDate { get; set; }
        }
    
}
