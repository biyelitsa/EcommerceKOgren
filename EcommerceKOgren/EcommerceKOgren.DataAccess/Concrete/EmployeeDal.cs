using EcommerceKOgren.DataAccess.Abstract;
using EcommerceKOgren.DTO.DTOs;
using EcommerceKOgren.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.DataAccess.Concrete
{
    public class EmployeeDal : BaseRepository<Employee>, IEmployeeDal
    {
        
        public EmployeeDal(Context db) : base(db)
        {
            
        }

        public string FullName(int id)
        {
            Employee emp = Find(id);
            return emp.FirstName + " " + emp.Surname;
        }

        public int GetAge(int id)
        {
            Employee emp = Find(id);
            var today = DateTime.Now;
            var age = today.Year - emp.DateofBirth.Year;
            var BirthDay = emp.DateofBirth.AddYears(age);
            if (BirthDay > today)
            {
                age++;
            }

            return age;
        }

        public EmployeeDetail GetEmployeeDetail(int id)
        {
            EmployeeDetail employeeDetail = new EmployeeDetail();
            employeeDetail.Id = id;
            employeeDetail.Head = $"{GetTitle(id)} Yaşınız: {GetAge(id)}";
            return employeeDetail;
        }

        public IQueryable<EmployeeList> GetEmployeeList()
        {
            return Set().Select(x => new EmployeeList
            {
                EmployeeId = x.Id,
                FullName = x.FirstName + " " + x.Surname,   //FullName(x.Id)
                Gender = x.Gender,
                Birthday = x.DateofBirth,
                Salary = x.Salary,
                ManagerName = x.Manager.FirstName + " " + x.Manager.Surname,  //Select ManagerName from Employee e inner join Employee m (m.Id == e.ManagerId)
                IsManager = x.IsManager,
                FullAddress = $"{x.Street} St., {x.Avenue} Ave., No: {x.OutDoorNumber}, County: {x.County.CountyName}",
                PhoneNumber = x.PhoneNumber
            });
        }

        public IQueryable<ManagerList> GetManagerList()
        {
            return Set().Select(x => new ManagerList
            {
                ManagerId = x.Id,
                Fullname = x.FirstName + " " + x.Surname,
                IsManager = x.IsManager
            });
        }

        public string GetTitle(int id)
        {
            Employee emp = Find(id);
            if (emp.Gender == 'E')
            {
                return $"Mr.{emp.FirstName} {emp.Surname}";
            }
            else
            {
                return $"Mrs.{emp.FirstName} {emp.Surname}";
            }
        }
    }
}
