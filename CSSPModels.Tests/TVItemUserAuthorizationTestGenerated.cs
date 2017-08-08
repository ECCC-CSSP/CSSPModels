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
    public partial class TVItemUserAuthorizationTest : SetupData
    {
        [TestMethod]
        public void TVItemUserAuthorization_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemUserAuthorizationID", "ContactTVItemID", "TVItemID1", "TVItemID2", "TVItemID3", "TVItemID4", "TVAuth", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "ContactTVText", "TVText1", "TVText2", "TVText3", "TVText4", "LastUpdateContactTVText", "TVAuthText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.TVItemUserAuthorization).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVItemUserAuthorization).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemUserAuthorization_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemUserAuthorization).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemUserAuthorization).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemUserAuthorization_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemUserAuthorization).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemUserAuthorization_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVItemUserAuthorizationID);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationContactTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVItemID1);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVItemID2);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVItemID3);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVItemID4);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVAuth);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationContactTVText);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVText1);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVText2);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVText3);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVText4);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.TVItemUserAuthorizationTVAuthText);
        }
        [TestMethod]
        public void TVItemUserAuthorization_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tVItemUserAuthorization.TVItemUserAuthorizationID = val1;
               Assert.AreEqual(val1, tVItemUserAuthorization.TVItemUserAuthorizationID);
               int val2 = 45;
               tVItemUserAuthorization.ContactTVItemID = val2;
               Assert.AreEqual(val2, tVItemUserAuthorization.ContactTVItemID);
               int val3 = 45;
               tVItemUserAuthorization.TVItemID1 = val3;
               Assert.AreEqual(val3, tVItemUserAuthorization.TVItemID1);
               int val4 = 45;
               tVItemUserAuthorization.TVItemID2 = val4;
               Assert.AreEqual(val4, tVItemUserAuthorization.TVItemID2);
               int val5 = 45;
               tVItemUserAuthorization.TVItemID3 = val5;
               Assert.AreEqual(val5, tVItemUserAuthorization.TVItemID3);
               int val6 = 45;
               tVItemUserAuthorization.TVItemID4 = val6;
               Assert.AreEqual(val6, tVItemUserAuthorization.TVItemID4);
               TVAuthEnum val7 = (TVAuthEnum)3;
               tVItemUserAuthorization.TVAuth = val7;
               Assert.AreEqual(val7, tVItemUserAuthorization.TVAuth);
               DateTime val8 = new DateTime(2010, 3, 4);
               tVItemUserAuthorization.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, tVItemUserAuthorization.LastUpdateDate_UTC);
               int val9 = 45;
               tVItemUserAuthorization.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, tVItemUserAuthorization.LastUpdateContactTVItemID);
               string val10 = "Some text";
               tVItemUserAuthorization.ContactTVText = val10;
               Assert.AreEqual(val10, tVItemUserAuthorization.ContactTVText);
               string val11 = "Some text";
               tVItemUserAuthorization.TVText1 = val11;
               Assert.AreEqual(val11, tVItemUserAuthorization.TVText1);
               string val12 = "Some text";
               tVItemUserAuthorization.TVText2 = val12;
               Assert.AreEqual(val12, tVItemUserAuthorization.TVText2);
               string val13 = "Some text";
               tVItemUserAuthorization.TVText3 = val13;
               Assert.AreEqual(val13, tVItemUserAuthorization.TVText3);
               string val14 = "Some text";
               tVItemUserAuthorization.TVText4 = val14;
               Assert.AreEqual(val14, tVItemUserAuthorization.TVText4);
               string val15 = "Some text";
               tVItemUserAuthorization.LastUpdateContactTVText = val15;
               Assert.AreEqual(val15, tVItemUserAuthorization.LastUpdateContactTVText);
               string val16 = "Some text";
               tVItemUserAuthorization.TVAuthText = val16;
               Assert.AreEqual(val16, tVItemUserAuthorization.TVAuthText);
               IEnumerable<ValidationResult> val51 = new List<ValidationResult>().AsEnumerable();
               tVItemUserAuthorization.ValidationResults = val51;
               Assert.AreEqual(val51, tVItemUserAuthorization.ValidationResults);
        }
    }
}
