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
    public partial class ContactTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private Contact contact { get; set; }
        private Contact_A contact_A { get; set; }
        private Contact_B contact_B { get; set; }
        #endregion Properties

        #region Constructors
        public ContactTest()
        {
            contact = new Contact();
            contact_A = new Contact_A();
            contact_B = new Contact_B();
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
        public void Contact_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactTVItemLanguage", "LastUpdateContactTVItemLanguage", "ParentTVItemID", "ContactTitleText", "ContactID", "Id", "ContactTVItemID", "LoginEmail", "FirstName", "LastName", "Initial", "WebName", "ContactTitle", "IsAdmin", "EmailValidated", "Disabled", "IsNew", "SamplingPlanner_ProvincesTVItemID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Contact_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(Contact_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Contact_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactReportTest", "ContactTVItemLanguage", "LastUpdateContactTVItemLanguage", "ParentTVItemID", "ContactTitleText", "ContactID", "Id", "ContactTVItemID", "LoginEmail", "FirstName", "LastName", "Initial", "WebName", "ContactTitle", "IsAdmin", "EmailValidated", "Disabled", "IsNew", "SamplingPlanner_ProvincesTVItemID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Contact_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(Contact_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Contact_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Contact_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Contact_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Contact_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Contact_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Contact_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Contact_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Contact_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Contact_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Contact_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               IEnumerable<ValidationResult> val54 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               contact.ValidationResults = val54;
               Assert.AreEqual(val54, contact.ValidationResults);
        }
        [TestMethod]
        public void Contact_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               contact_A.ContactTVItemLanguage = val1;
               Assert.AreEqual(val1, contact_A.ContactTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               contact_A.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, contact_A.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               contact_A.ParentTVItemID = val3;
               Assert.AreEqual(val3, contact_A.ParentTVItemID);
               string val4 = "Some text";
               contact_A.ContactTitleText = val4;
               Assert.AreEqual(val4, contact_A.ContactTitleText);
               int val5 = 45;
               contact_A.ContactID = val5;
               Assert.AreEqual(val5, contact_A.ContactID);
               string val6 = "Some text";
               contact_A.Id = val6;
               Assert.AreEqual(val6, contact_A.Id);
               int val7 = 45;
               contact_A.ContactTVItemID = val7;
               Assert.AreEqual(val7, contact_A.ContactTVItemID);
               string val8 = "Some text";
               contact_A.LoginEmail = val8;
               Assert.AreEqual(val8, contact_A.LoginEmail);
               string val9 = "Some text";
               contact_A.FirstName = val9;
               Assert.AreEqual(val9, contact_A.FirstName);
               string val10 = "Some text";
               contact_A.LastName = val10;
               Assert.AreEqual(val10, contact_A.LastName);
               string val11 = "Some text";
               contact_A.Initial = val11;
               Assert.AreEqual(val11, contact_A.Initial);
               string val12 = "Some text";
               contact_A.WebName = val12;
               Assert.AreEqual(val12, contact_A.WebName);
               ContactTitleEnum val13 = (ContactTitleEnum)3;
               contact_A.ContactTitle = val13;
               Assert.AreEqual(val13, contact_A.ContactTitle);
               bool val14 = true;
               contact_A.IsAdmin = val14;
               Assert.AreEqual(val14, contact_A.IsAdmin);
               bool val15 = true;
               contact_A.EmailValidated = val15;
               Assert.AreEqual(val15, contact_A.EmailValidated);
               bool val16 = true;
               contact_A.Disabled = val16;
               Assert.AreEqual(val16, contact_A.Disabled);
               bool val17 = true;
               contact_A.IsNew = val17;
               Assert.AreEqual(val17, contact_A.IsNew);
               string val18 = "Some text";
               contact_A.SamplingPlanner_ProvincesTVItemID = val18;
               Assert.AreEqual(val18, contact_A.SamplingPlanner_ProvincesTVItemID);
               DateTime val19 = new DateTime(2010, 3, 4);
               contact_A.LastUpdateDate_UTC = val19;
               Assert.AreEqual(val19, contact_A.LastUpdateDate_UTC);
               int val20 = 45;
               contact_A.LastUpdateContactTVItemID = val20;
               Assert.AreEqual(val20, contact_A.LastUpdateContactTVItemID);
               bool val21 = true;
               contact_A.HasErrors = val21;
               Assert.AreEqual(val21, contact_A.HasErrors);
               IEnumerable<ValidationResult> val66 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               contact_A.ValidationResults = val66;
               Assert.AreEqual(val66, contact_A.ValidationResults);
        }
        [TestMethod]
        public void Contact_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               contact_B.ContactReportTest = val1;
               Assert.AreEqual(val1, contact_B.ContactReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               contact_B.ContactTVItemLanguage = val2;
               Assert.AreEqual(val2, contact_B.ContactTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               contact_B.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, contact_B.LastUpdateContactTVItemLanguage);
               int val4 = 45;
               contact_B.ParentTVItemID = val4;
               Assert.AreEqual(val4, contact_B.ParentTVItemID);
               string val5 = "Some text";
               contact_B.ContactTitleText = val5;
               Assert.AreEqual(val5, contact_B.ContactTitleText);
               int val6 = 45;
               contact_B.ContactID = val6;
               Assert.AreEqual(val6, contact_B.ContactID);
               string val7 = "Some text";
               contact_B.Id = val7;
               Assert.AreEqual(val7, contact_B.Id);
               int val8 = 45;
               contact_B.ContactTVItemID = val8;
               Assert.AreEqual(val8, contact_B.ContactTVItemID);
               string val9 = "Some text";
               contact_B.LoginEmail = val9;
               Assert.AreEqual(val9, contact_B.LoginEmail);
               string val10 = "Some text";
               contact_B.FirstName = val10;
               Assert.AreEqual(val10, contact_B.FirstName);
               string val11 = "Some text";
               contact_B.LastName = val11;
               Assert.AreEqual(val11, contact_B.LastName);
               string val12 = "Some text";
               contact_B.Initial = val12;
               Assert.AreEqual(val12, contact_B.Initial);
               string val13 = "Some text";
               contact_B.WebName = val13;
               Assert.AreEqual(val13, contact_B.WebName);
               ContactTitleEnum val14 = (ContactTitleEnum)3;
               contact_B.ContactTitle = val14;
               Assert.AreEqual(val14, contact_B.ContactTitle);
               bool val15 = true;
               contact_B.IsAdmin = val15;
               Assert.AreEqual(val15, contact_B.IsAdmin);
               bool val16 = true;
               contact_B.EmailValidated = val16;
               Assert.AreEqual(val16, contact_B.EmailValidated);
               bool val17 = true;
               contact_B.Disabled = val17;
               Assert.AreEqual(val17, contact_B.Disabled);
               bool val18 = true;
               contact_B.IsNew = val18;
               Assert.AreEqual(val18, contact_B.IsNew);
               string val19 = "Some text";
               contact_B.SamplingPlanner_ProvincesTVItemID = val19;
               Assert.AreEqual(val19, contact_B.SamplingPlanner_ProvincesTVItemID);
               DateTime val20 = new DateTime(2010, 3, 4);
               contact_B.LastUpdateDate_UTC = val20;
               Assert.AreEqual(val20, contact_B.LastUpdateDate_UTC);
               int val21 = 45;
               contact_B.LastUpdateContactTVItemID = val21;
               Assert.AreEqual(val21, contact_B.LastUpdateContactTVItemID);
               bool val22 = true;
               contact_B.HasErrors = val22;
               Assert.AreEqual(val22, contact_B.HasErrors);
               IEnumerable<ValidationResult> val69 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               contact_B.ValidationResults = val69;
               Assert.AreEqual(val69, contact_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
