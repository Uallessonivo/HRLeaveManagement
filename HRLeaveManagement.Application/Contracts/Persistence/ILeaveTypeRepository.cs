using HRLeaveManagement.Domain;

namespace HRLeaveManagement.Application.Contracts.Persistence
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
        Task<List<LeaveType>> GetLeaveTypesWithDetails();
        Task<LeaveType> GetLeaveTypeWithDetails(int id);
    }
}
