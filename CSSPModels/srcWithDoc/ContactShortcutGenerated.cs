/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
 *
 */ 
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**DB properties for table ContactShortcuts** : [ContactShortcutID](CSSPModels.ContactShortcut.html#CSSPModels_ContactShortcut_ContactShortcutID), [ContactID](CSSPModels.ContactShortcut.html#CSSPModels_ContactShortcut_ContactID), [ShortCutText](CSSPModels.ContactShortcut.html#CSSPModels_ContactShortcut_ShortCutText), [ShortCutAddress](CSSPModels.ContactShortcut.html#CSSPModels_ContactShortcut_ShortCutAddress), [LastUpdateDate_UTC](CSSPModels.ContactShortcut.html#CSSPModels_ContactShortcut_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.ContactShortcut.html#CSSPModels_ContactShortcut_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.ContactShortcut.html#CSSPModels_ContactShortcut_HasErrors), [ValidationResults](CSSPModels.ContactShortcut.html#CSSPModels_ContactShortcut_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ContactShortcutService](CSSPServices.ContactShortcutService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class ContactShortcut : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ContactShortcut ID")]
        [CSSPDisplayFR(DisplayFR = "ContactShortcut ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ContactShortcuts table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau ContactShortcuts")]
        public int ContactShortcutID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "Contact", ExistPlurial = "s", ExistFieldID = "ContactID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "Contact", ExistPlurial = "s", ExistFieldID = "ContactID")]
        public int ContactID { get; set; }
        [StringLength(100)]
        public string ShortCutText { get; set; }
        [StringLength(200)]
        public string ShortCutAddress { get; set; }
        #endregion Properties in DB

        #region Constructors
        public ContactShortcut() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ContactShortcutWeb : ContactShortcut
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ContactShortcutWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ContactShortcutReport : ContactShortcutWeb
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string ContactShortcutReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ContactShortcutReport() : base()
        {
        }
        #endregion Constructors
    }
}
