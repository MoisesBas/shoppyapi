namespace ShoppyEx.Order.Infrastructure.Base
{
    public class RequestResult<T>
    {
        public RequestResult() => this.Payload = (T)Activator.CreateInstance(typeof(T));

        public RequestResult(ICollection<string> errors)
        {
            Errors = errors;
        }

        public T Payload { get; set; }
        public ICollection<string> Errors { get; set; } = new List<string>();
        public bool IsSuccess => !Errors.Any();

        public void AddError(string error)
        {
            Errors.Add(error);
        }
    }
}
