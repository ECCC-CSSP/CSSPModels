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
    /// > <para>**DB properties for table PolSourceObservationIssues** : [PolSourceObservationIssueID](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_PolSourceObservationIssueID), [PolSourceObservationID](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_PolSourceObservationID), [ObservationInfo](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_ObservationInfo), [Ordinal](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_Ordinal), [ExtraComment](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_ExtraComment), [LastUpdate.LastUpdateDate_UTC](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateDate_UTC), [LastUpdate.LastUpdateContactTVItemID](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateContactTVItemID)</para>
    /// > <para>**Other properties** : [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [PolSourceObservationIssueService](CSSPServices.PolSourceObservationIssueService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [PolSourceObservationIssueController](CSSPWebAPI.Controllers.PolSourceObservationIssueController.html)</para>
    /// > <para>**Inherits [LastUpdate](CSSPModels.LastUpdate.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class PolSourceObservationIssue : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "PolSourceObservationIssue ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "PolSourceObservationIssue ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the PolSourceObservationIssues table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table PolSourceObservationIssues")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- PolSourceObservationIssue ID
        /// 
        /// **Display (fr)** --- PolSourceObservationIssue ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the PolSourceObservationIssues table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table PolSourceObservationIssues
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "PolSourceObservationIssue ID")]
        [CSSPDisplayFR(DisplayFR = "PolSourceObservationIssue ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the PolSourceObservationIssues table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table PolSourceObservationIssues")]
        public int PolSourceObservationIssueID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "PolSourceObservation", ExistPlurial = "s", ExistFieldID = "PolSourceObservationID")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Pollution source observation ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Observation de la source de pollution ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the PolSourceObservations table representing the pollution source observation")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table PolSourceObservations représentant l'observation de source de pollution")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Pollution source observation ID
        /// 
        /// **Display (fr)** --- Observation de la source de pollution ID
        /// 
        /// **Description (en)** --- Link to the PolSourceObservations table representing the pollution source observation
        /// 
        /// **Description (fr)** --- Lien à la table PolSourceObservations représentant l'observation de source de pollution
        /// </returns>
        [CSSPExist(ExistTypeName = "PolSourceObservation", ExistPlurial = "s", ExistFieldID = "PolSourceObservationID")]
        [CSSPDisplayEN(DisplayEN = "Pollution source observation ID")]
        [CSSPDisplayFR(DisplayFR = "Observation de la source de pollution ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the PolSourceObservations table representing the pollution source observation")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table PolSourceObservations représentant l'observation de source de pollution")]
        public int PolSourceObservationID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Observation information")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "L'information de l'observation")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Observation information is a series of numbers representing the path of a collection of descriptive text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "L'information de l'observation est une liste de chiffres représentant la ligne d'une collection de texte descriptif")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Observation information
        /// 
        /// **Display (fr)** --- L'information de l'observation
        /// 
        /// **Description (en)** --- Observation information is a series of numbers representing the path of a collection of descriptive text
        /// 
        /// **Description (fr)** --- L'information de l'observation est une liste de chiffres représentant la ligne d'une collection de texte descriptif
        /// </returns>
        [StringLength(250)]
        [CSSPDisplayEN(DisplayEN = "Observation information")]
        [CSSPDisplayFR(DisplayFR = "L'information de l'observation")]
        [CSSPDescriptionEN(DescriptionEN = @"Observation information is a series of numbers representing the path of a collection of descriptive text")]
        [CSSPDescriptionFR(DescriptionFR = @"L'information de l'observation est une liste de chiffres représentant la ligne d'une collection de texte descriptif")]
        public string ObservationInfo { get; set; }
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
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Extra comment")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Commentaire d'extra")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Extra comment")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Commentaire d'extra")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Extra comment
        /// 
        /// **Display (fr)** --- Commentaire d'extra
        /// 
        /// **Description (en)** --- Extra comment
        /// 
        /// **Description (fr)** --- Commentaire d'extra
        /// </returns>
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Extra comment")]
        [CSSPDisplayFR(DisplayFR = "Commentaire d'extra")]
        [CSSPDescriptionEN(DescriptionEN = @"Extra comment")]
        [CSSPDescriptionFR(DescriptionFR = @"Commentaire d'extra")]
        public string ExtraComment { get; set; }
        #endregion Properties in DB

        #region Constructors
        public PolSourceObservationIssue() : base()
        {
        }
        #endregion Constructors
    }
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [LastUpdateContactText](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_LastUpdateContactText)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [PolSourceObservationIssueService](CSSPServices.PolSourceObservationIssueService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [PolSourceObservationIssueController](CSSPWebAPI.Controllers.PolSourceObservationIssueController.html)</para>
    /// > <para>**Inherits [PolSourceObservationIssue](CSSPModels.PolSourceObservationIssue.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class PolSourceObservationIssueExtraA : PolSourceObservationIssue
    {
        #region Properties
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
        #endregion Properties

        #region Constructors
        public PolSourceObservationIssueExtraA() : base()
        {
        }
        #endregion Constructors
    }
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [PolSourceObservationIssueReportTest](CSSPModels.PolSourceObservationIssue.html#CSSPModels_PolSourceObservationIssue_PolSourceObservationIssueReportTest)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [PolSourceObservationIssueService](CSSPServices.PolSourceObservationIssueService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [PolSourceObservationIssueController](CSSPWebAPI.Controllers.PolSourceObservationIssueController.html)</para>
    /// > <para>**Inherits [PolSourceObservationIssueExtraA](CSSPModels.PolSourceObservationIssueExtraA.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class PolSourceObservationIssueExtraB : PolSourceObservationIssueExtraA
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
        public string PolSourceObservationIssueReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceObservationIssueExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
