using System;
using System.ComponentModel.DataAnnotations;
using CSharpAdvancedProjectDAL.Entities;
using CSharpAdvancedProjectDAL.Interfaces.Entities;

namespace CSharpAdvancedProjectDAL.Entities
{
    public class Employee : IEntity
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        [StringLength(50)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Дата приёма на работу 
        /// </summary>
        [Required]
        public DateTime EmploymentDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PositionId { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// Идентификатор компании
        /// </summary>
        public int CompanyId { get; set; }

        public Company Company { get; set; }

        public int Id { get; set; }
    }
}
