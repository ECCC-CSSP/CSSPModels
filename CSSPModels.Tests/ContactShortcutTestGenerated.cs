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
    public partial class ContactShortcutTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private ContactShortcut contactShortcut { get; set; }
        private ContactShortcutExtraA contactShortcutExtraA { get; set; }
        private ContactShortcutExtraB contactShortcutExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public ContactShortcutTest()
        {
            contactShortcut = new ContactShortcut();
            contactShortcutExtraA = new ContactShortcutExtraA();
            contactShortcutExtraB = new ContactShortcutExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void ContactShortcut_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactShortcutID", "ContactID", "ShortCutText", "ShortCutAddress", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactShortcut).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ContactShortcut).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactShortcutExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactText", "ContactShortcutID", "ContactID", "ShortCutText", "ShortCutAddress", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactShortcutExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ContactShortcutExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactShortcutExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactShortcutReportTest", "LastUpdateContactText", "ContactShortcutID", "ContactID", "ShortCutText", "ShortCutAddress", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactShortcutExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ContactShortcutExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactShortcut_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactShortcut).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactShortcut).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactShortcutExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactShortcutExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactShortcutExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactShortcutExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactShortcutExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactShortcutExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactShortcut_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ContactShortcut).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ContactShortcutExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ContactShortcutExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ContactShortcutExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ContactShortcutExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ContactShortcut_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               contactShortcut.ContactShortcutID = val1;
               Assert.AreEqual(val1, contactShortcut.ContactShortcutID);
               int val2 = 45;
               contactShortcut.ContactID = val2;
               Assert.AreEqual(val2, contactShortcut.ContactID);
               string val3 = "Some text";
               contactShortcut.ShortCutText = val3;
               Assert.AreEqual(val3, contactShortcut.ShortCutText);
               string val4 = "Some text";
               contactShortcut.ShortCutAddress = val4;
               Assert.AreEqual(val4, contactShortcut.ShortCutAddress);
               DateTime val5 = new DateTime(2010, 3, 4);
               contactShortcut.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, contactShortcut.LastUpdateDate_UTC);
               int val6 = 45;
               contactShortcut.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, contactShortcut.LastUpdateContactTVItemID);
               bool val7 = true;
               contactShortcut.HasErrors = val7;
               Assert.AreEqual(val7, contactShortcut.HasErrors);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               contactShortcut.ValidationResults = val24;
               Assert.AreEqual(val24, contactShortcut.ValidationResults);
        }
        [TestMethod]
        public void ContactShortcutExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               contactShortcutExtraA.LastUpdateContactText = val1;
               Assert.AreEqual(val1, contactShortcutExtraA.LastUpdateContactText);
               int val2 = 45;
               contactShortcutExtraA.ContactShortcutID = val2;
               Assert.AreEqual(val2, contactShortcutExtraA.ContactShortcutID);
               int val3 = 45;
               contactShortcutExtraA.ContactID = val3;
               Assert.AreEqual(val3, contactShortcutExtraA.ContactID);
               string val4 = "Some text";
               contactShortcutExtraA.ShortCutText = val4;
               Assert.AreEqual(val4, contactShortcutExtraA.ShortCutText);
               string val5 = "Some text";
               contactShortcutExtraA.ShortCutAddress = val5;
               Assert.AreEqual(val5, contactShortcutExtraA.ShortCutAddress);
               DateTime val6 = new DateTime(2010, 3, 4);
               contactShortcutExtraA.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, contactShortcutExtraA.LastUpdateDate_UTC);
               int val7 = 45;
               contactShortcutExtraA.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, contactShortcutExtraA.LastUpdateContactTVItemID);
               bool val8 = true;
               contactShortcutExtraA.HasErrors = val8;
               Assert.AreEqual(val8, contactShortcutExtraA.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               contactShortcutExtraA.ValidationResults = val27;
               Assert.AreEqual(val27, contactShortcutExtraA.ValidationResults);
        }
        [TestMethod]
        public void ContactShortcutExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               contactShortcutExtraB.ContactShortcutReportTest = val1;
               Assert.AreEqual(val1, contactShortcutExtraB.ContactShortcutReportTest);
               string val2 = "Some text";
               contactShortcutExtraB.LastUpdateContactText = val2;
               Assert.AreEqual(val2, contactShortcutExtraB.LastUpdateContactText);
               int val3 = 45;
               contactShortcutExtraB.ContactShortcutID = val3;
               Assert.AreEqual(val3, contactShortcutExtraB.ContactShortcutID);
               int val4 = 45;
               contactShortcutExtraB.ContactID = val4;
               Assert.AreEqual(val4, contactShortcutExtraB.ContactID);
               string val5 = "Some text";
               contactShortcutExtraB.ShortCutText = val5;
               Assert.AreEqual(val5, contactShortcutExtraB.ShortCutText);
               string val6 = "Some text";
               contactShortcutExtraB.ShortCutAddress = val6;
               Assert.AreEqual(val6, contactShortcutExtraB.ShortCutAddress);
               DateTime val7 = new DateTime(2010, 3, 4);
               contactShortcutExtraB.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, contactShortcutExtraB.LastUpdateDate_UTC);
               int val8 = 45;
               contactShortcutExtraB.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, contactShortcutExtraB.LastUpdateContactTVItemID);
               bool val9 = true;
               contactShortcutExtraB.HasErrors = val9;
               Assert.AreEqual(val9, contactShortcutExtraB.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               contactShortcutExtraB.ValidationResults = val30;
               Assert.AreEqual(val30, contactShortcutExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
