public class Detail
{
    public string Name { get; set; }
    public double Weight { get; set; }

    public Detail(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }

    override public string ToString()
    {
        return $"Detail: {Name}, Weight: {Weight} kg";
    }
}