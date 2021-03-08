using System;
using System.ComponentModel.DataAnnotations;

namespace CSharpAdvancedProjectBLL.Models
{
    public class EmployeeModel : IBaseModel
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        [Required(ErrorMessage = "Поле Фамилия является обязательным")]
        [StringLength(50, ErrorMessage = "Максимальная длина поля Фамилия не может быть больше 50 символов")]
        public string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [Required(ErrorMessage = "Поле Имя является обязательным")]
        [StringLength(50, ErrorMessage = "Максимальная длина поля Имя не может быть больше 50 символов")]
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        [StringLength(50, ErrorMessage = "Максимальная длина поля Отчество не может быть больше 50 символов")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Дата приёма на работу 
        /// </summary>
        [Required]
        public DateTime EmploymentDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "Требуется указать должность сотрудника")]
        public int PositionId { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public PositionModel Position { get; set; }

        /// <summary>
        /// Идентификатор компании
        /// </summary>
        public int? CompanyId { get; set; }

        public CompanyModel Company { get; set; }

        public int Id { get; set; }
    }
}
