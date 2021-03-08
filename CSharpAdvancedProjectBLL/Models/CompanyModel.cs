using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSharpAdvancedProjectBLL.Models
{
    public class CompanyModel : IBaseModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Наименование компании
        /// </summary>
        [Required(ErrorMessage = "Наименование организации должно быть заполнено")]
        [StringLength(255, ErrorMessage = "Длина наименования организации не должна превышать 255 символов")]
        public string Name { get; set; }

        /// <summary>
        /// Размер компании
        /// </summary>
        [Range(1,int.MaxValue,ErrorMessage = "Максимальное кол-во сотрудников должно быть больше 0")]
        public int Size { get; set; }

        /// <summary>
        /// Организационно-правовая форма 
        /// </summary>
        [Required(ErrorMessage = "Организационно-правовая форма должна быть заполнена")]
        [StringLength(100, ErrorMessage = "Длина Организационно-правовой формы не должна превышать 100 символов")]
        public string LegalForm { get; set; }

        /// <summary>
        /// Вид деятельности
        /// </summary>
        public string ActivityType { get; set; }

        public List<EmployeeModel> Employees { get; set; }
    }
}
