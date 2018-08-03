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
    public partial class TVItemStat : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TVItemStat ID")]
        [CSSPDisplayFR(DisplayFR = "TVItemStat ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TVItemStats table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau TVItemStats")]
        public int TVItemStatID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
        public int TVItemID { get; set; }
        [CSSPEnumType]
        public TVTypeEnum TVType { get; set; }
        [Range(0, 10000000)]
        public int ChildCount { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TVItemStat() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemStatWeb : TVItemStat
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage TVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        public string TVTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public TVItemStatWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemStatReport : TVItemStatWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string TVItemStatReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TVItemStatReport() : base()
        {
        }
        #endregion Constructors
    }
}
