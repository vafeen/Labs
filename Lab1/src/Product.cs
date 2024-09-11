public class Product : Mechanism
{
	public string ProductCode { get; set; }

	public Product(string name, double weight, string productCode) : base(name, weight)
	{
		ProductCode = productCode;
	}

	override public string ToString()
	{
		return $"Product Code: {ProductCode}";
	}
}
