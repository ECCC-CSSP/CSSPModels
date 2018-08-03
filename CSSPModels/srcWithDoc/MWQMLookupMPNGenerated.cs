/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
 *
 */ 
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMLookupMPN ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMLookupMPN ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMLookupMPNs table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau MWQMLookupMPNs")]
        public int MWQMLookupMPNID { get; set; }
        [Range(0, 5)]
        public int Tubes10 { get; set; }
        [Range(0, 5)]
        public int Tubes1 { get; set; }
        [Range(0, 5)]
        public int Tubes01 { get; set; }
        [Range(1, 10000)]
        public int MPN_100ml { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMLookupMPN() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMLookupMPNWeb : MWQMLookupMPN
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MWQMLookupMPNWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMLookupMPNReport : MWQMLookupMPNWeb
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string MWQMLookupMPNReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MWQMLookupMPNReport() : base()
        {
        }
        #endregion Constructors
    }
}
