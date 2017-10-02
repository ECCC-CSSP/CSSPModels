using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class Coord : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(-180.0D, 180.0D)]
        public double Lat { get; set; }
        [Range(-90.0D, 90.0D)]
        public double Lng { get; set; }
        [Range(0, 10000)]
        public int Ordinal { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Coord() : base()
        {
        }
        #endregion Constructors
    }
}