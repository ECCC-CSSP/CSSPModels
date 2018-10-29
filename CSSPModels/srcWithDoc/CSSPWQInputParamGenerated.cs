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
    /// > <para>**Other properties** : [CSSPWQInputType](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_CSSPWQInputType), [Name](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_Name), [TVItemID](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_TVItemID), [CSSPWQInputTypeText](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_CSSPWQInputTypeText), [sidList](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_sidList), [MWQMSiteList](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_MWQMSiteList), [MWQMSiteTVItemIDList](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_MWQMSiteTVItemIDList), [DailyDuplicateMWQMSiteList](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_DailyDuplicateMWQMSiteList), [DailyDuplicateMWQMSiteTVItemIDList](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_DailyDuplicateMWQMSiteTVItemIDList), [InfrastructureList](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_InfrastructureList), [InfrastructureTVItemIDList](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_InfrastructureTVItemIDList), [HasErrors](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_HasErrors), [ValidationResults](CSSPModels.CSSPWQInputParam.html#CSSPModels_CSSPWQInputParam_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [CSSPWQInputParamService](CSSPServices.CSSPWQInputParamService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [CSSPWQInputTypeEnum](CSSPEnums.CSSPWQInputTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class CSSPWQInputParam : CSSPError
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "CSSP WQ input type")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Type d'input de qualité d'eau CSSP")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "CSSP water quality input type")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Type d'input de qualité d'eau CSSP")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- CSSP WQ input type
        /// 
        /// **Display (fr)** --- Type d'input de qualité d'eau CSSP
        /// 
        /// **Description (en)** --- CSSP water quality input type
        /// 
        /// **Description (fr)** --- Type d'input de qualité d'eau CSSP
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "CSSP WQ input type")]
        [CSSPDisplayFR(DisplayFR = "Type d'input de qualité d'eau CSSP")]
        [CSSPDescriptionEN(DescriptionEN = @"CSSP water quality input type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'input de qualité d'eau CSSP")]
        public CSSPWQInputTypeEnum CSSPWQInputType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Name")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Nom")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Name")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nom")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Name
        /// 
        /// **Display (fr)** --- Nom
        /// 
        /// **Description (en)** --- Name
        /// 
        /// **Description (fr)** --- Nom
        /// </returns>
        [StringLength(200, MinimumLength = 1)]
        [CSSPDisplayEN(DisplayEN = "Name")]
        [CSSPDisplayFR(DisplayFR = "Nom")]
        [CSSPDescriptionEN(DescriptionEN = @"Name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom")]
        public string Name { get; set; }
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "CSSPWQInputTypeEnum", EnumType = "CSSPWQInputType")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "CSSP WQ input type text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte du type d'input de qualité d'eau CSSP")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "CSSP water quality input type text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du type d'input de qualité d'eau CSSP")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- CSSP WQ input type text
        /// 
        /// **Display (fr)** --- Texte du type d'input de qualité d'eau CSSP
        /// 
        /// **Description (en)** --- CSSP water quality input type text
        /// 
        /// **Description (fr)** --- Texte du type d'input de qualité d'eau CSSP
        /// </returns>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "CSSPWQInputTypeEnum", EnumType = "CSSPWQInputType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "CSSP WQ input type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type d'input de qualité d'eau CSSP")]
        [CSSPDescriptionEN(DescriptionEN = @"CSSP water quality input type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type d'input de qualité d'eau CSSP")]
        public string CSSPWQInputTypeText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "SID list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "List de SID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tide sites ID list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Liste des ID des sites de marée")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- SID list
        /// 
        /// **Display (fr)** --- List de SID
        /// 
        /// **Description (en)** --- Tide sites ID list
        /// 
        /// **Description (fr)** --- Liste des ID des sites de marée
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "SID list")]
        [CSSPDisplayFR(DisplayFR = "List de SID")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide sites ID list")]
        [CSSPDescriptionFR(DescriptionFR = @"Liste des ID des sites de marée")]
        public List<string> sidList { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MWQM site list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Liste des sites MWQM (fr)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Marine water quality monitoring site list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Liste des sitess MWQM (fr)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MWQM site list
        /// 
        /// **Display (fr)** --- Liste des sites MWQM (fr)
        /// 
        /// **Description (en)** --- Marine water quality monitoring site list
        /// 
        /// **Description (fr)** --- Liste des sitess MWQM (fr)
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "MWQM site list")]
        [CSSPDisplayFR(DisplayFR = "Liste des sites MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Marine water quality monitoring site list")]
        [CSSPDescriptionFR(DescriptionFR = @"Liste des sitess MWQM (fr)")]
        public List<string> MWQMSiteList { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MWQM site TVItemID list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Liste de TVItemID des sites MWQM (fr)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "MWQM site TVItemID list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Liste de TVItemID des sites MWQM (fr)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MWQM site TVItemID list
        /// 
        /// **Display (fr)** --- Liste de TVItemID des sites MWQM (fr)
        /// 
        /// **Description (en)** --- MWQM site TVItemID list
        /// 
        /// **Description (fr)** --- Liste de TVItemID des sites MWQM (fr)
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "MWQM site TVItemID list")]
        [CSSPDisplayFR(DisplayFR = "Liste de TVItemID des sites MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM site TVItemID list")]
        [CSSPDescriptionFR(DescriptionFR = @"Liste de TVItemID des sites MWQM (fr)")]
        public List<int> MWQMSiteTVItemIDList { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Daily duplicate MWQM site list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Liste de duplicata journalier des sites MWQM (fr)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Daily duplicate MWQM site list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Liste de duplicata journalier des sites MWQM (fr)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Daily duplicate MWQM site list
        /// 
        /// **Display (fr)** --- Liste de duplicata journalier des sites MWQM (fr)
        /// 
        /// **Description (en)** --- Daily duplicate MWQM site list
        /// 
        /// **Description (fr)** --- Liste de duplicata journalier des sites MWQM (fr)
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Daily duplicate MWQM site list")]
        [CSSPDisplayFR(DisplayFR = "Liste de duplicata journalier des sites MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Daily duplicate MWQM site list")]
        [CSSPDescriptionFR(DescriptionFR = @"Liste de duplicata journalier des sites MWQM (fr)")]
        public List<string> DailyDuplicateMWQMSiteList { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Daily duplicate MWQM site TVItemID list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Liste de TVItemID des duplicata journalier des sites MWQM (fr)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Daily duplicate MWQM site TVItemID list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Liste de TVItemID des duplicata journalier des sites MWQM (fr)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Daily duplicate MWQM site TVItemID list
        /// 
        /// **Display (fr)** --- Liste de TVItemID des duplicata journalier des sites MWQM (fr)
        /// 
        /// **Description (en)** --- Daily duplicate MWQM site TVItemID list
        /// 
        /// **Description (fr)** --- Liste de TVItemID des duplicata journalier des sites MWQM (fr)
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Daily duplicate MWQM site TVItemID list")]
        [CSSPDisplayFR(DisplayFR = "Liste de TVItemID des duplicata journalier des sites MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Daily duplicate MWQM site TVItemID list")]
        [CSSPDescriptionFR(DescriptionFR = @"Liste de TVItemID des duplicata journalier des sites MWQM (fr)")]
        public List<int> DailyDuplicateMWQMSiteTVItemIDList { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Infrastructure list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Liste des infrastructures")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Infrastructure list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Liste des infrastructures")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Infrastructure list
        /// 
        /// **Display (fr)** --- Liste des infrastructures
        /// 
        /// **Description (en)** --- Infrastructure list
        /// 
        /// **Description (fr)** --- Liste des infrastructures
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Infrastructure list")]
        [CSSPDisplayFR(DisplayFR = "Liste des infrastructures")]
        [CSSPDescriptionEN(DescriptionEN = @"Infrastructure list")]
        [CSSPDescriptionFR(DescriptionFR = @"Liste des infrastructures")]
        public List<string> InfrastructureList { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Infrastructure TVItemID list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Liste de TVItemID des infrastructures")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Infrastructure TVItemID list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Liste de TVItemID des infrastructures")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Infrastructure TVItemID list
        /// 
        /// **Display (fr)** --- Liste de TVItemID des infrastructures
        /// 
        /// **Description (en)** --- Infrastructure TVItemID list
        /// 
        /// **Description (fr)** --- Liste de TVItemID des infrastructures
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Infrastructure TVItemID list")]
        [CSSPDisplayFR(DisplayFR = "Liste de TVItemID des infrastructures")]
        [CSSPDescriptionEN(DescriptionEN = @"Infrastructure TVItemID list")]
        [CSSPDescriptionFR(DescriptionFR = @"Liste de TVItemID des infrastructures")]
        public List<int> InfrastructureTVItemIDList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public CSSPWQInputParam() : base()
        {
            sidList = new List<string>();
            MWQMSiteList = new List<string>();
            MWQMSiteTVItemIDList = new List<int>();
            DailyDuplicateMWQMSiteList = new List<string>();
            DailyDuplicateMWQMSiteTVItemIDList = new List<int>();
            InfrastructureList = new List<string>();
            InfrastructureTVItemIDList = new List<int>();
        }
        #endregion Constructors
    }
}
