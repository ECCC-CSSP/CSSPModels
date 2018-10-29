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
    public partial class SpillTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private Spill spill { get; set; }
        private SpillExtraA spillExtraA { get; set; }
        private SpillExtraB spillExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public SpillTest()
        {
            spill = new Spill();
            spillExtraA = new SpillExtraA();
            spillExtraB = new SpillExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void Spill_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SpillID", "MunicipalityTVItemID", "InfrastructureTVItemID", "StartDateTime_Local", "EndDateTime_Local", "AverageFlow_m3_day", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Spill).GetProperties().OrderBy(c => c.Name))
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
        public void SpillExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MunicipalityText", "InfrastructureText", "LastUpdateContactText", "SpillID", "MunicipalityTVItemID", "InfrastructureTVItemID", "StartDateTime_Local", "EndDateTime_Local", "AverageFlow_m3_day", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(SpillExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SpillExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SpillReportTest", "MunicipalityText", "InfrastructureText", "LastUpdateContactText", "SpillID", "MunicipalityTVItemID", "InfrastructureTVItemID", "StartDateTime_Local", "EndDateTime_Local", "AverageFlow_m3_day", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(SpillExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SpillExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SpillExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SpillExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(SpillExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SpillExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(SpillExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               bool val9 = true;
               spill.HasErrors = val9;
               Assert.AreEqual(val9, spill.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               spill.ValidationResults = val30;
               Assert.AreEqual(val30, spill.ValidationResults);
        }
        [TestMethod]
        public void SpillExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               spillExtraA.MunicipalityText = val1;
               Assert.AreEqual(val1, spillExtraA.MunicipalityText);
               string val2 = "Some text";
               spillExtraA.InfrastructureText = val2;
               Assert.AreEqual(val2, spillExtraA.InfrastructureText);
               string val3 = "Some text";
               spillExtraA.LastUpdateContactText = val3;
               Assert.AreEqual(val3, spillExtraA.LastUpdateContactText);
               int val4 = 45;
               spillExtraA.SpillID = val4;
               Assert.AreEqual(val4, spillExtraA.SpillID);
               int val5 = 45;
               spillExtraA.MunicipalityTVItemID = val5;
               Assert.AreEqual(val5, spillExtraA.MunicipalityTVItemID);
               int val6 = 45;
               spillExtraA.InfrastructureTVItemID = val6;
               Assert.AreEqual(val6, spillExtraA.InfrastructureTVItemID);
               DateTime val7 = new DateTime(2010, 3, 4);
               spillExtraA.StartDateTime_Local = val7;
               Assert.AreEqual(val7, spillExtraA.StartDateTime_Local);
               DateTime val8 = new DateTime(2010, 3, 4);
               spillExtraA.EndDateTime_Local = val8;
               Assert.AreEqual(val8, spillExtraA.EndDateTime_Local);
               double val9 = 87.9D;
               spillExtraA.AverageFlow_m3_day = val9;
               Assert.AreEqual(val9, spillExtraA.AverageFlow_m3_day);
               DateTime val10 = new DateTime(2010, 3, 4);
               spillExtraA.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, spillExtraA.LastUpdateDate_UTC);
               int val11 = 45;
               spillExtraA.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, spillExtraA.LastUpdateContactTVItemID);
               bool val12 = true;
               spillExtraA.HasErrors = val12;
               Assert.AreEqual(val12, spillExtraA.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               spillExtraA.ValidationResults = val39;
               Assert.AreEqual(val39, spillExtraA.ValidationResults);
        }
        [TestMethod]
        public void SpillExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               spillExtraB.SpillReportTest = val1;
               Assert.AreEqual(val1, spillExtraB.SpillReportTest);
               string val2 = "Some text";
               spillExtraB.MunicipalityText = val2;
               Assert.AreEqual(val2, spillExtraB.MunicipalityText);
               string val3 = "Some text";
               spillExtraB.InfrastructureText = val3;
               Assert.AreEqual(val3, spillExtraB.InfrastructureText);
               string val4 = "Some text";
               spillExtraB.LastUpdateContactText = val4;
               Assert.AreEqual(val4, spillExtraB.LastUpdateContactText);
               int val5 = 45;
               spillExtraB.SpillID = val5;
               Assert.AreEqual(val5, spillExtraB.SpillID);
               int val6 = 45;
               spillExtraB.MunicipalityTVItemID = val6;
               Assert.AreEqual(val6, spillExtraB.MunicipalityTVItemID);
               int val7 = 45;
               spillExtraB.InfrastructureTVItemID = val7;
               Assert.AreEqual(val7, spillExtraB.InfrastructureTVItemID);
               DateTime val8 = new DateTime(2010, 3, 4);
               spillExtraB.StartDateTime_Local = val8;
               Assert.AreEqual(val8, spillExtraB.StartDateTime_Local);
               DateTime val9 = new DateTime(2010, 3, 4);
               spillExtraB.EndDateTime_Local = val9;
               Assert.AreEqual(val9, spillExtraB.EndDateTime_Local);
               double val10 = 87.9D;
               spillExtraB.AverageFlow_m3_day = val10;
               Assert.AreEqual(val10, spillExtraB.AverageFlow_m3_day);
               DateTime val11 = new DateTime(2010, 3, 4);
               spillExtraB.LastUpdateDate_UTC = val11;
               Assert.AreEqual(val11, spillExtraB.LastUpdateDate_UTC);
               int val12 = 45;
               spillExtraB.LastUpdateContactTVItemID = val12;
               Assert.AreEqual(val12, spillExtraB.LastUpdateContactTVItemID);
               bool val13 = true;
               spillExtraB.HasErrors = val13;
               Assert.AreEqual(val13, spillExtraB.HasErrors);
               IEnumerable<ValidationResult> val42 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               spillExtraB.ValidationResults = val42;
               Assert.AreEqual(val42, spillExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
