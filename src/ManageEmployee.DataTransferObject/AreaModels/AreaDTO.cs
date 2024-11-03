using System.ComponentModel.DataAnnotations;

namespace ManageEmployee.DataTransferObject.AreaModels;
public class AreaDTO{
    [Required]
    public string Code{get;set;}
    [Required]
    public string Name{get;set;}
}