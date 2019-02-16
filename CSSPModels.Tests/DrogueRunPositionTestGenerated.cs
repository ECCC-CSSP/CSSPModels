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
    public partial class DrogueRunPositionTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private DrogueRunPosition drogueRunPosition { get; set; }
        private DrogueRunPositionExtraA drogueRunPositionExtraA { get; set; }
        private DrogueRunPositionExtraB drogueRunPositionExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public DrogueRunPositionTest()
        {
            drogueRunPosition = new DrogueRunPosition();
            drogueRunPositionExtraA = new DrogueRunPositionExtraA();
            drogueRunPositionExtraB = new DrogueRunPositionExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void DrogueRunPosition_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "DrogueRunPositionID", "DrogueRunID", "Ordinal", "StepLat", "StepLng", "StepDateTime_Local", "CalculatedSpeed_m_s", "CalculatedDirection_deg", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DrogueRunPosition).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(DrogueRunPosition).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void DrogueRunPositionExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactText", "DrogueRunPositionID", "DrogueRunID", "Ordinal", "StepLat", "StepLng", "StepDateTime_Local", "CalculatedSpeed_m_s", "CalculatedDirection_deg", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DrogueRunPositionExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(DrogueRunPositionExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void DrogueRunPositionExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "DrogueRunPositionReportTest", "LastUpdateContactText", "DrogueRunPositionID", "DrogueRunID", "Ordinal", "StepLat", "StepLng", "StepDateTime_Local", "CalculatedSpeed_m_s", "CalculatedDirection_deg", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DrogueRunPositionExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(DrogueRunPositionExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void DrogueRunPosition_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DrogueRunPosition).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DrogueRunPosition).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void DrogueRunPositionExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DrogueRunPositionExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DrogueRunPositionExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void DrogueRunPositionExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DrogueRunPositionExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DrogueRunPositionExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void DrogueRunPosition_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(DrogueRunPosition).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void DrogueRunPositionExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(DrogueRunPositionExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void DrogueRunPositionExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(DrogueRunPositionExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void DrogueRunPosition_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               drogueRunPosition.DrogueRunPositionID = val1;
               Assert.AreEqual(val1, drogueRunPosition.DrogueRunPositionID);
               int val2 = 45;
               drogueRunPosition.DrogueRunID = val2;
               Assert.AreEqual(val2, drogueRunPosition.DrogueRunID);
               int val3 = 45;
               drogueRunPosition.Ordinal = val3;
               Assert.AreEqual(val3, drogueRunPosition.Ordinal);
               double val4 = 87.9D;
               drogueRunPosition.StepLat = val4;
               Assert.AreEqual(val4, drogueRunPosition.StepLat);
               double val5 = 87.9D;
               drogueRunPosition.StepLng = val5;
               Assert.AreEqual(val5, drogueRunPosition.StepLng);
               DateTime val6 = new DateTime(2010, 3, 4);
               drogueRunPosition.StepDateTime_Local = val6;
               Assert.AreEqual(val6, drogueRunPosition.StepDateTime_Local);
               double val7 = 87.9D;
               drogueRunPosition.CalculatedSpeed_m_s = val7;
               Assert.AreEqual(val7, drogueRunPosition.CalculatedSpeed_m_s);
               double val8 = 87.9D;
               drogueRunPosition.CalculatedDirection_deg = val8;
               Assert.AreEqual(val8, drogueRunPosition.CalculatedDirection_deg);
               DateTime val9 = new DateTime(2010, 3, 4);
               drogueRunPosition.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, drogueRunPosition.LastUpdateDate_UTC);
               int val10 = 45;
               drogueRunPosition.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, drogueRunPosition.LastUpdateContactTVItemID);
               bool val11 = true;
               drogueRunPosition.HasErrors = val11;
               Assert.AreEqual(val11, drogueRunPosition.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               drogueRunPosition.ValidationResults = val36;
               Assert.AreEqual(val36, drogueRunPosition.ValidationResults);
        }
        [TestMethod]
        public void DrogueRunPositionExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               drogueRunPositionExtraA.LastUpdateContactText = val1;
               Assert.AreEqual(val1, drogueRunPositionExtraA.LastUpdateContactText);
               int val2 = 45;
               drogueRunPositionExtraA.DrogueRunPositionID = val2;
               Assert.AreEqual(val2, drogueRunPositionExtraA.DrogueRunPositionID);
               int val3 = 45;
               drogueRunPositionExtraA.DrogueRunID = val3;
               Assert.AreEqual(val3, drogueRunPositionExtraA.DrogueRunID);
               int val4 = 45;
               drogueRunPositionExtraA.Ordinal = val4;
               Assert.AreEqual(val4, drogueRunPositionExtraA.Ordinal);
               double val5 = 87.9D;
               drogueRunPositionExtraA.StepLat = val5;
               Assert.AreEqual(val5, drogueRunPositionExtraA.StepLat);
               double val6 = 87.9D;
               drogueRunPositionExtraA.StepLng = val6;
               Assert.AreEqual(val6, drogueRunPositionExtraA.StepLng);
               DateTime val7 = new DateTime(2010, 3, 4);
               drogueRunPositionExtraA.StepDateTime_Local = val7;
               Assert.AreEqual(val7, drogueRunPositionExtraA.StepDateTime_Local);
               double val8 = 87.9D;
               drogueRunPositionExtraA.CalculatedSpeed_m_s = val8;
               Assert.AreEqual(val8, drogueRunPositionExtraA.CalculatedSpeed_m_s);
               double val9 = 87.9D;
               drogueRunPositionExtraA.CalculatedDirection_deg = val9;
               Assert.AreEqual(val9, drogueRunPositionExtraA.CalculatedDirection_deg);
               DateTime val10 = new DateTime(2010, 3, 4);
               drogueRunPositionExtraA.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, drogueRunPositionExtraA.LastUpdateDate_UTC);
               int val11 = 45;
               drogueRunPositionExtraA.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, drogueRunPositionExtraA.LastUpdateContactTVItemID);
               bool val12 = true;
               drogueRunPositionExtraA.HasErrors = val12;
               Assert.AreEqual(val12, drogueRunPositionExtraA.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               drogueRunPositionExtraA.ValidationResults = val39;
               Assert.AreEqual(val39, drogueRunPositionExtraA.ValidationResults);
        }
        [TestMethod]
        public void DrogueRunPositionExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               drogueRunPositionExtraB.DrogueRunPositionReportTest = val1;
               Assert.AreEqual(val1, drogueRunPositionExtraB.DrogueRunPositionReportTest);
               string val2 = "Some text";
               drogueRunPositionExtraB.LastUpdateContactText = val2;
               Assert.AreEqual(val2, drogueRunPositionExtraB.LastUpdateContactText);
               int val3 = 45;
               drogueRunPositionExtraB.DrogueRunPositionID = val3;
               Assert.AreEqual(val3, drogueRunPositionExtraB.DrogueRunPositionID);
               int val4 = 45;
               drogueRunPositionExtraB.DrogueRunID = val4;
               Assert.AreEqual(val4, drogueRunPositionExtraB.DrogueRunID);
               int val5 = 45;
               drogueRunPositionExtraB.Ordinal = val5;
               Assert.AreEqual(val5, drogueRunPositionExtraB.Ordinal);
               double val6 = 87.9D;
               drogueRunPositionExtraB.StepLat = val6;
               Assert.AreEqual(val6, drogueRunPositionExtraB.StepLat);
               double val7 = 87.9D;
               drogueRunPositionExtraB.StepLng = val7;
               Assert.AreEqual(val7, drogueRunPositionExtraB.StepLng);
               DateTime val8 = new DateTime(2010, 3, 4);
               drogueRunPositionExtraB.StepDateTime_Local = val8;
               Assert.AreEqual(val8, drogueRunPositionExtraB.StepDateTime_Local);
               double val9 = 87.9D;
               drogueRunPositionExtraB.CalculatedSpeed_m_s = val9;
               Assert.AreEqual(val9, drogueRunPositionExtraB.CalculatedSpeed_m_s);
               double val10 = 87.9D;
               drogueRunPositionExtraB.CalculatedDirection_deg = val10;
               Assert.AreEqual(val10, drogueRunPositionExtraB.CalculatedDirection_deg);
               DateTime val11 = new DateTime(2010, 3, 4);
               drogueRunPositionExtraB.LastUpdateDate_UTC = val11;
               Assert.AreEqual(val11, drogueRunPositionExtraB.LastUpdateDate_UTC);
               int val12 = 45;
               drogueRunPositionExtraB.LastUpdateContactTVItemID = val12;
               Assert.AreEqual(val12, drogueRunPositionExtraB.LastUpdateContactTVItemID);
               bool val13 = true;
               drogueRunPositionExtraB.HasErrors = val13;
               Assert.AreEqual(val13, drogueRunPositionExtraB.HasErrors);
               IEnumerable<ValidationResult> val42 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               drogueRunPositionExtraB.ValidationResults = val42;
               Assert.AreEqual(val42, drogueRunPositionExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
