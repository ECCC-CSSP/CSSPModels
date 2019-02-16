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
    /// > <para>**DB properties for table AppTasks** : [AppTaskID](CSSPModels.AppTask.html#CSSPModels_AppTask_AppTaskID), [TVItemID](CSSPModels.AppTask.html#CSSPModels_AppTask_TVItemID), [TVItemID2](CSSPModels.AppTask.html#CSSPModels_AppTask_TVItemID2), [AppTaskCommand](CSSPModels.AppTask.html#CSSPModels_AppTask_AppTaskCommand), [AppTaskStatus](CSSPModels.AppTask.html#CSSPModels_AppTask_AppTaskStatus), [PercentCompleted](CSSPModels.AppTask.html#CSSPModels_AppTask_PercentCompleted), [Parameters](CSSPModels.AppTask.html#CSSPModels_AppTask_Parameters), [Language](CSSPModels.AppTask.html#CSSPModels_AppTask_Language), [StartDateTime_UTC](CSSPModels.AppTask.html#CSSPModels_AppTask_StartDateTime_UTC), [EndDateTime_UTC](CSSPModels.AppTask.html#CSSPModels_AppTask_EndDateTime_UTC), [EstimatedLength_second](CSSPModels.AppTask.html#CSSPModels_AppTask_EstimatedLength_second), [RemainingTime_second](CSSPModels.AppTask.html#CSSPModels_AppTask_RemainingTime_second), [LastUpdate.LastUpdateDate_UTC](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateDate_UTC), [LastUpdate.LastUpdateContactTVItemID](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateContactTVItemID)</para>
    /// > <para>**Other properties** : [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [AppTaskService](CSSPServices.AppTaskService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [AppTaskController](CSSPWebAPI.Controllers.AppTaskController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [AppTaskCommandEnum](CSSPEnums.AppTaskCommandEnum.html), [AppTaskStatusEnum](CSSPEnums.AppTaskStatusEnum.html), [LanguageEnum](CSSPEnums.LanguageEnum.html)</para>
    /// > <para>**Inherits [LastUpdate](CSSPModels.LastUpdate.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class AppTask : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "AppTask ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "AppTask ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the AppTasks table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table AppTasks")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- AppTask ID
        /// 
        /// **Display (fr)** --- AppTask ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the AppTasks table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table AppTasks
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "AppTask ID")]
        [CSSPDisplayFR(DisplayFR = "AppTask ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the AppTasks table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table AppTasks")]
        public int AppTaskID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>1 == Root, 2 == Address, 3 == Area, 4 == ClimateSite, 6 == Country, 8 == File, 9 == HydrometricSite, 11 == MikeBoundaryConditionWebTide, 12 == MikeBoundaryConditionMesh, 14 == MikeSource, 15 == Municipality, 16 == MWQMSite, 17 == PolSourceSite, 18 == Province, 19 == Sector, 20 == Subsector, 22 == TideSite, 24 == WasteWaterTreatmentPlant, 25 == LiftStation, 26 == Spill, 29 == Outfall, 30 == OtherInfrastructure, 41 == SeeOtherMunicipality, 42 == LineOverflow</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,6,8,9,11,12,14,15,16,17,18,19,20,22,24,25,26,29,30,41,42")]</para>
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
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,6,8,9,11,12,14,15,16,17,18,19,20,22,24,25,26,29,30,41,42")]
        [CSSPDisplayEN(DisplayEN = "TVItemID")]
        [CSSPDisplayFR(DisplayFR = "TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table with the unique identifier")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems avec l'identifiant unique")]
        public int TVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>1 == Root, 2 == Address, 3 == Area, 4 == ClimateSite, 6 == Country, 8 == File, 9 == HydrometricSite, 11 == MikeBoundaryConditionWebTide, 12 == MikeBoundaryConditionMesh, 14 == MikeSource, 15 == Municipality, 16 == MWQMSite, 17 == PolSourceSite, 18 == Province, 19 == Sector, 20 == Subsector, 22 == TideSite, 24 == WasteWaterTreatmentPlant, 25 == LiftStation, 26 == Spill, 29 == Outfall, 30 == OtherInfrastructure, 41 == SeeOtherMunicipality, 42 == LineOverflow</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,6,8,9,11,12,14,15,16,17,18,19,20,22,24,25,26,29,30,41,42")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TVItemID2")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemID2")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link #2 to the TVItems table with the unique identifier")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien #2 à la table TVItems avec l'identifiant unique")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TVItemID2
        /// 
        /// **Display (fr)** --- TVItemID2
        /// 
        /// **Description (en)** --- Link #2 to the TVItems table with the unique identifier
        /// 
        /// **Description (fr)** --- Lien #2 à la table TVItems avec l'identifiant unique
        /// </returns>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,6,8,9,11,12,14,15,16,17,18,19,20,22,24,25,26,29,30,41,42")]
        [CSSPDisplayEN(DisplayEN = "TVItemID2")]
        [CSSPDisplayFR(DisplayFR = "TVItemID2")]
        [CSSPDescriptionEN(DescriptionEN = @"Link #2 to the TVItems table with the unique identifier")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien #2 à la table TVItems avec l'identifiant unique")]
        public int TVItemID2 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Command")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Commande")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "App task command")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Commande de tâche App")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Command
        /// 
        /// **Display (fr)** --- Commande
        /// 
        /// **Description (en)** --- App task command
        /// 
        /// **Description (fr)** --- Commande de tâche App
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Command")]
        [CSSPDisplayFR(DisplayFR = "Commande")]
        [CSSPDescriptionEN(DescriptionEN = @"App task command")]
        [CSSPDescriptionFR(DescriptionFR = @"Commande de tâche App")]
        public AppTaskCommandEnum AppTaskCommand { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "App task status")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Statut de la tâche App")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "App task status")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Statut de la tâche App")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- App task status
        /// 
        /// **Display (fr)** --- Statut de la tâche App
        /// 
        /// **Description (en)** --- App task status
        /// 
        /// **Description (fr)** --- Statut de la tâche App
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "App task status")]
        [CSSPDisplayFR(DisplayFR = "Statut de la tâche App")]
        [CSSPDescriptionEN(DescriptionEN = @"App task status")]
        [CSSPDescriptionFR(DescriptionFR = @"Statut de la tâche App")]
        public AppTaskStatusEnum AppTaskStatus { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Percent completed")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Pourcentage complété")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "App task percent completed")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Pourcentage complété de la tâche App")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Percent completed
        /// 
        /// **Display (fr)** --- Pourcentage complété
        /// 
        /// **Description (en)** --- App task percent completed
        /// 
        /// **Description (fr)** --- Pourcentage complété de la tâche App
        /// </returns>
        [Range(0, 100)]
        [CSSPDisplayEN(DisplayEN = "Percent completed")]
        [CSSPDisplayFR(DisplayFR = "Pourcentage complété")]
        [CSSPDescriptionEN(DescriptionEN = @"App task percent completed")]
        [CSSPDescriptionFR(DescriptionFR = @"Pourcentage complété de la tâche App")]
        public int PercentCompleted { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Parameters")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Paramètres")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "App task parameters")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Paramètres de la tâche App")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Parameters
        /// 
        /// **Display (fr)** --- Paramètres
        /// 
        /// **Description (en)** --- App task parameters
        /// 
        /// **Description (fr)** --- Paramètres de la tâche App
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Parameters")]
        [CSSPDisplayFR(DisplayFR = "Paramètres")]
        [CSSPDescriptionEN(DescriptionEN = @"App task parameters")]
        [CSSPDescriptionFR(DescriptionFR = @"Paramètres de la tâche App")]
        public string Parameters { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Language")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Langage")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "App task Language")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Langage de la tâche App")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Language
        /// 
        /// **Display (fr)** --- Langage
        /// 
        /// **Description (en)** --- App task Language
        /// 
        /// **Description (fr)** --- Langage de la tâche App
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"App task Language")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage de la tâche App")]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Start date and time")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Date et temps de départ")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "App task start date and time")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Date et temps de départ de la tâche App")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Start date and time
        /// 
        /// **Display (fr)** --- Date et temps de départ
        /// 
        /// **Description (en)** --- App task start date and time
        /// 
        /// **Description (fr)** --- Date et temps de départ de la tâche App
        /// </returns>
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Start date and time")]
        [CSSPDisplayFR(DisplayFR = "Date et temps de départ")]
        [CSSPDescriptionEN(DescriptionEN = @"App task start date and time")]
        [CSSPDescriptionFR(DescriptionFR = @"Date et temps de départ de la tâche App")]
        public DateTime StartDateTime_UTC { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// > <para>[[CSSPBigger](CSSPModels.CSSPBiggerAttribute.html)(OtherField = "StartDateTime_UTC")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "End date and time")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Date et temps de fin")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "App task end date and time")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Date et temps de fin de la tâche App")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- End date and time
        /// 
        /// **Display (fr)** --- Date et temps de fin
        /// 
        /// **Description (en)** --- App task end date and time
        /// 
        /// **Description (fr)** --- Date et temps de fin de la tâche App
        /// </returns>
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDateTime_UTC")]
        [CSSPDisplayEN(DisplayEN = "End date and time")]
        [CSSPDisplayFR(DisplayFR = "Date et temps de fin")]
        [CSSPDescriptionEN(DescriptionEN = @"App task end date and time")]
        [CSSPDescriptionFR(DescriptionFR = @"Date et temps de fin de la tâche App")]
        public DateTime? EndDateTime_UTC { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Estimated time")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Temps estimé")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "App task estimated time (secondes)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Temps estimé de la tâche App (secondes)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Estimated time
        /// 
        /// **Display (fr)** --- Temps estimé
        /// 
        /// **Description (en)** --- App task estimated time (secondes)
        /// 
        /// **Description (fr)** --- Temps estimé de la tâche App (secondes)
        /// </returns>
        [Range(0, 1000000)]
        [CSSPDisplayEN(DisplayEN = "Estimated time")]
        [CSSPDisplayFR(DisplayFR = "Temps estimé")]
        [CSSPDescriptionEN(DescriptionEN = @"App task estimated time (secondes)")]
        [CSSPDescriptionFR(DescriptionFR = @"Temps estimé de la tâche App (secondes)")]
        public int? EstimatedLength_second { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Time remaining")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Temps qui reste")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "App task time remaining (secondes)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Temps qui reste de la tâche App (secondes)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Time remaining
        /// 
        /// **Display (fr)** --- Temps qui reste
        /// 
        /// **Description (en)** --- App task time remaining (secondes)
        /// 
        /// **Description (fr)** --- Temps qui reste de la tâche App (secondes)
        /// </returns>
        [Range(0, 1000000)]
        [CSSPDisplayEN(DisplayEN = "Time remaining")]
        [CSSPDisplayFR(DisplayFR = "Temps qui reste")]
        [CSSPDescriptionEN(DescriptionEN = @"App task time remaining (secondes)")]
        [CSSPDescriptionFR(DescriptionFR = @"Temps qui reste de la tâche App (secondes)")]
        public int? RemainingTime_second { get; set; }
        #endregion Properties in DB

        #region Constructors
        public AppTask() : base()
        {
        }
        #endregion Constructors
    }
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [TVItemText](CSSPModels.AppTask.html#CSSPModels_AppTask_TVItemText), [TVItem2Text](CSSPModels.AppTask.html#CSSPModels_AppTask_TVItem2Text), [LastUpdateContactText](CSSPModels.AppTask.html#CSSPModels_AppTask_LastUpdateContactText), [AppTaskCommandText](CSSPModels.AppTask.html#CSSPModels_AppTask_AppTaskCommandText), [AppTaskStatusText](CSSPModels.AppTask.html#CSSPModels_AppTask_AppTaskStatusText), [LanguageText](CSSPModels.AppTask.html#CSSPModels_AppTask_LanguageText)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [AppTaskService](CSSPServices.AppTaskService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [AppTaskController](CSSPWebAPI.Controllers.AppTaskController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [AppTaskCommandEnum](CSSPEnums.AppTaskCommandEnum.html), [AppTaskStatusEnum](CSSPEnums.AppTaskStatusEnum.html), [LanguageEnum](CSSPEnums.LanguageEnum.html)</para>
    /// > <para>**Inherits [AppTask](CSSPModels.AppTask.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class AppTaskExtraA : AppTask
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Item TVItemLanguage")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemLanguage item")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Item TVItemLanguage")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "TVItemLanguage de l'item")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Item TVItemLanguage
        /// 
        /// **Display (fr)** --- TVItemLanguage item
        /// 
        /// **Description (en)** --- Item TVItemLanguage
        /// 
        /// **Description (fr)** --- TVItemLanguage de l'item
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Item TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage item")]
        [CSSPDescriptionEN(DescriptionEN = @"Item TVItemLanguage")]
        [CSSPDescriptionFR(DescriptionFR = @"TVItemLanguage de l'item")]
        public string TVItemText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID2", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Item2 TVItemLanguage")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemLanguage item2")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Item TVItemLanguage")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "TVItemLanguage de l'item")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Item2 TVItemLanguage
        /// 
        /// **Display (fr)** --- TVItemLanguage item2
        /// 
        /// **Description (en)** --- Item TVItemLanguage
        /// 
        /// **Description (fr)** --- TVItemLanguage de l'item
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID2", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Item2 TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage item2")]
        [CSSPDescriptionEN(DescriptionEN = @"Item TVItemLanguage")]
        [CSSPDescriptionFR(DescriptionFR = @"TVItemLanguage de l'item")]
        public string TVItem2Text { get; set; }
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "AppTaskCommandEnum", EnumType = "AppTaskCommand")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Command text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte de la commande")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Command text of the App task")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte de la commande de la tâche App")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Command text
        /// 
        /// **Display (fr)** --- Texte de la commande
        /// 
        /// **Description (en)** --- Command text of the App task
        /// 
        /// **Description (fr)** --- Texte de la commande de la tâche App
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "AppTaskCommandEnum", EnumType = "AppTaskCommand")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Command text")]
        [CSSPDisplayFR(DisplayFR = "Texte de la commande")]
        [CSSPDescriptionEN(DescriptionEN = @"Command text of the App task")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de la commande de la tâche App")]
        public string AppTaskCommandText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "AppTaskStatusEnum", EnumType = "AppTaskStatus")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Status text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte du statut")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Status text of the App task")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du statut de la commande de la tâche App")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Status text
        /// 
        /// **Display (fr)** --- Texte du statut
        /// 
        /// **Description (en)** --- Status text of the App task
        /// 
        /// **Description (fr)** --- Texte du statut de la commande de la tâche App
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "AppTaskStatusEnum", EnumType = "AppTaskStatus")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Status text")]
        [CSSPDisplayFR(DisplayFR = "Texte du statut")]
        [CSSPDescriptionEN(DescriptionEN = @"Status text of the App task")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du statut de la commande de la tâche App")]
        public string AppTaskStatusText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "LanguageEnum", EnumType = "Language")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Language")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Langage")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Language of the App task")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Langage de la commande de la tâche App")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Language
        /// 
        /// **Display (fr)** --- Langage
        /// 
        /// **Description (en)** --- Language of the App task
        /// 
        /// **Description (fr)** --- Langage de la commande de la tâche App
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language of the App task")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage de la commande de la tâche App")]
        public string LanguageText { get; set; }
        #endregion Properties

        #region Constructors
        public AppTaskExtraA() : base()
        {
        }
        #endregion Constructors
    }
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [AppTaskReportTest](CSSPModels.AppTask.html#CSSPModels_AppTask_AppTaskReportTest)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [AppTaskService](CSSPServices.AppTaskService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [AppTaskController](CSSPWebAPI.Controllers.AppTaskController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [AppTaskCommandEnum](CSSPEnums.AppTaskCommandEnum.html), [AppTaskStatusEnum](CSSPEnums.AppTaskStatusEnum.html), [LanguageEnum](CSSPEnums.LanguageEnum.html)</para>
    /// > <para>**Inherits [AppTaskExtraA](CSSPModels.AppTaskExtraA.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class AppTaskExtraB : AppTaskExtraA
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
        public string AppTaskReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public AppTaskExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
