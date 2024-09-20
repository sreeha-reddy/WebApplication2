using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;
using System.Xml.Serialization;

namespace WebApplication2.Models
{
    public class VESModel
    {
    }

    public class Site
    {
        [Key]
        public int SiteID { get; set; }

        public int PMCID { get; set; }

        public int OneSiteSiteID { get; set; }

        public string SiteName { get; set; }

        public int UnitCount { get; set; }

        public int CreditHold { get; set; }

        public int Inactive { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int SiteTypeID { get; set; }

        public int AcctgSystemID { get; set; }

        public int InvFlucAlertsActive { get; set; }

        public int RentRollSystemID { get; set; }

        public int UnitInvFlucAlertsActive { get; set; }

        public int FormerCassSite { get; set; }

        public int SdIPPlatform { get; set; }

        public int SdVCRPlatform { get; set; }

        public int SdRBPlatform { get; set; }

        public int EnergyStarBedroomCount { get; set; }

        public int EnergyStarBathroomCount { get; set; }

        public int Sustainability { get; set; }

        public byte[] TaxID { get; set; }

        public int MeterHighUsageAlertExcluded { get; set; }
    }

    public class Sites
    {
        public Site Site { get; set; }
    }

    public class Area
    {

        public int AreaID { get; set; }

        public int SiteID { get; set; }

        public int AreaTypeID { get; set; }

        public string AreaDescription { get; set; }

        public string? Address1 { get; set; }

        public string City { get; set; }

        public string? StateCode { get; set; }

        public string? PostalCode { get; set; }

        public int ThirdPartyID { get; set; }

        public int Inactive { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }

    public class Areas
    {
        public Area Area { get; set; }
    }

    public class UnitType
    {

        public int UnitTypeID { get; set; }

        public string UnitTypeDescription { get; set; }

        public int SiteID { get; set; }

        public double BedCnt { get; set; }

        public double BathCnt { get; set; }

        public int SqFt { get; set; }

        public int Floor { get; set; }

        public int Inactive { get; set; }

        public int Createdby { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ThirdPartyID { get; set; }
    }

    public class Unittypes
    {
        public UnitType Unittype { get; set; }
    }

    public class Unit
    {
        [Key]
        public int UnitID { get; set; }

        public int UnitTypeID { get; set; }

        public int UnitDesignationID { get; set; }

        public int AreaID { get; set; }

        public int Floor { get; set; }

        public int UnitNo { get; set; }

        public int UnitUse { get; set; }

        public int Validated { get; set; }

        public int Override { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string StateCode { get; set; }

        public int PostalCode { get; set; }

        public int Inactive { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int ReportingAreaID { get; set; }

        public int SitePhaseID { get; set; }
    }
    public class Units
    {
        public Unit Unit { get; set; }
    }

    public class SiteService
    {

        public int SiteServiceID { get; set; }

        public int SiteID { get; set; }

        public int ServiceID { get; set; }

        public int SiteServiceStatusID { get; set; }

        public int LeadDays { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime PendingDate { get; set; }

        public DateTime TargetImpDate { get; set; }

        public DateTime ActualImpDate { get; set; }

        public DateTime TargetImpDateChanged { get; set; }

        public DateTime ApprovalDeadlineDate { get; set; }

        public DateTime AssignmentDate { get; set; }

        public DateTime ApprovalDate { get; set; }

        public DateTime EarliestStartDate { get; set; }

        public DateTime ActivationDate { get; set; }

        public int Inactive { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
    public class Services
    {
        public SiteService SiteService { get; set; }
    }

    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        public int AddressGroupTypeID { get; set; }

        public string AddressGroupDescription { get; set; }

        public string Address1 { get; set; }

        public string City { get; set; }

        public string StateCode { get; set; }

        public string PostalCode { get; set; }

        public int CountryID { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int Inactive { get; set; }

        public int Validated { get; set; }

        public int Override { get; set; }

        public string EntityPhone { get; set; }

        public string EntityFax { get; set; }

        public int VendorGracePeriod { get; set; }

        public string ResidentStatementPhone { get; set; }

        public string RPPAID { get; set; }

        public int RPPAStatusID { get; set; }

        public int AllowDuplicateAddress { get; set; }
    }

    public class AddressInfo
    {
        public Address Address { get; set; }
    }

    public class SiteGLCode
    {

        public int SiteGLCodeID { get; set; }

        public int SiteID { get; set; }

        public int VendorID { get; set; }

        public int SdSiteGLTypeID { get; set; }

        public int Master { get; set; }

        public int Unit { get; set; }

        public int Inactive { get; set; }
        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int AlertIfUsed { get; set; }

        public int SplitPercentageMultipleSites { get; set; }
    }
    public class GLCodes
    {
        public SiteGLCode SiteGLCode { get; set; }
    }

    public class SiteCAPrimaryCharge
    {
        [Key]
        public int SiteCAPrimaryChargeID { get; set; }

        public int SiteID { get; set; }

        public int HasBaseFee { get; set; }

        public string ChargeDesc { get; set; }

        public string ChargeBasisDesc { get; set; }

        public string AllocationMethodDesc { get; set; }

        public string AllocationFactorDesc { get; set; }

        public int Inactive { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int SiteCAChargeParameterSetID { get; set; }

        public int BillingCycleType { get; set; }

        public int ClientBillCycleType { get; set; }

        public DateTime LastBilledThruDate { get; set; }

        public string ExpenseTypesCompositeKey { get; set; }

        public int ChargeCodeID { get; set; }

        public int MultipleChargesSameExpenseType { get; set; }

        public int Followanotherchargeid { get; set; }
    }

    public class PrimaryCharges
    {
        public SiteCAPrimaryCharge SiteCAPrimaryCharge { get; set; }
    }

    public class VendorAccount
    {

        public int VendorAccountID { get; set; }

        public int VendorID { get; set; }

        public int SiteID { get; set; }

        public int SdVendorAccountTypeID { get; set; }

        public int InvoiceFrequencyID { get; set; }

        public double VendorAccountNo { get; set; }

        public string VendorAccountDescription { get; set; }

        public int RemitToAddressID { get; set; }

        public int Inactive { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string AlternateIdentifier { get; set; }

        public string WebsiteUserName { get; set; }

        public int TransmitInvoices { get; set; }

        public int CommoditySupplierOnly { get; set; }

        public int InvoiceSpecialHandling { get; set; }

        public int IsDoNotChangeAddress { get; set; }

        public int IsEDI { get; set; }

        public int IsEbill { get; set; }

        public int IsMail { get; set; }

        public int IsClient { get; set; }

        public int IsEBillAttempted { get; set; }

        public int IsPaperInvoiceRequired { get; set; }

        public int EarlyPayDiscountHandling { get; set; }

        public double DiscountPercentage { get; set; }

        public int IsUrjanet { get; set; }

        public int IsEmail { get; set; }

        public int IsFax { get; set; }

        public int ClientPay { get; set; }

        public int InvoiceNoRequired { get; set; }

        public int EnhancedTrash { get; set; }

        public byte[] WebsitePassword { get; set; }

        public string WebsitePasswordDecrypt { get; set; }

        public int PreventativePayment { get; set; }

        public string Comments { get; set; }

        public int ResidentBillingUseOnly { get; set; }

        public int IsAllowInvoiceCopy { get; set; }

        public int SdInactivationReasonID { get; set; }

        public int IsPlaceholder { get; set; }
    }

    public class VendorAccounts
    {
        public VendorAccount VendorAccount { get; set; }
    }

    public class Siteinfo
    {
        [Key]
        public int Id { get; set; }

        public Sites Sites { get; set; }

        public Areas Areas { get; set; }

        public Unittypes Unittypes { get; set; }

        public Units Units { get; set; }

        public Services Services { get; set; }

        public AddressInfo AddressInfo { get; set; }

        public GLCodes GLCodes { get; set; }

        public PrimaryCharges PrimaryCharges { get; set; }

        public VendorAccounts VendorAccounts { get; set; }
    }
    public class FileUpload
    {
        public int Id { get; set; }
        [Display(Name = "File Name")]
        public string FileName { get; set; } = string.Empty;
        [Display(Name = "File Type")]
        public string FileType { get; set; } = string.Empty;
        [Display(Name = "File Extension")]
        public string Extension { get; set; } = string.Empty;

        public byte[]? FileData { get; set; }
    }

}
