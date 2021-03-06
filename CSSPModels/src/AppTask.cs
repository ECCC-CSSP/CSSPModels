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
    public partial class AppTask : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "AppTask ID")]
        [CSSPDisplayFR(DisplayFR = "AppTask ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the AppTasks table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table AppTasks")]
        public int AppTaskID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,6,8,9,11,12,14,15,16,17,18,19,20,22,24,25,26,29,30,41,42")]
        [CSSPDisplayEN(DisplayEN = "TVItemID")]
        [CSSPDisplayFR(DisplayFR = "TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table with the unique identifier")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems avec l'identifiant unique")]
        public int TVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,6,8,9,11,12,14,15,16,17,18,19,20,22,24,25,26,29,30,41,42")]
        [CSSPDisplayEN(DisplayEN = "TVItemID2")]
        [CSSPDisplayFR(DisplayFR = "TVItemID2")]
        [CSSPDescriptionEN(DescriptionEN = @"Link #2 to the TVItems table with the unique identifier")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien #2 à la table TVItems avec l'identifiant unique")]
        public int TVItemID2 { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Command")]
        [CSSPDisplayFR(DisplayFR = "Commande")]
        [CSSPDescriptionEN(DescriptionEN = @"App task command")]
        [CSSPDescriptionFR(DescriptionFR = @"Commande de tâche App")]
        public AppTaskCommandEnum AppTaskCommand { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "App task status")]
        [CSSPDisplayFR(DisplayFR = "Statut de la tâche App")]
        [CSSPDescriptionEN(DescriptionEN = @"App task status")]
        [CSSPDescriptionFR(DescriptionFR = @"Statut de la tâche App")]
        public AppTaskStatusEnum AppTaskStatus { get; set; }
        [Range(0, 100)]
        [CSSPDisplayEN(DisplayEN = "Percent completed")]
        [CSSPDisplayFR(DisplayFR = "Pourcentage complété")]
        [CSSPDescriptionEN(DescriptionEN = @"App task percent completed")]
        [CSSPDescriptionFR(DescriptionFR = @"Pourcentage complété de la tâche App")]
        public int PercentCompleted { get; set; }
        [CSSPDisplayEN(DisplayEN = "Parameters")]
        [CSSPDisplayFR(DisplayFR = "Paramètres")]
        [CSSPDescriptionEN(DescriptionEN = @"App task parameters")]
        [CSSPDescriptionFR(DescriptionFR = @"Paramètres de la tâche App")]
        public string Parameters { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"App task Language")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage de la tâche App")]
        public LanguageEnum Language { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Start date and time")]
        [CSSPDisplayFR(DisplayFR = "Date et temps de départ")]
        [CSSPDescriptionEN(DescriptionEN = @"App task start date and time")]
        [CSSPDescriptionFR(DescriptionFR = @"Date et temps de départ de la tâche App")]
        public DateTime StartDateTime_UTC { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDateTime_UTC")]
        [CSSPDisplayEN(DisplayEN = "End date and time")]
        [CSSPDisplayFR(DisplayFR = "Date et temps de fin")]
        [CSSPDescriptionEN(DescriptionEN = @"App task end date and time")]
        [CSSPDescriptionFR(DescriptionFR = @"Date et temps de fin de la tâche App")]
        public DateTime? EndDateTime_UTC { get; set; }
        [Range(0, 1000000)]
        [CSSPDisplayEN(DisplayEN = "Estimated time")]
        [CSSPDisplayFR(DisplayFR = "Temps estimé")]
        [CSSPDescriptionEN(DescriptionEN = @"App task estimated time (secondes)")]
        [CSSPDescriptionFR(DescriptionFR = @"Temps estimé de la tâche App (secondes)")]
        public int? EstimatedLength_second { get; set; }
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
    [NotMapped]
    public partial class AppTaskExtraA : AppTask
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Item TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage item")]
        [CSSPDescriptionEN(DescriptionEN = @"Item TVItemLanguage")]
        [CSSPDescriptionFR(DescriptionFR = @"TVItemLanguage de l'item")]
        public string TVItemText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID2", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Item2 TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage item2")]
        [CSSPDescriptionEN(DescriptionEN = @"Item TVItemLanguage")]
        [CSSPDescriptionFR(DescriptionFR = @"TVItemLanguage de l'item")]
        public string TVItem2Text { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "AppTaskCommandEnum", EnumType = "AppTaskCommand")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Command text")]
        [CSSPDisplayFR(DisplayFR = "Texte de la commande")]
        [CSSPDescriptionEN(DescriptionEN = @"Command text of the App task")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de la commande de la tâche App")]
        public string AppTaskCommandText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "AppTaskStatusEnum", EnumType = "AppTaskStatus")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Status text")]
        [CSSPDisplayFR(DisplayFR = "Texte du statut")]
        [CSSPDescriptionEN(DescriptionEN = @"Status text of the App task")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du statut de la commande de la tâche App")]
        public string AppTaskStatusText { get; set; }
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
    [NotMapped]
    public partial class AppTaskExtraB : AppTaskExtraA
    {
        #region Properties
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
