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
    public partial class TVItemLinkTest : SetupData
    {
        [TestMethod]
        public void TVItemLink_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemLinkID", "FromTVItemID", "ToTVItemID", "FromTVType", "ToTVType", "StartDateTime_Local", "EndDateTime_Local", "Ordinal", "TVLevel", "TVPath", "ParentTVItemLinkID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "FromTVText", "ToTVText", "LastUpdateContactTVText", "FromTVTypeText", "ToTVTypeText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.TVItemLink).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVItemLink).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemLink_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLink).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLink).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemLink_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemLink).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemLink_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVItemLinkTVItemLinkID);
               Assert.IsNotNull(ModelsRes.TVItemLinkFromTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemLinkToTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemLinkFromTVType);
               Assert.IsNotNull(ModelsRes.TVItemLinkToTVType);
               Assert.IsNotNull(ModelsRes.TVItemLinkStartDateTime_Local);
               Assert.IsNotNull(ModelsRes.TVItemLinkEndDateTime_Local);
               Assert.IsNotNull(ModelsRes.TVItemLinkOrdinal);
               Assert.IsNotNull(ModelsRes.TVItemLinkTVLevel);
               Assert.IsNotNull(ModelsRes.TVItemLinkTVPath);
               Assert.IsNotNull(ModelsRes.TVItemLinkParentTVItemLinkID);
               Assert.IsNotNull(ModelsRes.TVItemLinkLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.TVItemLinkLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemLinkFromTVText);
               Assert.IsNotNull(ModelsRes.TVItemLinkToTVText);
               Assert.IsNotNull(ModelsRes.TVItemLinkLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.TVItemLinkFromTVTypeText);
               Assert.IsNotNull(ModelsRes.TVItemLinkToTVTypeText);
               Assert.IsNotNull(ModelsRes.TVItemLinkHasErrors);
        }
        [TestMethod]
        public void TVItemLink_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tVItemLink.TVItemLinkID = val1;
               Assert.AreEqual(val1, tVItemLink.TVItemLinkID);
               int val2 = 45;
               tVItemLink.FromTVItemID = val2;
               Assert.AreEqual(val2, tVItemLink.FromTVItemID);
               int val3 = 45;
               tVItemLink.ToTVItemID = val3;
               Assert.AreEqual(val3, tVItemLink.ToTVItemID);
               TVTypeEnum val4 = (TVTypeEnum)3;
               tVItemLink.FromTVType = val4;
               Assert.AreEqual(val4, tVItemLink.FromTVType);
               TVTypeEnum val5 = (TVTypeEnum)3;
               tVItemLink.ToTVType = val5;
               Assert.AreEqual(val5, tVItemLink.ToTVType);
               DateTime val6 = new DateTime(2010, 3, 4);
               tVItemLink.StartDateTime_Local = val6;
               Assert.AreEqual(val6, tVItemLink.StartDateTime_Local);
               DateTime val7 = new DateTime(2010, 3, 4);
               tVItemLink.EndDateTime_Local = val7;
               Assert.AreEqual(val7, tVItemLink.EndDateTime_Local);
               int val8 = 45;
               tVItemLink.Ordinal = val8;
               Assert.AreEqual(val8, tVItemLink.Ordinal);
               int val9 = 45;
               tVItemLink.TVLevel = val9;
               Assert.AreEqual(val9, tVItemLink.TVLevel);
               string val10 = "Some text";
               tVItemLink.TVPath = val10;
               Assert.AreEqual(val10, tVItemLink.TVPath);
               int val11 = 45;
               tVItemLink.ParentTVItemLinkID = val11;
               Assert.AreEqual(val11, tVItemLink.ParentTVItemLinkID);
               DateTime val12 = new DateTime(2010, 3, 4);
               tVItemLink.LastUpdateDate_UTC = val12;
               Assert.AreEqual(val12, tVItemLink.LastUpdateDate_UTC);
               int val13 = 45;
               tVItemLink.LastUpdateContactTVItemID = val13;
               Assert.AreEqual(val13, tVItemLink.LastUpdateContactTVItemID);
               string val14 = "Some text";
               tVItemLink.FromTVText = val14;
               Assert.AreEqual(val14, tVItemLink.FromTVText);
               string val15 = "Some text";
               tVItemLink.ToTVText = val15;
               Assert.AreEqual(val15, tVItemLink.ToTVText);
               string val16 = "Some text";
               tVItemLink.LastUpdateContactTVText = val16;
               Assert.AreEqual(val16, tVItemLink.LastUpdateContactTVText);
               string val17 = "Some text";
               tVItemLink.FromTVTypeText = val17;
               Assert.AreEqual(val17, tVItemLink.FromTVTypeText);
               string val18 = "Some text";
               tVItemLink.ToTVTypeText = val18;
               Assert.AreEqual(val18, tVItemLink.ToTVTypeText);
               bool val19 = true;
               tVItemLink.HasErrors = val19;
               Assert.AreEqual(val19, tVItemLink.HasErrors);
               IEnumerable<ValidationResult> val60 = new List<ValidationResult>().AsEnumerable();
               tVItemLink.ValidationResults = val60;
               Assert.AreEqual(val60, tVItemLink.ValidationResults);
        }
    }
}
