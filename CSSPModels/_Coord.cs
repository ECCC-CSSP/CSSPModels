using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class Coord
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

        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Coord()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
