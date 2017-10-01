using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TVItemStat : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int TVItemStatID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]
        public int TVItemID { get; set; }
        [CSSPEnumType]
        public TVTypeEnum TVType { get; set; }
        [Range(0, 10000000)]
        public int ChildCount { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public TVItemStatWeb TVItemStatWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public TVItemStatReport TVItemStatReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemStat() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemStatWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string TVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        public string TVTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public TVItemStatWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemStatReport
    {
        #region Properties for report information
        public string TVItemStatReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TVItemStatReport()
        {
        }
        #endregion Constructors
    }
}
