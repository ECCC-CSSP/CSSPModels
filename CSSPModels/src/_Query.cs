/*
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
    [NotMapped]
    public partial class Query : CSSPError
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [CSSPDisplayEN(DisplayEN = "Model type")]
        [CSSPDisplayFR(DisplayFR = "Type de modèle")]
        [CSSPDescriptionEN(DescriptionEN = @"Model type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de modèle")]
        public Type ModelType { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage")]
        public LanguageEnum? Language { get; set; }
        [StringLength(2)]
        [CSSPDisplayEN(DisplayEN = "Lang")]
        [CSSPDisplayFR(DisplayFR = "Lang")]
        [CSSPDescriptionEN(DescriptionEN = @"Language text (Ex: 'fr', 'en')")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du langage (Ex: 'fr', 'en')")]
        public string Lang { get; set; }
        [Range(0, 1000000)]
        [CSSPDisplayEN(DisplayEN = "Skip")]
        [CSSPDisplayFR(DisplayFR = "Sauté")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of items to skip while querying the database")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre d'éléments à ignorer lors de l'interrogation de la base de données")]
        public int Skip { get; set; }
        [Range(1, 1000000)]
        [CSSPDisplayEN(DisplayEN = "Take")]
        [CSSPDisplayFR(DisplayFR = "Prendre")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of items to take while querying the database")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre d'éléments à prendre lors de l'interrogation de la base de données")]
        public int Take { get; set; }
        [StringLength(200)]
        [CSSPDisplayEN(DisplayEN = "Order")]
        [CSSPDisplayFR(DisplayFR = "Ordre")]
        [CSSPDescriptionEN(DescriptionEN = @"Establishing the order of the items while querying the database")]
        [CSSPDescriptionFR(DescriptionFR = @"Établissement de l'ordre des éléments lors de l'interrogation de la base de données")]
        public string Order { get; set; }
        [StringLength(200)]
        [CSSPDisplayEN(DisplayEN = "Where")]
        [CSSPDisplayFR(DisplayFR = "Filtre")]
        [CSSPDescriptionEN(DescriptionEN = @"Establishing a filter of the items while querying the database")]
        [CSSPDescriptionFR(DescriptionFR = @"Établissement d'un filtre des éléments lors de l'interrogation de la base de données")]
        public string Where { get; set; }
        [StringLength(1)]
        [CSSPDisplayEN(DisplayEN = "Extra")]
        [CSSPDisplayFR(DisplayFR = "Extra")]
        [CSSPDescriptionEN(DescriptionEN = @"Getting extra or calculated fields while querying the database")]
        [CSSPDescriptionFR(DescriptionFR = @"Obtenir des champs d'extra ou de champs calculés lors de l'interrogation de la base de données")]
        public string Extra { get; set; }
        [CSSPDisplayEN(DisplayEN = "Order list")]
        [CSSPDisplayFR(DisplayFR = "Liste d'ordre")]
        [CSSPDescriptionEN(DescriptionEN = @"Order list showing all the fields to sort from")]
        [CSSPDescriptionFR(DescriptionFR = @"Liste de commandes indiquant tous les champs à trier")]
        public List<string> OrderList { get; set; }
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
            Order = "";
            Where = "";
            Extra = "";
            OrderList = new List<string>();
            WhereInfoList = new List<WhereInfo>();
        }
        #endregion Constructors
    }
}
