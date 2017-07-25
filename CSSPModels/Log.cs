using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class Log
    {
        #region Properties in DB
        [Key]
        public int LogID { get; set; }
        [StringLength(50)]
        public string TableName { get; set; }
        [Range(1, -1)]
        public int ID { get; set; }
        [CSSPEnumType]
        public LogCommandEnum LogCommand { get; set; }
        public string Information { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Log()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
