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
    public partial class MikeSourceTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MikeSource mikeSource { get; set; }
        private MikeSourceExtraA mikeSourceExtraA { get; set; }
        private MikeSourceExtraB mikeSourceExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public MikeSourceTest()
        {
            mikeSource = new MikeSource();
            mikeSourceExtraA = new MikeSourceExtraA();
            mikeSourceExtraB = new MikeSourceExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MikeSource_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeSourceID", "MikeSourceTVItemID", "IsContinuous", "Include", "IsRiver", "UseHydrometric", "HydrometricTVItemID", "DrainageArea_km2", "Factor", "SourceNumberString", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSource).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeSource).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeSourceExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeSourceText", "LastUpdateContactText", "MikeSourceID", "MikeSourceTVItemID", "IsContinuous", "Include", "IsRiver", "UseHydrometric", "HydrometricTVItemID", "DrainageArea_km2", "Factor", "SourceNumberString", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSourceExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeSourceExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeSourceExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeSourceReportTest", "MikeSourceText", "LastUpdateContactText", "MikeSourceID", "MikeSourceTVItemID", "IsContinuous", "Include", "IsRiver", "UseHydrometric", "HydrometricTVItemID", "DrainageArea_km2", "Factor", "SourceNumberString", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSourceExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeSourceExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeSource_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSource).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSource).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeSourceExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSourceExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSourceExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeSourceExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSourceExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSourceExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeSource_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeSource).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeSourceExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeSourceExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeSourceExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeSourceExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeSource_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mikeSource.MikeSourceID = val1;
               Assert.AreEqual(val1, mikeSource.MikeSourceID);
               int val2 = 45;
               mikeSource.MikeSourceTVItemID = val2;
               Assert.AreEqual(val2, mikeSource.MikeSourceTVItemID);
               bool val3 = true;
               mikeSource.IsContinuous = val3;
               Assert.AreEqual(val3, mikeSource.IsContinuous);
               bool val4 = true;
               mikeSource.Include = val4;
               Assert.AreEqual(val4, mikeSource.Include);
               bool val5 = true;
               mikeSource.IsRiver = val5;
               Assert.AreEqual(val5, mikeSource.IsRiver);
               bool val6 = true;
               mikeSource.UseHydrometric = val6;
               Assert.AreEqual(val6, mikeSource.UseHydrometric);
               int val7 = 45;
               mikeSource.HydrometricTVItemID = val7;
               Assert.AreEqual(val7, mikeSource.HydrometricTVItemID);
               double val8 = 87.9D;
               mikeSource.DrainageArea_km2 = val8;
               Assert.AreEqual(val8, mikeSource.DrainageArea_km2);
               double val9 = 87.9D;
               mikeSource.Factor = val9;
               Assert.AreEqual(val9, mikeSource.Factor);
               string val10 = "Some text";
               mikeSource.SourceNumberString = val10;
               Assert.AreEqual(val10, mikeSource.SourceNumberString);
               DateTime val11 = new DateTime(2010, 3, 4);
               mikeSource.LastUpdateDate_UTC = val11;
               Assert.AreEqual(val11, mikeSource.LastUpdateDate_UTC);
               int val12 = 45;
               mikeSource.LastUpdateContactTVItemID = val12;
               Assert.AreEqual(val12, mikeSource.LastUpdateContactTVItemID);
               bool val13 = true;
               mikeSource.HasErrors = val13;
               Assert.AreEqual(val13, mikeSource.HasErrors);
               IEnumerable<ValidationResult> val42 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               mikeSource.ValidationResults = val42;
               Assert.AreEqual(val42, mikeSource.ValidationResults);
        }
        [TestMethod]
        public void MikeSourceExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mikeSourceExtraA.MikeSourceText = val1;
               Assert.AreEqual(val1, mikeSourceExtraA.MikeSourceText);
               string val2 = "Some text";
               mikeSourceExtraA.LastUpdateContactText = val2;
               Assert.AreEqual(val2, mikeSourceExtraA.LastUpdateContactText);
               int val3 = 45;
               mikeSourceExtraA.MikeSourceID = val3;
               Assert.AreEqual(val3, mikeSourceExtraA.MikeSourceID);
               int val4 = 45;
               mikeSourceExtraA.MikeSourceTVItemID = val4;
               Assert.AreEqual(val4, mikeSourceExtraA.MikeSourceTVItemID);
               bool val5 = true;
               mikeSourceExtraA.IsContinuous = val5;
               Assert.AreEqual(val5, mikeSourceExtraA.IsContinuous);
               bool val6 = true;
               mikeSourceExtraA.Include = val6;
               Assert.AreEqual(val6, mikeSourceExtraA.Include);
               bool val7 = true;
               mikeSourceExtraA.IsRiver = val7;
               Assert.AreEqual(val7, mikeSourceExtraA.IsRiver);
               bool val8 = true;
               mikeSourceExtraA.UseHydrometric = val8;
               Assert.AreEqual(val8, mikeSourceExtraA.UseHydrometric);
               int val9 = 45;
               mikeSourceExtraA.HydrometricTVItemID = val9;
               Assert.AreEqual(val9, mikeSourceExtraA.HydrometricTVItemID);
               double val10 = 87.9D;
               mikeSourceExtraA.DrainageArea_km2 = val10;
               Assert.AreEqual(val10, mikeSourceExtraA.DrainageArea_km2);
               double val11 = 87.9D;
               mikeSourceExtraA.Factor = val11;
               Assert.AreEqual(val11, mikeSourceExtraA.Factor);
               string val12 = "Some text";
               mikeSourceExtraA.SourceNumberString = val12;
               Assert.AreEqual(val12, mikeSourceExtraA.SourceNumberString);
               DateTime val13 = new DateTime(2010, 3, 4);
               mikeSourceExtraA.LastUpdateDate_UTC = val13;
               Assert.AreEqual(val13, mikeSourceExtraA.LastUpdateDate_UTC);
               int val14 = 45;
               mikeSourceExtraA.LastUpdateContactTVItemID = val14;
               Assert.AreEqual(val14, mikeSourceExtraA.LastUpdateContactTVItemID);
               bool val15 = true;
               mikeSourceExtraA.HasErrors = val15;
               Assert.AreEqual(val15, mikeSourceExtraA.HasErrors);
               IEnumerable<ValidationResult> val48 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               mikeSourceExtraA.ValidationResults = val48;
               Assert.AreEqual(val48, mikeSourceExtraA.ValidationResults);
        }
        [TestMethod]
        public void MikeSourceExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mikeSourceExtraB.MikeSourceReportTest = val1;
               Assert.AreEqual(val1, mikeSourceExtraB.MikeSourceReportTest);
               string val2 = "Some text";
               mikeSourceExtraB.MikeSourceText = val2;
               Assert.AreEqual(val2, mikeSourceExtraB.MikeSourceText);
               string val3 = "Some text";
               mikeSourceExtraB.LastUpdateContactText = val3;
               Assert.AreEqual(val3, mikeSourceExtraB.LastUpdateContactText);
               int val4 = 45;
               mikeSourceExtraB.MikeSourceID = val4;
               Assert.AreEqual(val4, mikeSourceExtraB.MikeSourceID);
               int val5 = 45;
               mikeSourceExtraB.MikeSourceTVItemID = val5;
               Assert.AreEqual(val5, mikeSourceExtraB.MikeSourceTVItemID);
               bool val6 = true;
               mikeSourceExtraB.IsContinuous = val6;
               Assert.AreEqual(val6, mikeSourceExtraB.IsContinuous);
               bool val7 = true;
               mikeSourceExtraB.Include = val7;
               Assert.AreEqual(val7, mikeSourceExtraB.Include);
               bool val8 = true;
               mikeSourceExtraB.IsRiver = val8;
               Assert.AreEqual(val8, mikeSourceExtraB.IsRiver);
               bool val9 = true;
               mikeSourceExtraB.UseHydrometric = val9;
               Assert.AreEqual(val9, mikeSourceExtraB.UseHydrometric);
               int val10 = 45;
               mikeSourceExtraB.HydrometricTVItemID = val10;
               Assert.AreEqual(val10, mikeSourceExtraB.HydrometricTVItemID);
               double val11 = 87.9D;
               mikeSourceExtraB.DrainageArea_km2 = val11;
               Assert.AreEqual(val11, mikeSourceExtraB.DrainageArea_km2);
               double val12 = 87.9D;
               mikeSourceExtraB.Factor = val12;
               Assert.AreEqual(val12, mikeSourceExtraB.Factor);
               string val13 = "Some text";
               mikeSourceExtraB.SourceNumberString = val13;
               Assert.AreEqual(val13, mikeSourceExtraB.SourceNumberString);
               DateTime val14 = new DateTime(2010, 3, 4);
               mikeSourceExtraB.LastUpdateDate_UTC = val14;
               Assert.AreEqual(val14, mikeSourceExtraB.LastUpdateDate_UTC);
               int val15 = 45;
               mikeSourceExtraB.LastUpdateContactTVItemID = val15;
               Assert.AreEqual(val15, mikeSourceExtraB.LastUpdateContactTVItemID);
               bool val16 = true;
               mikeSourceExtraB.HasErrors = val16;
               Assert.AreEqual(val16, mikeSourceExtraB.HasErrors);
               IEnumerable<ValidationResult> val51 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               mikeSourceExtraB.ValidationResults = val51;
               Assert.AreEqual(val51, mikeSourceExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
