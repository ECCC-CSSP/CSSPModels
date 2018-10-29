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
    public partial class ContactTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private Contact contact { get; set; }
        private ContactExtraA contactExtraA { get; set; }
        private ContactExtraB contactExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public ContactTest()
        {
            contact = new Contact();
            contactExtraA = new ContactExtraA();
            contactExtraB = new ContactExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void Contact_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactID", "Id", "ContactTVItemID", "LoginEmail", "FirstName", "LastName", "Initial", "WebName", "ContactTitle", "IsAdmin", "EmailValidated", "Disabled", "IsNew", "SamplingPlanner_ProvincesTVItemID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Contact).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(Contact).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactName", "LastUpdateContactText", "ContactTitleText", "ContactID", "Id", "ContactTVItemID", "LoginEmail", "FirstName", "LastName", "Initial", "WebName", "ContactTitle", "IsAdmin", "EmailValidated", "Disabled", "IsNew", "SamplingPlanner_ProvincesTVItemID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ContactExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactReportTest", "ContactName", "LastUpdateContactText", "ContactTitleText", "ContactID", "Id", "ContactTVItemID", "LoginEmail", "FirstName", "LastName", "Initial", "WebName", "ContactTitle", "IsAdmin", "EmailValidated", "Disabled", "IsNew", "SamplingPlanner_ProvincesTVItemID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ContactExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Contact_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Contact).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Contact).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Contact_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Contact).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ContactExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ContactExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ContactExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ContactExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Contact_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               contact.ContactID = val1;
               Assert.AreEqual(val1, contact.ContactID);
               string val2 = "Some text";
               contact.Id = val2;
               Assert.AreEqual(val2, contact.Id);
               int val3 = 45;
               contact.ContactTVItemID = val3;
               Assert.AreEqual(val3, contact.ContactTVItemID);
               string val4 = "Some text";
               contact.LoginEmail = val4;
               Assert.AreEqual(val4, contact.LoginEmail);
               string val5 = "Some text";
               contact.FirstName = val5;
               Assert.AreEqual(val5, contact.FirstName);
               string val6 = "Some text";
               contact.LastName = val6;
               Assert.AreEqual(val6, contact.LastName);
               string val7 = "Some text";
               contact.Initial = val7;
               Assert.AreEqual(val7, contact.Initial);
               string val8 = "Some text";
               contact.WebName = val8;
               Assert.AreEqual(val8, contact.WebName);
               ContactTitleEnum val9 = (ContactTitleEnum)3;
               contact.ContactTitle = val9;
               Assert.AreEqual(val9, contact.ContactTitle);
               bool val10 = true;
               contact.IsAdmin = val10;
               Assert.AreEqual(val10, contact.IsAdmin);
               bool val11 = true;
               contact.EmailValidated = val11;
               Assert.AreEqual(val11, contact.EmailValidated);
               bool val12 = true;
               contact.Disabled = val12;
               Assert.AreEqual(val12, contact.Disabled);
               bool val13 = true;
               contact.IsNew = val13;
               Assert.AreEqual(val13, contact.IsNew);
               string val14 = "Some text";
               contact.SamplingPlanner_ProvincesTVItemID = val14;
               Assert.AreEqual(val14, contact.SamplingPlanner_ProvincesTVItemID);
               DateTime val15 = new DateTime(2010, 3, 4);
               contact.LastUpdateDate_UTC = val15;
               Assert.AreEqual(val15, contact.LastUpdateDate_UTC);
               int val16 = 45;
               contact.LastUpdateContactTVItemID = val16;
               Assert.AreEqual(val16, contact.LastUpdateContactTVItemID);
               bool val17 = true;
               contact.HasErrors = val17;
               Assert.AreEqual(val17, contact.HasErrors);
               IEnumerable<ValidationResult> val54 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               contact.ValidationResults = val54;
               Assert.AreEqual(val54, contact.ValidationResults);
        }
        [TestMethod]
        public void ContactExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               contactExtraA.ContactName = val1;
               Assert.AreEqual(val1, contactExtraA.ContactName);
               string val2 = "Some text";
               contactExtraA.LastUpdateContactText = val2;
               Assert.AreEqual(val2, contactExtraA.LastUpdateContactText);
               string val3 = "Some text";
               contactExtraA.ContactTitleText = val3;
               Assert.AreEqual(val3, contactExtraA.ContactTitleText);
               int val4 = 45;
               contactExtraA.ContactID = val4;
               Assert.AreEqual(val4, contactExtraA.ContactID);
               string val5 = "Some text";
               contactExtraA.Id = val5;
               Assert.AreEqual(val5, contactExtraA.Id);
               int val6 = 45;
               contactExtraA.ContactTVItemID = val6;
               Assert.AreEqual(val6, contactExtraA.ContactTVItemID);
               string val7 = "Some text";
               contactExtraA.LoginEmail = val7;
               Assert.AreEqual(val7, contactExtraA.LoginEmail);
               string val8 = "Some text";
               contactExtraA.FirstName = val8;
               Assert.AreEqual(val8, contactExtraA.FirstName);
               string val9 = "Some text";
               contactExtraA.LastName = val9;
               Assert.AreEqual(val9, contactExtraA.LastName);
               string val10 = "Some text";
               contactExtraA.Initial = val10;
               Assert.AreEqual(val10, contactExtraA.Initial);
               string val11 = "Some text";
               contactExtraA.WebName = val11;
               Assert.AreEqual(val11, contactExtraA.WebName);
               ContactTitleEnum val12 = (ContactTitleEnum)3;
               contactExtraA.ContactTitle = val12;
               Assert.AreEqual(val12, contactExtraA.ContactTitle);
               bool val13 = true;
               contactExtraA.IsAdmin = val13;
               Assert.AreEqual(val13, contactExtraA.IsAdmin);
               bool val14 = true;
               contactExtraA.EmailValidated = val14;
               Assert.AreEqual(val14, contactExtraA.EmailValidated);
               bool val15 = true;
               contactExtraA.Disabled = val15;
               Assert.AreEqual(val15, contactExtraA.Disabled);
               bool val16 = true;
               contactExtraA.IsNew = val16;
               Assert.AreEqual(val16, contactExtraA.IsNew);
               string val17 = "Some text";
               contactExtraA.SamplingPlanner_ProvincesTVItemID = val17;
               Assert.AreEqual(val17, contactExtraA.SamplingPlanner_ProvincesTVItemID);
               DateTime val18 = new DateTime(2010, 3, 4);
               contactExtraA.LastUpdateDate_UTC = val18;
               Assert.AreEqual(val18, contactExtraA.LastUpdateDate_UTC);
               int val19 = 45;
               contactExtraA.LastUpdateContactTVItemID = val19;
               Assert.AreEqual(val19, contactExtraA.LastUpdateContactTVItemID);
               bool val20 = true;
               contactExtraA.HasErrors = val20;
               Assert.AreEqual(val20, contactExtraA.HasErrors);
               IEnumerable<ValidationResult> val63 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               contactExtraA.ValidationResults = val63;
               Assert.AreEqual(val63, contactExtraA.ValidationResults);
        }
        [TestMethod]
        public void ContactExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               contactExtraB.ContactReportTest = val1;
               Assert.AreEqual(val1, contactExtraB.ContactReportTest);
               string val2 = "Some text";
               contactExtraB.ContactName = val2;
               Assert.AreEqual(val2, contactExtraB.ContactName);
               string val3 = "Some text";
               contactExtraB.LastUpdateContactText = val3;
               Assert.AreEqual(val3, contactExtraB.LastUpdateContactText);
               string val4 = "Some text";
               contactExtraB.ContactTitleText = val4;
               Assert.AreEqual(val4, contactExtraB.ContactTitleText);
               int val5 = 45;
               contactExtraB.ContactID = val5;
               Assert.AreEqual(val5, contactExtraB.ContactID);
               string val6 = "Some text";
               contactExtraB.Id = val6;
               Assert.AreEqual(val6, contactExtraB.Id);
               int val7 = 45;
               contactExtraB.ContactTVItemID = val7;
               Assert.AreEqual(val7, contactExtraB.ContactTVItemID);
               string val8 = "Some text";
               contactExtraB.LoginEmail = val8;
               Assert.AreEqual(val8, contactExtraB.LoginEmail);
               string val9 = "Some text";
               contactExtraB.FirstName = val9;
               Assert.AreEqual(val9, contactExtraB.FirstName);
               string val10 = "Some text";
               contactExtraB.LastName = val10;
               Assert.AreEqual(val10, contactExtraB.LastName);
               string val11 = "Some text";
               contactExtraB.Initial = val11;
               Assert.AreEqual(val11, contactExtraB.Initial);
               string val12 = "Some text";
               contactExtraB.WebName = val12;
               Assert.AreEqual(val12, contactExtraB.WebName);
               ContactTitleEnum val13 = (ContactTitleEnum)3;
               contactExtraB.ContactTitle = val13;
               Assert.AreEqual(val13, contactExtraB.ContactTitle);
               bool val14 = true;
               contactExtraB.IsAdmin = val14;
               Assert.AreEqual(val14, contactExtraB.IsAdmin);
               bool val15 = true;
               contactExtraB.EmailValidated = val15;
               Assert.AreEqual(val15, contactExtraB.EmailValidated);
               bool val16 = true;
               contactExtraB.Disabled = val16;
               Assert.AreEqual(val16, contactExtraB.Disabled);
               bool val17 = true;
               contactExtraB.IsNew = val17;
               Assert.AreEqual(val17, contactExtraB.IsNew);
               string val18 = "Some text";
               contactExtraB.SamplingPlanner_ProvincesTVItemID = val18;
               Assert.AreEqual(val18, contactExtraB.SamplingPlanner_ProvincesTVItemID);
               DateTime val19 = new DateTime(2010, 3, 4);
               contactExtraB.LastUpdateDate_UTC = val19;
               Assert.AreEqual(val19, contactExtraB.LastUpdateDate_UTC);
               int val20 = 45;
               contactExtraB.LastUpdateContactTVItemID = val20;
               Assert.AreEqual(val20, contactExtraB.LastUpdateContactTVItemID);
               bool val21 = true;
               contactExtraB.HasErrors = val21;
               Assert.AreEqual(val21, contactExtraB.HasErrors);
               IEnumerable<ValidationResult> val66 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               contactExtraB.ValidationResults = val66;
               Assert.AreEqual(val66, contactExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
