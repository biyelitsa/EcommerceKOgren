using EcommerceKOgren.DTO.DTOs;
using EcommerceKOgren.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.DataAccess.Abstract
{
    public interface IEmployeeDal : IBaseRepository<Employee>
    {
        IQueryable<EmployeeList> GetEmployeeList();
        string GetTitle(int id);
        int GetAge(int id);
        string FullName(int id);
        IQueryable<ManagerList> GetManagerList();
        EmployeeDetail GetEmployeeDetail(int id);
    }
}
