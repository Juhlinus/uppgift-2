class Order : OrderLineItem
{
	public override int Number { get; set; }
	public override int Quantity { get; set; }

	public string Data { get; set; }

	public override void Total() {}
	public override void Tax() {}

	public void SubTotal() {}
	public void ShippingCharge() {}
}