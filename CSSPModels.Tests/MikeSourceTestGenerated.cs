/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
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
        private MikeSource_A mikeSource_A { get; set; }
        private MikeSource_B mikeSource_B { get; set; }
        #endregion Properties

        #region Constructors
        public MikeSourceTest()
        {
            mikeSource = new MikeSource();
            mikeSource_A = new MikeSource_A();
            mikeSource_B = new MikeSource_B();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MikeSource_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeSourceID", "MikeSourceTVItemID", "IsContinuous", "Include", "IsRiver", "SourceNumberString", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
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
        public void MikeSource_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeSourceTVItemLanguage", "LastUpdateContactTVItemLanguage", "MikeSourceID", "MikeSourceTVItemID", "IsContinuous", "Include", "IsRiver", "SourceNumberString", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSource_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeSource_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeSource_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeSourceReportTest", "MikeSourceTVItemLanguage", "LastUpdateContactTVItemLanguage", "MikeSourceID", "MikeSourceTVItemID", "IsContinuous", "Include", "IsRiver", "SourceNumberString", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSource_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeSource_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeSource_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSource_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSource_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeSource_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSource_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeSource_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeSource_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeSource_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeSource_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeSource_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               string val6 = "Some text";
               mikeSource.SourceNumberString = val6;
               Assert.AreEqual(val6, mikeSource.SourceNumberString);
               DateTime val7 = new DateTime(2010, 3, 4);
               mikeSource.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, mikeSource.LastUpdateDate_UTC);
               int val8 = 45;
               mikeSource.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, mikeSource.LastUpdateContactTVItemID);
               bool val9 = true;
               mikeSource.HasErrors = val9;
               Assert.AreEqual(val9, mikeSource.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mikeSource.ValidationResults = val30;
               Assert.AreEqual(val30, mikeSource.ValidationResults);
        }
        [TestMethod]
        public void MikeSource_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               mikeSource_A.MikeSourceTVItemLanguage = val1;
               Assert.AreEqual(val1, mikeSource_A.MikeSourceTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               mikeSource_A.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, mikeSource_A.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               mikeSource_A.MikeSourceID = val3;
               Assert.AreEqual(val3, mikeSource_A.MikeSourceID);
               int val4 = 45;
               mikeSource_A.MikeSourceTVItemID = val4;
               Assert.AreEqual(val4, mikeSource_A.MikeSourceTVItemID);
               bool val5 = true;
               mikeSource_A.IsContinuous = val5;
               Assert.AreEqual(val5, mikeSource_A.IsContinuous);
               bool val6 = true;
               mikeSource_A.Include = val6;
               Assert.AreEqual(val6, mikeSource_A.Include);
               bool val7 = true;
               mikeSource_A.IsRiver = val7;
               Assert.AreEqual(val7, mikeSource_A.IsRiver);
               string val8 = "Some text";
               mikeSource_A.SourceNumberString = val8;
               Assert.AreEqual(val8, mikeSource_A.SourceNumberString);
               DateTime val9 = new DateTime(2010, 3, 4);
               mikeSource_A.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, mikeSource_A.LastUpdateDate_UTC);
               int val10 = 45;
               mikeSource_A.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, mikeSource_A.LastUpdateContactTVItemID);
               bool val11 = true;
               mikeSource_A.HasErrors = val11;
               Assert.AreEqual(val11, mikeSource_A.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mikeSource_A.ValidationResults = val36;
               Assert.AreEqual(val36, mikeSource_A.ValidationResults);
        }
        [TestMethod]
        public void MikeSource_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mikeSource_B.MikeSourceReportTest = val1;
               Assert.AreEqual(val1, mikeSource_B.MikeSourceReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               mikeSource_B.MikeSourceTVItemLanguage = val2;
               Assert.AreEqual(val2, mikeSource_B.MikeSourceTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               mikeSource_B.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, mikeSource_B.LastUpdateContactTVItemLanguage);
               int val4 = 45;
               mikeSource_B.MikeSourceID = val4;
               Assert.AreEqual(val4, mikeSource_B.MikeSourceID);
               int val5 = 45;
               mikeSource_B.MikeSourceTVItemID = val5;
               Assert.AreEqual(val5, mikeSource_B.MikeSourceTVItemID);
               bool val6 = true;
               mikeSource_B.IsContinuous = val6;
               Assert.AreEqual(val6, mikeSource_B.IsContinuous);
               bool val7 = true;
               mikeSource_B.Include = val7;
               Assert.AreEqual(val7, mikeSource_B.Include);
               bool val8 = true;
               mikeSource_B.IsRiver = val8;
               Assert.AreEqual(val8, mikeSource_B.IsRiver);
               string val9 = "Some text";
               mikeSource_B.SourceNumberString = val9;
               Assert.AreEqual(val9, mikeSource_B.SourceNumberString);
               DateTime val10 = new DateTime(2010, 3, 4);
               mikeSource_B.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, mikeSource_B.LastUpdateDate_UTC);
               int val11 = 45;
               mikeSource_B.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, mikeSource_B.LastUpdateContactTVItemID);
               bool val12 = true;
               mikeSource_B.HasErrors = val12;
               Assert.AreEqual(val12, mikeSource_B.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mikeSource_B.ValidationResults = val39;
               Assert.AreEqual(val39, mikeSource_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
