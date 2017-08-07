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
    public partial class TVItemInfrastructureTypeTVItemLinkTest : SetupData
    {
        [TestMethod]
        public void TVItemInfrastructureTypeTVItemLink_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "InfrastructureType", "SeeOtherTVItemID", "InfrastructureTypeText", "TVItem", "TVItemLinkList", "FlowTo",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemInfrastructureTypeTVItemLink).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void TVItemInfrastructureTypeTVItemLink_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemInfrastructureTypeTVItemLink).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemInfrastructureTypeTVItemLink_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVItemInfrastructureTypeTVItemLinkInfrastructureType);
               Assert.IsNotNull(ModelsRes.TVItemInfrastructureTypeTVItemLinkSeeOtherTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemInfrastructureTypeTVItemLinkInfrastructureTypeText);
               Assert.IsNotNull(ModelsRes.TVItemInfrastructureTypeTVItemLinkTVItem);
               Assert.IsNotNull(ModelsRes.TVItemInfrastructureTypeTVItemLinkTVItemLinkList);
               Assert.IsNotNull(ModelsRes.TVItemInfrastructureTypeTVItemLinkFlowTo);
        }
        [TestMethod]
        public void TVItemInfrastructureTypeTVItemLink_Every_Property_Has_Get_Set_Test()
        {
               InfrastructureTypeEnum val1 = (InfrastructureTypeEnum)3;
               tVItemInfrastructureTypeTVItemLink.InfrastructureType = val1;
               Assert.AreEqual(val1, tVItemInfrastructureTypeTVItemLink.InfrastructureType);
               int val2 = 45;
               tVItemInfrastructureTypeTVItemLink.SeeOtherTVItemID = val2;
               Assert.AreEqual(val2, tVItemInfrastructureTypeTVItemLink.SeeOtherTVItemID);
               string val3 = "Some text";
               tVItemInfrastructureTypeTVItemLink.InfrastructureTypeText = val3;
               Assert.AreEqual(val3, tVItemInfrastructureTypeTVItemLink.InfrastructureTypeText);
               TVItem val11 = new TVItem();
               tVItemInfrastructureTypeTVItemLink.TVItem = val11;
               Assert.AreEqual(val11, tVItemInfrastructureTypeTVItemLink.TVItem);
               List<TVItemLink> val12 = new List<TVItemLink>();
               tVItemInfrastructureTypeTVItemLink.TVItemLinkList = val12;
               Assert.AreEqual(val12, tVItemInfrastructureTypeTVItemLink.TVItemLinkList);
               TVItemInfrastructureTypeTVItemLink val13 = new TVItemInfrastructureTypeTVItemLink();
               tVItemInfrastructureTypeTVItemLink.FlowTo = val13;
               Assert.AreEqual(val13, tVItemInfrastructureTypeTVItemLink.FlowTo);
               IEnumerable<ValidationResult> val21 = new List<ValidationResult>().AsEnumerable();
               tVItemInfrastructureTypeTVItemLink.ValidationResults = val21;
               Assert.AreEqual(val21, tVItemInfrastructureTypeTVItemLink.ValidationResults);
        }
    }
}
