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
    public partial class DocTemplateTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private DocTemplate docTemplate { get; set; }
        private DocTemplate_A docTemplate_A { get; set; }
        private DocTemplate_B docTemplate_B { get; set; }
        #endregion Properties

        #region Constructors
        public DocTemplateTest()
        {
            docTemplate = new DocTemplate();
            docTemplate_A = new DocTemplate_A();
            docTemplate_B = new DocTemplate_B();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void DocTemplate_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "DocTemplateID", "Language", "TVType", "TVFileTVItemID", "FileName", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DocTemplate).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(DocTemplate).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void DocTemplate_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "LanguageText", "TVTypeText", "DocTemplateID", "Language", "TVType", "TVFileTVItemID", "FileName", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DocTemplate_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(DocTemplate_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void DocTemplate_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "DocTemplateReportTest", "LastUpdateContactTVItemLanguage", "LanguageText", "TVTypeText", "DocTemplateID", "Language", "TVType", "TVFileTVItemID", "FileName", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DocTemplate_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(DocTemplate_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void DocTemplate_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DocTemplate).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DocTemplate).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void DocTemplate_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DocTemplate_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DocTemplate_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void DocTemplate_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DocTemplate_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DocTemplate_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void DocTemplate_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(DocTemplate).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void DocTemplate_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(DocTemplate_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void DocTemplate_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(DocTemplate_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void DocTemplate_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               docTemplate.DocTemplateID = val1;
               Assert.AreEqual(val1, docTemplate.DocTemplateID);
               LanguageEnum val2 = (LanguageEnum)3;
               docTemplate.Language = val2;
               Assert.AreEqual(val2, docTemplate.Language);
               TVTypeEnum val3 = (TVTypeEnum)3;
               docTemplate.TVType = val3;
               Assert.AreEqual(val3, docTemplate.TVType);
               int val4 = 45;
               docTemplate.TVFileTVItemID = val4;
               Assert.AreEqual(val4, docTemplate.TVFileTVItemID);
               string val5 = "Some text";
               docTemplate.FileName = val5;
               Assert.AreEqual(val5, docTemplate.FileName);
               DateTime val6 = new DateTime(2010, 3, 4);
               docTemplate.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, docTemplate.LastUpdateDate_UTC);
               int val7 = 45;
               docTemplate.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, docTemplate.LastUpdateContactTVItemID);
               bool val8 = true;
               docTemplate.HasErrors = val8;
               Assert.AreEqual(val8, docTemplate.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               docTemplate.ValidationResults = val27;
               Assert.AreEqual(val27, docTemplate.ValidationResults);
        }
        [TestMethod]
        public void DocTemplate_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               docTemplate_A.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, docTemplate_A.LastUpdateContactTVItemLanguage);
               string val2 = "Some text";
               docTemplate_A.LanguageText = val2;
               Assert.AreEqual(val2, docTemplate_A.LanguageText);
               string val3 = "Some text";
               docTemplate_A.TVTypeText = val3;
               Assert.AreEqual(val3, docTemplate_A.TVTypeText);
               int val4 = 45;
               docTemplate_A.DocTemplateID = val4;
               Assert.AreEqual(val4, docTemplate_A.DocTemplateID);
               LanguageEnum val5 = (LanguageEnum)3;
               docTemplate_A.Language = val5;
               Assert.AreEqual(val5, docTemplate_A.Language);
               TVTypeEnum val6 = (TVTypeEnum)3;
               docTemplate_A.TVType = val6;
               Assert.AreEqual(val6, docTemplate_A.TVType);
               int val7 = 45;
               docTemplate_A.TVFileTVItemID = val7;
               Assert.AreEqual(val7, docTemplate_A.TVFileTVItemID);
               string val8 = "Some text";
               docTemplate_A.FileName = val8;
               Assert.AreEqual(val8, docTemplate_A.FileName);
               DateTime val9 = new DateTime(2010, 3, 4);
               docTemplate_A.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, docTemplate_A.LastUpdateDate_UTC);
               int val10 = 45;
               docTemplate_A.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, docTemplate_A.LastUpdateContactTVItemID);
               bool val11 = true;
               docTemplate_A.HasErrors = val11;
               Assert.AreEqual(val11, docTemplate_A.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               docTemplate_A.ValidationResults = val36;
               Assert.AreEqual(val36, docTemplate_A.ValidationResults);
        }
        [TestMethod]
        public void DocTemplate_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               docTemplate_B.DocTemplateReportTest = val1;
               Assert.AreEqual(val1, docTemplate_B.DocTemplateReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               docTemplate_B.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, docTemplate_B.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               docTemplate_B.LanguageText = val3;
               Assert.AreEqual(val3, docTemplate_B.LanguageText);
               string val4 = "Some text";
               docTemplate_B.TVTypeText = val4;
               Assert.AreEqual(val4, docTemplate_B.TVTypeText);
               int val5 = 45;
               docTemplate_B.DocTemplateID = val5;
               Assert.AreEqual(val5, docTemplate_B.DocTemplateID);
               LanguageEnum val6 = (LanguageEnum)3;
               docTemplate_B.Language = val6;
               Assert.AreEqual(val6, docTemplate_B.Language);
               TVTypeEnum val7 = (TVTypeEnum)3;
               docTemplate_B.TVType = val7;
               Assert.AreEqual(val7, docTemplate_B.TVType);
               int val8 = 45;
               docTemplate_B.TVFileTVItemID = val8;
               Assert.AreEqual(val8, docTemplate_B.TVFileTVItemID);
               string val9 = "Some text";
               docTemplate_B.FileName = val9;
               Assert.AreEqual(val9, docTemplate_B.FileName);
               DateTime val10 = new DateTime(2010, 3, 4);
               docTemplate_B.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, docTemplate_B.LastUpdateDate_UTC);
               int val11 = 45;
               docTemplate_B.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, docTemplate_B.LastUpdateContactTVItemID);
               bool val12 = true;
               docTemplate_B.HasErrors = val12;
               Assert.AreEqual(val12, docTemplate_B.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               docTemplate_B.ValidationResults = val39;
               Assert.AreEqual(val39, docTemplate_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
