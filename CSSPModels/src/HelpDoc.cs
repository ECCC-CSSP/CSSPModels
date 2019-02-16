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
    public partial class HelpDoc : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "Help document ID")]
        [CSSPDisplayFR(DisplayFR = "Identifiant du document aide")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the HelpDocs table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table HelpDocs")]
        public int HelpDocID { get; set; }
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "Help document key")]
        [CSSPDisplayFR(DisplayFR = "Identifiant du document aide")]
        [CSSPDescriptionEN(DescriptionEN = @"Help document key")]
        [CSSPDescriptionFR(DescriptionFR = @"Identifiant du document aide")]
        public string DocKey { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language of the help document")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage du document aide")]
        public LanguageEnum Language { get; set; }
        [StringLength(100000)]
        [CSSPDisplayEN(DisplayEN = "HTML text of help document")]
        [CSSPDisplayFR(DisplayFR = "Texte HTML du document help")]
        [CSSPDescriptionEN(DescriptionEN = @"HTML text of help document")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte HTML du document help")]
        public string DocHTMLText { get; set; }
        #endregion Properties in DB

        #region Constructors
        public HelpDoc() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class HelpDocExtraA : HelpDoc
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        #endregion Properties

        #region Constructors
        public HelpDocExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class HelpDocExtraB : HelpDocExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string EmailReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public HelpDocExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
