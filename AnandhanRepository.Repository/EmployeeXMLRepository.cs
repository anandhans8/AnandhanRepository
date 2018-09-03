using System;
using AnandhanRepository.Core.DomainObjecs;
using AnandhanRepository.XMLSource;

namespace AnandhanRepository.Repository
{
    public class EmployeeXMLRepository: XMLRepositoryBase<XMLSet<Employee>, Employee, int>, IEmployeeRepository
    {
        public EmployeeXMLRepository()
            :base("employee.xml")
        {

        }
    }
}