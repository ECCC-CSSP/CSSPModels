/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{
    [NotMapped]
    public partial class VPScenarioIDAndRawResults : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(1, -1)]
        public int VPScenarioID { get; set; }
        public string RawResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPScenarioIDAndRawResults() : base()
        {
        }
        #endregion Constructors
    }
}
