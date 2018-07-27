/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 27 04:53
 * by leblancc on WMON01DTCHLEBL2 machine
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
    public partial class EmailDistributionListTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private EmailDistributionList emailDistributionList { get; set; }
        #endregion Properties

        #region Constructors
        public EmailDistributionListTest()
        {
            emailDistributionList = new EmailDistributionList();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void EmailDistributionList_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "EmailDistributionListID", "CountryTVItemID", "Ordinal", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "EmailDistributionListWeb", "EmailDistributionListReport", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.EmailDistributionList).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionList).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionList_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionList).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionList).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionList_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(EmailDistributionList).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void EmailDistributionList_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListEmailDistributionListID);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListCountryTVItemID);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListOrdinal);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListHasErrors);
        }
        [TestMethod]
        public void EmailDistributionList_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               emailDistributionList.EmailDistributionListID = val1;
               Assert.AreEqual(val1, emailDistributionList.EmailDistributionListID);
               int val2 = 45;
               emailDistributionList.CountryTVItemID = val2;
               Assert.AreEqual(val2, emailDistributionList.CountryTVItemID);
               int val3 = 45;
               emailDistributionList.Ordinal = val3;
               Assert.AreEqual(val3, emailDistributionList.Ordinal);
               DateTime val4 = new DateTime(2010, 3, 4);
               emailDistributionList.LastUpdateDate_UTC = val4;
               Assert.AreEqual(val4, emailDistributionList.LastUpdateDate_UTC);
               int val5 = 45;
               emailDistributionList.LastUpdateContactTVItemID = val5;
               Assert.AreEqual(val5, emailDistributionList.LastUpdateContactTVItemID);
               bool val6 = true;
               emailDistributionList.HasErrors = val6;
               Assert.AreEqual(val6, emailDistributionList.HasErrors);
               IEnumerable<ValidationResult> val25 = new List<ValidationResult>().AsEnumerable();
               emailDistributionList.ValidationResults = val25;
               Assert.AreEqual(val25, emailDistributionList.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
