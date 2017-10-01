using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class FileItem : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255, MinimumLength = 0)]
        public string Name { get; set; }
        [Range(1, -1)]
        public int TVItemID { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public FileItem() : base()
        {
        }
        #endregion Constructors
    }
}
