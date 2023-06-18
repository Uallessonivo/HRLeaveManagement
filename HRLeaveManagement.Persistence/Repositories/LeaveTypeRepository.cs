using HRLeaveManagement.Application.Persistence.Contracts;
using HRLeaveManagement.Domain;

namespace HRLeaveManagement.Persistence.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly LeaveManagementDbContext _dbContext;

        public LeaveTypeRepository(LeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<LeaveType>> GetLeaveTypesWithDetails()
        {
            throw new NotImplementedException();
        }

        public Task<LeaveType> GetLeaveTypeWithDetails(int id)
        {
            throw new NotImplementedException();
        }
    }
}
