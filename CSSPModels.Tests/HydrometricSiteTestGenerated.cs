using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace CSSPModels.Tests
{
    public partial class HydrometricSiteTest
    {
        [TestMethod]
        public void HydrometricSite_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "HydrometricSiteID", "HydrometricSiteTVItemID", "FedSiteNumber", "QuebecSiteNumber", "HydrometricSiteName", "Description", "Province", "Elevation_m", "StartDate_Local", "EndDate_Local", "TimeOffset_hour", "DrainageArea_km2", "IsNatural", "IsActive", "Sediment", "RHBN", "RealTime", "HasRatingCurve", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyType.Name);
                index += 1;
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
        public void HydrometricSite_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "HydrometricSiteTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "HydrometricDataValues", "RatingCurves",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))
            {
                Assert.AreEqual(foreignNameList[index], foreignName);
                index += 1;
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
        public void HydrometricSite_Has_ValidationResults_OK()
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
               Assert.IsNotNull(ModelsRes.HydrometricSiteHydrometricDataValues);
               Assert.IsNotNull(ModelsRes.HydrometricSiteRatingCurves);
               Assert.IsNotNull(ModelsRes.HydrometricSiteHydrometricSiteTVItem);
        }
    }
}
