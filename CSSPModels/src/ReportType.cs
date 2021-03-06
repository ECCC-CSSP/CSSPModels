﻿/*
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
    public partial class ReportType : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ReportType ID")]
        [CSSPDisplayFR(DisplayFR = "ReportType ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ReportTypes table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table ReportTypes")]
        public int ReportTypeID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "TV type")]
        [CSSPDisplayFR(DisplayFR = "Type de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"TV type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de l'arbre visuel")]
        public TVTypeEnum TVType { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "File type")]
        [CSSPDisplayFR(DisplayFR = "Type de filière")]
        [CSSPDescriptionEN(DescriptionEN = @"File type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de filière")]
        public FileTypeEnum FileType { get; set; }
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "Unique code")]
        [CSSPDisplayFR(DisplayFR = "Code unique")]
        [CSSPDescriptionEN(DescriptionEN = @"Unique code --- used in code for knowing which document and type of document to create")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de filière --- utilisé dans le code afin de savoir quel document et type de document à créer")]
        public string UniqueCode { get; set; }
        #endregion Properties in DB

        #region Constructors
        public ReportType() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportTypeExtraA : ReportType
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        #endregion Properties

        #region Constructors
        public ReportTypeExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportTypeExtraB : ReportTypeExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string ReportTypeReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public ReportTypeExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
