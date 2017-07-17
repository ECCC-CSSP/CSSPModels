using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class VPFull
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB

        public virtual VPScenario VPScenario { get; set; }
        public virtual List<VPAmbient> AmbientList { get; set; }
        public virtual List<VPResult> ResultList { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPFull()
        {
            AmbientList = new List<VPAmbient>();
            ResultList = new List<VPResult>();
        }
        #endregion Constructors
    }
}
