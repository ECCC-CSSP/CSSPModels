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
    /// > <para>**DB properties for table MikeBoundaryConditions** : [MikeBoundaryConditionID](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionID), [MikeBoundaryConditionTVItemID](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionTVItemID), [MikeBoundaryConditionCode](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionCode), [MikeBoundaryConditionName](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionName), [MikeBoundaryConditionLength_m](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionLength_m), [MikeBoundaryConditionFormat](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionFormat), [MikeBoundaryConditionLevelOrVelocity](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionLevelOrVelocity), [WebTideDataSet](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_WebTideDataSet), [NumberOfWebTideNodes](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_NumberOfWebTideNodes), [WebTideDataFromStartToEndDate](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_WebTideDataFromStartToEndDate), [TVType](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_TVType), [LastUpdateDate_UTC](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_HasErrors), [ValidationResults](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MikeBoundaryConditionService](CSSPServices.MikeBoundaryConditionService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [MikeBoundaryConditionLevelOrVelocityEnum](CSSPEnums.MikeBoundaryConditionLevelOrVelocityEnum.html), [WebTideDataSetEnum](CSSPEnums.WebTideDataSetEnum.html), [TVTypeEnum](CSSPEnums.TVTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class MikeBoundaryCondition : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MikeBoundaryCondition ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "MikeBoundaryCondition ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the MikeBoundaryConditions table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table MikeBoundaryConditions")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MikeBoundaryCondition ID
        /// 
        /// **Display (fr)** --- MikeBoundaryCondition ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the MikeBoundaryConditions table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table MikeBoundaryConditions
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "MikeBoundaryCondition ID")]
        [CSSPDisplayFR(DisplayFR = "MikeBoundaryCondition ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MikeBoundaryConditions table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MikeBoundaryConditions")]
        public int MikeBoundaryConditionID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>12 == MikeBoundaryConditionMesh, 11 == MikeBoundaryConditionWebTide</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "12,11")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MIKE boundary contidition TVItemID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemID de conditions limits MIKE")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the TVItems table representing the MIKE boundary condition")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table TVItems représentant les conditions limits MIKE")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MIKE boundary contidition TVItemID
        /// 
        /// **Display (fr)** --- TVItemID de conditions limits MIKE
        /// 
        /// **Description (en)** --- Link to the TVItems table representing the MIKE boundary condition
        /// 
        /// **Description (fr)** --- Lien à la table TVItems représentant les conditions limits MIKE
        /// </returns>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "12,11")]
        [CSSPDisplayEN(DisplayEN = "MIKE boundary contidition TVItemID")]
        [CSSPDisplayFR(DisplayFR = "TVItemID de conditions limits MIKE")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the MIKE boundary condition")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant les conditions limits MIKE")]
        public int MikeBoundaryConditionTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MIKE boundary contidition code")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Code de conditions limits MIKE")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "MIKE boundary contidition code")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Code de conditions limits MIKE")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MIKE boundary contidition code
        /// 
        /// **Display (fr)** --- Code de conditions limits MIKE
        /// 
        /// **Description (en)** --- MIKE boundary contidition code
        /// 
        /// **Description (fr)** --- Code de conditions limits MIKE
        /// </returns>
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "MIKE boundary contidition code")]
        [CSSPDisplayFR(DisplayFR = "Code de conditions limits MIKE")]
        [CSSPDescriptionEN(DescriptionEN = @"MIKE boundary contidition code")]
        [CSSPDescriptionFR(DescriptionFR = @"Code de conditions limits MIKE")]
        public string MikeBoundaryConditionCode { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MIKE boundary contidition name")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Nom de conditions limits MIKE")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "MIKE boundary contidition name")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nom de conditions limits MIKE")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MIKE boundary contidition name
        /// 
        /// **Display (fr)** --- Nom de conditions limits MIKE
        /// 
        /// **Description (en)** --- MIKE boundary contidition name
        /// 
        /// **Description (fr)** --- Nom de conditions limits MIKE
        /// </returns>
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "MIKE boundary contidition name")]
        [CSSPDisplayFR(DisplayFR = "Nom de conditions limits MIKE")]
        [CSSPDescriptionEN(DescriptionEN = @"MIKE boundary contidition name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom de conditions limits MIKE")]
        public string MikeBoundaryConditionName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MIKE boundary contidition length (m)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Longueur de conditions limits MIKE (m)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "MIKE boundary contidition length in meters")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Longueur de conditions limits MIKE en mètres")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MIKE boundary contidition length (m)
        /// 
        /// **Display (fr)** --- Longueur de conditions limits MIKE (m)
        /// 
        /// **Description (en)** --- MIKE boundary contidition length in meters
        /// 
        /// **Description (fr)** --- Longueur de conditions limits MIKE en mètres
        /// </returns>
        [Range(1.0D, 100000.0D)]
        [CSSPDisplayEN(DisplayEN = "MIKE boundary contidition length (m)")]
        [CSSPDisplayFR(DisplayFR = "Longueur de conditions limits MIKE (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"MIKE boundary contidition length in meters")]
        [CSSPDescriptionFR(DescriptionFR = @"Longueur de conditions limits MIKE en mètres")]
        public double MikeBoundaryConditionLength_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MIKE boundary contidition format")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Format de conditions limits MIKE")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "MIKE boundary contidition format")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Format de conditions limits MIKE")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MIKE boundary contidition format
        /// 
        /// **Display (fr)** --- Format de conditions limits MIKE
        /// 
        /// **Description (en)** --- MIKE boundary contidition format
        /// 
        /// **Description (fr)** --- Format de conditions limits MIKE
        /// </returns>
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "MIKE boundary contidition format")]
        [CSSPDisplayFR(DisplayFR = "Format de conditions limits MIKE")]
        [CSSPDescriptionEN(DescriptionEN = @"MIKE boundary contidition format")]
        [CSSPDescriptionFR(DescriptionFR = @"Format de conditions limits MIKE")]
        public string MikeBoundaryConditionFormat { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MIKE boundary contidition level of velocity")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Niveau ou vélocité de conditions limits MIKE")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "MIKE boundary contidition level or velocity")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Niveau ou vélocité de conditions limits MIKE")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MIKE boundary contidition level of velocity
        /// 
        /// **Display (fr)** --- Niveau ou vélocité de conditions limits MIKE
        /// 
        /// **Description (en)** --- MIKE boundary contidition level or velocity
        /// 
        /// **Description (fr)** --- Niveau ou vélocité de conditions limits MIKE
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "MIKE boundary contidition level of velocity")]
        [CSSPDisplayFR(DisplayFR = "Niveau ou vélocité de conditions limits MIKE")]
        [CSSPDescriptionEN(DescriptionEN = @"MIKE boundary contidition level or velocity")]
        [CSSPDescriptionFR(DescriptionFR = @"Niveau ou vélocité de conditions limits MIKE")]
        public MikeBoundaryConditionLevelOrVelocityEnum MikeBoundaryConditionLevelOrVelocity { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Web tide data set")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Donnée web tide")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Web tide data set")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Donnée web tide")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Web tide data set
        /// 
        /// **Display (fr)** --- Donnée web tide
        /// 
        /// **Description (en)** --- Web tide data set
        /// 
        /// **Description (fr)** --- Donnée web tide
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Web tide data set")]
        [CSSPDisplayFR(DisplayFR = "Donnée web tide")]
        [CSSPDescriptionEN(DescriptionEN = @"Web tide data set")]
        [CSSPDescriptionFR(DescriptionFR = @"Donnée web tide")]
        public WebTideDataSetEnum WebTideDataSet { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Number of web tide node")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Nombre de noeux de web tide")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Number of web tide node")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nombre de noeux de web tide")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Number of web tide node
        /// 
        /// **Display (fr)** --- Nombre de noeux de web tide
        /// 
        /// **Description (en)** --- Number of web tide node
        /// 
        /// **Description (fr)** --- Nombre de noeux de web tide
        /// </returns>
        [Range(0, 1000)]
        [CSSPDisplayEN(DisplayEN = "Number of web tide node")]
        [CSSPDisplayFR(DisplayFR = "Nombre de noeux de web tide")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of web tide node")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre de noeux de web tide")]
        public int NumberOfWebTideNodes { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Web tide data between dates")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Données web tide entre les dates")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Web tide data between dates")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Données web tide entre les dates")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Web tide data between dates
        /// 
        /// **Display (fr)** --- Données web tide entre les dates
        /// 
        /// **Description (en)** --- Web tide data between dates
        /// 
        /// **Description (fr)** --- Données web tide entre les dates
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Web tide data between dates")]
        [CSSPDisplayFR(DisplayFR = "Données web tide entre les dates")]
        [CSSPDescriptionEN(DescriptionEN = @"Web tide data between dates")]
        [CSSPDescriptionFR(DescriptionFR = @"Données web tide entre les dates")]
        public string WebTideDataFromStartToEndDate { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TV type")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Type d'arbre visuel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view type")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Type d'arbre visuel")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TV type
        /// 
        /// **Display (fr)** --- Type d'arbre visuel
        /// 
        /// **Description (en)** --- Tree view type
        /// 
        /// **Description (fr)** --- Type d'arbre visuel
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "TV type")]
        [CSSPDisplayFR(DisplayFR = "Type d'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'arbre visuel")]
        public TVTypeEnum TVType { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MikeBoundaryCondition() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeBoundaryCondition_A : MikeBoundaryCondition
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MikeBoundaryConditionTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MikeBoundaryConditionTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage MikeBoundaryConditionTVItemLanguage { get; set; }
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
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "MikeBoundaryConditionLevelOrVelocityEnum", EnumType = "MikeBoundaryConditionLevelOrVelocity")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MIKE boundary condition level or velocity text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte de niveau ou vélocité de conditions limits MIKE")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "MIKE boundary condition level or velocity text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte de niveau ou vélocité de conditions limits MIKE")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MIKE boundary condition level or velocity text
        /// 
        /// **Display (fr)** --- Texte de niveau ou vélocité de conditions limits MIKE
        /// 
        /// **Description (en)** --- MIKE boundary condition level or velocity text
        /// 
        /// **Description (fr)** --- Texte de niveau ou vélocité de conditions limits MIKE
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "MikeBoundaryConditionLevelOrVelocityEnum", EnumType = "MikeBoundaryConditionLevelOrVelocity")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "MIKE boundary condition level or velocity text")]
        [CSSPDisplayFR(DisplayFR = "Texte de niveau ou vélocité de conditions limits MIKE")]
        [CSSPDescriptionEN(DescriptionEN = @"MIKE boundary condition level or velocity text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de niveau ou vélocité de conditions limits MIKE")]
        public string MikeBoundaryConditionLevelOrVelocityText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "WebTideDataSetEnum", EnumType = "WebTideDataSet")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Web tide dataset text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte de données web tide")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Web tide dataset text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte de données web tide")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Web tide dataset text
        /// 
        /// **Display (fr)** --- Texte de données web tide
        /// 
        /// **Description (en)** --- Web tide dataset text
        /// 
        /// **Description (fr)** --- Texte de données web tide
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "WebTideDataSetEnum", EnumType = "WebTideDataSet")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Web tide dataset text")]
        [CSSPDisplayFR(DisplayFR = "Texte de données web tide")]
        [CSSPDescriptionEN(DescriptionEN = @"Web tide dataset text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de données web tide")]
        public string WebTideDataSetText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Tree view type text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte de l'arbre visuel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view type text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte de l'arbre visuel")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Tree view type text
        /// 
        /// **Display (fr)** --- Texte de l'arbre visuel
        /// 
        /// **Description (en)** --- Tree view type text
        /// 
        /// **Description (fr)** --- Texte de l'arbre visuel
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Tree view type text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de l'arbre visuel")]
        public string TVTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public MikeBoundaryCondition_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeBoundaryCondition_B : MikeBoundaryCondition_A
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
        public string MikeBoundaryConditionReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MikeBoundaryCondition_B() : base()
        {
        }
        #endregion Constructors
    }
}
