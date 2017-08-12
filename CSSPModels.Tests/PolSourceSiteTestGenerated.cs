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
    public partial class PolSourceSiteTest : SetupData
    {
        [TestMethod]
        public void PolSourceSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "PolSourceSiteID", "PolSourceSiteTVItemID", "Temp_Locator_CanDelete", "Oldsiteid", "Site", "SiteID", "IsPointSource", "InactiveReason", "CivicAddressTVItemID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "PolSourceSiteTVText", "LastUpdateContactTVText", "InactiveReasonText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.PolSourceSite).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(PolSourceSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void PolSourceSite_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceSite).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void PolSourceSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(PolSourceSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void PolSourceSite_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.PolSourceSitePolSourceSiteID);
               Assert.IsNotNull(ModelsRes.PolSourceSitePolSourceSiteTVItemID);
               Assert.IsNotNull(ModelsRes.PolSourceSiteTemp_Locator_CanDelete);
               Assert.IsNotNull(ModelsRes.PolSourceSiteOldsiteid);
               Assert.IsNotNull(ModelsRes.PolSourceSiteSite);
               Assert.IsNotNull(ModelsRes.PolSourceSiteSiteID);
               Assert.IsNotNull(ModelsRes.PolSourceSiteIsPointSource);
               Assert.IsNotNull(ModelsRes.PolSourceSiteInactiveReason);
               Assert.IsNotNull(ModelsRes.PolSourceSiteCivicAddressTVItemID);
               Assert.IsNotNull(ModelsRes.PolSourceSiteLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.PolSourceSiteLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.PolSourceSitePolSourceSiteTVText);
               Assert.IsNotNull(ModelsRes.PolSourceSiteLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.PolSourceSiteInactiveReasonText);
               Assert.IsNotNull(ModelsRes.PolSourceSiteHasErrors);
        }
        [TestMethod]
        public void PolSourceSite_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               polSourceSite.PolSourceSiteID = val1;
               Assert.AreEqual(val1, polSourceSite.PolSourceSiteID);
               int val2 = 45;
               polSourceSite.PolSourceSiteTVItemID = val2;
               Assert.AreEqual(val2, polSourceSite.PolSourceSiteTVItemID);
               string val3 = "Some text";
               polSourceSite.Temp_Locator_CanDelete = val3;
               Assert.AreEqual(val3, polSourceSite.Temp_Locator_CanDelete);
               int val4 = 45;
               polSourceSite.Oldsiteid = val4;
               Assert.AreEqual(val4, polSourceSite.Oldsiteid);
               int val5 = 45;
               polSourceSite.Site = val5;
               Assert.AreEqual(val5, polSourceSite.Site);
               int val6 = 45;
               polSourceSite.SiteID = val6;
               Assert.AreEqual(val6, polSourceSite.SiteID);
               bool val7 = true;
               polSourceSite.IsPointSource = val7;
               Assert.AreEqual(val7, polSourceSite.IsPointSource);
               PolSourceInactiveReasonEnum val8 = (PolSourceInactiveReasonEnum)3;
               polSourceSite.InactiveReason = val8;
               Assert.AreEqual(val8, polSourceSite.InactiveReason);
               int val9 = 45;
               polSourceSite.CivicAddressTVItemID = val9;
               Assert.AreEqual(val9, polSourceSite.CivicAddressTVItemID);
               DateTime val10 = new DateTime(2010, 3, 4);
               polSourceSite.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, polSourceSite.LastUpdateDate_UTC);
               int val11 = 45;
               polSourceSite.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, polSourceSite.LastUpdateContactTVItemID);
               string val12 = "Some text";
               polSourceSite.PolSourceSiteTVText = val12;
               Assert.AreEqual(val12, polSourceSite.PolSourceSiteTVText);
               string val13 = "Some text";
               polSourceSite.LastUpdateContactTVText = val13;
               Assert.AreEqual(val13, polSourceSite.LastUpdateContactTVText);
               string val14 = "Some text";
               polSourceSite.InactiveReasonText = val14;
               Assert.AreEqual(val14, polSourceSite.InactiveReasonText);
               bool val15 = true;
               polSourceSite.HasErrors = val15;
               Assert.AreEqual(val15, polSourceSite.HasErrors);
               IEnumerable<ValidationResult> val48 = new List<ValidationResult>().AsEnumerable();
               polSourceSite.ValidationResults = val48;
               Assert.AreEqual(val48, polSourceSite.ValidationResults);
        }
    }
}
