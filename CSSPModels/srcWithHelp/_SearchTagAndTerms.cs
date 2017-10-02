using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class SearchTagAndTerms : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [CSSPEnumType]
        public SearchTagEnum SearchTag { get; set; }
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "SearchTagEnum", EnumType = "SearchTag")]
        [CSSPAllowNull]
        public string SearchTagText { get; set; }
        public virtual List<string> SearchTermList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public SearchTagAndTerms() : base()
        {
            SearchTermList = new List<string>();
        }
        #endregion Constructors
    }
}