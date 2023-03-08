namespace KeysHandler.Models;

public class Platform
{
    public string? Name { get; set; }

    public string? Description { get; set; }

    public List<string>? UrlList { get; set; }

    public List<VerifyRecord>? VerifyRecords { get; set; }
}