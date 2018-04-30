﻿using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MikeBoundaryCondition : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MikeBoundaryCondition ID")]
        [CSSPDisplayFR(DisplayFR = "MikeBoundaryCondition ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MikeBoundaryConditions table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau MikeBoundaryConditions")]
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

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public MikeBoundaryConditionWeb MikeBoundaryConditionWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public MikeBoundaryConditionReport MikeBoundaryConditionReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MikeBoundaryCondition() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeBoundaryConditionWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MikeBoundaryConditionTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string MikeBoundaryConditionTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "MikeBoundaryConditionLevelOrVelocityEnum", EnumType = "MikeBoundaryConditionLevelOrVelocity")]
        [CSSPAllowNull]
        public string MikeBoundaryConditionLevelOrVelocityText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "WebTideDataSetEnum", EnumType = "WebTideDataSet")]
        [CSSPAllowNull]
        public string WebTideDataSetText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        public string TVTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MikeBoundaryConditionWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeBoundaryConditionReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string MikeBoundaryConditionReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MikeBoundaryConditionReport()
        {
        }
        #endregion Constructors
    }
}
