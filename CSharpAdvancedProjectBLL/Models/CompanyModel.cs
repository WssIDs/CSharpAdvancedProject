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
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Размер компании
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Организационно-правовая форма 
        /// </summary>
        [Required]
        public string LegalForm { get; set; }

        /// <summary>
        /// Вид деятельности
        /// </summary>
        public string ActivityType { get; set; }

        public List<EmployeeModel> Employees { get; set; }
    }
}
