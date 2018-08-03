﻿/*
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
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau Classification")]
        public int ClassificationID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "79")]
        public int ClassificationTVItemID { get; set; }
        [CSSPEnumType]
        public ClassificationTypeEnum ClassificationType { get; set; }
        [Range(0, 10000)]
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
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "ClassificationTypeEnum", EnumType = "ClassificationType")]
        [CSSPAllowNull]
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
        public string ClassificationReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ClassificationReport() : base()
        {
        }
        #endregion Constructors
    }
}
