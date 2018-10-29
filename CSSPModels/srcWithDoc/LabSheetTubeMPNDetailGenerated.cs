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
    /// > <para>**DB properties for table LabSheetTubeMPNDetails** : [LabSheetTubeMPNDetailID](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_LabSheetTubeMPNDetailID), [LabSheetDetailID](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_LabSheetDetailID), [Ordinal](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_Ordinal), [MWQMSiteTVItemID](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_MWQMSiteTVItemID), [SampleDateTime](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_SampleDateTime), [MPN](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_MPN), [Tube10](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_Tube10), [Tube1_0](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_Tube1_0), [Tube0_1](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_Tube0_1), [Salinity](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_Salinity), [Temperature](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_Temperature), [ProcessedBy](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_ProcessedBy), [SampleType](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_SampleType), [SiteComment](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_SiteComment), [LastUpdateDate_UTC](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_HasErrors), [ValidationResults](CSSPModels.LabSheetTubeMPNDetail.html#CSSPModels_LabSheetTubeMPNDetail_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [LabSheetTubeMPNDetailService](CSSPServices.LabSheetTubeMPNDetailService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [SampleTypeEnum](CSSPEnums.SampleTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class LabSheetTubeMPNDetail : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "LabSheetTubeMPNDetail ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "LabSheetTubeMPNDetail ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the LabSheetTubeMPNDetails table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table LabSheetTubeMPNDetails")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- LabSheetTubeMPNDetail ID
        /// 
        /// **Display (fr)** --- LabSheetTubeMPNDetail ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the LabSheetTubeMPNDetails table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table LabSheetTubeMPNDetails
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "LabSheetTubeMPNDetail ID")]
        [CSSPDisplayFR(DisplayFR = "LabSheetTubeMPNDetail ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the LabSheetTubeMPNDetails table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table LabSheetTubeMPNDetails")]
        public int LabSheetTubeMPNDetailID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "LabSheetDetail", ExistPlurial = "s", ExistFieldID = "LabSheetDetailID")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Lab sheet details")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Détails de feuille de laboratoire")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the LabSheetDetails table representing the lab sheet detail")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table LabSheetDetails représentant les détail de laboratoire")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Lab sheet details
        /// 
        /// **Display (fr)** --- Détails de feuille de laboratoire
        /// 
        /// **Description (en)** --- Link to the LabSheetDetails table representing the lab sheet detail
        /// 
        /// **Description (fr)** --- Lien à la table LabSheetDetails représentant les détail de laboratoire
        /// </returns>
        [CSSPExist(ExistTypeName = "LabSheetDetail", ExistPlurial = "s", ExistFieldID = "LabSheetDetailID")]
        [CSSPDisplayEN(DisplayEN = "Lab sheet details")]
        [CSSPDisplayFR(DisplayFR = "Détails de feuille de laboratoire")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the LabSheetDetails table representing the lab sheet detail")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table LabSheetDetails représentant les détail de laboratoire")]
        public int LabSheetDetailID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Ordinal")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Ordre")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Ordinal")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Ordre")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Ordinal
        /// 
        /// **Display (fr)** --- Ordre
        /// 
        /// **Description (en)** --- Ordinal
        /// 
        /// **Description (fr)** --- Ordre
        /// </returns>
        [Range(0, 1000)]
        [CSSPDisplayEN(DisplayEN = "Ordinal")]
        [CSSPDisplayFR(DisplayFR = "Ordre")]
        [CSSPDescriptionEN(DescriptionEN = @"Ordinal")]
        [CSSPDescriptionFR(DescriptionFR = @"Ordre")]
        public int Ordinal { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>16 == MWQMSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MWQMSite TVItemID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "MWQMSite TVItemID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the TVItems table representing the MWQM site")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table TVItems représentant le site de MWQM (fr)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MWQMSite TVItemID
        /// 
        /// **Display (fr)** --- MWQMSite TVItemID
        /// 
        /// **Description (en)** --- Link to the TVItems table representing the MWQM site
        /// 
        /// **Description (fr)** --- Lien à la table TVItems représentant le site de MWQM (fr)
        /// </returns>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        [CSSPDisplayEN(DisplayEN = "MWQMSite TVItemID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSite TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the MWQM site")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le site de MWQM (fr)")]
        public int MWQMSiteTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Sample date")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Date de la tournée")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Sample date")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Date de la tournée")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Sample date
        /// 
        /// **Display (fr)** --- Date de la tournée
        /// 
        /// **Description (en)** --- Sample date
        /// 
        /// **Description (fr)** --- Date de la tournée
        /// </returns>
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Sample date")]
        [CSSPDisplayFR(DisplayFR = "Date de la tournée")]
        [CSSPDescriptionEN(DescriptionEN = @"Sample date")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de la tournée")]
        public DateTime? SampleDateTime { get; set; }
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
        [Range(1, 10000000)]
        [CSSPDisplayEN(DisplayEN = "MPN (/100 mL)")]
        [CSSPDisplayFR(DisplayFR = "NPP (/100 mL)")]
        [CSSPDescriptionEN(DescriptionEN = @"Most probable number of fecal coliform colonies per 100 mL")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre le plus probable de colonies de coliform fécaux par 100 mL")]
        public int? MPN { get; set; }
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
        public int? Tube10 { get; set; }
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
        public int? Tube1_0 { get; set; }
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
        public int? Tube0_1 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Salinity (PPT)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Salinité (PPT)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Salinity in parts per thousand")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Salinité en parties par millier")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Salinity (PPT)
        /// 
        /// **Display (fr)** --- Salinité (PPT)
        /// 
        /// **Description (en)** --- Salinity in parts per thousand
        /// 
        /// **Description (fr)** --- Salinité en parties par millier
        /// </returns>
        [Range(0.0D, 40.0D)]
        [CSSPDisplayEN(DisplayEN = "Salinity (PPT)")]
        [CSSPDisplayFR(DisplayFR = "Salinité (PPT)")]
        [CSSPDescriptionEN(DescriptionEN = @"Salinity in parts per thousand")]
        [CSSPDescriptionFR(DescriptionFR = @"Salinité en parties par millier")]
        public double? Salinity { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Temperature (°C)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Température (°C)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Temperature in degree Celcius")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Température en dégré Celcius")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Temperature (°C)
        /// 
        /// **Display (fr)** --- Température (°C)
        /// 
        /// **Description (en)** --- Temperature in degree Celcius
        /// 
        /// **Description (fr)** --- Température en dégré Celcius
        /// </returns>
        [Range(-10.0D, 40.0D)]
        [CSSPDisplayEN(DisplayEN = "Temperature (°C)")]
        [CSSPDisplayFR(DisplayFR = "Température (°C)")]
        [CSSPDescriptionEN(DescriptionEN = @"Temperature in degree Celcius")]
        [CSSPDescriptionFR(DescriptionFR = @"Température en dégré Celcius")]
        public double? Temperature { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Processed by")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Traité par")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Processed by")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Traité par")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Processed by
        /// 
        /// **Display (fr)** --- Traité par
        /// 
        /// **Description (en)** --- Processed by
        /// 
        /// **Description (fr)** --- Traité par
        /// </returns>
        [StringLength(10)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Processed by")]
        [CSSPDisplayFR(DisplayFR = "Traité par")]
        [CSSPDescriptionEN(DescriptionEN = @"Processed by")]
        [CSSPDescriptionFR(DescriptionFR = @"Traité par")]
        public string ProcessedBy { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Sample type")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Type d'échantillon")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Sample type")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Type d'échantillon")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Sample type
        /// 
        /// **Display (fr)** --- Type d'échantillon
        /// 
        /// **Description (en)** --- Sample type
        /// 
        /// **Description (fr)** --- Type d'échantillon
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Sample type")]
        [CSSPDisplayFR(DisplayFR = "Type d'échantillon")]
        [CSSPDescriptionEN(DescriptionEN = @"Sample type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'échantillon")]
        public SampleTypeEnum SampleType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Site comment")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Commentaire relié au site")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Site comment")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Commentaire relié au site")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Site comment
        /// 
        /// **Display (fr)** --- Commentaire relié au site
        /// 
        /// **Description (en)** --- Site comment
        /// 
        /// **Description (fr)** --- Commentaire relié au site
        /// </returns>
        [StringLength(250)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Site comment")]
        [CSSPDisplayFR(DisplayFR = "Commentaire relié au site")]
        [CSSPDescriptionEN(DescriptionEN = @"Site comment")]
        [CSSPDescriptionFR(DescriptionFR = @"Commentaire relié au site")]
        public string SiteComment { get; set; }
        #endregion Properties in DB

        #region Constructors
        public LabSheetTubeMPNDetail() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LabSheetTubeMPNDetailExtraA : LabSheetTubeMPNDetail
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MWQM Site text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte du site MWQM (fr)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "MWQM Site text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du site MWQM (fr)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MWQM Site text
        /// 
        /// **Display (fr)** --- Texte du site MWQM (fr)
        /// 
        /// **Description (en)** --- MWQM Site text
        /// 
        /// **Description (fr)** --- Texte du site MWQM (fr)
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "MWQM Site text")]
        [CSSPDisplayFR(DisplayFR = "Texte du site MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM Site text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du site MWQM (fr)")]
        public string MWQMSiteText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Last update contact name")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Nom du contact ayant fait le dernière changement")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Last update contact name")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nom du contact ayant fait le dernière changement")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Last update contact name
        /// 
        /// **Display (fr)** --- Nom du contact ayant fait le dernière changement
        /// 
        /// **Description (en)** --- Last update contact name
        /// 
        /// **Description (fr)** --- Nom du contact ayant fait le dernière changement
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Sample type text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte du type d'échantillon")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Sample type text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du type d'échantillon")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Sample type text
        /// 
        /// **Display (fr)** --- Texte du type d'échantillon
        /// 
        /// **Description (en)** --- Sample type text
        /// 
        /// **Description (fr)** --- Texte du type d'échantillon
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Sample type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type d'échantillon")]
        [CSSPDescriptionEN(DescriptionEN = @"Sample type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type d'échantillon")]
        public string SampleTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetTubeMPNDetailExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LabSheetTubeMPNDetailExtraB : LabSheetTubeMPNDetailExtraA
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
        public string LabSheetTubeMPNDetailReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetTubeMPNDetailExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
