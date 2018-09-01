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
    public partial class EmailTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private Email email { get; set; }
        private Email_A email_A { get; set; }
        private Email_B email_B { get; set; }
        #endregion Properties

        #region Constructors
        public EmailTest()
        {
            email = new Email();
            email_A = new Email_A();
            email_B = new Email_B();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void Email_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "EmailID", "EmailTVItemID", "EmailAddress", "EmailType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Email).GetProperties().OrderBy(c => c.Name))
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
        public void Email_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "EmailTVItemLanguage", "LastUpdateContactTVItemLanguage", "EmailTypeText", "EmailID", "EmailTVItemID", "EmailAddress", "EmailType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Email_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(Email_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Email_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "EmailReportTest", "EmailTVItemLanguage", "LastUpdateContactTVItemLanguage", "EmailTypeText", "EmailID", "EmailTVItemID", "EmailAddress", "EmailType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Email_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(Email_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Email_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Email_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Email_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Email_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Email_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Email_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Email_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Email_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Email_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Email_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               email.ValidationResults = val24;
               Assert.AreEqual(val24, email.ValidationResults);
        }
        [TestMethod]
        public void Email_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               email_A.EmailTVItemLanguage = val1;
               Assert.AreEqual(val1, email_A.EmailTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               email_A.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, email_A.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               email_A.EmailTypeText = val3;
               Assert.AreEqual(val3, email_A.EmailTypeText);
               int val4 = 45;
               email_A.EmailID = val4;
               Assert.AreEqual(val4, email_A.EmailID);
               int val5 = 45;
               email_A.EmailTVItemID = val5;
               Assert.AreEqual(val5, email_A.EmailTVItemID);
               string val6 = "Some text";
               email_A.EmailAddress = val6;
               Assert.AreEqual(val6, email_A.EmailAddress);
               EmailTypeEnum val7 = (EmailTypeEnum)3;
               email_A.EmailType = val7;
               Assert.AreEqual(val7, email_A.EmailType);
               DateTime val8 = new DateTime(2010, 3, 4);
               email_A.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, email_A.LastUpdateDate_UTC);
               int val9 = 45;
               email_A.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, email_A.LastUpdateContactTVItemID);
               bool val10 = true;
               email_A.HasErrors = val10;
               Assert.AreEqual(val10, email_A.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               email_A.ValidationResults = val33;
               Assert.AreEqual(val33, email_A.ValidationResults);
        }
        [TestMethod]
        public void Email_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               email_B.EmailReportTest = val1;
               Assert.AreEqual(val1, email_B.EmailReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               email_B.EmailTVItemLanguage = val2;
               Assert.AreEqual(val2, email_B.EmailTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               email_B.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, email_B.LastUpdateContactTVItemLanguage);
               string val4 = "Some text";
               email_B.EmailTypeText = val4;
               Assert.AreEqual(val4, email_B.EmailTypeText);
               int val5 = 45;
               email_B.EmailID = val5;
               Assert.AreEqual(val5, email_B.EmailID);
               int val6 = 45;
               email_B.EmailTVItemID = val6;
               Assert.AreEqual(val6, email_B.EmailTVItemID);
               string val7 = "Some text";
               email_B.EmailAddress = val7;
               Assert.AreEqual(val7, email_B.EmailAddress);
               EmailTypeEnum val8 = (EmailTypeEnum)3;
               email_B.EmailType = val8;
               Assert.AreEqual(val8, email_B.EmailType);
               DateTime val9 = new DateTime(2010, 3, 4);
               email_B.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, email_B.LastUpdateDate_UTC);
               int val10 = 45;
               email_B.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, email_B.LastUpdateContactTVItemID);
               bool val11 = true;
               email_B.HasErrors = val11;
               Assert.AreEqual(val11, email_B.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               email_B.ValidationResults = val36;
               Assert.AreEqual(val36, email_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
