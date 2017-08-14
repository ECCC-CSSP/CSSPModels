using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    /// Custom validation attribute used when creating code
    /// <para>Used when creating [class]ServiceGenerated.cs and [class]ServiceTestGenerated.cs codes</para>
    /// <para>Used on type: <see cref="DateTime"></see></para>
    /// <para>DateTime only valid for years after <c>Year</c></para>
    /// <para>Year: Determine the year for which the DateTime has to be after</para>
    /// </summary>
    /// <example>
    /// [CSSPAfter(Year = 1980)]
    /// public DateTime StartDate { get; set; }
    /// [CSSPAfter(OtherField = "StartDate")]
    /// public DateTime EndDate { get; set; }
    /// </example>
    /// <remarks>
    /// <para>Validation code produced</para>
    /// <code>
    /// if (mwqmSample.SampleDateTime_Local.Year &lt; 1980)
    /// {
    ///     mwqmSample.HasErrors = true;
    ///     yield return new ValidationResult(string.Format(ServicesRes._YearShouldBeBiggerThan_, ModelsRes.MWQMSampleSampleDateTime_Local, "1980"), new[] { "SampleDateTime_Local" });
    /// }
    /// </code>
    /// </remarks>
    public class CSSPAfterAttribute : Attribute
    {
        /// <summary>
        /// Year for which the Date has to be after
        /// </summary>
        public int Year { get; set; }
    }

    /// <summary>
    /// Custom validation attribute used when creating code
    /// <para>Used when creating [class]ServiceGenerated.cs and [class]ServiceTestGenerated.cs codes</para>
    /// <para>Used on type: <see cref="string"/></para>
    /// <para>Used when creating validation and testing on string properties when nullable</para>
    /// <para>No parameter</para>
    /// </summary>
    /// <example>
    /// [CSSPAllowNull]
    /// [StringLength(200)]
    /// public string StreetName { get; set; }
    /// </example>
    /// <remarks>
    /// <para>Validation code produced</para>
    /// <code>
    /// if (!string.IsNullOrWhiteSpace(address.StreetName) &amp;&amp; address.StreetName.Length > 200)
    /// {
    ///     address.HasErrors = true;
    ///     yield return new ValidationResult(string.Format(ServicesRes._MaxLengthIs_, ModelsRes.AddressStreetName, "200"), new[] { "StreetName" });
    /// }    
    /// </code>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CSSPAllowNullAttribute : ValidationAttribute
    {
        /// <summary>
        /// No used. Using own validation system.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            return true;
        }
    }

    /// <summary>
    /// Custom validation attribute used when creating code
    /// <para>Used when creating [class]ServiceGenerated.cs and [class]ServiceTestGenerated.cs codes</para>
    /// <para>Used on type: <see cref="DateTime"></see></para>
    /// <para>DateTime only valid if DateTime of <c>OtherField</c> is smaller or equal</para>
    /// <para>OtherField: Determine the other field for which the DateTime has to be bigger</para>
    /// </summary>
    /// <example>
    /// [CSSPAfter(Year = 1980)]
    /// public DateTime StartDateTime_UTC { get; set; }
    /// [CSSPAfter(Year = 1980)]
    /// [CSSPBigger(OtherField = "StartDateTime_UTC")]
    /// public DateTime? EndDateTime_UTC { get; set; }
    /// </example>
    /// <remarks>
    /// <para>Validation code produced</para>
    /// <code>
    /// if (appTask.StartDateTime_UTC > appTask.EndDateTime_UTC)
    /// {
    ///     appTask.HasErrors = true;
    ///     yield return new ValidationResult(string.Format(ServicesRes._DateIsBiggerThan_, ModelsRes.AppTaskEndDateTime_UTC, ModelsRes.AppTaskStartDateTime_UTC), new[] { ModelsRes.AppTaskEndDateTime_UTC });
    /// }
    /// </code>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CSSPBiggerAttribute : ValidationAttribute
    {
        /// <summary>
        /// Represent the other date field for which it has to be bigger
        /// </summary>
        public string OtherField { get; set; }

        /// <summary>
        /// No used. Using own validation system.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            return true;
        }
    }

    /// <summary>
    /// Custom validation attribute used when creating code
    /// <para>Used when creating [class]ServiceGenerated.cs and [class]ServiceTestGenerated.cs codes</para>
    /// <para>Used on type: Enumeration properties</para>
    /// <para>Only valid if the Enum value is one of existing Enum</para>
    /// <para>No parameter</para>
    /// </summary>
    /// <example>
    /// [CSSPEnumType]
    /// public AddressTypeEnum AddressType { get; set; }
    /// </example>
    /// <remarks>
    /// <para>Validation code produced</para>
    /// <code>
    /// retStr = enums.AddressTypeOK(address.AddressType);
    /// if (address.AddressType == AddressTypeEnum.Error || !string.IsNullOrWhiteSpace(retStr))
    /// {
    ///     address.HasErrors = true;
    ///     yield return new ValidationResult(string.Format(ServicesRes._IsRequired, ModelsRes.AddressAddressType), new[] { "AddressType" });
    /// }
    /// </code>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CSSPEnumTypeAttribute : ValidationAttribute
    {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="value"></param>
       /// <returns></returns>
       public override bool IsValid(object value)
        {
            return true;
        }
    }

    /// <summary>
    /// Custom validation attribute used when creating code
    /// <para>Used when creating [class]ServiceGenerated.cs and [class]ServiceTestGenerated.cs codes</para>
    /// <para>Used on type: Enumeration properties</para>
    /// <para>Used when creating Fill of services for enumeration</para>
    /// <para>EnumTypeName: Enumeration name within CSSPEnums</para>
    /// <para>EnumType: Property name</para>
    /// </summary>
    /// <example>
    /// [CSSPEnumTypeText(EnumTypeName = "AddressTypeEnum", EnumType = "AddressType")]
    /// public string AddressTypeText { get; set; }
    /// </example>
    /// <remarks>
    /// <para>Validation code produced</para>
    /// <code>
    /// retStr = enums.AddressTypeOK(address.AddressType);
    /// if (address.AddressType == AddressTypeEnum.Error || !string.IsNullOrWhiteSpace(retStr))
    /// {
    ///     address.HasErrors = true;
    ///     yield return new ValidationResult(string.Format(ServicesRes._IsRequired, ModelsRes.AddressAddressType), new[] { "AddressType" });
    /// }
    /// </code>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CSSPEnumTypeTextAttribute : ValidationAttribute
    {
        /// <summary>
        /// Enumeration name with CSSPEnums
        /// </summary>
        public string EnumTypeName { get; set; }
        /// <summary>
        /// Represent the property name
        /// </summary>
        public string EnumType { get; set; }

        /// <summary>
        /// No used. Using own validation system.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            return true;
        }
    }

    /// <summary>
    /// Custom validation attribute used when creating code
    /// <para>Used when creating [class]ServiceGenerated.cs and [class]ServiceTestGenerated.cs codes</para>
    /// <para>Used on type: int which represend the ID of database field key</para>
    /// <para>ExistTypeName: Object Type text representing the name of the type</para>
    /// <para>ExistPlurial: Plurial of the type which together creates the table name of the DB</para>
    /// <para>ExistFieldID: Field ID of the table for which to compare with</para>
    /// <para>AllowableTVTypeList: List of TVTypeEnum numbers separated by commas (only used with TVItems DB table)</para>
    /// </summary>
    /// <example>
    /// [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22,28")]
    /// public int TVItemID { get; set; }
    /// </example>
    /// <example>
    /// [CSSPExist(ExistTypeName = "AppTask", ExistPlurial = "s", ExistFieldID = "AppTaskID")]
    /// public int AppTaskID { get; set; }
    /// </example>
    /// <remarks>
    /// <para>Validation code produced</para>
    /// <code>
    ///     TVItem TVItemTVItemID = (from c in db.TVItems where c.TVItemID == appTask.TVItemID select c).FirstOrDefault();
    ///     
    ///     if (TVItemTVItemID == null)
    ///     {
    ///         appTask.HasErrors = true;
    ///         yield return new ValidationResult(string.Format(ServicesRes.CouldNotFind_With_Equal_, ModelsRes.TVItem, ModelsRes.AppTaskTVItemID, appTask.TVItemID.ToString()), new[] { "TVItemID" });
    ///     }
    ///     else
    ///     {
    ///         List&lt;TVTypeEnum&gt; AllowableTVTypes = new List&lt;TVTypeEnum&gt;()
    ///         {
    ///             TVTypeEnum.Root,
    ///             TVTypeEnum.Country,
    ///             TVTypeEnum.Province,
    ///             TVTypeEnum.Area,
    ///             TVTypeEnum.Sector,
    ///             TVTypeEnum.Subsector,
    ///             TVTypeEnum.ClimateSite,
    ///             TVTypeEnum.File,
    ///             TVTypeEnum.HydrometricSite,
    ///             TVTypeEnum.Infrastructure,
    ///             TVTypeEnum.MikeBoundaryConditionMesh,
    ///             TVTypeEnum.MikeBoundaryConditionWebTide,
    ///             TVTypeEnum.MikeScenario,
    ///             TVTypeEnum.MikeSource,
    ///             TVTypeEnum.Municipality,
    ///             TVTypeEnum.MWQMRun,
    ///             TVTypeEnum.MWQMSite,
    ///             TVTypeEnum.MWQMSiteSample,
    ///             TVTypeEnum.PolSourceSite,
    ///             TVTypeEnum.SamplingPlan,
    ///             TVTypeEnum.Spill,
    ///             TVTypeEnum.TideSite,
    ///             TVTypeEnum.VisualPlumesScenario,
    ///         };
    ///         if (!AllowableTVTypes.Contains(TVItemTVItemID.TVType))
    ///         {
    ///             appTask.HasErrors = true;
    ///             yield return new ValidationResult(string.Format(ServicesRes._IsNotOfType_, ModelsRes.AppTaskTVItemID, "Root,Country,Province,Area,Sector,Subsector,ClimateSite,File,HydrometricSite,Infrastructure,MikeBoundaryConditionMesh,MikeBoundaryConditionWebTide,MikeScenario,MikeSource,Municipality,MWQMRun,MWQMSite,MWQMSiteSample,PolSourceSite,SamplingPlan,Spill,TideSite,VisualPlumesScenario"), new[] { "TVItemID" });
    ///         }
    ///     }
    /// </code>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CSSPExistAttribute : ValidationAttribute
    {
        /// <summary>
        /// Type text representing the name of the type
        /// </summary>
        public string ExistTypeName { get; set; }
        /// <summary>
        /// Plurial of the type which together creates the table name of the DB
        /// </summary>
        public string ExistPlurial { get; set; }
        /// <summary>
        /// Field ID of the table for which to compare with
        /// </summary>
        public string ExistFieldID { get; set; }
        /// <summary>
        /// List of TVTypeEnum numbers separated by commas (only used with TVItems DB table)
        /// </summary>
        public string AllowableTVTypeList { get; set; }

        /// <summary>
        /// No used. Using own validation system.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            return true;
        }
    }

    /// <summary>
    /// Custom validation attribute used when creating code
    /// <para>Used when creating [class]ServiceGenerated.cs and [class]ServiceTestGenerated.cs codes</para>
    /// <para>Used on various types</para>
    /// <para>FillTypeName: Object Type text representing the name of the type</para>
    /// <para>FillPlurial: Plurial of the type which together creates the table name of the DB</para>
    /// <para>FillFieldID: Field ID of the table for which to compare with</para>
    /// <para>FillEqualField: Field name/value to compare with DB table</para>
    /// <para>FillReturnField: Field name/value to return</para>
    /// <para>FillNeedLanguage: If true, a language comparision will also be included</para>
    /// </summary>
    /// <example>
    /// [NotMapped]
    /// [StringLength(200)]
    /// [CSSPAllowNull]
    /// [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "AddressTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
    /// public string AddressTVText { get; set; }
    /// </example>
    /// <remarks>
    /// <para>Validation code produced</para>
    /// <code>
    /// private List&lt;Address&gt; FillAddress(IQueryable&lt;Address&gt; addressQuery)
    /// {
    ///     List&lt;Address&gt; AddressList = (from c in addressQuery
    ///                                  let ParentTVItemID = (from cl in db.TVItems
    ///                                                        where cl.TVItemID == c.AddressTVItemID
    ///                                                        select cl.ParentID).FirstOrDefault()
    ///                                  let AddressTVText = (from cl in db.TVItemLanguages
    ///                                                       where cl.TVItemID == c.AddressTVItemID
    ///                                                       &amp;&amp; cl.Language == LanguageRequest
    ///                                                       select cl.TVText).FirstOrDefault()
    ///                                  let CountryTVText = (from cl in db.TVItemLanguages
    ///                                                       where cl.TVItemID == c.CountryTVItemID
    ///                                                       &amp;&amp; cl.Language == LanguageRequest
    ///                                                       select cl.TVText).FirstOrDefault()
    ///                                  let ProvinceTVText = (from cl in db.TVItemLanguages
    ///                                                        where cl.TVItemID == c.ProvinceTVItemID
    ///                                                        &amp;&amp; cl.Language == LanguageRequest
    ///                                                        select cl.TVText).FirstOrDefault()
    ///                                  let MunicipalityTVText = (from cl in db.TVItemLanguages
    ///                                                            where cl.TVItemID == c.MunicipalityTVItemID
    ///                                                            &amp;&amp; cl.Language == LanguageRequest
    ///                                                            select cl.TVText).FirstOrDefault()
    ///                                  let LastUpdateContactTVText = (from cl in db.TVItemLanguages
    ///                                                                 where cl.TVItemID == c.LastUpdateContactTVItemID
    ///                                                                 &amp;&amp; cl.Language == LanguageRequest
    ///                                                                 select cl.TVText).FirstOrDefault()
    ///                                  select new Address
    ///                                  {
    ///                                      AddressID = c.AddressID,
    ///                                      AddressTVItemID = c.AddressTVItemID,
    ///                                      AddressType = c.AddressType,
    ///                                      CountryTVItemID = c.CountryTVItemID,
    ///                                      ProvinceTVItemID = c.ProvinceTVItemID,
    ///                                      MunicipalityTVItemID = c.MunicipalityTVItemID,
    ///                                      StreetName = c.StreetName,
    ///                                      StreetNumber = c.StreetNumber,
    ///                                      StreetType = c.StreetType,
    ///                                      PostalCode = c.PostalCode,
    ///                                      GoogleAddressText = c.GoogleAddressText,
    ///                                      LastUpdateDate_UTC = c.LastUpdateDate_UTC,
    ///                                      LastUpdateContactTVItemID = c.LastUpdateContactTVItemID,
    ///                                      ParentTVItemID = ParentTVItemID,
    ///                                      AddressTVText = AddressTVText,
    ///                                      CountryTVText = CountryTVText,
    ///                                      ProvinceTVText = ProvinceTVText,
    ///                                      MunicipalityTVText = MunicipalityTVText,
    ///                                      LastUpdateContactTVText = LastUpdateContactTVText,
    ///                                      ValidationResults = null,
    ///                                  }).ToList();
    /// 
    ///     Enums enums = new Enums(LanguageRequest);
    /// 
    ///     foreach (Address address in AddressList)
    ///     {
    ///         address.AddressTypeText = enums.GetEnumText_AddressTypeEnum(address.AddressType);
    ///         address.StreetTypeText = enums.GetEnumText_StreetTypeEnum(address.StreetType);
    ///     }
    /// 
    ///     return AddressList;
    /// }
    /// </code>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class CSSPFillAttribute : ValidationAttribute
    {
        /// <summary>
        /// Object Type text representing the name of the type
        /// </summary>
        public string FillTypeName { get; set; }
        /// <summary>
        /// Plurial of the type which together creates the table name of the DB
        /// </summary>
        public string FillPlurial { get; set; }
        /// <summary>
        /// Field ID of the table for which to compare with
        /// </summary>
        public string FillFieldID { get; set; }
        /// <summary>
        /// Field name/value to compare with DB table
        /// </summary>
        public string FillEqualField { get; set; }
        /// <summary>
        /// Field name/value to return
        /// </summary>
        public string FillReturnField { get; set; }
        /// <summary>
        /// If true, a language comparision will also be included
        /// </summary>
        public bool FillNeedLanguage { get; set; }

        /// <summary>
        /// No used. Using own validation system.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            return true;
        }
    }
}
