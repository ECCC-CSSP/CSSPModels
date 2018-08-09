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
    public partial class MikeBoundaryCondition : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MikeBoundaryCondition ID")]
        [CSSPDisplayFR(DisplayFR = "MikeBoundaryCondition ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MikeBoundaryConditions table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MikeBoundaryConditions")]
        public int MikeBoundaryConditionID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "12,11")]
        public int MikeBoundaryConditionTVItemID { get; set; }
        [StringLength(100)]
        public string MikeBoundaryConditionCode { get; set; }
        [StringLength(100)]
        public string MikeBoundaryConditionName { get; set; }
        [Range(1.0D, 100000.0D)]
        public double MikeBoundaryConditionLength_m { get; set; }
        [StringLength(100)]
        public string MikeBoundaryConditionFormat { get; set; }
        [CSSPEnumType]
        public MikeBoundaryConditionLevelOrVelocityEnum MikeBoundaryConditionLevelOrVelocity { get; set; }
        [CSSPEnumType]
        public WebTideDataSetEnum WebTideDataSet { get; set; }
        [Range(0, 1000)]
        public int NumberOfWebTideNodes { get; set; }
        public string WebTideDataFromStartToEndDate { get; set; }
        [CSSPEnumType]
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
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MikeBoundaryConditionTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage MikeBoundaryConditionTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "MikeBoundaryConditionLevelOrVelocityEnum", EnumType = "MikeBoundaryConditionLevelOrVelocity")]
        [CSSPAllowNull]
        public string MikeBoundaryConditionLevelOrVelocityText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "WebTideDataSetEnum", EnumType = "WebTideDataSet")]
        [CSSPAllowNull]
        public string WebTideDataSetText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
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
