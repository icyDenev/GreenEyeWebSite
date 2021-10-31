using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LitWebSite.Models
{
    public class Sensors
    {
        [Key]
        public int Id { get; set; }

        public decimal CO { get; set; }

        public decimal CO2 { get; set; }

        public decimal O3 { get; set; }

        public decimal PM25 { get; set; }

        public decimal DownLeftLongtitude { get; set; }

        public decimal DownLeftLatitude { get; set; }

        public decimal UpRightLongtitude { get; set; }

        public decimal UpRightLatitude { get; set; }

    }
}
