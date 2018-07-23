using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class WhereInfo : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(100)]
        public string PropertyName { get; set; }
        [CSSPEnumType]
        public PropertyTypeEnum PropertyType { get; set; }
        [CSSPEnumType]
        public WhereOperatorEnum WhereOperator { get; set; }
        [StringLength(100)]
        public string Value { get; set; }
        [Range(-1, -1)]
        public int ValueInt { get; set; }
        [Range(-1.0D, -1.0D)]
        public double ValueDouble { get; set; }
        public bool ValueBool { get; set; }
        [CSSPAfter(Year = 1900)]
        public DateTime ValueDateTime { get; set; }
        [StringLength(100)]
        public string ValueEnumText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public WhereInfo() : base()
        {
        }
        #endregion Constructors
    }
}
