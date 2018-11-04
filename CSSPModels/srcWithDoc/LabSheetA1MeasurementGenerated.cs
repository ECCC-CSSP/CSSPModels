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
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [Site](CSSPModels.LabSheetA1Measurement.html#CSSPModels_LabSheetA1Measurement_Site), [TVItemID](CSSPModels.LabSheetA1Measurement.html#CSSPModels_LabSheetA1Measurement_TVItemID), [Time](CSSPModels.LabSheetA1Measurement.html#CSSPModels_LabSheetA1Measurement_Time), [MPN](CSSPModels.LabSheetA1Measurement.html#CSSPModels_LabSheetA1Measurement_MPN), [Tube10](CSSPModels.LabSheetA1Measurement.html#CSSPModels_LabSheetA1Measurement_Tube10), [Tube1_0](CSSPModels.LabSheetA1Measurement.html#CSSPModels_LabSheetA1Measurement_Tube1_0), [Tube0_1](CSSPModels.LabSheetA1Measurement.html#CSSPModels_LabSheetA1Measurement_Tube0_1), [Salinity](CSSPModels.LabSheetA1Measurement.html#CSSPModels_LabSheetA1Measurement_Salinity), [Temperature](CSSPModels.LabSheetA1Measurement.html#CSSPModels_LabSheetA1Measurement_Temperature), [ProcessedBy](CSSPModels.LabSheetA1Measurement.html#CSSPModels_LabSheetA1Measurement_ProcessedBy), [SampleType](CSSPModels.LabSheetA1Measurement.html#CSSPModels_LabSheetA1Measurement_SampleType), [SiteComment](CSSPModels.LabSheetA1Measurement.html#CSSPModels_LabSheetA1Measurement_SiteComment), [SampleTypeText](CSSPModels.LabSheetA1Measurement.html#CSSPModels_LabSheetA1Measurement_SampleTypeText), [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [SampleTypeEnum](CSSPEnums.SampleTypeEnum.html)</para>
    /// > <para>**Inherits [CSSPError](CSSPModels.CSSPError.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class LabSheetA1Measurement : CSSPError
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Site")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Site")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Site MWQM")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Site MWQM (fr)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Site
        /// 
        /// **Display (fr)** --- Site
        /// 
        /// **Description (en)** --- Site MWQM
        /// 
        /// **Description (fr)** --- Site MWQM (fr)
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Site")]
        [CSSPDisplayFR(DisplayFR = "Site")]
        [CSSPDescriptionEN(DescriptionEN = @"Site MWQM")]
        [CSSPDescriptionFR(DescriptionFR = @"Site MWQM (fr)")]
        public string Site { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TVItemID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the TVItems table with the unique identifier")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table TVItems avec l'identifiant unique")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TVItemID
        /// 
        /// **Display (fr)** --- TVItemID
        /// 
        /// **Description (en)** --- Link to the TVItems table with the unique identifier
        /// 
        /// **Description (fr)** --- Lien à la table TVItems avec l'identifiant unique
        /// </returns>
        [Range(1, -1)]
        [CSSPDisplayEN(DisplayEN = "TVItemID")]
        [CSSPDisplayFR(DisplayFR = "TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table with the unique identifier")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems avec l'identifiant unique")]
        public int TVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Time")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Temps")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Time")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Temps")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Time
        /// 
        /// **Display (fr)** --- Temps
        /// 
        /// **Description (en)** --- Time
        /// 
        /// **Description (fr)** --- Temps
        /// </returns>
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Time")]
        [CSSPDisplayFR(DisplayFR = "Temps")]
        [CSSPDescriptionEN(DescriptionEN = @"Time")]
        [CSSPDescriptionFR(DescriptionFR = @"Temps")]
        public DateTime? Time { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MPN (/100 mL)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "NPP (/100 mL)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Most probable number of fecal coliform colonies per 100 mL")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nombre le plus probable de colonies de coliform fécaux par 100 mL")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
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
        [CSSPAllowNull]
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
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
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
        [CSSPAllowNull]
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
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
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
        [CSSPAllowNull]
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
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
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
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Tube .1")]
        [CSSPDisplayFR(DisplayFR = "Tube .1")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of positive tube for Tube .1")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre de tube positif pour Tube .1")]
        public int? Tube0_1 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Salinity (PSU)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Salinité (PSU)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Salinity (PSU)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Salinité (PSU)")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Salinity (PSU)
        /// 
        /// **Display (fr)** --- Salinité (PSU)
        /// 
        /// **Description (en)** --- Salinity (PSU)
        /// 
        /// **Description (fr)** --- Salinité (PSU)
        /// </returns>
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Salinity (PSU)")]
        [CSSPDisplayFR(DisplayFR = "Salinité (PSU)")]
        [CSSPDescriptionEN(DescriptionEN = @"Salinity (PSU)")]
        [CSSPDescriptionFR(DescriptionFR = @"Salinité (PSU)")]
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
        [CSSPDisplayEN(DisplayEN = "Temperature (°C)")]
        [CSSPDisplayFR(DisplayFR = "Température (°C)")]
        [CSSPDescriptionEN(DescriptionEN = @"Temperature in degree Celcius")]
        [CSSPDescriptionFR(DescriptionFR = @"Température en dégré Celcius")]
        public double Temperature { get; set; }
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
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
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
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Sample type")]
        [CSSPDisplayFR(DisplayFR = "Type d'échantillon")]
        [CSSPDescriptionEN(DescriptionEN = @"Sample type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'échantillon")]
        public SampleTypeEnum? SampleType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Site comment")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Commentaire relatif au site")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Site comment")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Commentaire relatif au site")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Site comment
        /// 
        /// **Display (fr)** --- Commentaire relatif au site
        /// 
        /// **Description (en)** --- Site comment
        /// 
        /// **Description (fr)** --- Commentaire relatif au site
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Site comment")]
        [CSSPDisplayFR(DisplayFR = "Commentaire relatif au site")]
        [CSSPDescriptionEN(DescriptionEN = @"Site comment")]
        [CSSPDescriptionFR(DescriptionFR = @"Commentaire relatif au site")]
        public string SiteComment { get; set; }
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
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Sample type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type d'échantillon")]
        [CSSPDescriptionEN(DescriptionEN = @"Sample type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type d'échantillon")]
        public string SampleTypeText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LabSheetA1Measurement() : base()
        {
        }
        #endregion Constructors
    }
}
