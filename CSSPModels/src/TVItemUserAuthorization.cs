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
    public partial class TVItemUserAuthorization : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TVItemUserAuthorization ID")]
        [CSSPDisplayFR(DisplayFR = "TVItemUserAuthorization ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TVItemUserAuthorizations table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table TVItemUserAuthorizations")]
        public int TVItemUserAuthorizationID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        [CSSPDisplayEN(DisplayEN = "Contact TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Contact TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the contact")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le contact")]
        public int ContactTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
        [CSSPDisplayEN(DisplayEN = "TVItemID 1")]
        [CSSPDisplayFR(DisplayFR = "TVItemID 1")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the item 1 of the tree view")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant l'item 1 de l'arbre visuel")]
        public int TVItemID1 { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
        [CSSPDisplayEN(DisplayEN = "TVItemID 2")]
        [CSSPDisplayFR(DisplayFR = "TVItemID 2")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the item 2 of the tree view")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant l'item 2 de l'arbre visuel")]
        public int? TVItemID2 { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
        [CSSPDisplayEN(DisplayEN = "TVItemID 3")]
        [CSSPDisplayFR(DisplayFR = "TVItemID 3")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the item 3 of the tree view")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant l'item 3 de l'arbre visuel")]
        public int? TVItemID3 { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
        [CSSPDisplayEN(DisplayEN = "TVItemID 4")]
        [CSSPDisplayFR(DisplayFR = "TVItemID 4")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the item 4 of the tree view")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant l'item 4 de l'arbre visuel")]
        public int? TVItemID4 { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "TV authorization")]
        [CSSPDisplayFR(DisplayFR = "Authorization pour l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the tree view authorization")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant l'authorization pour l'arbre visuel")]
        public TVAuthEnum TVAuth { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TVItemUserAuthorization() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemUserAuthorization_A : TVItemUserAuthorization
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage contact")]
        [CSSPDescriptionEN(DescriptionEN = @"Contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact")]
        public TVItemLanguage ContactTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID1", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "TV item 1 TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage de l'item 1 de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view item 1 TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage de l'item 1 de l'arbre visuel")]
        public TVItemLanguage TVItemLanguage1 { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID2", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "TV item 2 TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage de l'item 2 de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view item 2 TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage de l'item 2 de l'arbre visuel")]
        public TVItemLanguage TVItemLanguage2 { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID3", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "TV item 3 TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage de l'item 3 de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view item 3 TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage de l'item 3 de l'arbre visuel")]
        public TVItemLanguage TVItemLanguage3 { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID4", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "TV item 4 TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage de l'item 4 de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view item 4 TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage de l'item 4 de l'arbre visuel")]
        public TVItemLanguage TVItemLanguage4 { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVAuthEnum", EnumType = "TVAuth")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "TV authorization text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'authorization pour l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view authorization text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de l'authorization pour l'arbre visuel")]
        public string TVAuthText { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemUserAuthorization_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemUserAuthorization_B : TVItemUserAuthorization_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string TVItemUserAuthorizationReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemUserAuthorization_B() : base()
        {
        }
        #endregion Constructors
    }
}
