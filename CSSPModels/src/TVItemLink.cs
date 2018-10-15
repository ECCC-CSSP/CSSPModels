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
    public partial class TVItemLink : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TVItemLink ID")]
        [CSSPDisplayFR(DisplayFR = "TVItemLink ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TVItemLinks table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table TVItemLinks")]
        public int TVItemLinkID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
        [CSSPDisplayEN(DisplayEN = "From TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Départ TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the from")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le départ")]
        public int FromTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
        [CSSPDisplayEN(DisplayEN = "To TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Fin TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the to")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant la fin")]
        public int ToTVItemID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "From tv type")]
        [CSSPDisplayFR(DisplayFR = "Type d'arbre visuel du départ")]
        [CSSPDescriptionEN(DescriptionEN = @"From tree view type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'arbre visuel du départ")]
        public TVTypeEnum FromTVType { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "To tv type")]
        [CSSPDisplayFR(DisplayFR = "Type d'arbre visuel de la fin")]
        [CSSPDescriptionEN(DescriptionEN = @"To tree view type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'arbre visuel de la fin")]
        public TVTypeEnum ToTVType { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Start date")]
        [CSSPDisplayFR(DisplayFR = "Date de départ")]
        [CSSPDescriptionEN(DescriptionEN = @"Start date")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de départ")]
        public DateTime? StartDateTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDateTime_Local")]
        [CSSPDisplayEN(DisplayEN = "End date")]
        [CSSPDisplayFR(DisplayFR = "Date de fin")]
        [CSSPDescriptionEN(DescriptionEN = @"End date")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de fin")]
        public DateTime? EndDateTime_Local { get; set; }
        [Range(0, 100)]
        [CSSPDisplayEN(DisplayEN = "Ordinal")]
        [CSSPDisplayFR(DisplayFR = "Ordre")]
        [CSSPDescriptionEN(DescriptionEN = @"Ordinal")]
        [CSSPDescriptionFR(DescriptionFR = @"Ordre")]
        public int Ordinal { get; set; }
        [Range(0, 100)]
        [CSSPDisplayEN(DisplayEN = "TV level")]
        [CSSPDisplayFR(DisplayFR = "Niveau de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view level")]
        [CSSPDescriptionFR(DescriptionFR = @"Niveau de l'arbre visuel")]
        public int TVLevel { get; set; }
        [StringLength(250)]
        [CSSPDisplayEN(DisplayEN = "TV path")]
        [CSSPDisplayFR(DisplayFR = "Chemin de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view path")]
        [CSSPDescriptionFR(DescriptionFR = @"Chemin de l'arbre visuel")]
        public string TVPath { get; set; }
        [CSSPExist(ExistTypeName = "TVItemLink", ExistPlurial = "s", ExistFieldID = "TVItemLinkID")]
        [CSSPDisplayEN(DisplayEN = "Parent TV item link")]
        [CSSPDisplayFR(DisplayFR = "Lien du parent de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Parent tree view item link")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien du parent de l'arbre visuel")]
        public int? ParentTVItemLinkID { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TVItemLink() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemLinkExtraA : TVItemLink
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "FromTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "From tv item TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage de l'item de départ de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"From tree view item TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage de l'item de départ de l'arbre visuel")]
        public TVItemLanguage FromTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ToTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "To tv item TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage de l'item de fin de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"To tree view item TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage de l'item de fin de l'arbre visuel")]
        public TVItemLanguage ToTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "FromTVType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "From tv type TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du type d'arbre visuel de départ")]
        [CSSPDescriptionEN(DescriptionEN = @"From tree view type TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du type d'arbre visuel de départ")]
        public string FromTVTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "ToTVType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "To tv type TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du type d'arbre visuel de fin")]
        [CSSPDescriptionEN(DescriptionEN = @"To tree view type TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du type d'arbre visuel de fin")]
        public string ToTVTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemLinkExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemLinkExtraB : TVItemLinkExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string TVItemLinkReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemLinkExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
