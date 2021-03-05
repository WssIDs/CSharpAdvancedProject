using System.ComponentModel.DataAnnotations;

namespace CSharpAdvancedProjectDAL.Interfaces.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEntity
    {
        [Key]
        int Id { get; set; }
    }
}
