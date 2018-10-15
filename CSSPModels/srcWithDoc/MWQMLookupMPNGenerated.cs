/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
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
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**DB properties for table MWQMLookupMPNs** : [MWQMLookupMPNID](CSSPModels.MWQMLookupMPN.html#CSSPModels_MWQMLookupMPN_MWQMLookupMPNID), [Tubes10](CSSPModels.MWQMLookupMPN.html#CSSPModels_MWQMLookupMPN_Tubes10), [Tubes1](CSSPModels.MWQMLookupMPN.html#CSSPModels_MWQMLookupMPN_Tubes1), [Tubes01](CSSPModels.MWQMLookupMPN.html#CSSPModels_MWQMLookupMPN_Tubes01), [MPN_100ml](CSSPModels.MWQMLookupMPN.html#CSSPModels_MWQMLookupMPN_MPN_100ml), [LastUpdateDate_UTC](CSSPModels.MWQMLookupMPN.html#CSSPModels_MWQMLookupMPN_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.MWQMLookupMPN.html#CSSPModels_MWQMLookupMPN_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.MWQMLookupMPN.html#CSSPModels_MWQMLookupMPN_HasErrors), [ValidationResults](CSSPModels.MWQMLookupMPN.html#CSSPModels_MWQMLookupMPN_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MWQMLookupMPNService](CSSPServices.MWQMLookupMPNService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class MWQMLookupMPN : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MWQMLookupMPN ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "MWQMLookupMPN ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the MWQMLookupMPNs table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table MWQMLookupMPNs")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MWQMLookupMPN ID
        /// 
        /// **Display (fr)** --- MWQMLookupMPN ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the MWQMLookupMPNs table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table MWQMLookupMPNs
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMLookupMPN ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMLookupMPN ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMLookupMPNs table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMLookupMPNs")]
        public int MWQMLookupMPNID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Tube 10")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Tube 10")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Number of positive tube for Tube 10")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nombre de tube positif pour Tube 10")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Tube 10
        /// 
        /// **Display (fr)** --- Tube 10
        /// 
        /// **Description (en)** --- Number of positive tube for Tube 10
        /// 
        /// **Description (fr)** --- Nombre de tube positif pour Tube 10
        /// </returns>
        [Range(0, 5)]
        [CSSPDisplayEN(DisplayEN = "Tube 10")]
        [CSSPDisplayFR(DisplayFR = "Tube 10")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of positive tube for Tube 10")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre de tube positif pour Tube 10")]
        public int Tubes10 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Tube 1")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Tube 1")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Number of positive tube for Tube 1")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nombre de tube positif pour Tube 1")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Tube 1
        /// 
        /// **Display (fr)** --- Tube 1
        /// 
        /// **Description (en)** --- Number of positive tube for Tube 1
        /// 
        /// **Description (fr)** --- Nombre de tube positif pour Tube 1
        /// </returns>
        [Range(0, 5)]
        [CSSPDisplayEN(DisplayEN = "Tube 1")]
        [CSSPDisplayFR(DisplayFR = "Tube 1")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of positive tube for Tube 1")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre de tube positif pour Tube 1")]
        public int Tubes1 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Tube .1")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Tube .1")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Number of positive tube for Tube .1")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nombre de tube positif pour Tube .1")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Tube .1
        /// 
        /// **Display (fr)** --- Tube .1
        /// 
        /// **Description (en)** --- Number of positive tube for Tube .1
        /// 
        /// **Description (fr)** --- Nombre de tube positif pour Tube .1
        /// </returns>
        [Range(0, 5)]
        [CSSPDisplayEN(DisplayEN = "Tube .1")]
        [CSSPDisplayFR(DisplayFR = "Tube .1")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of positive tube for Tube .1")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre de tube positif pour Tube .1")]
        public int Tubes01 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MPN (/100 mL)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "NPP (/100 mL)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Most probable number of fecal coliform colonies per 100 mL")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nombre le plus probable de colonies de coliform fécaux par 100 mL")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MPN (/100 mL)
        /// 
        /// **Display (fr)** --- NPP (/100 mL)
        /// 
        /// **Description (en)** --- Most probable number of fecal coliform colonies per 100 mL
        /// 
        /// **Description (fr)** --- Nombre le plus probable de colonies de coliform fécaux par 100 mL
        /// </returns>
        [Range(1, 10000)]
        [CSSPDisplayEN(DisplayEN = "MPN (/100 mL)")]
        [CSSPDisplayFR(DisplayFR = "NPP (/100 mL)")]
        [CSSPDescriptionEN(DescriptionEN = @"Most probable number of fecal coliform colonies per 100 mL")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre le plus probable de colonies de coliform fécaux par 100 mL")]
        public int MPN_100ml { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMLookupMPN() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMLookupMPNExtraA : MWQMLookupMPN
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Last update contact TVItemLanguage")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Last update contact TVItemLanguage DB object")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Object BD TVItemLanguage du contact ayant fait le dernière changement")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Last update contact TVItemLanguage
        /// 
        /// **Display (fr)** --- TVItemLanguage du contact ayant fait le dernière changement
        /// 
        /// **Description (en)** --- Last update contact TVItemLanguage DB object
        /// 
        /// **Description (fr)** --- Object BD TVItemLanguage du contact ayant fait le dernière changement
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMLookupMPNExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMLookupMPNExtraB : MWQMLookupMPNExtraA
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Report test")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Test report")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Report test description")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Description de test report")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Report test
        /// 
        /// **Display (fr)** --- Test report
        /// 
        /// **Description (en)** --- Report test description
        /// 
        /// **Description (fr)** --- Description de test report
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MWQMLookupMPNReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMLookupMPNExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
