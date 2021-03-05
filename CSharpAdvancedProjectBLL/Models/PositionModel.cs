using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSharpAdvancedProjectBLL.Models
{
    public class PositionModel : IBaseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "Наименование должности является обязательным полем")]
        [StringLength(30, ErrorMessage = "Максимальная длина поля не должна превышать 30 символов")]
        public string Name { get; set; }

        public List<EmployeeModel> Employees { get; set; }
        public int Id { get; set; }
    }
}
