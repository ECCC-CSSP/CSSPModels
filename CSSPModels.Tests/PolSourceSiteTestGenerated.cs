/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
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
    public partial class PolSourceSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private PolSourceSite polSourceSite { get; set; }
        private PolSourceSiteExtraA polSourceSiteExtraA { get; set; }
        private PolSourceSiteExtraB polSourceSiteExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceSiteTest()
        {
            polSourceSite = new PolSourceSite();
            polSourceSiteExtraA = new PolSourceSiteExtraA();
            polSourceSiteExtraB = new PolSourceSiteExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void PolSourceSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "PolSourceSiteID", "PolSourceSiteTVItemID", "Temp_Locator_CanDelete", "Oldsiteid", "Site", "SiteID", "IsPointSource", "InactiveReason", "CivicAddressTVItemID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceSite).GetProperties().OrderBy(c => c.Name))
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
        public void PolSourceSiteExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "PolSourceSiteText", "LastUpdateContactText", "InactiveReasonText", "PolSourceSiteID", "PolSourceSiteTVItemID", "Temp_Locator_CanDelete", "Oldsiteid", "Site", "SiteID", "IsPointSource", "InactiveReason", "CivicAddressTVItemID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceSiteExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(PolSourceSiteExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void PolSourceSiteExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "PolSourceSiteReportTest", "PolSourceSiteText", "LastUpdateContactText", "InactiveReasonText", "PolSourceSiteID", "PolSourceSiteTVItemID", "Temp_Locator_CanDelete", "Oldsiteid", "Site", "SiteID", "IsPointSource", "InactiveReason", "CivicAddressTVItemID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceSiteExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(PolSourceSiteExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void PolSourceSiteExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceSiteExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceSiteExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void PolSourceSiteExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceSiteExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceSiteExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void PolSourceSiteExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(PolSourceSiteExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void PolSourceSiteExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(PolSourceSiteExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               bool val12 = true;
               polSourceSite.HasErrors = val12;
               Assert.AreEqual(val12, polSourceSite.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               polSourceSite.ValidationResults = val39;
               Assert.AreEqual(val39, polSourceSite.ValidationResults);
        }
        [TestMethod]
        public void PolSourceSiteExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               polSourceSiteExtraA.PolSourceSiteText = val1;
               Assert.AreEqual(val1, polSourceSiteExtraA.PolSourceSiteText);
               string val2 = "Some text";
               polSourceSiteExtraA.LastUpdateContactText = val2;
               Assert.AreEqual(val2, polSourceSiteExtraA.LastUpdateContactText);
               string val3 = "Some text";
               polSourceSiteExtraA.InactiveReasonText = val3;
               Assert.AreEqual(val3, polSourceSiteExtraA.InactiveReasonText);
               int val4 = 45;
               polSourceSiteExtraA.PolSourceSiteID = val4;
               Assert.AreEqual(val4, polSourceSiteExtraA.PolSourceSiteID);
               int val5 = 45;
               polSourceSiteExtraA.PolSourceSiteTVItemID = val5;
               Assert.AreEqual(val5, polSourceSiteExtraA.PolSourceSiteTVItemID);
               string val6 = "Some text";
               polSourceSiteExtraA.Temp_Locator_CanDelete = val6;
               Assert.AreEqual(val6, polSourceSiteExtraA.Temp_Locator_CanDelete);
               int val7 = 45;
               polSourceSiteExtraA.Oldsiteid = val7;
               Assert.AreEqual(val7, polSourceSiteExtraA.Oldsiteid);
               int val8 = 45;
               polSourceSiteExtraA.Site = val8;
               Assert.AreEqual(val8, polSourceSiteExtraA.Site);
               int val9 = 45;
               polSourceSiteExtraA.SiteID = val9;
               Assert.AreEqual(val9, polSourceSiteExtraA.SiteID);
               bool val10 = true;
               polSourceSiteExtraA.IsPointSource = val10;
               Assert.AreEqual(val10, polSourceSiteExtraA.IsPointSource);
               PolSourceInactiveReasonEnum val11 = (PolSourceInactiveReasonEnum)3;
               polSourceSiteExtraA.InactiveReason = val11;
               Assert.AreEqual(val11, polSourceSiteExtraA.InactiveReason);
               int val12 = 45;
               polSourceSiteExtraA.CivicAddressTVItemID = val12;
               Assert.AreEqual(val12, polSourceSiteExtraA.CivicAddressTVItemID);
               DateTime val13 = new DateTime(2010, 3, 4);
               polSourceSiteExtraA.LastUpdateDate_UTC = val13;
               Assert.AreEqual(val13, polSourceSiteExtraA.LastUpdateDate_UTC);
               int val14 = 45;
               polSourceSiteExtraA.LastUpdateContactTVItemID = val14;
               Assert.AreEqual(val14, polSourceSiteExtraA.LastUpdateContactTVItemID);
               bool val15 = true;
               polSourceSiteExtraA.HasErrors = val15;
               Assert.AreEqual(val15, polSourceSiteExtraA.HasErrors);
               IEnumerable<ValidationResult> val48 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               polSourceSiteExtraA.ValidationResults = val48;
               Assert.AreEqual(val48, polSourceSiteExtraA.ValidationResults);
        }
        [TestMethod]
        public void PolSourceSiteExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               polSourceSiteExtraB.PolSourceSiteReportTest = val1;
               Assert.AreEqual(val1, polSourceSiteExtraB.PolSourceSiteReportTest);
               string val2 = "Some text";
               polSourceSiteExtraB.PolSourceSiteText = val2;
               Assert.AreEqual(val2, polSourceSiteExtraB.PolSourceSiteText);
               string val3 = "Some text";
               polSourceSiteExtraB.LastUpdateContactText = val3;
               Assert.AreEqual(val3, polSourceSiteExtraB.LastUpdateContactText);
               string val4 = "Some text";
               polSourceSiteExtraB.InactiveReasonText = val4;
               Assert.AreEqual(val4, polSourceSiteExtraB.InactiveReasonText);
               int val5 = 45;
               polSourceSiteExtraB.PolSourceSiteID = val5;
               Assert.AreEqual(val5, polSourceSiteExtraB.PolSourceSiteID);
               int val6 = 45;
               polSourceSiteExtraB.PolSourceSiteTVItemID = val6;
               Assert.AreEqual(val6, polSourceSiteExtraB.PolSourceSiteTVItemID);
               string val7 = "Some text";
               polSourceSiteExtraB.Temp_Locator_CanDelete = val7;
               Assert.AreEqual(val7, polSourceSiteExtraB.Temp_Locator_CanDelete);
               int val8 = 45;
               polSourceSiteExtraB.Oldsiteid = val8;
               Assert.AreEqual(val8, polSourceSiteExtraB.Oldsiteid);
               int val9 = 45;
               polSourceSiteExtraB.Site = val9;
               Assert.AreEqual(val9, polSourceSiteExtraB.Site);
               int val10 = 45;
               polSourceSiteExtraB.SiteID = val10;
               Assert.AreEqual(val10, polSourceSiteExtraB.SiteID);
               bool val11 = true;
               polSourceSiteExtraB.IsPointSource = val11;
               Assert.AreEqual(val11, polSourceSiteExtraB.IsPointSource);
               PolSourceInactiveReasonEnum val12 = (PolSourceInactiveReasonEnum)3;
               polSourceSiteExtraB.InactiveReason = val12;
               Assert.AreEqual(val12, polSourceSiteExtraB.InactiveReason);
               int val13 = 45;
               polSourceSiteExtraB.CivicAddressTVItemID = val13;
               Assert.AreEqual(val13, polSourceSiteExtraB.CivicAddressTVItemID);
               DateTime val14 = new DateTime(2010, 3, 4);
               polSourceSiteExtraB.LastUpdateDate_UTC = val14;
               Assert.AreEqual(val14, polSourceSiteExtraB.LastUpdateDate_UTC);
               int val15 = 45;
               polSourceSiteExtraB.LastUpdateContactTVItemID = val15;
               Assert.AreEqual(val15, polSourceSiteExtraB.LastUpdateContactTVItemID);
               bool val16 = true;
               polSourceSiteExtraB.HasErrors = val16;
               Assert.AreEqual(val16, polSourceSiteExtraB.HasErrors);
               IEnumerable<ValidationResult> val51 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               polSourceSiteExtraB.ValidationResults = val51;
               Assert.AreEqual(val51, polSourceSiteExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
