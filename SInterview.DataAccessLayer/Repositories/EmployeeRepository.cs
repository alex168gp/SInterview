using System;
using System.Collections.Generic;
using System.Linq;

namespace SInterview.DataAccessLayer
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public EmployeeRepository(SInterviewDbContext context) : base(context) { }

        #endregion

        /// <summary>
        /// Get a list of all employees with specified position in the company inside interview system
        /// </summary>
        /// <param name="position">A position of <see cref="Employee"/></param>
        /// <returns>All employees with specified position</returns>
        public IEnumerable<Employee> GetAllEmployeesWithPosition(string position)
        {
            IEnumerable<Employee> employeesByPosition = new List<Employee>();
            /*
            // TODO: Add a way to pass object, then cast it to a type of Employee.Position and search for matches in database
            if (position != null)
            {
                // Get employee as type
                var typeEmployee = new Employee().GetType();

                // Get property info of a Employee.Position property
                var propertyPosition = typeEmployee.GetProperty("Position");

                // Convert position to type of the Employee.Position property
                // we get object(typeof(Employee.Position)), not typeof(Employee.Position)
                // it could be casted to typeof(Employee.Position), but only manually
                position = Convert.ChangeType(position, propertyPosition.PropertyType);

                // this will never work since type don't match
                // dynamic can't be used too
                employeesByPosition = mEntities.Where(emp => emp.Position.Equals(position)).ToList();
            }
            */

            /*
            // Another option. We can expect that position object will be identifier: most likely if type string will be changed,
            // it will be enum or PositionID (type int), and we can check what we have in object position and cast it
            if (position is string)
            {
                string posStr = (string)position;
                employeesByPosition = mEntities.Where(emp => emp.Position.Equals(posStr)).ToList();
            }
            else if (position is int)
            {
                int posInt = (int)position;
                employeesByPosition = mEntities.Where(emp => emp.Position.Equals(posInt)).ToList();
            }
            */
            employeesByPosition = mEntities.Where(emp => emp.Position.Equals(position)).ToList();
            return employeesByPosition;
        }
    }
}
