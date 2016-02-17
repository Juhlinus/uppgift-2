abstract class OrderLineItem
{
	public abstract int Number { get; set; }
	public abstract int Quantity { get; set; }

	public abstract void Total();
	public abstract void Tax();

	public void IsFilled() {}
}