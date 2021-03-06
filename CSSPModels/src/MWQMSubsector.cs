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
    public partial class MWQMSubsector : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMSubsector ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSubsector ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMSubsectors table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMSubsectors")]
        public int MWQMSubsectorID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        [CSSPDisplayEN(DisplayEN = "MWQM subsector TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Sous-secteur MWQM TVItemID (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing MWQM subsector")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le sous-secteur MWQM (fr)")]
        public int MWQMSubsectorTVItemID { get; set; }
        [StringLength(20)]
        [CSSPDisplayEN(DisplayEN = "Subsector historic key")]
        [CSSPDisplayFR(DisplayFR = "Clef du sous-secteur historique")]
        [CSSPDescriptionEN(DescriptionEN = @"Subsector historic key")]
        [CSSPDescriptionFR(DescriptionFR = @"Clef du sous-secteur historique")]
        public string SubsectorHistoricKey { get; set; }
        [StringLength(20)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Tide location SID text")]
        [CSSPDisplayFR(DisplayFR = "Identifiants SID des site de marées")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide location SID text")]
        [CSSPDescriptionFR(DescriptionFR = @"Identifiants SID des site de marées")]
        public string TideLocationSIDText { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMSubsector() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSubsectorExtraA : MWQMSubsector
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSubsectorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Subsector text")]
        [CSSPDisplayFR(DisplayFR = "Texte du sous-secteur")]
        [CSSPDescriptionEN(DescriptionEN = @"Subsector text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du sous-secteur")]
        public string SubsectorText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSubsectorExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSubsectorExtraB : MWQMSubsectorExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MWQMSubsectorReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSubsectorExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
