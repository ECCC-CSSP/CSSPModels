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
    public partial class LastUpdateAndTVText : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Error { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateAndTVTextDate_UTC { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_Local { get; set; }
        [StringLength(200, MinimumLength = 1)]
        public string TVText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LastUpdateAndTVText() : base()
        {
        }
        #endregion Constructors
    }
}
