/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class VPResValues : Error
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
        #endregion Properties not in DB

        #region Constructors
        public VPResValues() : base()
        {
        }
        #endregion Constructors
    }
}
