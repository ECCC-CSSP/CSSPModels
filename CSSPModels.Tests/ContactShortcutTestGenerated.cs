/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 28 01:58
 * by Charles on CHARLES-PC machine
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
    public partial class ContactShortcutTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private ContactShortcut contactShortcut { get; set; }
        #endregion Properties

        #region Constructors
        public ContactShortcutTest()
        {
            contactShortcut = new ContactShortcut();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void ContactShortcut_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactShortcutID", "ContactID", "ShortCutText", "ShortCutAddress", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "ContactShortcutWeb", "ContactShortcutReport", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.ContactShortcut).GetProperties().OrderBy(c => c.Name))
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
        public void ContactShortcut_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ContactShortcut).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ContactShortcut_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.ContactShortcutContactShortcutID);
               Assert.IsNotNull(CSSPModelsRes.ContactShortcutContactID);
               Assert.IsNotNull(CSSPModelsRes.ContactShortcutShortCutText);
               Assert.IsNotNull(CSSPModelsRes.ContactShortcutShortCutAddress);
               Assert.IsNotNull(CSSPModelsRes.ContactShortcutLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.ContactShortcutLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.ContactShortcutHasErrors);
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
               IEnumerable<ValidationResult> val28 = new List<ValidationResult>().AsEnumerable();
               contactShortcut.ValidationResults = val28;
               Assert.AreEqual(val28, contactShortcut.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
