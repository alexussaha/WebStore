using System;
using System.Collections.Generic;
using System.Linq;
using WebStore.Domian.Models;
using WebStore.Interfaces.Services;
using WebStore.Services.Data;

namespace WebStore.Services.Products.InMemory
{
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<Employee> __Employees = TestData.Employees;

        public IEnumerable<Employee> GetAll() => __Employees;

        public Employee GetById(int id) => __Employees.FirstOrDefault(e => e.Id == id);

        public void Add(Employee Employee)
        {
            if (Employee is null)
                throw new ArgumentNullException(nameof(Employee));

            if (__Employees.Contains(Employee)) return;
            Employee.Id = __Employees.Count == 0 ? 1 : __Employees.Max(e => e.Id) + 1;
            __Employees.Add(Employee);
        }

        public void Edit(int id, Employee Employee)
        {
            if (Employee is null)
                throw new ArgumentNullException(nameof(Employee));

            if (__Employees.Contains(Employee)) return;

            var db__Employee = GetById(id);
            if (db__Employee is null)
                return;

            db__Employee.SurName = Employee.SurName;
            db__Employee.FirstName = Employee.FirstName;
            db__Employee.Patronymic = Employee.Patronymic;
            db__Employee.Age = Employee.Age;
        }

        public bool Delete(int id)
        {
            var db__Employee = GetById(id);
            if (db__Employee is null)
                return false;

            return __Employees.Remove(db__Employee);
        }

        public void SaveChanges() { }
    }
}
