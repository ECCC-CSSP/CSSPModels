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
    /// > <para>**Other properties** : [ModelType](CSSPModels.Query.html#CSSPModels_Query_ModelType), [Language](CSSPModels.Query.html#CSSPModels_Query_Language), [Lang](CSSPModels.Query.html#CSSPModels_Query_Lang), [Skip](CSSPModels.Query.html#CSSPModels_Query_Skip), [Take](CSSPModels.Query.html#CSSPModels_Query_Take), [Asc](CSSPModels.Query.html#CSSPModels_Query_Asc), [Desc](CSSPModels.Query.html#CSSPModels_Query_Desc), [Where](CSSPModels.Query.html#CSSPModels_Query_Where), [Extra](CSSPModels.Query.html#CSSPModels_Query_Extra), [AscList](CSSPModels.Query.html#CSSPModels_Query_AscList), [DescList](CSSPModels.Query.html#CSSPModels_Query_DescList), [WhereInfoList](CSSPModels.Query.html#CSSPModels_Query_WhereInfoList), [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html)</para>
    /// > <para>**Inherits [CSSPError](CSSPModels.CSSPError.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class Query : CSSPError
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Model type")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Type de modèle")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Model type")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Type de modèle")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Model type
        /// 
        /// **Display (fr)** --- Type de modèle
        /// 
        /// **Description (en)** --- Model type
        /// 
        /// **Description (fr)** --- Type de modèle
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Model type")]
        [CSSPDisplayFR(DisplayFR = "Type de modèle")]
        [CSSPDescriptionEN(DescriptionEN = @"Model type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de modèle")]
        public Type ModelType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Language")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Langage")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Language")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Langage")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Language
        /// 
        /// **Display (fr)** --- Langage
        /// 
        /// **Description (en)** --- Language
        /// 
        /// **Description (fr)** --- Langage
        /// </returns>
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage")]
        public LanguageEnum? Language { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Lang")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Lang")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Language text (Ex: 'fr', 'en')")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du langage (Ex: 'fr', 'en')")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Lang
        /// 
        /// **Display (fr)** --- Lang
        /// 
        /// **Description (en)** --- Language text (Ex: 'fr', 'en')
        /// 
        /// **Description (fr)** --- Texte du langage (Ex: 'fr', 'en')
        /// </returns>
        [StringLength(2)]
        [CSSPDisplayEN(DisplayEN = "Lang")]
        [CSSPDisplayFR(DisplayFR = "Lang")]
        [CSSPDescriptionEN(DescriptionEN = @"Language text (Ex: 'fr', 'en')")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du langage (Ex: 'fr', 'en')")]
        public string Lang { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Skip")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Sauté")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Number of items to skip while querying the database")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nombre d'éléments à ignorer lors de l'interrogation de la base de données")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Skip
        /// 
        /// **Display (fr)** --- Sauté
        /// 
        /// **Description (en)** --- Number of items to skip while querying the database
        /// 
        /// **Description (fr)** --- Nombre d'éléments à ignorer lors de l'interrogation de la base de données
        /// </returns>
        [Range(0, 1000000)]
        [CSSPDisplayEN(DisplayEN = "Skip")]
        [CSSPDisplayFR(DisplayFR = "Sauté")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of items to skip while querying the database")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre d'éléments à ignorer lors de l'interrogation de la base de données")]
        public int Skip { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Take")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Prendre")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Number of items to take while querying the database")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nombre d'éléments à prendre lors de l'interrogation de la base de données")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Take
        /// 
        /// **Display (fr)** --- Prendre
        /// 
        /// **Description (en)** --- Number of items to take while querying the database
        /// 
        /// **Description (fr)** --- Nombre d'éléments à prendre lors de l'interrogation de la base de données
        /// </returns>
        [Range(1, 1000000)]
        [CSSPDisplayEN(DisplayEN = "Take")]
        [CSSPDisplayFR(DisplayFR = "Prendre")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of items to take while querying the database")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre d'éléments à prendre lors de l'interrogation de la base de données")]
        public int Take { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Asc")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Asc")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Establishing the ascending order of the items while querying the database")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Établissement de l'ordre ascendant des éléments lors de l'interrogation de la base de données")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Asc
        /// 
        /// **Display (fr)** --- Asc
        /// 
        /// **Description (en)** --- Establishing the ascending order of the items while querying the database
        /// 
        /// **Description (fr)** --- Établissement de l'ordre ascendant des éléments lors de l'interrogation de la base de données
        /// </returns>
        [StringLength(200)]
        [CSSPDisplayEN(DisplayEN = "Asc")]
        [CSSPDisplayFR(DisplayFR = "Asc")]
        [CSSPDescriptionEN(DescriptionEN = @"Establishing the ascending order of the items while querying the database")]
        [CSSPDescriptionFR(DescriptionFR = @"Établissement de l'ordre ascendant des éléments lors de l'interrogation de la base de données")]
        public string Asc { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Desc")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Desc")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Establishing the descending order of the items while querying the database")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Établissement de l'ordre déscendant des éléments lors de l'interrogation de la base de données")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Desc
        /// 
        /// **Display (fr)** --- Desc
        /// 
        /// **Description (en)** --- Establishing the descending order of the items while querying the database
        /// 
        /// **Description (fr)** --- Établissement de l'ordre déscendant des éléments lors de l'interrogation de la base de données
        /// </returns>
        [StringLength(200)]
        [CSSPDisplayEN(DisplayEN = "Desc")]
        [CSSPDisplayFR(DisplayFR = "Desc")]
        [CSSPDescriptionEN(DescriptionEN = @"Establishing the descending order of the items while querying the database")]
        [CSSPDescriptionFR(DescriptionFR = @"Établissement de l'ordre déscendant des éléments lors de l'interrogation de la base de données")]
        public string Desc { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Where")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Filtre")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Establishing a filter of the items while querying the database")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Établissement d'un filtre des éléments lors de l'interrogation de la base de données")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Where
        /// 
        /// **Display (fr)** --- Filtre
        /// 
        /// **Description (en)** --- Establishing a filter of the items while querying the database
        /// 
        /// **Description (fr)** --- Établissement d'un filtre des éléments lors de l'interrogation de la base de données
        /// </returns>
        [StringLength(200)]
        [CSSPDisplayEN(DisplayEN = "Where")]
        [CSSPDisplayFR(DisplayFR = "Filtre")]
        [CSSPDescriptionEN(DescriptionEN = @"Establishing a filter of the items while querying the database")]
        [CSSPDescriptionFR(DescriptionFR = @"Établissement d'un filtre des éléments lors de l'interrogation de la base de données")]
        public string Where { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Extra")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Extra")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Getting extra or calculated fields while querying the database")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Obtenir des champs d'extra ou de champs calculés lors de l'interrogation de la base de données")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Extra
        /// 
        /// **Display (fr)** --- Extra
        /// 
        /// **Description (en)** --- Getting extra or calculated fields while querying the database
        /// 
        /// **Description (fr)** --- Obtenir des champs d'extra ou de champs calculés lors de l'interrogation de la base de données
        /// </returns>
        [StringLength(1)]
        [CSSPDisplayEN(DisplayEN = "Extra")]
        [CSSPDisplayFR(DisplayFR = "Extra")]
        [CSSPDescriptionEN(DescriptionEN = @"Getting extra or calculated fields while querying the database")]
        [CSSPDescriptionFR(DescriptionFR = @"Obtenir des champs d'extra ou de champs calculés lors de l'interrogation de la base de données")]
        public string Extra { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Asc field list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Liste de champs asc")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Ascending field list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Liste de champs ascendant")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Asc field list
        /// 
        /// **Display (fr)** --- Liste de champs asc
        /// 
        /// **Description (en)** --- Ascending field list
        /// 
        /// **Description (fr)** --- Liste de champs ascendant
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Asc field list")]
        [CSSPDisplayFR(DisplayFR = "Liste de champs asc")]
        [CSSPDescriptionEN(DescriptionEN = @"Ascending field list")]
        [CSSPDescriptionFR(DescriptionFR = @"Liste de champs ascendant")]
        public List<string> AscList { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Desc field list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Liste de champs desc")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Descending field list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Liste de champs descendant")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Desc field list
        /// 
        /// **Display (fr)** --- Liste de champs desc
        /// 
        /// **Description (en)** --- Descending field list
        /// 
        /// **Description (fr)** --- Liste de champs descendant
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Desc field list")]
        [CSSPDisplayFR(DisplayFR = "Liste de champs desc")]
        [CSSPDescriptionEN(DescriptionEN = @"Descending field list")]
        [CSSPDescriptionFR(DescriptionFR = @"Liste de champs descendant")]
        public List<string> DescList { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Where info list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Liste d'info de filtrage")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Filtering fields with related variables list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Filtrage des champs avec la liste des variables associées")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Where info list
        /// 
        /// **Display (fr)** --- Liste d'info de filtrage
        /// 
        /// **Description (en)** --- Filtering fields with related variables list
        /// 
        /// **Description (fr)** --- Filtrage des champs avec la liste des variables associées
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Where info list")]
        [CSSPDisplayFR(DisplayFR = "Liste d'info de filtrage")]
        [CSSPDescriptionEN(DescriptionEN = @"Filtering fields with related variables list")]
        [CSSPDescriptionFR(DescriptionFR = @"Filtrage des champs avec la liste des variables associées")]
        public List<WhereInfo> WhereInfoList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Query() : base()
        {
            Language = LanguageEnum.en;
            Lang = "en";
            Skip = 0;
            Take = 200;
            Asc = "";
            Desc = "";
            Where = "";
            Extra = "";
            AscList = new List<string>();
            DescList = new List<string>();
            WhereInfoList = new List<WhereInfo>();
        }
        #endregion Constructors
    }
}
