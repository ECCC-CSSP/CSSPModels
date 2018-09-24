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
    public partial class TVItemStat : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TVItemStat ID")]
        [CSSPDisplayFR(DisplayFR = "TVItemStat ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TVItemStats table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table TVItemStats")]
        public int TVItemStatID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
        [CSSPDisplayEN(DisplayEN = "TVItemID")]
        [CSSPDisplayFR(DisplayFR = "TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing item of the tree view")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant l'item de l'arbre visuel")]
        public int TVItemID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "TV type")]
        [CSSPDisplayFR(DisplayFR = "Type d'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'arbre visuel")]
        public TVTypeEnum TVType { get; set; }
        [Range(0, 10000000)]
        [CSSPDisplayEN(DisplayEN = "Child items number")]
        [CSSPDisplayFR(DisplayFR = "Nombre sous items")]
        [CSSPDescriptionEN(DescriptionEN = @"Child items number")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre sous items")]
        public int ChildCount { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TVItemStat() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemStat_A : TVItemStat
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "TV item TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage de l'item de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view item TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage de l'item de l'arbre visuel")]
        public TVItemLanguage TVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "TV item text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'item de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view item text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de l'item de l'arbre visuel")]
        public string TVTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemStat_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemStat_B : TVItemStat_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string TVItemStatReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemStat_B() : base()
        {
        }
        #endregion Constructors
    }
}
