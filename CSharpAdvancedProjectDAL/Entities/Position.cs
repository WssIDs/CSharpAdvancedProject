using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CSharpAdvancedProjectDAL.Entities;
using CSharpAdvancedProjectDAL.Interfaces.Entities;

namespace CSharpAdvancedProjectDAL.Entities
{
    public class Position : IEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public int Id { get; set; }
    }
}
