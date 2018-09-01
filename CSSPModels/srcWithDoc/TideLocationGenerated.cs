/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
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
    /// > <para>**DB properties for table TideLocations** : [TideLocationID](CSSPModels.TideLocation.html#CSSPModels_TideLocation_TideLocationID), [Zone](CSSPModels.TideLocation.html#CSSPModels_TideLocation_Zone), [Name](CSSPModels.TideLocation.html#CSSPModels_TideLocation_Name), [Prov](CSSPModels.TideLocation.html#CSSPModels_TideLocation_Prov), [sid](CSSPModels.TideLocation.html#CSSPModels_TideLocation_sid), [Lat](CSSPModels.TideLocation.html#CSSPModels_TideLocation_Lat), [Lng](CSSPModels.TideLocation.html#CSSPModels_TideLocation_Lng), [LastUpdateDate_UTC](CSSPModels.TideLocation.html#CSSPModels_TideLocation_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.TideLocation.html#CSSPModels_TideLocation_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.TideLocation.html#CSSPModels_TideLocation_HasErrors), [ValidationResults](CSSPModels.TideLocation.html#CSSPModels_TideLocation_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TideLocationService](CSSPServices.TideLocationService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class TideLocation : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TideLocation ID")]
        [CSSPDisplayFR(DisplayFR = "TideLocation ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TideLocations table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table TideLocations")]
        public int TideLocationID { get; set; }
        [Range(0, 10000)]
        public int Zone { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Prov { get; set; }
        [Range(0, 100000)]
        public int sid { get; set; }
        [Range(-90.0D, 90.0D)]
        public double Lat { get; set; }
        [Range(-180.0D, 180.0D)]
        public double Lng { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TideLocation() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideLocation_A : TideLocation
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public TideLocation_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideLocation_B : TideLocation_A
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string TideLocationReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TideLocation_B() : base()
        {
        }
        #endregion Constructors
    }
}
