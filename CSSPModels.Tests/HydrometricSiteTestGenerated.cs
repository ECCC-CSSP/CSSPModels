/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
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
    public partial class HydrometricSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private HydrometricSite hydrometricSite { get; set; }
        private HydrometricSiteWeb hydrometricSiteWeb { get; set; }
        private HydrometricSiteReport hydrometricSiteReport { get; set; }
        #endregion Properties

        #region Constructors
        public HydrometricSiteTest()
        {
            hydrometricSite = new HydrometricSite();
            hydrometricSiteWeb = new HydrometricSiteWeb();
            hydrometricSiteReport = new HydrometricSiteReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void HydrometricSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "HydrometricSiteID", "HydrometricSiteTVItemID", "FedSiteNumber", "QuebecSiteNumber", "HydrometricSiteName", "Description", "Province", "Elevation_m", "StartDate_Local", "EndDate_Local", "TimeOffset_hour", "DrainageArea_km2", "IsNatural", "IsActive", "Sediment", "RHBN", "RealTime", "HasRatingCurve", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricSite).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(HydrometricSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void HydrometricSiteWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "HydrometricTVItemLanguage", "LastUpdateContactTVItemLanguage", "HydrometricSiteID", "HydrometricSiteTVItemID", "FedSiteNumber", "QuebecSiteNumber", "HydrometricSiteName", "Description", "Province", "Elevation_m", "StartDate_Local", "EndDate_Local", "TimeOffset_hour", "DrainageArea_km2", "IsNatural", "IsActive", "Sediment", "RHBN", "RealTime", "HasRatingCurve", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricSiteWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(HydrometricSiteWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void HydrometricSiteReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "HydrometricSiteReportTest", "HydrometricTVItemLanguage", "LastUpdateContactTVItemLanguage", "HydrometricSiteID", "HydrometricSiteTVItemID", "FedSiteNumber", "QuebecSiteNumber", "HydrometricSiteName", "Description", "Province", "Elevation_m", "StartDate_Local", "EndDate_Local", "TimeOffset_hour", "DrainageArea_km2", "IsNatural", "IsActive", "Sediment", "RHBN", "RealTime", "HasRatingCurve", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricSiteReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(HydrometricSiteReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void HydrometricSite_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricSite).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void HydrometricSiteWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricSiteWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricSiteWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void HydrometricSiteReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricSiteReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricSiteReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void HydrometricSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(HydrometricSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void HydrometricSiteWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(HydrometricSiteWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void HydrometricSiteReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(HydrometricSiteReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void HydrometricSite_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               hydrometricSite.HydrometricSiteID = val1;
               Assert.AreEqual(val1, hydrometricSite.HydrometricSiteID);
               int val2 = 45;
               hydrometricSite.HydrometricSiteTVItemID = val2;
               Assert.AreEqual(val2, hydrometricSite.HydrometricSiteTVItemID);
               string val3 = "Some text";
               hydrometricSite.FedSiteNumber = val3;
               Assert.AreEqual(val3, hydrometricSite.FedSiteNumber);
               string val4 = "Some text";
               hydrometricSite.QuebecSiteNumber = val4;
               Assert.AreEqual(val4, hydrometricSite.QuebecSiteNumber);
               string val5 = "Some text";
               hydrometricSite.HydrometricSiteName = val5;
               Assert.AreEqual(val5, hydrometricSite.HydrometricSiteName);
               string val6 = "Some text";
               hydrometricSite.Description = val6;
               Assert.AreEqual(val6, hydrometricSite.Description);
               string val7 = "Some text";
               hydrometricSite.Province = val7;
               Assert.AreEqual(val7, hydrometricSite.Province);
               double val8 = 87.9D;
               hydrometricSite.Elevation_m = val8;
               Assert.AreEqual(val8, hydrometricSite.Elevation_m);
               DateTime val9 = new DateTime(2010, 3, 4);
               hydrometricSite.StartDate_Local = val9;
               Assert.AreEqual(val9, hydrometricSite.StartDate_Local);
               DateTime val10 = new DateTime(2010, 3, 4);
               hydrometricSite.EndDate_Local = val10;
               Assert.AreEqual(val10, hydrometricSite.EndDate_Local);
               double val11 = 87.9D;
               hydrometricSite.TimeOffset_hour = val11;
               Assert.AreEqual(val11, hydrometricSite.TimeOffset_hour);
               double val12 = 87.9D;
               hydrometricSite.DrainageArea_km2 = val12;
               Assert.AreEqual(val12, hydrometricSite.DrainageArea_km2);
               bool val13 = true;
               hydrometricSite.IsNatural = val13;
               Assert.AreEqual(val13, hydrometricSite.IsNatural);
               bool val14 = true;
               hydrometricSite.IsActive = val14;
               Assert.AreEqual(val14, hydrometricSite.IsActive);
               bool val15 = true;
               hydrometricSite.Sediment = val15;
               Assert.AreEqual(val15, hydrometricSite.Sediment);
               bool val16 = true;
               hydrometricSite.RHBN = val16;
               Assert.AreEqual(val16, hydrometricSite.RHBN);
               bool val17 = true;
               hydrometricSite.RealTime = val17;
               Assert.AreEqual(val17, hydrometricSite.RealTime);
               bool val18 = true;
               hydrometricSite.HasRatingCurve = val18;
               Assert.AreEqual(val18, hydrometricSite.HasRatingCurve);
               DateTime val19 = new DateTime(2010, 3, 4);
               hydrometricSite.LastUpdateDate_UTC = val19;
               Assert.AreEqual(val19, hydrometricSite.LastUpdateDate_UTC);
               int val20 = 45;
               hydrometricSite.LastUpdateContactTVItemID = val20;
               Assert.AreEqual(val20, hydrometricSite.LastUpdateContactTVItemID);
               bool val21 = true;
               hydrometricSite.HasErrors = val21;
               Assert.AreEqual(val21, hydrometricSite.HasErrors);
               IEnumerable<ValidationResult> val66 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               hydrometricSite.ValidationResults = val66;
               Assert.AreEqual(val66, hydrometricSite.ValidationResults);
        }
        [TestMethod]
        public void HydrometricSiteWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               hydrometricSiteWeb.HydrometricTVItemLanguage = val1;
               Assert.AreEqual(val1, hydrometricSiteWeb.HydrometricTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               hydrometricSiteWeb.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, hydrometricSiteWeb.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               hydrometricSiteWeb.HydrometricSiteID = val3;
               Assert.AreEqual(val3, hydrometricSiteWeb.HydrometricSiteID);
               int val4 = 45;
               hydrometricSiteWeb.HydrometricSiteTVItemID = val4;
               Assert.AreEqual(val4, hydrometricSiteWeb.HydrometricSiteTVItemID);
               string val5 = "Some text";
               hydrometricSiteWeb.FedSiteNumber = val5;
               Assert.AreEqual(val5, hydrometricSiteWeb.FedSiteNumber);
               string val6 = "Some text";
               hydrometricSiteWeb.QuebecSiteNumber = val6;
               Assert.AreEqual(val6, hydrometricSiteWeb.QuebecSiteNumber);
               string val7 = "Some text";
               hydrometricSiteWeb.HydrometricSiteName = val7;
               Assert.AreEqual(val7, hydrometricSiteWeb.HydrometricSiteName);
               string val8 = "Some text";
               hydrometricSiteWeb.Description = val8;
               Assert.AreEqual(val8, hydrometricSiteWeb.Description);
               string val9 = "Some text";
               hydrometricSiteWeb.Province = val9;
               Assert.AreEqual(val9, hydrometricSiteWeb.Province);
               double val10 = 87.9D;
               hydrometricSiteWeb.Elevation_m = val10;
               Assert.AreEqual(val10, hydrometricSiteWeb.Elevation_m);
               DateTime val11 = new DateTime(2010, 3, 4);
               hydrometricSiteWeb.StartDate_Local = val11;
               Assert.AreEqual(val11, hydrometricSiteWeb.StartDate_Local);
               DateTime val12 = new DateTime(2010, 3, 4);
               hydrometricSiteWeb.EndDate_Local = val12;
               Assert.AreEqual(val12, hydrometricSiteWeb.EndDate_Local);
               double val13 = 87.9D;
               hydrometricSiteWeb.TimeOffset_hour = val13;
               Assert.AreEqual(val13, hydrometricSiteWeb.TimeOffset_hour);
               double val14 = 87.9D;
               hydrometricSiteWeb.DrainageArea_km2 = val14;
               Assert.AreEqual(val14, hydrometricSiteWeb.DrainageArea_km2);
               bool val15 = true;
               hydrometricSiteWeb.IsNatural = val15;
               Assert.AreEqual(val15, hydrometricSiteWeb.IsNatural);
               bool val16 = true;
               hydrometricSiteWeb.IsActive = val16;
               Assert.AreEqual(val16, hydrometricSiteWeb.IsActive);
               bool val17 = true;
               hydrometricSiteWeb.Sediment = val17;
               Assert.AreEqual(val17, hydrometricSiteWeb.Sediment);
               bool val18 = true;
               hydrometricSiteWeb.RHBN = val18;
               Assert.AreEqual(val18, hydrometricSiteWeb.RHBN);
               bool val19 = true;
               hydrometricSiteWeb.RealTime = val19;
               Assert.AreEqual(val19, hydrometricSiteWeb.RealTime);
               bool val20 = true;
               hydrometricSiteWeb.HasRatingCurve = val20;
               Assert.AreEqual(val20, hydrometricSiteWeb.HasRatingCurve);
               DateTime val21 = new DateTime(2010, 3, 4);
               hydrometricSiteWeb.LastUpdateDate_UTC = val21;
               Assert.AreEqual(val21, hydrometricSiteWeb.LastUpdateDate_UTC);
               int val22 = 45;
               hydrometricSiteWeb.LastUpdateContactTVItemID = val22;
               Assert.AreEqual(val22, hydrometricSiteWeb.LastUpdateContactTVItemID);
               bool val23 = true;
               hydrometricSiteWeb.HasErrors = val23;
               Assert.AreEqual(val23, hydrometricSiteWeb.HasErrors);
               IEnumerable<ValidationResult> val72 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               hydrometricSiteWeb.ValidationResults = val72;
               Assert.AreEqual(val72, hydrometricSiteWeb.ValidationResults);
        }
        [TestMethod]
        public void HydrometricSiteReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               hydrometricSiteReport.HydrometricSiteReportTest = val1;
               Assert.AreEqual(val1, hydrometricSiteReport.HydrometricSiteReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               hydrometricSiteReport.HydrometricTVItemLanguage = val2;
               Assert.AreEqual(val2, hydrometricSiteReport.HydrometricTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               hydrometricSiteReport.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, hydrometricSiteReport.LastUpdateContactTVItemLanguage);
               int val4 = 45;
               hydrometricSiteReport.HydrometricSiteID = val4;
               Assert.AreEqual(val4, hydrometricSiteReport.HydrometricSiteID);
               int val5 = 45;
               hydrometricSiteReport.HydrometricSiteTVItemID = val5;
               Assert.AreEqual(val5, hydrometricSiteReport.HydrometricSiteTVItemID);
               string val6 = "Some text";
               hydrometricSiteReport.FedSiteNumber = val6;
               Assert.AreEqual(val6, hydrometricSiteReport.FedSiteNumber);
               string val7 = "Some text";
               hydrometricSiteReport.QuebecSiteNumber = val7;
               Assert.AreEqual(val7, hydrometricSiteReport.QuebecSiteNumber);
               string val8 = "Some text";
               hydrometricSiteReport.HydrometricSiteName = val8;
               Assert.AreEqual(val8, hydrometricSiteReport.HydrometricSiteName);
               string val9 = "Some text";
               hydrometricSiteReport.Description = val9;
               Assert.AreEqual(val9, hydrometricSiteReport.Description);
               string val10 = "Some text";
               hydrometricSiteReport.Province = val10;
               Assert.AreEqual(val10, hydrometricSiteReport.Province);
               double val11 = 87.9D;
               hydrometricSiteReport.Elevation_m = val11;
               Assert.AreEqual(val11, hydrometricSiteReport.Elevation_m);
               DateTime val12 = new DateTime(2010, 3, 4);
               hydrometricSiteReport.StartDate_Local = val12;
               Assert.AreEqual(val12, hydrometricSiteReport.StartDate_Local);
               DateTime val13 = new DateTime(2010, 3, 4);
               hydrometricSiteReport.EndDate_Local = val13;
               Assert.AreEqual(val13, hydrometricSiteReport.EndDate_Local);
               double val14 = 87.9D;
               hydrometricSiteReport.TimeOffset_hour = val14;
               Assert.AreEqual(val14, hydrometricSiteReport.TimeOffset_hour);
               double val15 = 87.9D;
               hydrometricSiteReport.DrainageArea_km2 = val15;
               Assert.AreEqual(val15, hydrometricSiteReport.DrainageArea_km2);
               bool val16 = true;
               hydrometricSiteReport.IsNatural = val16;
               Assert.AreEqual(val16, hydrometricSiteReport.IsNatural);
               bool val17 = true;
               hydrometricSiteReport.IsActive = val17;
               Assert.AreEqual(val17, hydrometricSiteReport.IsActive);
               bool val18 = true;
               hydrometricSiteReport.Sediment = val18;
               Assert.AreEqual(val18, hydrometricSiteReport.Sediment);
               bool val19 = true;
               hydrometricSiteReport.RHBN = val19;
               Assert.AreEqual(val19, hydrometricSiteReport.RHBN);
               bool val20 = true;
               hydrometricSiteReport.RealTime = val20;
               Assert.AreEqual(val20, hydrometricSiteReport.RealTime);
               bool val21 = true;
               hydrometricSiteReport.HasRatingCurve = val21;
               Assert.AreEqual(val21, hydrometricSiteReport.HasRatingCurve);
               DateTime val22 = new DateTime(2010, 3, 4);
               hydrometricSiteReport.LastUpdateDate_UTC = val22;
               Assert.AreEqual(val22, hydrometricSiteReport.LastUpdateDate_UTC);
               int val23 = 45;
               hydrometricSiteReport.LastUpdateContactTVItemID = val23;
               Assert.AreEqual(val23, hydrometricSiteReport.LastUpdateContactTVItemID);
               bool val24 = true;
               hydrometricSiteReport.HasErrors = val24;
               Assert.AreEqual(val24, hydrometricSiteReport.HasErrors);
               IEnumerable<ValidationResult> val75 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               hydrometricSiteReport.ValidationResults = val75;
               Assert.AreEqual(val75, hydrometricSiteReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
