public class Node : Detail
{
	public string NodeType { get; set; }

	public Node(string name, double weight, string nodeType) : base(name, weight)
	{
		NodeType = nodeType;
	}

	override public string ToString()
	{
		return $"Node Type: {NodeType}";
	}
}