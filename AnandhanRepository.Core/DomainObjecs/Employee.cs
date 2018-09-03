namespace AnandhanRepository.Core.DomainObjecs
{
    using System;
    using System.Reflection;
    using System.ComponentModel;
    using Microsoft.AspNetCore.Mvc.DataAnnotations;

    [Serializable]
    // [Table("Employee")]
    public partial class Employee: IEntity<int>
    {
        public int Id {get; set;}
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Classroom { get; set; }
    }
}