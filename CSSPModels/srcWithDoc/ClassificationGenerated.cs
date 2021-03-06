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
    /// > <para>**DB properties for table Classifications** : [ClassificationID](CSSPModels.Classification.html#CSSPModels_Classification_ClassificationID), [ClassificationTVItemID](CSSPModels.Classification.html#CSSPModels_Classification_ClassificationTVItemID), [ClassificationType](CSSPModels.Classification.html#CSSPModels_Classification_ClassificationType), [Ordinal](CSSPModels.Classification.html#CSSPModels_Classification_Ordinal), [LastUpdate.LastUpdateDate_UTC](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateDate_UTC), [LastUpdate.LastUpdateContactTVItemID](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateContactTVItemID)</para>
    /// > <para>**Other properties** : [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ClassificationService](CSSPServices.ClassificationService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [ClassificationController](CSSPWebAPI.Controllers.ClassificationController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [ClassificationTypeEnum](CSSPEnums.ClassificationTypeEnum.html)</para>
    /// > <para>**Inherits [LastUpdate](CSSPModels.LastUpdate.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class Classification : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Classification ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Classification ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the Classification table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table Classification")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Classification ID
        /// 
        /// **Display (fr)** --- Classification ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the Classification table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table Classification
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "Classification ID")]
        [CSSPDisplayFR(DisplayFR = "Classification ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the Classification table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table Classification")]
        public int ClassificationID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>79 == Classification</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "79")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Classification TVItemID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Classification TVItemID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the TVItems table with the unique identifier")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table TVItems avec l'identifiant unique")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Classification TVItemID
        /// 
        /// **Display (fr)** --- Classification TVItemID
        /// 
        /// **Description (en)** --- Link to the TVItems table with the unique identifier
        /// 
        /// **Description (fr)** --- Lien à la table TVItems avec l'identifiant unique
        /// </returns>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "79")]
        [CSSPDisplayEN(DisplayEN = "Classification TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Classification TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table with the unique identifier")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems avec l'identifiant unique")]
        public int ClassificationTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Classification type")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Type de classification")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Classification type")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Type de classification")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Classification type
        /// 
        /// **Display (fr)** --- Type de classification
        /// 
        /// **Description (en)** --- Classification type
        /// 
        /// **Description (fr)** --- Type de classification
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Classification type")]
        [CSSPDisplayFR(DisplayFR = "Type de classification")]
        [CSSPDescriptionEN(DescriptionEN = @"Classification type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de classification")]
        public ClassificationTypeEnum ClassificationType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Ordinal")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Ordre")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Ordinal number used to order the classification")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Numéro indiquent l'ordre des classification")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Ordinal
        /// 
        /// **Display (fr)** --- Ordre
        /// 
        /// **Description (en)** --- Ordinal number used to order the classification
        /// 
        /// **Description (fr)** --- Numéro indiquent l'ordre des classification
        /// </returns>
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
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [LastUpdateContactText](CSSPModels.Classification.html#CSSPModels_Classification_LastUpdateContactText), [ClassificationTVText](CSSPModels.Classification.html#CSSPModels_Classification_ClassificationTVText)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ClassificationService](CSSPServices.ClassificationService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [ClassificationController](CSSPWebAPI.Controllers.ClassificationController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [ClassificationTypeEnum](CSSPEnums.ClassificationTypeEnum.html)</para>
    /// > <para>**Inherits [Classification](CSSPModels.Classification.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class ClassificationExtraA : Classification
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "ClassificationTypeEnum", EnumType = "ClassificationType")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Classification text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte de la classification")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Classification text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte de la classification")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Classification text
        /// 
        /// **Display (fr)** --- Texte de la classification
        /// 
        /// **Description (en)** --- Classification text
        /// 
        /// **Description (fr)** --- Texte de la classification
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "ClassificationTypeEnum", EnumType = "ClassificationType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Classification text")]
        [CSSPDisplayFR(DisplayFR = "Texte de la classification")]
        [CSSPDescriptionEN(DescriptionEN = @"Classification text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de la classification")]
        public string ClassificationTVText { get; set; }
        #endregion Properties

        #region Constructors
        public ClassificationExtraA() : base()
        {
        }
        #endregion Constructors
    }
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [ClassificationReportTest](CSSPModels.Classification.html#CSSPModels_Classification_ClassificationReportTest)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ClassificationService](CSSPServices.ClassificationService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [ClassificationController](CSSPWebAPI.Controllers.ClassificationController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [ClassificationTypeEnum](CSSPEnums.ClassificationTypeEnum.html)</para>
    /// > <para>**Inherits [ClassificationExtraA](CSSPModels.ClassificationExtraA.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class ClassificationExtraB : ClassificationExtraA
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
        public string ClassificationReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public ClassificationExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
