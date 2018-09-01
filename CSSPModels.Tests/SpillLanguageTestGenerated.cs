/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
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
    public partial class SpillLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private SpillLanguage spillLanguage { get; set; }
        private SpillLanguage_A spillLanguage_A { get; set; }
        private SpillLanguage_B spillLanguage_B { get; set; }
        #endregion Properties

        #region Constructors
        public SpillLanguageTest()
        {
            spillLanguage = new SpillLanguage();
            spillLanguage_A = new SpillLanguage_A();
            spillLanguage_B = new SpillLanguage_B();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void SpillLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SpillLanguageID", "SpillID", "Language", "SpillComment", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(SpillLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SpillLanguage_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "LanguageText", "TranslationStatusText", "SpillLanguageID", "SpillID", "Language", "SpillComment", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillLanguage_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(SpillLanguage_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SpillLanguage_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SpillLanguageReportTest", "LastUpdateContactTVItemLanguage", "LanguageText", "TranslationStatusText", "SpillLanguageID", "SpillID", "Language", "SpillComment", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillLanguage_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(SpillLanguage_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SpillLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SpillLanguage_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillLanguage_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillLanguage_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SpillLanguage_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillLanguage_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillLanguage_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SpillLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(SpillLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SpillLanguage_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(SpillLanguage_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SpillLanguage_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(SpillLanguage_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SpillLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               spillLanguage.SpillLanguageID = val1;
               Assert.AreEqual(val1, spillLanguage.SpillLanguageID);
               int val2 = 45;
               spillLanguage.SpillID = val2;
               Assert.AreEqual(val2, spillLanguage.SpillID);
               LanguageEnum val3 = (LanguageEnum)3;
               spillLanguage.Language = val3;
               Assert.AreEqual(val3, spillLanguage.Language);
               string val4 = "Some text";
               spillLanguage.SpillComment = val4;
               Assert.AreEqual(val4, spillLanguage.SpillComment);
               TranslationStatusEnum val5 = (TranslationStatusEnum)3;
               spillLanguage.TranslationStatus = val5;
               Assert.AreEqual(val5, spillLanguage.TranslationStatus);
               DateTime val6 = new DateTime(2010, 3, 4);
               spillLanguage.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, spillLanguage.LastUpdateDate_UTC);
               int val7 = 45;
               spillLanguage.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, spillLanguage.LastUpdateContactTVItemID);
               bool val8 = true;
               spillLanguage.HasErrors = val8;
               Assert.AreEqual(val8, spillLanguage.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               spillLanguage.ValidationResults = val27;
               Assert.AreEqual(val27, spillLanguage.ValidationResults);
        }
        [TestMethod]
        public void SpillLanguage_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               spillLanguage_A.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, spillLanguage_A.LastUpdateContactTVItemLanguage);
               string val2 = "Some text";
               spillLanguage_A.LanguageText = val2;
               Assert.AreEqual(val2, spillLanguage_A.LanguageText);
               string val3 = "Some text";
               spillLanguage_A.TranslationStatusText = val3;
               Assert.AreEqual(val3, spillLanguage_A.TranslationStatusText);
               int val4 = 45;
               spillLanguage_A.SpillLanguageID = val4;
               Assert.AreEqual(val4, spillLanguage_A.SpillLanguageID);
               int val5 = 45;
               spillLanguage_A.SpillID = val5;
               Assert.AreEqual(val5, spillLanguage_A.SpillID);
               LanguageEnum val6 = (LanguageEnum)3;
               spillLanguage_A.Language = val6;
               Assert.AreEqual(val6, spillLanguage_A.Language);
               string val7 = "Some text";
               spillLanguage_A.SpillComment = val7;
               Assert.AreEqual(val7, spillLanguage_A.SpillComment);
               TranslationStatusEnum val8 = (TranslationStatusEnum)3;
               spillLanguage_A.TranslationStatus = val8;
               Assert.AreEqual(val8, spillLanguage_A.TranslationStatus);
               DateTime val9 = new DateTime(2010, 3, 4);
               spillLanguage_A.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, spillLanguage_A.LastUpdateDate_UTC);
               int val10 = 45;
               spillLanguage_A.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, spillLanguage_A.LastUpdateContactTVItemID);
               bool val11 = true;
               spillLanguage_A.HasErrors = val11;
               Assert.AreEqual(val11, spillLanguage_A.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               spillLanguage_A.ValidationResults = val36;
               Assert.AreEqual(val36, spillLanguage_A.ValidationResults);
        }
        [TestMethod]
        public void SpillLanguage_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               spillLanguage_B.SpillLanguageReportTest = val1;
               Assert.AreEqual(val1, spillLanguage_B.SpillLanguageReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               spillLanguage_B.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, spillLanguage_B.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               spillLanguage_B.LanguageText = val3;
               Assert.AreEqual(val3, spillLanguage_B.LanguageText);
               string val4 = "Some text";
               spillLanguage_B.TranslationStatusText = val4;
               Assert.AreEqual(val4, spillLanguage_B.TranslationStatusText);
               int val5 = 45;
               spillLanguage_B.SpillLanguageID = val5;
               Assert.AreEqual(val5, spillLanguage_B.SpillLanguageID);
               int val6 = 45;
               spillLanguage_B.SpillID = val6;
               Assert.AreEqual(val6, spillLanguage_B.SpillID);
               LanguageEnum val7 = (LanguageEnum)3;
               spillLanguage_B.Language = val7;
               Assert.AreEqual(val7, spillLanguage_B.Language);
               string val8 = "Some text";
               spillLanguage_B.SpillComment = val8;
               Assert.AreEqual(val8, spillLanguage_B.SpillComment);
               TranslationStatusEnum val9 = (TranslationStatusEnum)3;
               spillLanguage_B.TranslationStatus = val9;
               Assert.AreEqual(val9, spillLanguage_B.TranslationStatus);
               DateTime val10 = new DateTime(2010, 3, 4);
               spillLanguage_B.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, spillLanguage_B.LastUpdateDate_UTC);
               int val11 = 45;
               spillLanguage_B.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, spillLanguage_B.LastUpdateContactTVItemID);
               bool val12 = true;
               spillLanguage_B.HasErrors = val12;
               Assert.AreEqual(val12, spillLanguage_B.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               spillLanguage_B.ValidationResults = val39;
               Assert.AreEqual(val39, spillLanguage_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
