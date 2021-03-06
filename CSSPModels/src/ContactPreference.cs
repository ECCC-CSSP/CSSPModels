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
    public partial class ContactPreference : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ContactPreference ID")]
        [CSSPDisplayFR(DisplayFR = "ContactPreference ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ContactPreferences table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table ContactPreferences")]
        public int ContactPreferenceID { get; set; }
        [CSSPExist(ExistTypeName = "Contact", ExistPlurial = "s", ExistFieldID = "ContactID")]
        [CSSPDisplayEN(DisplayEN = "Contact ID")]
        [CSSPDisplayFR(DisplayFR = "Contact ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the Contacts table with the unique identifier")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table Contacts avec l'identifiant unique")]
        public int ContactID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "TV type")]
        [CSSPDisplayFR(DisplayFR = "Type AV")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view item type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'item pour l'arbre visuel")]
        public TVTypeEnum TVType { get; set; }
        [Range(1, 1000)]
        [CSSPDisplayEN(DisplayEN = "Marker size")]
        [CSSPDisplayFR(DisplayFR = "Taille du marqueur")]
        [CSSPDescriptionEN(DescriptionEN = @"Marker size")]
        [CSSPDescriptionFR(DescriptionFR = @"Taille du marqueur")]
        public int MarkerSize { get; set; }
        #endregion Properties in DB

        #region Constructors
        public ContactPreference() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ContactPreferenceExtraA : ContactPreference
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "TV type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type AV")]
        [CSSPDescriptionEN(DescriptionEN = @"TV type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type AV")]
        public string TVTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public ContactPreferenceExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ContactPreferenceExtraB : ContactPreferenceExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string ContactPreferenceReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public ContactPreferenceExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
