// end product
public class Car
{
    private List<string> Details = new List<string>();

    public void AddDetail(string data)
    {
        Details.Add(data);
    }

    public void GetDetails()
    {
        foreach(var detail in Details)
        {
            System.Console.WriteLine(detail);
        }
    }
}