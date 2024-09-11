public class Mechanism : Detail
{
	public List<Detail> Components { get; set; }

	public Mechanism(string name, double weight) : base(name, weight)
	{
		Components = new List<Detail>();
	}

	public void AddComponent(Detail component)
	{
		Components.Add(component);
	}

	override public string ToString()
	{
		return $"Mechanism: {Name} has {Components.Count} components.";
	}
}