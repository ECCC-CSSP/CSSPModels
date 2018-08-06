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
    public partial class TVFile : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TVFile ID")]
        [CSSPDisplayFR(DisplayFR = "TVFile ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TVFiles table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table TVFiles")]
        public int TVFileID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]
        public int TVFileTVItemID { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public TVTypeEnum? TemplateTVType { get; set; }
        [CSSPExist(ExistTypeName = "ReportType", ExistPlurial = "s", ExistFieldID = "ReportTypeID")]
        public int? ReportTypeID { get; set; }
        [CSSPAllowNull]
        public string Parameters { get; set; }
        [Range(1980, 2050)]
        public int? Year { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [CSSPEnumType]
        public FilePurposeEnum FilePurpose { get; set; }
        [CSSPEnumType]
        public FileTypeEnum FileType { get; set; }
        [Range(0, 100000000)]
        public int FileSize_kb { get; set; }
        [CSSPAllowNull]
        public string FileInfo { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime FileCreatedDate_UTC { get; set; }
        public bool? FromWater { get; set; }
        [StringLength(250)]
        [CSSPAllowNull]
        public string ClientFilePath { get; set; }
        [StringLength(250)]
        public string ServerFileName { get; set; }
        [StringLength(250)]
        public string ServerFilePath { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TVFile() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVFileWeb : TVFile
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVFileTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage TVFileTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TemplateTVType")]
        [CSSPAllowNull]
        public string TemplateTVTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        public string LanguageText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "FilePurposeEnum", EnumType = "FilePurpose")]
        [CSSPAllowNull]
        public string FilePurposeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "FileTypeEnum", EnumType = "FileType")]
        [CSSPAllowNull]
        public string FileTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public TVFileWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVFileReport : TVFileWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string TVFileReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TVFileReport() : base()
        {
        }
        #endregion Constructors
    }
}
