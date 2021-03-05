using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CSharpAdvancedProjectDAL.Interfaces.Entities;

namespace CSharpAdvancedProjectDAL.Entities
{
    public class Company : IEntity
    {
        /// <summary>
        /// Наименование компании
        /// </summary>
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        /// <summary>
        /// Размер компании
        /// </summary>
        [Range(1, int.MaxValue)]
        public int Size { get; set; }

        /// <summary>
        /// Организационно-правовая форма 
        /// </summary>
        [Required]
        [StringLength(100)]
        public string LegalForm { get; set; }

        /// <summary>
        /// Вид деятельности
        /// </summary>
        public string ActivityType { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public int Id { get; set; }
    }
}
