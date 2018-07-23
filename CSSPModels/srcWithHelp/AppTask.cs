using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class AppTask : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "AppTask ID")]
        [CSSPDisplayFR(DisplayFR = "AppTask ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the AppTasks table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau AppTasks")]
        public int AppTaskID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,6,8,9,11,12,14,15,16,17,18,19,20,22,24,25,26,29,30,41,42")]
        public int TVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,6,8,9,11,12,14,15,16,17,18,19,20,22,24,25,26,29,30,41,42")]
        public int TVItemID2 { get; set; }
        [CSSPEnumType]
        public AppTaskCommandEnum AppTaskCommand { get; set; }
        [CSSPEnumType]
        public AppTaskStatusEnum AppTaskStatus { get; set; }
        [Range(0, 100)]
        public int PercentCompleted { get; set; }
        public string Parameters { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime StartDateTime_UTC { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDateTime_UTC")]
        public DateTime? EndDateTime_UTC { get; set; }
        [Range(0, 1000000)]
        public int? EstimatedLength_second { get; set; }
        [Range(0, 1000000)]
        public int? RemainingTime_second { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public AppTaskWeb AppTaskWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public AppTaskReport AppTaskReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public AppTask() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class AppTaskWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string TVItemTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID2", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string TVItem2TVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "AppTaskCommandEnum", EnumType = "AppTaskCommand")]
        [CSSPAllowNull]
        public string AppTaskCommandText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "AppTaskStatusEnum", EnumType = "AppTaskStatus")]
        [CSSPAllowNull]
        public string AppTaskStatusText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        public string LanguageText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public AppTaskWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class AppTaskReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string AppTaskReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public AppTaskReport()
        {
        }
        #endregion Constructors
    }
}
