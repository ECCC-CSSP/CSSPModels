using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace CSSPModels.Tests
{
    public partial class InfrastructureTest
    {
        [TestMethod]
        public void Infrastructure_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "InfrastructureID", "InfrastructureTVItemID", "PrismID", "TPID", "LSID", "SiteID", "Site", "InfrastructureCategory", "InfrastructureType", "FacilityType", "IsMechanicallyAerated", "NumberOfCells", "NumberOfAeratedCells", "AerationType", "PreliminaryTreatmentType", "PrimaryTreatmentType", "SecondaryTreatmentType", "TertiaryTreatmentType", "TreatmentType", "DisinfectionType", "CollectionSystemType", "AlarmSystemType", "DesignFlow_m3_day", "AverageFlow_m3_day", "PeakFlow_m3_day", "PopServed", "CanOverflow", "PercFlowOfTotal", "TimeOffset_hour", "TempCatchAllRemoveLater", "AverageDepth_m", "NumberOfPorts", "PortDiameter_m", "PortSpacing_m", "PortElevation_m", "VerticalAngle_deg", "HorizontalAngle_deg", "DecayRate_per_day", "NearFieldVelocity_m_s", "FarFieldVelocity_m_s", "ReceivingWaterSalinity_PSU", "ReceivingWaterTemperature_C", "ReceivingWater_MPN_per_100ml", "DistanceFromShore_m", "SeeOtherTVItemID", "CivicAddressTVItemID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyType.Name);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Infrastructure).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Infrastructure_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "InfrastructureTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "InfrastructureLanguages",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))
            {
                Assert.AreEqual(foreignNameList[index], foreignName);
                index += 1;
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Infrastructure).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Infrastructure_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(Infrastructure).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Infrastructure_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.InfrastructureInfrastructureID);
               Assert.IsNotNull(ModelsRes.InfrastructureInfrastructureTVItemID);
               Assert.IsNotNull(ModelsRes.InfrastructurePrismID);
               Assert.IsNotNull(ModelsRes.InfrastructureTPID);
               Assert.IsNotNull(ModelsRes.InfrastructureLSID);
               Assert.IsNotNull(ModelsRes.InfrastructureSiteID);
               Assert.IsNotNull(ModelsRes.InfrastructureSite);
               Assert.IsNotNull(ModelsRes.InfrastructureInfrastructureCategory);
               Assert.IsNotNull(ModelsRes.InfrastructureInfrastructureType);
               Assert.IsNotNull(ModelsRes.InfrastructureFacilityType);
               Assert.IsNotNull(ModelsRes.InfrastructureIsMechanicallyAerated);
               Assert.IsNotNull(ModelsRes.InfrastructureNumberOfCells);
               Assert.IsNotNull(ModelsRes.InfrastructureNumberOfAeratedCells);
               Assert.IsNotNull(ModelsRes.InfrastructureAerationType);
               Assert.IsNotNull(ModelsRes.InfrastructurePreliminaryTreatmentType);
               Assert.IsNotNull(ModelsRes.InfrastructurePrimaryTreatmentType);
               Assert.IsNotNull(ModelsRes.InfrastructureSecondaryTreatmentType);
               Assert.IsNotNull(ModelsRes.InfrastructureTertiaryTreatmentType);
               Assert.IsNotNull(ModelsRes.InfrastructureTreatmentType);
               Assert.IsNotNull(ModelsRes.InfrastructureDisinfectionType);
               Assert.IsNotNull(ModelsRes.InfrastructureCollectionSystemType);
               Assert.IsNotNull(ModelsRes.InfrastructureAlarmSystemType);
               Assert.IsNotNull(ModelsRes.InfrastructureDesignFlow_m3_day);
               Assert.IsNotNull(ModelsRes.InfrastructureAverageFlow_m3_day);
               Assert.IsNotNull(ModelsRes.InfrastructurePeakFlow_m3_day);
               Assert.IsNotNull(ModelsRes.InfrastructurePopServed);
               Assert.IsNotNull(ModelsRes.InfrastructureCanOverflow);
               Assert.IsNotNull(ModelsRes.InfrastructurePercFlowOfTotal);
               Assert.IsNotNull(ModelsRes.InfrastructureTimeOffset_hour);
               Assert.IsNotNull(ModelsRes.InfrastructureTempCatchAllRemoveLater);
               Assert.IsNotNull(ModelsRes.InfrastructureAverageDepth_m);
               Assert.IsNotNull(ModelsRes.InfrastructureNumberOfPorts);
               Assert.IsNotNull(ModelsRes.InfrastructurePortDiameter_m);
               Assert.IsNotNull(ModelsRes.InfrastructurePortSpacing_m);
               Assert.IsNotNull(ModelsRes.InfrastructurePortElevation_m);
               Assert.IsNotNull(ModelsRes.InfrastructureVerticalAngle_deg);
               Assert.IsNotNull(ModelsRes.InfrastructureHorizontalAngle_deg);
               Assert.IsNotNull(ModelsRes.InfrastructureDecayRate_per_day);
               Assert.IsNotNull(ModelsRes.InfrastructureNearFieldVelocity_m_s);
               Assert.IsNotNull(ModelsRes.InfrastructureFarFieldVelocity_m_s);
               Assert.IsNotNull(ModelsRes.InfrastructureReceivingWaterSalinity_PSU);
               Assert.IsNotNull(ModelsRes.InfrastructureReceivingWaterTemperature_C);
               Assert.IsNotNull(ModelsRes.InfrastructureReceivingWater_MPN_per_100ml);
               Assert.IsNotNull(ModelsRes.InfrastructureDistanceFromShore_m);
               Assert.IsNotNull(ModelsRes.InfrastructureSeeOtherTVItemID);
               Assert.IsNotNull(ModelsRes.InfrastructureCivicAddressTVItemID);
               Assert.IsNotNull(ModelsRes.InfrastructureLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.InfrastructureLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.InfrastructureInfrastructureLanguages);
               Assert.IsNotNull(ModelsRes.InfrastructureInfrastructureTVItem);
        }
    }
}
