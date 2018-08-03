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
    public partial class TelTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private Tel tel { get; set; }
        private TelWeb telWeb { get; set; }
        private TelReport telReport { get; set; }
        #endregion Properties

        #region Constructors
        public TelTest()
        {
            tel = new Tel();
            telWeb = new TelWeb();
            telReport = new TelReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void Tel_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TelID", "TelTVItemID", "TelNumber", "TelType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Tel).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(Tel).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TelWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TelTVItemLanguage", "LastUpdateContactTVItemLanguage", "TelTypeText", "TelID", "TelTVItemID", "TelNumber", "TelType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TelWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TelWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TelReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TelReportTest", "TelTVItemLanguage", "LastUpdateContactTVItemLanguage", "TelTypeText", "TelID", "TelTVItemID", "TelNumber", "TelType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TelReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TelReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Tel_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Tel).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Tel).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TelWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TelWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TelWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TelReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TelReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TelReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Tel_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Tel).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TelWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TelWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TelReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TelReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Tel_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tel.TelID = val1;
               Assert.AreEqual(val1, tel.TelID);
               int val2 = 45;
               tel.TelTVItemID = val2;
               Assert.AreEqual(val2, tel.TelTVItemID);
               string val3 = "Some text";
               tel.TelNumber = val3;
               Assert.AreEqual(val3, tel.TelNumber);
               TelTypeEnum val4 = (TelTypeEnum)3;
               tel.TelType = val4;
               Assert.AreEqual(val4, tel.TelType);
               DateTime val5 = new DateTime(2010, 3, 4);
               tel.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, tel.LastUpdateDate_UTC);
               int val6 = 45;
               tel.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, tel.LastUpdateContactTVItemID);
               bool val7 = true;
               tel.HasErrors = val7;
               Assert.AreEqual(val7, tel.HasErrors);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tel.ValidationResults = val24;
               Assert.AreEqual(val24, tel.ValidationResults);
        }
        [TestMethod]
        public void TelWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               telWeb.TelTVItemLanguage = val1;
               Assert.AreEqual(val1, telWeb.TelTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               telWeb.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, telWeb.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               telWeb.TelTypeText = val3;
               Assert.AreEqual(val3, telWeb.TelTypeText);
               int val4 = 45;
               telWeb.TelID = val4;
               Assert.AreEqual(val4, telWeb.TelID);
               int val5 = 45;
               telWeb.TelTVItemID = val5;
               Assert.AreEqual(val5, telWeb.TelTVItemID);
               string val6 = "Some text";
               telWeb.TelNumber = val6;
               Assert.AreEqual(val6, telWeb.TelNumber);
               TelTypeEnum val7 = (TelTypeEnum)3;
               telWeb.TelType = val7;
               Assert.AreEqual(val7, telWeb.TelType);
               DateTime val8 = new DateTime(2010, 3, 4);
               telWeb.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, telWeb.LastUpdateDate_UTC);
               int val9 = 45;
               telWeb.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, telWeb.LastUpdateContactTVItemID);
               bool val10 = true;
               telWeb.HasErrors = val10;
               Assert.AreEqual(val10, telWeb.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               telWeb.ValidationResults = val33;
               Assert.AreEqual(val33, telWeb.ValidationResults);
        }
        [TestMethod]
        public void TelReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               telReport.TelReportTest = val1;
               Assert.AreEqual(val1, telReport.TelReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               telReport.TelTVItemLanguage = val2;
               Assert.AreEqual(val2, telReport.TelTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               telReport.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, telReport.LastUpdateContactTVItemLanguage);
               string val4 = "Some text";
               telReport.TelTypeText = val4;
               Assert.AreEqual(val4, telReport.TelTypeText);
               int val5 = 45;
               telReport.TelID = val5;
               Assert.AreEqual(val5, telReport.TelID);
               int val6 = 45;
               telReport.TelTVItemID = val6;
               Assert.AreEqual(val6, telReport.TelTVItemID);
               string val7 = "Some text";
               telReport.TelNumber = val7;
               Assert.AreEqual(val7, telReport.TelNumber);
               TelTypeEnum val8 = (TelTypeEnum)3;
               telReport.TelType = val8;
               Assert.AreEqual(val8, telReport.TelType);
               DateTime val9 = new DateTime(2010, 3, 4);
               telReport.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, telReport.LastUpdateDate_UTC);
               int val10 = 45;
               telReport.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, telReport.LastUpdateContactTVItemID);
               bool val11 = true;
               telReport.HasErrors = val11;
               Assert.AreEqual(val11, telReport.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               telReport.ValidationResults = val36;
               Assert.AreEqual(val36, telReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
