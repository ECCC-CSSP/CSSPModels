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
    /// > <para>**DB properties for table TVItemLinks** : [TVItemLinkID](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_TVItemLinkID), [FromTVItemID](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_FromTVItemID), [ToTVItemID](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_ToTVItemID), [FromTVType](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_FromTVType), [ToTVType](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_ToTVType), [StartDateTime_Local](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_StartDateTime_Local), [EndDateTime_Local](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_EndDateTime_Local), [Ordinal](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_Ordinal), [TVLevel](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_TVLevel), [TVPath](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_TVPath), [ParentTVItemLinkID](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_ParentTVItemLinkID), [LastUpdate.LastUpdateDate_UTC](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateDate_UTC), [LastUpdate.LastUpdateContactTVItemID](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateContactTVItemID)</para>
    /// > <para>**Other properties** : [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TVItemLinkService](CSSPServices.TVItemLinkService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [TVItemLinkController](CSSPWebAPI.Controllers.TVItemLinkController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [TVTypeEnum](CSSPEnums.TVTypeEnum.html), [TVTypeEnum](CSSPEnums.TVTypeEnum.html)</para>
    /// > <para>**Inherits [LastUpdate](CSSPModels.LastUpdate.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class TVItemLink : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TVItemLink ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemLink ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the TVItemLinks table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table TVItemLinks")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TVItemLink ID
        /// 
        /// **Display (fr)** --- TVItemLink ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the TVItemLinks table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table TVItemLinks
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "TVItemLink ID")]
        [CSSPDisplayFR(DisplayFR = "TVItemLink ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TVItemLinks table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table TVItemLinks")]
        public int TVItemLinkID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>1 == Root, 2 == Address, 3 == Area, 4 == ClimateSite, 5 == Contact, 6 == Country, 7 == Email, 8 == File, 9 == HydrometricSite, 10 == Infrastructure, 13 == MikeScenario, 14 == MikeSource, 15 == Municipality, 16 == MWQMSite, 17 == PolSourceSite, 18 == Province, 19 == Sector, 20 == Subsector, 21 == Tel, 22 == TideSite, 24 == WasteWaterTreatmentPlant, 25 == LiftStation, 26 == Spill, 27 == BoxModel, 28 == VisualPlumesScenario, 30 == OtherInfrastructure, 31 == MWQMRun, 38 == MeshNode, 39 == WebTideNode, 40 == SamplingPlan, 41 == SeeOther, 42 == LineOverflow, 52 == MapInfo, 53 == MapInfoPoint</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "From TVItemID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Départ TVItemID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the TVItems table representing the from")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table TVItems représentant le départ")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- From TVItemID
        /// 
        /// **Display (fr)** --- Départ TVItemID
        /// 
        /// **Description (en)** --- Link to the TVItems table representing the from
        /// 
        /// **Description (fr)** --- Lien à la table TVItems représentant le départ
        /// </returns>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
        [CSSPDisplayEN(DisplayEN = "From TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Départ TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the from")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le départ")]
        public int FromTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>1 == Root, 2 == Address, 3 == Area, 4 == ClimateSite, 5 == Contact, 6 == Country, 7 == Email, 8 == File, 9 == HydrometricSite, 10 == Infrastructure, 13 == MikeScenario, 14 == MikeSource, 15 == Municipality, 16 == MWQMSite, 17 == PolSourceSite, 18 == Province, 19 == Sector, 20 == Subsector, 21 == Tel, 22 == TideSite, 24 == WasteWaterTreatmentPlant, 25 == LiftStation, 26 == Spill, 27 == BoxModel, 28 == VisualPlumesScenario, 30 == OtherInfrastructure, 31 == MWQMRun, 38 == MeshNode, 39 == WebTideNode, 40 == SamplingPlan, 41 == SeeOther, 42 == LineOverflow, 52 == MapInfo, 53 == MapInfoPoint</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "To TVItemID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Fin TVItemID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the TVItems table representing the to")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table TVItems représentant la fin")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- To TVItemID
        /// 
        /// **Display (fr)** --- Fin TVItemID
        /// 
        /// **Description (en)** --- Link to the TVItems table representing the to
        /// 
        /// **Description (fr)** --- Lien à la table TVItems représentant la fin
        /// </returns>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
        [CSSPDisplayEN(DisplayEN = "To TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Fin TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the to")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant la fin")]
        public int ToTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "From tv type")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Type d'arbre visuel du départ")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "From tree view type")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Type d'arbre visuel du départ")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- From tv type
        /// 
        /// **Display (fr)** --- Type d'arbre visuel du départ
        /// 
        /// **Description (en)** --- From tree view type
        /// 
        /// **Description (fr)** --- Type d'arbre visuel du départ
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "From tv type")]
        [CSSPDisplayFR(DisplayFR = "Type d'arbre visuel du départ")]
        [CSSPDescriptionEN(DescriptionEN = @"From tree view type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'arbre visuel du départ")]
        public TVTypeEnum FromTVType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "To tv type")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Type d'arbre visuel de la fin")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "To tree view type")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Type d'arbre visuel de la fin")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- To tv type
        /// 
        /// **Display (fr)** --- Type d'arbre visuel de la fin
        /// 
        /// **Description (en)** --- To tree view type
        /// 
        /// **Description (fr)** --- Type d'arbre visuel de la fin
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "To tv type")]
        [CSSPDisplayFR(DisplayFR = "Type d'arbre visuel de la fin")]
        [CSSPDescriptionEN(DescriptionEN = @"To tree view type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'arbre visuel de la fin")]
        public TVTypeEnum ToTVType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Start date")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Date de départ")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Start date")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Date de départ")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Start date
        /// 
        /// **Display (fr)** --- Date de départ
        /// 
        /// **Description (en)** --- Start date
        /// 
        /// **Description (fr)** --- Date de départ
        /// </returns>
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Start date")]
        [CSSPDisplayFR(DisplayFR = "Date de départ")]
        [CSSPDescriptionEN(DescriptionEN = @"Start date")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de départ")]
        public DateTime? StartDateTime_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// > <para>[[CSSPBigger](CSSPModels.CSSPBiggerAttribute.html)(OtherField = "StartDateTime_Local")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "End date")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Date de fin")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "End date")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Date de fin")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- End date
        /// 
        /// **Display (fr)** --- Date de fin
        /// 
        /// **Description (en)** --- End date
        /// 
        /// **Description (fr)** --- Date de fin
        /// </returns>
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDateTime_Local")]
        [CSSPDisplayEN(DisplayEN = "End date")]
        [CSSPDisplayFR(DisplayFR = "Date de fin")]
        [CSSPDescriptionEN(DescriptionEN = @"End date")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de fin")]
        public DateTime? EndDateTime_Local { get; set; }
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
        [Range(0, 100)]
        [CSSPDisplayEN(DisplayEN = "Ordinal")]
        [CSSPDisplayFR(DisplayFR = "Ordre")]
        [CSSPDescriptionEN(DescriptionEN = @"Ordinal")]
        [CSSPDescriptionFR(DescriptionFR = @"Ordre")]
        public int Ordinal { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TV level")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Niveau de l'arbre visuel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view level")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Niveau de l'arbre visuel")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TV level
        /// 
        /// **Display (fr)** --- Niveau de l'arbre visuel
        /// 
        /// **Description (en)** --- Tree view level
        /// 
        /// **Description (fr)** --- Niveau de l'arbre visuel
        /// </returns>
        [Range(0, 100)]
        [CSSPDisplayEN(DisplayEN = "TV level")]
        [CSSPDisplayFR(DisplayFR = "Niveau de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view level")]
        [CSSPDescriptionFR(DescriptionFR = @"Niveau de l'arbre visuel")]
        public int TVLevel { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TV path")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Chemin de l'arbre visuel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view path")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Chemin de l'arbre visuel")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TV path
        /// 
        /// **Display (fr)** --- Chemin de l'arbre visuel
        /// 
        /// **Description (en)** --- Tree view path
        /// 
        /// **Description (fr)** --- Chemin de l'arbre visuel
        /// </returns>
        [StringLength(250)]
        [CSSPDisplayEN(DisplayEN = "TV path")]
        [CSSPDisplayFR(DisplayFR = "Chemin de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view path")]
        [CSSPDescriptionFR(DescriptionFR = @"Chemin de l'arbre visuel")]
        public string TVPath { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItemLink", ExistPlurial = "s", ExistFieldID = "TVItemLinkID")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Parent TV item link")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Lien du parent de l'arbre visuel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Parent tree view item link")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien du parent de l'arbre visuel")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Parent TV item link
        /// 
        /// **Display (fr)** --- Lien du parent de l'arbre visuel
        /// 
        /// **Description (en)** --- Parent tree view item link
        /// 
        /// **Description (fr)** --- Lien du parent de l'arbre visuel
        /// </returns>
        [CSSPExist(ExistTypeName = "TVItemLink", ExistPlurial = "s", ExistFieldID = "TVItemLinkID")]
        [CSSPDisplayEN(DisplayEN = "Parent TV item link")]
        [CSSPDisplayFR(DisplayFR = "Lien du parent de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Parent tree view item link")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien du parent de l'arbre visuel")]
        public int? ParentTVItemLinkID { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TVItemLink() : base()
        {
        }
        #endregion Constructors
    }
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [FromText](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_FromText), [ToText](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_ToText), [LastUpdateContactText](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_LastUpdateContactText), [FromTVTypeText](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_FromTVTypeText), [ToTVTypeText](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_ToTVTypeText)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TVItemLinkService](CSSPServices.TVItemLinkService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [TVItemLinkController](CSSPWebAPI.Controllers.TVItemLinkController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [TVTypeEnum](CSSPEnums.TVTypeEnum.html), [TVTypeEnum](CSSPEnums.TVTypeEnum.html)</para>
    /// > <para>**Inherits [TVItemLink](CSSPModels.TVItemLink.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class TVItemLinkExtraA : TVItemLink
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "FromTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "From tv item text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte de l'item de départ de l'arbre visuel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "From tree view item text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte de l'item de départ de l'arbre visuel")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- From tv item text
        /// 
        /// **Display (fr)** --- Texte de l'item de départ de l'arbre visuel
        /// 
        /// **Description (en)** --- From tree view item text
        /// 
        /// **Description (fr)** --- Texte de l'item de départ de l'arbre visuel
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "FromTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "From tv item text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'item de départ de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"From tree view item text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de l'item de départ de l'arbre visuel")]
        public string FromText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ToTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "To tv item text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte de l'item de fin de l'arbre visuel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "To tree view item text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte de l'item de fin de l'arbre visuel")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- To tv item text
        /// 
        /// **Display (fr)** --- Texte de l'item de fin de l'arbre visuel
        /// 
        /// **Description (en)** --- To tree view item text
        /// 
        /// **Description (fr)** --- Texte de l'item de fin de l'arbre visuel
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ToTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "To tv item text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'item de fin de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"To tree view item text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de l'item de fin de l'arbre visuel")]
        public string ToText { get; set; }
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TVTypeEnum", EnumType = "FromTVType")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "From tv type TVItemLanguage")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemLanguage du type d'arbre visuel de départ")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "From tree view type TVItemLanguage DB object")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Object BD TVItemLanguage du type d'arbre visuel de départ")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- From tv type TVItemLanguage
        /// 
        /// **Display (fr)** --- TVItemLanguage du type d'arbre visuel de départ
        /// 
        /// **Description (en)** --- From tree view type TVItemLanguage DB object
        /// 
        /// **Description (fr)** --- Object BD TVItemLanguage du type d'arbre visuel de départ
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "FromTVType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "From tv type TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du type d'arbre visuel de départ")]
        [CSSPDescriptionEN(DescriptionEN = @"From tree view type TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du type d'arbre visuel de départ")]
        public string FromTVTypeText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TVTypeEnum", EnumType = "ToTVType")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "To tv type TVItemLanguage")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemLanguage du type d'arbre visuel de fin")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "To tree view type TVItemLanguage DB object")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Object BD TVItemLanguage du type d'arbre visuel de fin")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- To tv type TVItemLanguage
        /// 
        /// **Display (fr)** --- TVItemLanguage du type d'arbre visuel de fin
        /// 
        /// **Description (en)** --- To tree view type TVItemLanguage DB object
        /// 
        /// **Description (fr)** --- Object BD TVItemLanguage du type d'arbre visuel de fin
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "ToTVType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "To tv type TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du type d'arbre visuel de fin")]
        [CSSPDescriptionEN(DescriptionEN = @"To tree view type TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du type d'arbre visuel de fin")]
        public string ToTVTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemLinkExtraA() : base()
        {
        }
        #endregion Constructors
    }
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [TVItemLinkReportTest](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_TVItemLinkReportTest)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TVItemLinkService](CSSPServices.TVItemLinkService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [TVItemLinkController](CSSPWebAPI.Controllers.TVItemLinkController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [TVTypeEnum](CSSPEnums.TVTypeEnum.html), [TVTypeEnum](CSSPEnums.TVTypeEnum.html)</para>
    /// > <para>**Inherits [TVItemLinkExtraA](CSSPModels.TVItemLinkExtraA.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class TVItemLinkExtraB : TVItemLinkExtraA
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
        public string TVItemLinkReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemLinkExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
