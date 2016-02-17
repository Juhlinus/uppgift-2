class Item : OrderLineItem
{
	public override int Number { get; set; }
	public override int Quantity { get; set; }

	public string Description { get; set; }
	public string UnitPrice { get; set; }

	public override void Total() {}
	public override void Tax() {}
}