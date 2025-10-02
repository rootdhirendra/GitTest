namespace GitTest.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        //added on remote

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
