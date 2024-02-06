namespace TODOWebAPI.Domain.Entities
{
    public class ResponseWrapper<TypeResponse>
    {
        public int StatusCode { get; set; }
        public TypeResponse? Data { get; set; }
        public bool Success { get; set; }
    }
}
