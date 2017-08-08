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
    public partial class HydrometricSiteTest : SetupData
    {
        [TestMethod]
        public void HydrometricSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "HydrometricSiteID", "HydrometricSiteTVItemID", "FedSiteNumber", "QuebecSiteNumber", "HydrometricSiteName", "Description", "Province", "Elevation_m", "StartDate_Local", "EndDate_Local", "TimeOffset_hour", "DrainageArea_km2", "IsNatural", "IsActive", "Sediment", "RHBN", "RealTime", "HasRatingCurve", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HydrometricTVText", "LastUpdateContactTVText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.HydrometricSite).GetProperties().OrderBy(c => c.Name))
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
        public void HydrometricSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(HydrometricSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void HydrometricSite_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.HydrometricSiteHydrometricSiteID);
               Assert.IsNotNull(ModelsRes.HydrometricSiteHydrometricSiteTVItemID);
               Assert.IsNotNull(ModelsRes.HydrometricSiteFedSiteNumber);
               Assert.IsNotNull(ModelsRes.HydrometricSiteQuebecSiteNumber);
               Assert.IsNotNull(ModelsRes.HydrometricSiteHydrometricSiteName);
               Assert.IsNotNull(ModelsRes.HydrometricSiteDescription);
               Assert.IsNotNull(ModelsRes.HydrometricSiteProvince);
               Assert.IsNotNull(ModelsRes.HydrometricSiteElevation_m);
               Assert.IsNotNull(ModelsRes.HydrometricSiteStartDate_Local);
               Assert.IsNotNull(ModelsRes.HydrometricSiteEndDate_Local);
               Assert.IsNotNull(ModelsRes.HydrometricSiteTimeOffset_hour);
               Assert.IsNotNull(ModelsRes.HydrometricSiteDrainageArea_km2);
               Assert.IsNotNull(ModelsRes.HydrometricSiteIsNatural);
               Assert.IsNotNull(ModelsRes.HydrometricSiteIsActive);
               Assert.IsNotNull(ModelsRes.HydrometricSiteSediment);
               Assert.IsNotNull(ModelsRes.HydrometricSiteRHBN);
               Assert.IsNotNull(ModelsRes.HydrometricSiteRealTime);
               Assert.IsNotNull(ModelsRes.HydrometricSiteHasRatingCurve);
               Assert.IsNotNull(ModelsRes.HydrometricSiteLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.HydrometricSiteLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.HydrometricSiteHydrometricTVText);
               Assert.IsNotNull(ModelsRes.HydrometricSiteLastUpdateContactTVText);
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
               string val21 = "Some text";
               hydrometricSite.HydrometricTVText = val21;
               Assert.AreEqual(val21, hydrometricSite.HydrometricTVText);
               string val22 = "Some text";
               hydrometricSite.LastUpdateContactTVText = val22;
               Assert.AreEqual(val22, hydrometricSite.LastUpdateContactTVText);
               IEnumerable<ValidationResult> val69 = new List<ValidationResult>().AsEnumerable();
               hydrometricSite.ValidationResults = val69;
               Assert.AreEqual(val69, hydrometricSite.ValidationResults);
        }
    }
}
