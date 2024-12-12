public class Cargo
{
    public string Name { get; set; }
    public string Unit { get; set; }
    public int Quantity { get; set; }
    public float Weight { get; set; }
    public float InsuranceValue { get; set; }

    public Cargo(string name, string unit, int quantity, float weight, float insuranceValue)
    {
        Name = name;
        Unit = unit;
        Quantity = quantity;
        Weight = weight;
        InsuranceValue = insuranceValue;
    }
}