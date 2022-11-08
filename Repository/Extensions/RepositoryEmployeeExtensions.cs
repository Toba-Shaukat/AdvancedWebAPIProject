using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

namespace Repository.Extensions
{
    public static class RepositoryEmployeeExtensions
    {
        public static IQueryable<Employee> FilterEmployees(this IQueryable<Employee> employees, uint minAge, uint maxAge)
        {
            return employees.Where(x => (x.Age >= minAge && x.Age <= maxAge));
        }

        public static IQueryable<Employee> Search(this IQueryable<Employee> employees, string searchTerm)
        {
            if(string.IsNullOrWhiteSpace(searchTerm))
                return employees;

            var lowerCaseSearchTerm = searchTerm.Trim().ToLower();

            //abhishek KUMAR
            //abhishekkumar

            var employeesWithSearch = employees.Where(x => x.Name.ToLower().Contains(lowerCaseSearchTerm));

            return employeesWithSearch;
        }

        public static IQueryable<Employee> Sort(this IQueryable<Employee> employees, string orderByQueryString)
        {
            if(string.IsNullOrWhiteSpace(orderByQueryString))
                return employees.OrderBy(x => x.Name);

            var orderQuery = OrderQueryBuilder.CreateOrderQuery<Employee>(orderByQueryString);

            if(string.IsNullOrWhiteSpace(orderQuery))
                return employees.OrderBy(x => x.Name);

            return employees.OrderBy(orderQuery);
        }
    }
}
