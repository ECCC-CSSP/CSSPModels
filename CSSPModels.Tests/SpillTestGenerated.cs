/*
 * Auto generated from the CSSPModelsGenerateCode.proj
 *
 * Do not edit this file.
 *
 * Last generated by Charles LeBlanc
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
    public partial class SpillTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private Spill spill { get; set; }
        #endregion Properties

        #region Constructors
        public SpillTest()
        {
            spill = new Spill();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void Spill_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SpillID", "MunicipalityTVItemID", "InfrastructureTVItemID", "StartDateTime_Local", "EndDateTime_Local", "AverageFlow_m3_day", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "MunicipalityTVText", "InfrastructureTVText", "LastUpdateContactTVText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.Spill).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(Spill).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Spill_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Spill).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Spill).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Spill_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Spill).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Spill_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.SpillSpillID);
               Assert.IsNotNull(CSSPModelsRes.SpillMunicipalityTVItemID);
               Assert.IsNotNull(CSSPModelsRes.SpillInfrastructureTVItemID);
               Assert.IsNotNull(CSSPModelsRes.SpillStartDateTime_Local);
               Assert.IsNotNull(CSSPModelsRes.SpillEndDateTime_Local);
               Assert.IsNotNull(CSSPModelsRes.SpillAverageFlow_m3_day);
               Assert.IsNotNull(CSSPModelsRes.SpillLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.SpillLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.SpillMunicipalityTVText);
               Assert.IsNotNull(CSSPModelsRes.SpillInfrastructureTVText);
               Assert.IsNotNull(CSSPModelsRes.SpillLastUpdateContactTVText);
               Assert.IsNotNull(CSSPModelsRes.SpillHasErrors);
        }
        [TestMethod]
        public void Spill_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               spill.SpillID = val1;
               Assert.AreEqual(val1, spill.SpillID);
               int val2 = 45;
               spill.MunicipalityTVItemID = val2;
               Assert.AreEqual(val2, spill.MunicipalityTVItemID);
               int val3 = 45;
               spill.InfrastructureTVItemID = val3;
               Assert.AreEqual(val3, spill.InfrastructureTVItemID);
               DateTime val4 = new DateTime(2010, 3, 4);
               spill.StartDateTime_Local = val4;
               Assert.AreEqual(val4, spill.StartDateTime_Local);
               DateTime val5 = new DateTime(2010, 3, 4);
               spill.EndDateTime_Local = val5;
               Assert.AreEqual(val5, spill.EndDateTime_Local);
               double val6 = 87.9D;
               spill.AverageFlow_m3_day = val6;
               Assert.AreEqual(val6, spill.AverageFlow_m3_day);
               DateTime val7 = new DateTime(2010, 3, 4);
               spill.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, spill.LastUpdateDate_UTC);
               int val8 = 45;
               spill.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, spill.LastUpdateContactTVItemID);
               string val9 = "Some text";
               spill.MunicipalityTVText = val9;
               Assert.AreEqual(val9, spill.MunicipalityTVText);
               string val10 = "Some text";
               spill.InfrastructureTVText = val10;
               Assert.AreEqual(val10, spill.InfrastructureTVText);
               string val11 = "Some text";
               spill.LastUpdateContactTVText = val11;
               Assert.AreEqual(val11, spill.LastUpdateContactTVText);
               bool val12 = true;
               spill.HasErrors = val12;
               Assert.AreEqual(val12, spill.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>().AsEnumerable();
               spill.ValidationResults = val39;
               Assert.AreEqual(val39, spill.ValidationResults);
        }
        #endregion Tests
    }
}
