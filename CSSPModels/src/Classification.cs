/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class Classification : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "Classification ID")]
        [CSSPDisplayFR(DisplayFR = "Classification ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the Classification table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table Classification")]
        public int ClassificationID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "79")]
        [CSSPDisplayEN(DisplayEN = "Classification TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Classification TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table with the unique identifier")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems avec l'identifiant unique")]
        public int ClassificationTVItemID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Classification type")]
        [CSSPDisplayFR(DisplayFR = "Type de classification")]
        [CSSPDescriptionEN(DescriptionEN = @"Classification type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de classification")]
        public ClassificationTypeEnum ClassificationType { get; set; }
        [Range(0, 10000)]
        [CSSPDisplayEN(DisplayEN = "Ordinal")]
        [CSSPDisplayFR(DisplayFR = "Ordre")]
        [CSSPDescriptionEN(DescriptionEN = @"Ordinal number used to order the classification")]
        [CSSPDescriptionFR(DescriptionFR = @"Numéro indiquent l'ordre des classification")]
        public int Ordinal { get; set; }
        #endregion Properties in DB

        #region Constructors
        public Classification() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ClassificationWeb : Classification
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "ClassificationTypeEnum", EnumType = "ClassificationType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Classification text")]
        [CSSPDisplayFR(DisplayFR = "Texte de la classification")]
        [CSSPDescriptionEN(DescriptionEN = @"Classification text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de la classification")]
        public string ClassificationTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ClassificationWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ClassificationReport : ClassificationWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string ClassificationReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ClassificationReport() : base()
        {
        }
        #endregion Constructors
    }
}
