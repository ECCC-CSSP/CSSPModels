using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    // CSSPAfterAttribute (used with date with year as value
    // CSSPAllowNullAttribute (used to indicate that null is allowed for the field
    // CSSPBiggerAttribute (used with date) with other date field name as value
    // CSSPEnumTypeAttribute (used with Enums) with type as value
    // CSSPExistAttribute (use with anytype) with other entity name as value

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CSSPAfterAttribute : ValidationAttribute
    {
        public int Year { get; set; }

        public override bool IsValid(object value)
        {
            return true;
        }
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CSSPAllowNullAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return true;
        }
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CSSPBiggerAttribute : ValidationAttribute
    {
        public string OtherField { get; set; }

        public override bool IsValid(object value)
        {
            return true;
        }
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CSSPEnumTypeAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return true;
        }
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CSSPExistAttribute : ValidationAttribute
    {
        public string TypeName { get; set; }
        public string Plurial { get; set; }
        public string FieldID { get; set; }

        public override bool IsValid(object value)
        {
            return true;
        }
    }

}
