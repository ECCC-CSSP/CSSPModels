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
    public partial class ClassificationTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private Classification classification { get; set; }
        #endregion Properties

        #region Constructors
        public ClassificationTest()
        {
            classification = new Classification();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void Classification_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ClassificationID", "ClassificationTVItemID", "ClassificationType", "Ordinal", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "ClassificationWeb", "ClassificationReport", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.Classification).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(Classification).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Classification_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Classification).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Classification).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Classification_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Classification).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Classification_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.ClassificationClassificationID);
               Assert.IsNotNull(CSSPModelsRes.ClassificationClassificationTVItemID);
               Assert.IsNotNull(CSSPModelsRes.ClassificationClassificationType);
               Assert.IsNotNull(CSSPModelsRes.ClassificationOrdinal);
               Assert.IsNotNull(CSSPModelsRes.ClassificationLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.ClassificationLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.ClassificationHasErrors);
        }
        [TestMethod]
        public void Classification_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               classification.ClassificationID = val1;
               Assert.AreEqual(val1, classification.ClassificationID);
               int val2 = 45;
               classification.ClassificationTVItemID = val2;
               Assert.AreEqual(val2, classification.ClassificationTVItemID);
               ClassificationTypeEnum val3 = (ClassificationTypeEnum)3;
               classification.ClassificationType = val3;
               Assert.AreEqual(val3, classification.ClassificationType);
               int val4 = 45;
               classification.Ordinal = val4;
               Assert.AreEqual(val4, classification.Ordinal);
               DateTime val5 = new DateTime(2010, 3, 4);
               classification.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, classification.LastUpdateDate_UTC);
               int val6 = 45;
               classification.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, classification.LastUpdateContactTVItemID);
               bool val7 = true;
               classification.HasErrors = val7;
               Assert.AreEqual(val7, classification.HasErrors);
               IEnumerable<ValidationResult> val28 = new List<ValidationResult>().AsEnumerable();
               classification.ValidationResults = val28;
               Assert.AreEqual(val28, classification.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
