using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class PolSourceObsInfoChild : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [CSSPEnumType]
        public PolSourceObsInfoEnum PolSourceObsInfo { get; set; }
        [CSSPEnumType]
        public PolSourceObsInfoEnum PolSourceObsInfoChildStart { get; set; }
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "PolSourceObsInfoEnum", EnumType = "PolSourceObsInfo")]
        public string PolSourceObsInfoText { get; set; }
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "PolSourceObsInfoEnum", EnumType = "PolSourceObsInfoChildStart")]
        public string PolSourceObsInfoChildStartText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolSourceObsInfoChild() : base()
        {
        }
        #endregion Constructors
    }
}
