namespace Utility.Shared.Interfaces
{
    public interface IResult<T>
    {
        List<string> Messages { get; set; }
        List<string> ErrorMessages { get; set; }
        bool Succeeded { get; set; }

        T Data { get; set; }

        //List<ValidationResult> ValidationErrors { get; set; }

        //Exception Exception { get; set; }

        int Code { get; set; }
    }
}
