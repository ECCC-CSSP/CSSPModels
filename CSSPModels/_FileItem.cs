using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class FileItem
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(0, 255)]
        public string Name { get; set; }
        [Required]
        [Range(1, -1)]
        public int TVItemID { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public FileItem()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
