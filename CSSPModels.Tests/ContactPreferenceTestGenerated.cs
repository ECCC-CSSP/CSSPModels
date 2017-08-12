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
    public partial class ContactPreferenceTest : SetupData
    {
        [TestMethod]
        public void ContactPreference_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactPreferenceID", "ContactID", "TVType", "MarkerSize", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "TVTypeText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.ContactPreference).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ContactPreference).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactPreference_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactPreference).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactPreference).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactPreference_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ContactPreference).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ContactPreference_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.ContactPreferenceContactPreferenceID);
               Assert.IsNotNull(ModelsRes.ContactPreferenceContactID);
               Assert.IsNotNull(ModelsRes.ContactPreferenceTVType);
               Assert.IsNotNull(ModelsRes.ContactPreferenceMarkerSize);
               Assert.IsNotNull(ModelsRes.ContactPreferenceLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.ContactPreferenceLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.ContactPreferenceLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.ContactPreferenceTVTypeText);
               Assert.IsNotNull(ModelsRes.ContactPreferenceHasErrors);
        }
        [TestMethod]
        public void ContactPreference_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               contactPreference.ContactPreferenceID = val1;
               Assert.AreEqual(val1, contactPreference.ContactPreferenceID);
               int val2 = 45;
               contactPreference.ContactID = val2;
               Assert.AreEqual(val2, contactPreference.ContactID);
               TVTypeEnum val3 = (TVTypeEnum)3;
               contactPreference.TVType = val3;
               Assert.AreEqual(val3, contactPreference.TVType);
               int val4 = 45;
               contactPreference.MarkerSize = val4;
               Assert.AreEqual(val4, contactPreference.MarkerSize);
               DateTime val5 = new DateTime(2010, 3, 4);
               contactPreference.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, contactPreference.LastUpdateDate_UTC);
               int val6 = 45;
               contactPreference.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, contactPreference.LastUpdateContactTVItemID);
               string val7 = "Some text";
               contactPreference.LastUpdateContactTVText = val7;
               Assert.AreEqual(val7, contactPreference.LastUpdateContactTVText);
               string val8 = "Some text";
               contactPreference.TVTypeText = val8;
               Assert.AreEqual(val8, contactPreference.TVTypeText);
               bool val9 = true;
               contactPreference.HasErrors = val9;
               Assert.AreEqual(val9, contactPreference.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>().AsEnumerable();
               contactPreference.ValidationResults = val30;
               Assert.AreEqual(val30, contactPreference.ValidationResults);
        }
    }
}
