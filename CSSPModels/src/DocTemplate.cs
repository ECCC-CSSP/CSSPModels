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
    public partial class DocTemplate : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "DocTemplate ID")]
        [CSSPDisplayFR(DisplayFR = "DocTemplate ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the DocTemplates table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table DocTemplates")]
        public int DocTemplateID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Document template language")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage du document modèle")]
        public LanguageEnum Language { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "TV type")]
        [CSSPDisplayFR(DisplayFR = "Type AV")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view item type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'item pour l'arbre visuel")]
        public TVTypeEnum TVType { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]
        [CSSPDisplayEN(DisplayEN = "TVFile ID")]
        [CSSPDisplayFR(DisplayFR = "TVFile ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVFiles table with the unique identifier")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVFiles avec l'identifiant unique")]
        public int TVFileTVItemID { get; set; }
        [StringLength(150)]
        [CSSPDisplayEN(DisplayEN = "File name")]
        [CSSPDisplayFR(DisplayFR = "Nom de la filière")]
        [CSSPDescriptionEN(DescriptionEN = @"File name of the document template")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom de la filière du document modèle")]
        public string FileName { get; set; }
        #endregion Properties in DB

        #region Constructors
        public DocTemplate() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class DocTemplateExtraA : DocTemplate
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Language text")]
        [CSSPDisplayFR(DisplayFR = "Texte du language")]
        [CSSPDescriptionEN(DescriptionEN = @"Language text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du language")]
        public string LanguageText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "TV type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type AV")]
        [CSSPDescriptionEN(DescriptionEN = @"TV type text")]
        public string TVTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public DocTemplateExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class DocTemplateExtraB : DocTemplateExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string DocTemplateReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public DocTemplateExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
