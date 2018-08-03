/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
 *
 */ 
using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;
using CSSPEnums;
using System.ComponentModel.DataAnnotations;

namespace CSSPModels.Tests
{
    [TestClass]
    public partial class ClimateSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private ClimateSite climateSite { get; set; }
        private ClimateSiteWeb climateSiteWeb { get; set; }
        private ClimateSiteReport climateSiteReport { get; set; }
        #endregion Properties

        #region Constructors
        public ClimateSiteTest()
        {
            climateSite = new ClimateSite();
            climateSiteWeb = new ClimateSiteWeb();
            climateSiteReport = new ClimateSiteReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void ClimateSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ClimateSiteID", "ClimateSiteTVItemID", "ECDBID", "ClimateSiteName", "Province", "Elevation_m", "ClimateID", "WMOID", "TCID", "IsProvincial", "ProvSiteID", "TimeOffset_hour", "File_desc", "HourlyStartDate_Local", "HourlyEndDate_Local", "HourlyNow", "DailyStartDate_Local", "DailyEndDate_Local", "DailyNow", "MonthlyStartDate_Local", "MonthlyEndDate_Local", "MonthlyNow", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateSite).GetProperties().OrderBy(c => c.Name))
            {
                if (!propertyInfo.GetGetMethod().IsVirtual
                    && propertyInfo.Name != "ValidationResults"
                    && !propertyInfo.CustomAttributes.Where(c => c.AttributeType.Name.Contains("NotMappedAttribute")).Any())
                {
                    Assert.AreEqual(propNameList[index], propertyInfo.Name);
                    index += 1;
                }
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                foreach (CustomAttributeData customAttributeData in propertyInfo.CustomAttributes)
                {
                    if (customAttributeData.AttributeType.Name == "NotMappedAttribute")
                    {
                        Assert.AreEqual(propertyInfo.Name, propNameNotMappedList[index]);
                        index += 1;
                    }
                }
            }

            Assert.AreEqual(propNameNotMappedList.Count, index);

        }
        [TestMethod]
        public void ClimateSiteWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ClimateSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "ClimateSiteID", "ClimateSiteTVItemID", "ECDBID", "ClimateSiteName", "Province", "Elevation_m", "ClimateID", "WMOID", "TCID", "IsProvincial", "ProvSiteID", "TimeOffset_hour", "File_desc", "HourlyStartDate_Local", "HourlyEndDate_Local", "HourlyNow", "DailyStartDate_Local", "DailyEndDate_Local", "DailyNow", "MonthlyStartDate_Local", "MonthlyEndDate_Local", "MonthlyNow", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateSiteWeb).GetProperties().OrderBy(c => c.Name))
            {
                if (!propertyInfo.GetGetMethod().IsVirtual
                    && propertyInfo.Name != "ValidationResults"
                    && !propertyInfo.CustomAttributes.Where(c => c.AttributeType.Name.Contains("NotMappedAttribute")).Any())
                {
                    Assert.AreEqual(propNameList[index], propertyInfo.Name);
                    index += 1;
                }
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateSiteWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                foreach (CustomAttributeData customAttributeData in propertyInfo.CustomAttributes)
                {
                    if (customAttributeData.AttributeType.Name == "NotMappedAttribute")
                    {
                        Assert.AreEqual(propertyInfo.Name, propNameNotMappedList[index]);
                        index += 1;
                    }
                }
            }

            Assert.AreEqual(propNameNotMappedList.Count, index);

        }
        [TestMethod]
        public void ClimateSiteReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ClimateSiteReportTest", "ClimateSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "ClimateSiteID", "ClimateSiteTVItemID", "ECDBID", "ClimateSiteName", "Province", "Elevation_m", "ClimateID", "WMOID", "TCID", "IsProvincial", "ProvSiteID", "TimeOffset_hour", "File_desc", "HourlyStartDate_Local", "HourlyEndDate_Local", "HourlyNow", "DailyStartDate_Local", "DailyEndDate_Local", "DailyNow", "MonthlyStartDate_Local", "MonthlyEndDate_Local", "MonthlyNow", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateSiteReport).GetProperties().OrderBy(c => c.Name))
            {
                if (!propertyInfo.GetGetMethod().IsVirtual
                    && propertyInfo.Name != "ValidationResults"
                    && !propertyInfo.CustomAttributes.Where(c => c.AttributeType.Name.Contains("NotMappedAttribute")).Any())
                {
                    Assert.AreEqual(propNameList[index], propertyInfo.Name);
                    index += 1;
                }
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateSiteReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                foreach (CustomAttributeData customAttributeData in propertyInfo.CustomAttributes)
                {
                    if (customAttributeData.AttributeType.Name == "NotMappedAttribute")
                    {
                        Assert.AreEqual(propertyInfo.Name, propNameNotMappedList[index]);
                        index += 1;
                    }
                }
            }

            Assert.AreEqual(propNameNotMappedList.Count, index);

        }
        [TestMethod]
        public void ClimateSite_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateSite).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                if (propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameCollectionList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameCollectionList.Count, index);

        }
        [TestMethod]
        public void ClimateSiteWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateSiteWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateSiteWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                if (propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameCollectionList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameCollectionList.Count, index);

        }
        [TestMethod]
        public void ClimateSiteReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateSiteReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateSiteReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                if (propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameCollectionList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameCollectionList.Count, index);

        }
        [TestMethod]
        public void ClimateSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ClimateSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ClimateSiteWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ClimateSiteWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ClimateSiteReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ClimateSiteReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ClimateSite_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               climateSite.ClimateSiteID = val1;
               Assert.AreEqual(val1, climateSite.ClimateSiteID);
               int val2 = 45;
               climateSite.ClimateSiteTVItemID = val2;
               Assert.AreEqual(val2, climateSite.ClimateSiteTVItemID);
               int val3 = 45;
               climateSite.ECDBID = val3;
               Assert.AreEqual(val3, climateSite.ECDBID);
               string val4 = "Some text";
               climateSite.ClimateSiteName = val4;
               Assert.AreEqual(val4, climateSite.ClimateSiteName);
               string val5 = "Some text";
               climateSite.Province = val5;
               Assert.AreEqual(val5, climateSite.Province);
               double val6 = 87.9D;
               climateSite.Elevation_m = val6;
               Assert.AreEqual(val6, climateSite.Elevation_m);
               string val7 = "Some text";
               climateSite.ClimateID = val7;
               Assert.AreEqual(val7, climateSite.ClimateID);
               int val8 = 45;
               climateSite.WMOID = val8;
               Assert.AreEqual(val8, climateSite.WMOID);
               string val9 = "Some text";
               climateSite.TCID = val9;
               Assert.AreEqual(val9, climateSite.TCID);
               bool val10 = true;
               climateSite.IsProvincial = val10;
               Assert.AreEqual(val10, climateSite.IsProvincial);
               string val11 = "Some text";
               climateSite.ProvSiteID = val11;
               Assert.AreEqual(val11, climateSite.ProvSiteID);
               double val12 = 87.9D;
               climateSite.TimeOffset_hour = val12;
               Assert.AreEqual(val12, climateSite.TimeOffset_hour);
               string val13 = "Some text";
               climateSite.File_desc = val13;
               Assert.AreEqual(val13, climateSite.File_desc);
               DateTime val14 = new DateTime(2010, 3, 4);
               climateSite.HourlyStartDate_Local = val14;
               Assert.AreEqual(val14, climateSite.HourlyStartDate_Local);
               DateTime val15 = new DateTime(2010, 3, 4);
               climateSite.HourlyEndDate_Local = val15;
               Assert.AreEqual(val15, climateSite.HourlyEndDate_Local);
               bool val16 = true;
               climateSite.HourlyNow = val16;
               Assert.AreEqual(val16, climateSite.HourlyNow);
               DateTime val17 = new DateTime(2010, 3, 4);
               climateSite.DailyStartDate_Local = val17;
               Assert.AreEqual(val17, climateSite.DailyStartDate_Local);
               DateTime val18 = new DateTime(2010, 3, 4);
               climateSite.DailyEndDate_Local = val18;
               Assert.AreEqual(val18, climateSite.DailyEndDate_Local);
               bool val19 = true;
               climateSite.DailyNow = val19;
               Assert.AreEqual(val19, climateSite.DailyNow);
               DateTime val20 = new DateTime(2010, 3, 4);
               climateSite.MonthlyStartDate_Local = val20;
               Assert.AreEqual(val20, climateSite.MonthlyStartDate_Local);
               DateTime val21 = new DateTime(2010, 3, 4);
               climateSite.MonthlyEndDate_Local = val21;
               Assert.AreEqual(val21, climateSite.MonthlyEndDate_Local);
               bool val22 = true;
               climateSite.MonthlyNow = val22;
               Assert.AreEqual(val22, climateSite.MonthlyNow);
               DateTime val23 = new DateTime(2010, 3, 4);
               climateSite.LastUpdateDate_UTC = val23;
               Assert.AreEqual(val23, climateSite.LastUpdateDate_UTC);
               int val24 = 45;
               climateSite.LastUpdateContactTVItemID = val24;
               Assert.AreEqual(val24, climateSite.LastUpdateContactTVItemID);
               bool val25 = true;
               climateSite.HasErrors = val25;
               Assert.AreEqual(val25, climateSite.HasErrors);
               IEnumerable<ValidationResult> val78 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               climateSite.ValidationResults = val78;
               Assert.AreEqual(val78, climateSite.ValidationResults);
        }
        [TestMethod]
        public void ClimateSiteWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               climateSiteWeb.ClimateSiteTVItemLanguage = val1;
               Assert.AreEqual(val1, climateSiteWeb.ClimateSiteTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               climateSiteWeb.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, climateSiteWeb.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               climateSiteWeb.ClimateSiteID = val3;
               Assert.AreEqual(val3, climateSiteWeb.ClimateSiteID);
               int val4 = 45;
               climateSiteWeb.ClimateSiteTVItemID = val4;
               Assert.AreEqual(val4, climateSiteWeb.ClimateSiteTVItemID);
               int val5 = 45;
               climateSiteWeb.ECDBID = val5;
               Assert.AreEqual(val5, climateSiteWeb.ECDBID);
               string val6 = "Some text";
               climateSiteWeb.ClimateSiteName = val6;
               Assert.AreEqual(val6, climateSiteWeb.ClimateSiteName);
               string val7 = "Some text";
               climateSiteWeb.Province = val7;
               Assert.AreEqual(val7, climateSiteWeb.Province);
               double val8 = 87.9D;
               climateSiteWeb.Elevation_m = val8;
               Assert.AreEqual(val8, climateSiteWeb.Elevation_m);
               string val9 = "Some text";
               climateSiteWeb.ClimateID = val9;
               Assert.AreEqual(val9, climateSiteWeb.ClimateID);
               int val10 = 45;
               climateSiteWeb.WMOID = val10;
               Assert.AreEqual(val10, climateSiteWeb.WMOID);
               string val11 = "Some text";
               climateSiteWeb.TCID = val11;
               Assert.AreEqual(val11, climateSiteWeb.TCID);
               bool val12 = true;
               climateSiteWeb.IsProvincial = val12;
               Assert.AreEqual(val12, climateSiteWeb.IsProvincial);
               string val13 = "Some text";
               climateSiteWeb.ProvSiteID = val13;
               Assert.AreEqual(val13, climateSiteWeb.ProvSiteID);
               double val14 = 87.9D;
               climateSiteWeb.TimeOffset_hour = val14;
               Assert.AreEqual(val14, climateSiteWeb.TimeOffset_hour);
               string val15 = "Some text";
               climateSiteWeb.File_desc = val15;
               Assert.AreEqual(val15, climateSiteWeb.File_desc);
               DateTime val16 = new DateTime(2010, 3, 4);
               climateSiteWeb.HourlyStartDate_Local = val16;
               Assert.AreEqual(val16, climateSiteWeb.HourlyStartDate_Local);
               DateTime val17 = new DateTime(2010, 3, 4);
               climateSiteWeb.HourlyEndDate_Local = val17;
               Assert.AreEqual(val17, climateSiteWeb.HourlyEndDate_Local);
               bool val18 = true;
               climateSiteWeb.HourlyNow = val18;
               Assert.AreEqual(val18, climateSiteWeb.HourlyNow);
               DateTime val19 = new DateTime(2010, 3, 4);
               climateSiteWeb.DailyStartDate_Local = val19;
               Assert.AreEqual(val19, climateSiteWeb.DailyStartDate_Local);
               DateTime val20 = new DateTime(2010, 3, 4);
               climateSiteWeb.DailyEndDate_Local = val20;
               Assert.AreEqual(val20, climateSiteWeb.DailyEndDate_Local);
               bool val21 = true;
               climateSiteWeb.DailyNow = val21;
               Assert.AreEqual(val21, climateSiteWeb.DailyNow);
               DateTime val22 = new DateTime(2010, 3, 4);
               climateSiteWeb.MonthlyStartDate_Local = val22;
               Assert.AreEqual(val22, climateSiteWeb.MonthlyStartDate_Local);
               DateTime val23 = new DateTime(2010, 3, 4);
               climateSiteWeb.MonthlyEndDate_Local = val23;
               Assert.AreEqual(val23, climateSiteWeb.MonthlyEndDate_Local);
               bool val24 = true;
               climateSiteWeb.MonthlyNow = val24;
               Assert.AreEqual(val24, climateSiteWeb.MonthlyNow);
               DateTime val25 = new DateTime(2010, 3, 4);
               climateSiteWeb.LastUpdateDate_UTC = val25;
               Assert.AreEqual(val25, climateSiteWeb.LastUpdateDate_UTC);
               int val26 = 45;
               climateSiteWeb.LastUpdateContactTVItemID = val26;
               Assert.AreEqual(val26, climateSiteWeb.LastUpdateContactTVItemID);
               bool val27 = true;
               climateSiteWeb.HasErrors = val27;
               Assert.AreEqual(val27, climateSiteWeb.HasErrors);
               IEnumerable<ValidationResult> val84 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               climateSiteWeb.ValidationResults = val84;
               Assert.AreEqual(val84, climateSiteWeb.ValidationResults);
        }
        [TestMethod]
        public void ClimateSiteReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               climateSiteReport.ClimateSiteReportTest = val1;
               Assert.AreEqual(val1, climateSiteReport.ClimateSiteReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               climateSiteReport.ClimateSiteTVItemLanguage = val2;
               Assert.AreEqual(val2, climateSiteReport.ClimateSiteTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               climateSiteReport.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, climateSiteReport.LastUpdateContactTVItemLanguage);
               int val4 = 45;
               climateSiteReport.ClimateSiteID = val4;
               Assert.AreEqual(val4, climateSiteReport.ClimateSiteID);
               int val5 = 45;
               climateSiteReport.ClimateSiteTVItemID = val5;
               Assert.AreEqual(val5, climateSiteReport.ClimateSiteTVItemID);
               int val6 = 45;
               climateSiteReport.ECDBID = val6;
               Assert.AreEqual(val6, climateSiteReport.ECDBID);
               string val7 = "Some text";
               climateSiteReport.ClimateSiteName = val7;
               Assert.AreEqual(val7, climateSiteReport.ClimateSiteName);
               string val8 = "Some text";
               climateSiteReport.Province = val8;
               Assert.AreEqual(val8, climateSiteReport.Province);
               double val9 = 87.9D;
               climateSiteReport.Elevation_m = val9;
               Assert.AreEqual(val9, climateSiteReport.Elevation_m);
               string val10 = "Some text";
               climateSiteReport.ClimateID = val10;
               Assert.AreEqual(val10, climateSiteReport.ClimateID);
               int val11 = 45;
               climateSiteReport.WMOID = val11;
               Assert.AreEqual(val11, climateSiteReport.WMOID);
               string val12 = "Some text";
               climateSiteReport.TCID = val12;
               Assert.AreEqual(val12, climateSiteReport.TCID);
               bool val13 = true;
               climateSiteReport.IsProvincial = val13;
               Assert.AreEqual(val13, climateSiteReport.IsProvincial);
               string val14 = "Some text";
               climateSiteReport.ProvSiteID = val14;
               Assert.AreEqual(val14, climateSiteReport.ProvSiteID);
               double val15 = 87.9D;
               climateSiteReport.TimeOffset_hour = val15;
               Assert.AreEqual(val15, climateSiteReport.TimeOffset_hour);
               string val16 = "Some text";
               climateSiteReport.File_desc = val16;
               Assert.AreEqual(val16, climateSiteReport.File_desc);
               DateTime val17 = new DateTime(2010, 3, 4);
               climateSiteReport.HourlyStartDate_Local = val17;
               Assert.AreEqual(val17, climateSiteReport.HourlyStartDate_Local);
               DateTime val18 = new DateTime(2010, 3, 4);
               climateSiteReport.HourlyEndDate_Local = val18;
               Assert.AreEqual(val18, climateSiteReport.HourlyEndDate_Local);
               bool val19 = true;
               climateSiteReport.HourlyNow = val19;
               Assert.AreEqual(val19, climateSiteReport.HourlyNow);
               DateTime val20 = new DateTime(2010, 3, 4);
               climateSiteReport.DailyStartDate_Local = val20;
               Assert.AreEqual(val20, climateSiteReport.DailyStartDate_Local);
               DateTime val21 = new DateTime(2010, 3, 4);
               climateSiteReport.DailyEndDate_Local = val21;
               Assert.AreEqual(val21, climateSiteReport.DailyEndDate_Local);
               bool val22 = true;
               climateSiteReport.DailyNow = val22;
               Assert.AreEqual(val22, climateSiteReport.DailyNow);
               DateTime val23 = new DateTime(2010, 3, 4);
               climateSiteReport.MonthlyStartDate_Local = val23;
               Assert.AreEqual(val23, climateSiteReport.MonthlyStartDate_Local);
               DateTime val24 = new DateTime(2010, 3, 4);
               climateSiteReport.MonthlyEndDate_Local = val24;
               Assert.AreEqual(val24, climateSiteReport.MonthlyEndDate_Local);
               bool val25 = true;
               climateSiteReport.MonthlyNow = val25;
               Assert.AreEqual(val25, climateSiteReport.MonthlyNow);
               DateTime val26 = new DateTime(2010, 3, 4);
               climateSiteReport.LastUpdateDate_UTC = val26;
               Assert.AreEqual(val26, climateSiteReport.LastUpdateDate_UTC);
               int val27 = 45;
               climateSiteReport.LastUpdateContactTVItemID = val27;
               Assert.AreEqual(val27, climateSiteReport.LastUpdateContactTVItemID);
               bool val28 = true;
               climateSiteReport.HasErrors = val28;
               Assert.AreEqual(val28, climateSiteReport.HasErrors);
               IEnumerable<ValidationResult> val87 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               climateSiteReport.ValidationResults = val87;
               Assert.AreEqual(val87, climateSiteReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
