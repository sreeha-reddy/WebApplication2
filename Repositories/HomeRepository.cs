using WebApplication2.Data;
using WebApplication2.Models;
using Dapper;
using System.Data;

namespace WebApplication2.Repositories
{
    public class HomeRepository
    {
        private readonly DapperContext _context;

        public HomeRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<int> InsertSiteAsync(Site site)
        {
            string sql = @"
            INSERT INTO Site
            (PMCID, OneSiteSiteID, SiteName, UnitCount, CreditHold, Inactive, CreatedBy, CreatedDate, 
            ModifiedBy, ModifiedDate, SiteTypeID, AcctgSystemID, InvFlucAlertsActive, RentRollSystemID, 
            UnitInvFlucAlertsActive, FormerCassSite, SdIPPlatform, SdVCRPlatform, SdRBPlatform, 
            EnergyStarBedroomCount, EnergyStarBathroomCount, Sustainability, TaxID, MeterHighUsageAlertExcluded)
            VALUES 
            (@PMCID, @OneSiteSiteID, @SiteName, @UnitCount, @CreditHold, @Inactive, @CreatedBy, @CreatedDate, 
            @ModifiedBy, @ModifiedDate, @SiteTypeID, @AcctgSystemID, @InvFlucAlertsActive, @RentRollSystemID, 
            @UnitInvFlucAlertsActive, @FormerCassSite, @SdIPPlatform, @SdVCRPlatform, @SdRBPlatform, 
            @EnergyStarBedroomCount, @EnergyStarBathroomCount, @Sustainability, @TaxID, @MeterHighUsageAlertExcluded);
            SELECT CAST(SCOPE_IDENTITY() as int);";


            using (var connection = _context.CreateConnection())
            {
                var result = await connection.ExecuteScalarAsync<int>(sql, site);
                return result;
            }
        }
    }
}