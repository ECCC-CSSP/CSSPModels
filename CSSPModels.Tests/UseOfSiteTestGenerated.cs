/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 28 01:58
 * by Charles on CHARLES-PC machine
 *
 */ 
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
    [TestClass]
    public partial class UseOfSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private UseOfSite useOfSite { get; set; }
        #endregion Properties

        #region Constructors
        public UseOfSiteTest()
        {
            useOfSite = new UseOfSite();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void UseOfSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "UseOfSiteID", "SiteTVItemID", "SubsectorTVItemID", "SiteType", "Ordinal", "StartYear", "EndYear", "UseWeight", "Weight_perc", "UseEquation", "Param1", "Param2", "Param3", "Param4", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "UseOfSiteWeb", "UseOfSiteReport", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.UseOfSite).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(UseOfSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void UseOfSite_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(UseOfSite).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(UseOfSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void UseOfSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(UseOfSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void UseOfSite_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteUseOfSiteID);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteSiteTVItemID);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteSubsectorTVItemID);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteSiteType);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteOrdinal);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteStartYear);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteEndYear);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteUseWeight);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteWeight_perc);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteUseEquation);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteParam1);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteParam2);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteParam3);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteParam4);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.UseOfSiteHasErrors);
        }
        [TestMethod]
        public void UseOfSite_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               useOfSite.UseOfSiteID = val1;
               Assert.AreEqual(val1, useOfSite.UseOfSiteID);
               int val2 = 45;
               useOfSite.SiteTVItemID = val2;
               Assert.AreEqual(val2, useOfSite.SiteTVItemID);
               int val3 = 45;
               useOfSite.SubsectorTVItemID = val3;
               Assert.AreEqual(val3, useOfSite.SubsectorTVItemID);
               SiteTypeEnum val4 = (SiteTypeEnum)3;
               useOfSite.SiteType = val4;
               Assert.AreEqual(val4, useOfSite.SiteType);
               int val5 = 45;
               useOfSite.Ordinal = val5;
               Assert.AreEqual(val5, useOfSite.Ordinal);
               int val6 = 45;
               useOfSite.StartYear = val6;
               Assert.AreEqual(val6, useOfSite.StartYear);
               int val7 = 45;
               useOfSite.EndYear = val7;
               Assert.AreEqual(val7, useOfSite.EndYear);
               bool val8 = true;
               useOfSite.UseWeight = val8;
               Assert.AreEqual(val8, useOfSite.UseWeight);
               double val9 = 87.9D;
               useOfSite.Weight_perc = val9;
               Assert.AreEqual(val9, useOfSite.Weight_perc);
               bool val10 = true;
               useOfSite.UseEquation = val10;
               Assert.AreEqual(val10, useOfSite.UseEquation);
               double val11 = 87.9D;
               useOfSite.Param1 = val11;
               Assert.AreEqual(val11, useOfSite.Param1);
               double val12 = 87.9D;
               useOfSite.Param2 = val12;
               Assert.AreEqual(val12, useOfSite.Param2);
               double val13 = 87.9D;
               useOfSite.Param3 = val13;
               Assert.AreEqual(val13, useOfSite.Param3);
               double val14 = 87.9D;
               useOfSite.Param4 = val14;
               Assert.AreEqual(val14, useOfSite.Param4);
               DateTime val15 = new DateTime(2010, 3, 4);
               useOfSite.LastUpdateDate_UTC = val15;
               Assert.AreEqual(val15, useOfSite.LastUpdateDate_UTC);
               int val16 = 45;
               useOfSite.LastUpdateContactTVItemID = val16;
               Assert.AreEqual(val16, useOfSite.LastUpdateContactTVItemID);
               bool val17 = true;
               useOfSite.HasErrors = val17;
               Assert.AreEqual(val17, useOfSite.HasErrors);
               IEnumerable<ValidationResult> val58 = new List<ValidationResult>().AsEnumerable();
               useOfSite.ValidationResults = val58;
               Assert.AreEqual(val58, useOfSite.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
