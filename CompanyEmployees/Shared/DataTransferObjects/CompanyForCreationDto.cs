using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects;

public record CompanyForCreationDto
{
    [Required(ErrorMessage = "Employee name is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
    public string Name { get; init; }
    
    public string Address { get; init; }
    
    public string Country { get; init; }
    public IEnumerable<EmployeeForCreationDto> Employees { get; init; }
}