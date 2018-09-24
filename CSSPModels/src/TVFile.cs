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
        [CSSPDisplayEN(DisplayEN = "TV file TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Filière sous l'arbre visuel TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the file under the tree view")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant la filière sous l'arbre visuel")]
        public int TVFileTVItemID { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Template TV type")]
        [CSSPDisplayFR(DisplayFR = "Type d'arbre visuel du gabari")]
        [CSSPDescriptionEN(DescriptionEN = @"Template tree view type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'arbre visuel du gabari")]
        public TVTypeEnum? TemplateTVType { get; set; }
        [CSSPExist(ExistTypeName = "ReportType", ExistPlurial = "s", ExistFieldID = "ReportTypeID")]
        [CSSPDisplayEN(DisplayEN = "Report type ID")]
        [CSSPDisplayFR(DisplayFR = "Type de raport ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the ReportTypes table representing the report type")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table ReportTypes représentant le type de raport")]
        public int? ReportTypeID { get; set; }
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Parameters")]
        [CSSPDisplayFR(DisplayFR = "Paramètres")]
        [CSSPDescriptionEN(DescriptionEN = @"Parameters used when producing the report")]
        [CSSPDescriptionFR(DescriptionFR = @"Paramètres utilisé lors de la production de raport")]
        public string Parameters { get; set; }
        [Range(1980, 2050)]
        [CSSPDisplayEN(DisplayEN = "Year")]
        [CSSPDisplayFR(DisplayFR = "Année")]
        [CSSPDescriptionEN(DescriptionEN = @"Year")]
        [CSSPDescriptionFR(DescriptionFR = @"Année")]
        public int? Year { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage")]
        public LanguageEnum Language { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "File purpose")]
        [CSSPDisplayFR(DisplayFR = "But du fichier")]
        [CSSPDescriptionEN(DescriptionEN = @"File purpose")]
        [CSSPDescriptionFR(DescriptionFR = @"But du fichier")]
        public FilePurposeEnum FilePurpose { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "File type")]
        [CSSPDisplayFR(DisplayFR = "Type de filière")]
        [CSSPDescriptionEN(DescriptionEN = @"File type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de filière")]
        public FileTypeEnum FileType { get; set; }
        [Range(0, 100000000)]
        [CSSPDisplayEN(DisplayEN = "File size (KB)")]
        [CSSPDisplayFR(DisplayFR = "Taille du fichier (KB)")]
        [CSSPDescriptionEN(DescriptionEN = @"File site (KB)")]
        [CSSPDescriptionFR(DescriptionFR = @"Taille du fichier")]
        public int FileSize_kb { get; set; }
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "File info")]
        [CSSPDisplayFR(DisplayFR = "Info sur le fichier")]
        [CSSPDescriptionEN(DescriptionEN = @"File information")]
        [CSSPDescriptionFR(DescriptionFR = @"Information sur le fichier")]
        public string FileInfo { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "File created date (UTC)")]
        [CSSPDisplayFR(DisplayFR = "Date de création du fichier (UTC)")]
        [CSSPDescriptionEN(DescriptionEN = @"File created date (UTC)")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de création du fichier (UTC)")]
        public DateTime FileCreatedDate_UTC { get; set; }
        [CSSPDisplayEN(DisplayEN = "From water")]
        [CSSPDisplayFR(DisplayFR = "Pris sur l'eau")]
        [CSSPDescriptionEN(DescriptionEN = @"Taken from water")]
        [CSSPDescriptionFR(DescriptionFR = @"Pris sur l'eau")]
        public bool? FromWater { get; set; }
        [StringLength(250)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Client file path")]
        [CSSPDisplayFR(DisplayFR = "Adress du fichier au client")]
        [CSSPDescriptionEN(DescriptionEN = @"Client file path")]
        [CSSPDescriptionFR(DescriptionFR = @"Adress du fichier au client")]
        public string ClientFilePath { get; set; }
        [StringLength(250)]
        [CSSPDisplayEN(DisplayEN = "Server file name")]
        [CSSPDisplayFR(DisplayFR = "Nom du fichier au serveur")]
        [CSSPDescriptionEN(DescriptionEN = @"Server file name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du fichier au serveur")]
        public string ServerFileName { get; set; }
        [StringLength(250)]
        [CSSPDisplayEN(DisplayEN = "Server file path")]
        [CSSPDisplayFR(DisplayFR = "Adress du fichier au serveur")]
        [CSSPDescriptionEN(DescriptionEN = @"Server file path")]
        [CSSPDescriptionFR(DescriptionFR = @"Adress du fichier au serveur")]
        public string ServerFilePath { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TVFile() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVFile_A : TVFile
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVFileTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "TV file TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage de l'arbre visuel du fichier")]
        [CSSPDescriptionEN(DescriptionEN = @"TV file TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage de l'arbre visuel du fichier")]
        public TVItemLanguage TVFileTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TemplateTVType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Template TV type text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'arbre visuel du gabari")]
        [CSSPDescriptionEN(DescriptionEN = @"Template TV type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de l'arbre visuel du gabari")]
        public string TemplateTVTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Language text")]
        [CSSPDisplayFR(DisplayFR = "Texte de la langue")]
        [CSSPDescriptionEN(DescriptionEN = @"Language text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de la langue")]
        public string LanguageText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "FilePurposeEnum", EnumType = "FilePurpose")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "File purpose text")]
        [CSSPDisplayFR(DisplayFR = "Texte du but du fichier")]
        [CSSPDescriptionEN(DescriptionEN = @"File purpose text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du but du fichier")]
        public string FilePurposeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "FileTypeEnum", EnumType = "FileType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "File type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type de filière")]
        [CSSPDescriptionEN(DescriptionEN = @"File type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type de filière")]
        public string FileTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public TVFile_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVFile_B : TVFile_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string TVFileReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TVFile_B() : base()
        {
        }
        #endregion Constructors
    }
}
