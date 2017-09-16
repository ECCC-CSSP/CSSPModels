using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    ///     Entity object for CSSPModels.VPFulls DB Table
    /// </summary>
    [NotMapped]
    public partial class VPFull
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public virtual VPScenario VPScenario { get; set; }
        public virtual List<VPAmbient> VPAmbientList { get; set; }
        public virtual List<VPResult> VPResultList { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPFull()
        {
            VPAmbientList = new List<VPAmbient>();
            VPResultList = new List<VPResult>();
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
