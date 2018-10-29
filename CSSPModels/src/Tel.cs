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
    public partial class Tel : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "Tel ID")]
        [CSSPDisplayFR(DisplayFR = "Tel ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the Tels table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table Tels")]
        public int TelID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "21")]
        [CSSPDisplayEN(DisplayEN = "Tel")]
        [CSSPDisplayFR(DisplayFR = "Tél")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the telephone")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant la téléphone")]
        public int TelTVItemID { get; set; }
        [StringLength(50)]
        [CSSPDisplayEN(DisplayEN = "Tel number")]
        [CSSPDisplayFR(DisplayFR = "Numéro de tél")]
        [CSSPDescriptionEN(DescriptionEN = @"Telephone number")]
        [CSSPDescriptionFR(DescriptionFR = @"Numéro de téléphone")]
        public string TelNumber { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Tel type")]
        [CSSPDisplayFR(DisplayFR = "Type de tél")]
        [CSSPDescriptionEN(DescriptionEN = @"Telephone type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de téléphone")]
        public TelTypeEnum TelType { get; set; }
        #endregion Properties in DB

        #region Constructors
        public Tel() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TelExtraA : Tel
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TelTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Tel number")]
        [CSSPDisplayFR(DisplayFR = "Numéro de téléphone")]
        [CSSPDescriptionEN(DescriptionEN = @"Tel number")]
        [CSSPDescriptionFR(DescriptionFR = @"Numéro de téléphone")]
        public string TelNumberText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TelTypeEnum", EnumType = "TelType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Tel type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type de tél")]
        [CSSPDescriptionEN(DescriptionEN = @"Telephone type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type de téléphone")]
        public string TelTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public TelExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TelExtraB : TelExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string TelReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TelExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
