using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class ContourPolygon
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(0.0D, -1.0D)]
        public double ContourValue { get; set; }
        [Range(1, 100)]
        public int Layer { get; set; }
        [Range(1.0D, 10000.0D)]
        public double Depth { get; set; }

        public virtual List<Node> ContourNodeList { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ContourPolygon()
        {
            ContourNodeList = new List<Node>();
        }
        #endregion Constructors
    }
}
