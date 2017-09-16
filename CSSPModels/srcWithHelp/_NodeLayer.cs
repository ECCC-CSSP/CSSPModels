using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    ///     Entity object for CSSPModels.NodeLayers DB Table
    /// </summary>
    [NotMapped]
    public partial class NodeLayer
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(1, 100)]
        public int Layer { get; set; }
        public double Z { get; set; }
        public virtual Node Node { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public NodeLayer()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
