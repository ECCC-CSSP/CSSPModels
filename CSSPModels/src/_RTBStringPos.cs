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
    public partial class RTBStringPos : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(0, -1)]
        public int StartPos { get; set; }
        [Range(0, -1)]
        public int EndPos { get; set; }
        public string Text { get; set; }
        public string TagText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public RTBStringPos() : base()
        {
        }
        #endregion Constructors
    }
}
