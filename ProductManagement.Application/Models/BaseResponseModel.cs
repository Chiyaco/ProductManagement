using ProductManagement.Domain.Enums;

namespace ProductManagement.Application.Models
{
    public class BaseResponseModel
    {
        public BaseResponseModel()
        {
            Messages = new List<string>();
        }

        public ResultType Result { get; set; }

        public List<string> Messages { get; set; }
    }
}
