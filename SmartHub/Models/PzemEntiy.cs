namespace SmartHub.Models;

public class PzemEntiy
{
    /*
        Voltage: 115.90V
        Current: 0.09A
        Power: 9.80W
        Energy: 0.001kWh
        Frequency: 59.9Hz
        PF: 0.95
     */

    public float Voltage { get; set; }
    public float Current { get; set; }
    public float Power { get; set; }
    public float Energy { get; set; }
    public float Frequency { get; set; }
    public float PF { get; set; }

    public override string ToString()
    {
        return string.Format($"Voltage:{this.Voltage}V\n" +
                             $"Current:{Current}A\n" +
                             $"Power:{Power}W\n" +
                             $"Energy:{Energy}kWh\n" +
                             $"Frequency:{Frequency}Hz\n" +
                             $"PF:{PF}\n");
    }
}