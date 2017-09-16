using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    ///     Entity object for CSSPModels.VPResValuess DB Table
    /// </summary>
    [NotMapped]
    public partial class VPResValues
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(0, -1)]
        public int Conc { get; set; }
        public double Dilu { get; set; }
        public double FarfieldWidth { get; set; }
        public double Distance { get; set; }
        public double TheTime { get; set; }
        public double Decay { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPResValues()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
