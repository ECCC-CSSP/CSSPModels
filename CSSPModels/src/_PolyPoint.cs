using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class PolyPoint
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(-180.0D, 180.0D)]
        public double XCoord { get; set; }
        [Range(-90.0D, 90.0D)]
        public double YCoord { get; set; }
        public double Z { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolyPoint()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
