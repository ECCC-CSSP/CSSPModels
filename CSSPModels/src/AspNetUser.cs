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
    public partial class AspNetUser : Error
    {
        #region Properties in DB
        [Key]
        [StringLength(128)]
        [CSSPDisplayEN(DisplayEN = "ID")]
        [CSSPDisplayFR(DisplayFR = "ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the AspNetUsers table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table AspNetUsers")]
        public string Id { get; set; }
        [StringLength(256)]
        [CSSPAllowNull]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        [StringLength(256)]
        [CSSPAllowNull]
        public string PasswordHash { get; set; }
        [StringLength(256)]
        [CSSPAllowNull]
        public string SecurityStamp { get; set; }
        [StringLength(256)]
        [CSSPAllowNull]
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        [Range(0, 10000)]
        public int AccessFailedCount { get; set; }
        [StringLength(256)]
        public string UserName { get; set; }
        #endregion Properties in DB

        #region Constructors
        public AspNetUser()
        {
        }
        #endregion Constructors
    }
}
