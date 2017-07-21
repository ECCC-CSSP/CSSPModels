using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class ElementLayer
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(1, 1000)]
        public int Layer { get; set; }
        public double ZMin { get; set; }
        public double ZMax { get; set; }

        public virtual Element Element { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ElementLayer()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
