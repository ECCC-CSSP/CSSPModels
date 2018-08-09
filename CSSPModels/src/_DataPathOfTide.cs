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
    public partial class DataPathOfTide : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(200, MinimumLength = 1)]
        public string Text { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public WebTideDataSetEnum? WebTideDataSet { get; set; }
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "WebTideDataSetEnum", EnumType = "WebTideDataSet")]
        [CSSPAllowNull]
        public string WebTideDataSetText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public DataPathOfTide() : base()
        {
            Text = "";
            WebTideDataSet = null;
        }
        #endregion Constructors
    }
}
