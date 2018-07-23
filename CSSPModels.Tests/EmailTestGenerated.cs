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
    public partial class EmailTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private Email email { get; set; }
        #endregion Properties

        #region Constructors
        public EmailTest()
        {
            email = new Email();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void Email_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "EmailID", "EmailTVItemID", "EmailAddress", "EmailType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "EmailWeb", "EmailReport", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.Email).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(Email).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Email_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Email).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Email).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Email_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Email).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Email_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.EmailEmailID);
               Assert.IsNotNull(CSSPModelsRes.EmailEmailTVItemID);
               Assert.IsNotNull(CSSPModelsRes.EmailEmailAddress);
               Assert.IsNotNull(CSSPModelsRes.EmailEmailType);
               Assert.IsNotNull(CSSPModelsRes.EmailLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.EmailLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.EmailHasErrors);
        }
        [TestMethod]
        public void Email_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               email.EmailID = val1;
               Assert.AreEqual(val1, email.EmailID);
               int val2 = 45;
               email.EmailTVItemID = val2;
               Assert.AreEqual(val2, email.EmailTVItemID);
               string val3 = "Some text";
               email.EmailAddress = val3;
               Assert.AreEqual(val3, email.EmailAddress);
               EmailTypeEnum val4 = (EmailTypeEnum)3;
               email.EmailType = val4;
               Assert.AreEqual(val4, email.EmailType);
               DateTime val5 = new DateTime(2010, 3, 4);
               email.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, email.LastUpdateDate_UTC);
               int val6 = 45;
               email.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, email.LastUpdateContactTVItemID);
               bool val7 = true;
               email.HasErrors = val7;
               Assert.AreEqual(val7, email.HasErrors);
               IEnumerable<ValidationResult> val28 = new List<ValidationResult>().AsEnumerable();
               email.ValidationResults = val28;
               Assert.AreEqual(val28, email.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
