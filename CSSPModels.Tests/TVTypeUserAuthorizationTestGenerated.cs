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
    public partial class TVTypeUserAuthorizationTest : SetupData
    {
        [TestMethod]
        public void TVTypeUserAuthorization_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVTypeUserAuthorizationID", "ContactTVItemID", "TVType", "TVAuth", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "ContactTVText", "LastUpdateContactTVText", "TVTypeText", "TVAuthText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.TVTypeUserAuthorization).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorization).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVTypeUserAuthorization_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorization).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorization).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVTypeUserAuthorization_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVTypeUserAuthorization).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVTypeUserAuthorization_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVTypeUserAuthorizationTVTypeUserAuthorizationID);
               Assert.IsNotNull(ModelsRes.TVTypeUserAuthorizationContactTVItemID);
               Assert.IsNotNull(ModelsRes.TVTypeUserAuthorizationTVType);
               Assert.IsNotNull(ModelsRes.TVTypeUserAuthorizationTVAuth);
               Assert.IsNotNull(ModelsRes.TVTypeUserAuthorizationLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.TVTypeUserAuthorizationLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.TVTypeUserAuthorizationContactTVText);
               Assert.IsNotNull(ModelsRes.TVTypeUserAuthorizationLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.TVTypeUserAuthorizationTVTypeText);
               Assert.IsNotNull(ModelsRes.TVTypeUserAuthorizationTVAuthText);
               Assert.IsNotNull(ModelsRes.TVTypeUserAuthorizationHasErrors);
        }
        [TestMethod]
        public void TVTypeUserAuthorization_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tVTypeUserAuthorization.TVTypeUserAuthorizationID = val1;
               Assert.AreEqual(val1, tVTypeUserAuthorization.TVTypeUserAuthorizationID);
               int val2 = 45;
               tVTypeUserAuthorization.ContactTVItemID = val2;
               Assert.AreEqual(val2, tVTypeUserAuthorization.ContactTVItemID);
               TVTypeEnum val3 = (TVTypeEnum)3;
               tVTypeUserAuthorization.TVType = val3;
               Assert.AreEqual(val3, tVTypeUserAuthorization.TVType);
               TVAuthEnum val4 = (TVAuthEnum)3;
               tVTypeUserAuthorization.TVAuth = val4;
               Assert.AreEqual(val4, tVTypeUserAuthorization.TVAuth);
               DateTime val5 = new DateTime(2010, 3, 4);
               tVTypeUserAuthorization.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, tVTypeUserAuthorization.LastUpdateDate_UTC);
               int val6 = 45;
               tVTypeUserAuthorization.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, tVTypeUserAuthorization.LastUpdateContactTVItemID);
               string val7 = "Some text";
               tVTypeUserAuthorization.ContactTVText = val7;
               Assert.AreEqual(val7, tVTypeUserAuthorization.ContactTVText);
               string val8 = "Some text";
               tVTypeUserAuthorization.LastUpdateContactTVText = val8;
               Assert.AreEqual(val8, tVTypeUserAuthorization.LastUpdateContactTVText);
               string val9 = "Some text";
               tVTypeUserAuthorization.TVTypeText = val9;
               Assert.AreEqual(val9, tVTypeUserAuthorization.TVTypeText);
               string val10 = "Some text";
               tVTypeUserAuthorization.TVAuthText = val10;
               Assert.AreEqual(val10, tVTypeUserAuthorization.TVAuthText);
               bool val11 = true;
               tVTypeUserAuthorization.HasErrors = val11;
               Assert.AreEqual(val11, tVTypeUserAuthorization.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>().AsEnumerable();
               tVTypeUserAuthorization.ValidationResults = val36;
               Assert.AreEqual(val36, tVTypeUserAuthorization.ValidationResults);
        }
    }
}
