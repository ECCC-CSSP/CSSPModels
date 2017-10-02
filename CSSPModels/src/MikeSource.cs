using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MikeSource : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int MikeSourceID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "14")]
        public int MikeSourceTVItemID { get; set; }
        public bool IsContinuous { get; set; }
        public bool Include { get; set; }
        public bool IsRiver { get; set; }
        [StringLength(50)]
        public string SourceNumberString { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public MikeSourceWeb MikeSourceWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public MikeSourceReport MikeSourceReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MikeSource() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeSourceWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MikeSourceTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string MikeSourceTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MikeSourceWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeSourceReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string MikeSourceReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MikeSourceReport()
        {
        }
        #endregion Constructors
    }
}
