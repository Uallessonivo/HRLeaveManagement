using HRLeaveManagement.Domain;

namespace HRLeaveManagement.Application.Persistence.Contracts
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
        Task<List<LeaveType>> GetLeaveTypesWithDetails();
        Task<LeaveType> GetLeaveTypeWithDetails(int id);
    }
}
