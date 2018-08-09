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
    public partial class Log : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "Log ID")]
        [CSSPDisplayFR(DisplayFR = "Log ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the Logs table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table Logs")]
        public int LogID { get; set; }
        [StringLength(50)]
        public string TableName { get; set; }
        [Range(1, -1)]
        public int ID { get; set; }
        [CSSPEnumType]
        public LogCommandEnum LogCommand { get; set; }
        public string Information { get; set; }
        #endregion Properties in DB

        #region Constructors
        public Log() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class Log_A : Log
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LogCommandEnum", EnumType = "LogCommand")]
        [CSSPAllowNull]
        public string LogCommandText { get; set; }
        #endregion Properties

        #region Constructors
        public Log_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class Log_B : Log_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string LogReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public Log_B() : base()
        {
        }
        #endregion Constructors
    }
}
