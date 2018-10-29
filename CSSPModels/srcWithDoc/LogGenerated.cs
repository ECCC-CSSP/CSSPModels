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
    /// > <para>**DB properties for table Logs** : [LogID](CSSPModels.Log.html#CSSPModels_Log_LogID), [TableName](CSSPModels.Log.html#CSSPModels_Log_TableName), [ID](CSSPModels.Log.html#CSSPModels_Log_ID), [LogCommand](CSSPModels.Log.html#CSSPModels_Log_LogCommand), [Information](CSSPModels.Log.html#CSSPModels_Log_Information), [LastUpdateDate_UTC](CSSPModels.Log.html#CSSPModels_Log_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.Log.html#CSSPModels_Log_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.Log.html#CSSPModels_Log_HasErrors), [ValidationResults](CSSPModels.Log.html#CSSPModels_Log_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [LogService](CSSPServices.LogService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LogCommandEnum](CSSPEnums.LogCommandEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class Log : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Log ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Log ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the Logs table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table Logs")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Log ID
        /// 
        /// **Display (fr)** --- Log ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the Logs table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table Logs
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "Log ID")]
        [CSSPDisplayFR(DisplayFR = "Log ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the Logs table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table Logs")]
        public int LogID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Table name")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Nom de la table")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Table name")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nom de la table")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Table name
        /// 
        /// **Display (fr)** --- Nom de la table
        /// 
        /// **Description (en)** --- Table name
        /// 
        /// **Description (fr)** --- Nom de la table
        /// </returns>
        [StringLength(50)]
        [CSSPDisplayEN(DisplayEN = "Table name")]
        [CSSPDisplayFR(DisplayFR = "Nom de la table")]
        [CSSPDescriptionEN(DescriptionEN = @"Table name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom de la table")]
        public string TableName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Key of table")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Clef de la table")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Key of table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Clef de la table")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Key of table
        /// 
        /// **Display (fr)** --- Clef de la table
        /// 
        /// **Description (en)** --- Key of table
        /// 
        /// **Description (fr)** --- Clef de la table
        /// </returns>
        [Range(1, -1)]
        [CSSPDisplayEN(DisplayEN = "Key of table")]
        [CSSPDisplayFR(DisplayFR = "Clef de la table")]
        [CSSPDescriptionEN(DescriptionEN = @"Key of table")]
        [CSSPDescriptionFR(DescriptionFR = @"Clef de la table")]
        public int ID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Log command")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Command log")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Log command")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Command log")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Log command
        /// 
        /// **Display (fr)** --- Command log
        /// 
        /// **Description (en)** --- Log command
        /// 
        /// **Description (fr)** --- Command log
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Log command")]
        [CSSPDisplayFR(DisplayFR = "Command log")]
        [CSSPDescriptionEN(DescriptionEN = @"Log command")]
        [CSSPDescriptionFR(DescriptionFR = @"Command log")]
        public LogCommandEnum LogCommand { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Information")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Information")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Information describing the log command")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Information décrivant la command log")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Information
        /// 
        /// **Display (fr)** --- Information
        /// 
        /// **Description (en)** --- Information describing the log command
        /// 
        /// **Description (fr)** --- Information décrivant la command log
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Information")]
        [CSSPDisplayFR(DisplayFR = "Information")]
        [CSSPDescriptionEN(DescriptionEN = @"Information describing the log command")]
        [CSSPDescriptionFR(DescriptionFR = @"Information décrivant la command log")]
        public string Information { get; set; }
        #endregion Properties in DB

        #region Constructors
        public Log() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LogExtraA : Log
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
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "LogCommandEnum", EnumType = "LogCommand")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Log command text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte de la commande log")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Log command text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte de la commande log")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Log command text
        /// 
        /// **Display (fr)** --- Texte de la commande log
        /// 
        /// **Description (en)** --- Log command text
        /// 
        /// **Description (fr)** --- Texte de la commande log
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "LogCommandEnum", EnumType = "LogCommand")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Log command text")]
        [CSSPDisplayFR(DisplayFR = "Texte de la commande log")]
        [CSSPDescriptionEN(DescriptionEN = @"Log command text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de la commande log")]
        public string LogCommandText { get; set; }
        #endregion Properties

        #region Constructors
        public LogExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LogExtraB : LogExtraA
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
        public string LogReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public LogExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
