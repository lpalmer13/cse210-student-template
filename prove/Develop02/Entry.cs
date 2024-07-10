public class Entry
{
    public string Date { get; set; }
    public string Prompt { get;  set; }
    public string Response { get; set; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }    
}