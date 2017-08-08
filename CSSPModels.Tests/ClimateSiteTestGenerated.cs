using System;
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
    public partial class ClimateSiteTest : SetupData
    {
        [TestMethod]
        public void ClimateSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ClimateSiteID", "ClimateSiteTVItemID", "ECDBID", "ClimateSiteName", "Province", "Elevation_m", "ClimateID", "WMOID", "TCID", "IsProvincial", "ProvSiteID", "TimeOffset_hour", "File_desc", "HourlyStartDate_Local", "HourlyEndDate_Local", "HourlyNow", "DailyStartDate_Local", "DailyEndDate_Local", "DailyNow", "MonthlyStartDate_Local", "MonthlyEndDate_Local", "MonthlyNow", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "ClimateSiteTVText", "LastUpdateContactTVText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.ClimateSite).GetProperties().OrderBy(c => c.Name))
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
        public void ClimateSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ClimateSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ClimateSite_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.ClimateSiteClimateSiteID);
               Assert.IsNotNull(ModelsRes.ClimateSiteClimateSiteTVItemID);
               Assert.IsNotNull(ModelsRes.ClimateSiteECDBID);
               Assert.IsNotNull(ModelsRes.ClimateSiteClimateSiteName);
               Assert.IsNotNull(ModelsRes.ClimateSiteProvince);
               Assert.IsNotNull(ModelsRes.ClimateSiteElevation_m);
               Assert.IsNotNull(ModelsRes.ClimateSiteClimateID);
               Assert.IsNotNull(ModelsRes.ClimateSiteWMOID);
               Assert.IsNotNull(ModelsRes.ClimateSiteTCID);
               Assert.IsNotNull(ModelsRes.ClimateSiteIsProvincial);
               Assert.IsNotNull(ModelsRes.ClimateSiteProvSiteID);
               Assert.IsNotNull(ModelsRes.ClimateSiteTimeOffset_hour);
               Assert.IsNotNull(ModelsRes.ClimateSiteFile_desc);
               Assert.IsNotNull(ModelsRes.ClimateSiteHourlyStartDate_Local);
               Assert.IsNotNull(ModelsRes.ClimateSiteHourlyEndDate_Local);
               Assert.IsNotNull(ModelsRes.ClimateSiteHourlyNow);
               Assert.IsNotNull(ModelsRes.ClimateSiteDailyStartDate_Local);
               Assert.IsNotNull(ModelsRes.ClimateSiteDailyEndDate_Local);
               Assert.IsNotNull(ModelsRes.ClimateSiteDailyNow);
               Assert.IsNotNull(ModelsRes.ClimateSiteMonthlyStartDate_Local);
               Assert.IsNotNull(ModelsRes.ClimateSiteMonthlyEndDate_Local);
               Assert.IsNotNull(ModelsRes.ClimateSiteMonthlyNow);
               Assert.IsNotNull(ModelsRes.ClimateSiteLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.ClimateSiteLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.ClimateSiteClimateSiteTVText);
               Assert.IsNotNull(ModelsRes.ClimateSiteLastUpdateContactTVText);
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
               string val25 = "Some text";
               climateSite.ClimateSiteTVText = val25;
               Assert.AreEqual(val25, climateSite.ClimateSiteTVText);
               string val26 = "Some text";
               climateSite.LastUpdateContactTVText = val26;
               Assert.AreEqual(val26, climateSite.LastUpdateContactTVText);
               IEnumerable<ValidationResult> val81 = new List<ValidationResult>().AsEnumerable();
               climateSite.ValidationResults = val81;
               Assert.AreEqual(val81, climateSite.ValidationResults);
        }
    }
}
