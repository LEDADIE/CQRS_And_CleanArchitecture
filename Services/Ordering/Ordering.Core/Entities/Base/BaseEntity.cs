using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ordering.Core.Entities.Base;

public class BaseEntity
{
    public BaseEntity()
    {
        this.Modifieddate = DateTime.Now;
    }

    public DateTime CreatedDate { get; set; }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Int64 Id { get; set; }

    public DateTime Modifieddate { get; set; }
}