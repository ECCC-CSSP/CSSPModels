﻿/*
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
    public partial class TVItem : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TVItem ID")]
        [CSSPDisplayFR(DisplayFR = "TVItem ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TVItems table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table TVItems")]
        public int TVItemID { get; set; }
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
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "TV type")]
        [CSSPDisplayFR(DisplayFR = "Type d'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"TV type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'arbre visuel")]
        public TVTypeEnum TVType { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,9,10,11,12,13,14,15,16,17,18,19,20,21,31,79")]
        [CSSPDisplayEN(DisplayEN = "Parent TV ID")]
        [CSSPDisplayFR(DisplayFR = "Parent de l'arbre visuel ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVFiles table representing the parent of the tree view")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le parent de l'arbre visuel")]
        public int ParentID { get; set; }
        [CSSPDisplayEN(DisplayEN = "Is active")]
        [CSSPDisplayFR(DisplayFR = "Est actif")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVFiles table representing the parent of the tree view")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le parent de l'arbre visuel")]
        public bool IsActive { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TVItem() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemExtraA : TVItem
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Tree view Item text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'item de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view item text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de l'item de l'arbre visuel")]
        public string TVItemText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "TV type text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de l'arbre visuel")]
        public string TVTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemExtraB : TVItemExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string TVItemReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
