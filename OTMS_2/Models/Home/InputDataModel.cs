using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTMS_2.Models.Home
{
    public class InputDataModel
    {
        //public Agregat agregat { get; set; } = new Agregat(4d, 2.1d);
        //public Material material { get; set; } = new Material(650d, 1.7d, 1.49d);
        //public Gas gas { get; set; } = new Gas(30d, 1.33d, 2450d, 0.5d);

        //public InputDataModel() { }
        //public InputDataModel(Agregat _agregat, Material _material, Gas _gas) { agregat = _agregat; material = _material; gas = _gas; }
        public double? CalculationStep { get; set; } = 0.5;
        public double? Height { get; set; } = 4;
        public double? Diameter { get; set; } = 2.2;
        public double? Vol_heat_transfer_coeff { get; set; } = 2440;
        public double? Speed { get; set; } = 0.74;
        public double? GasStartTemperature { get; set; } = 700;
        public double? GasHeatCapacity { get; set; } = 1.35;
        public double? MaterialWaste { get; set; } = 1.68;
        public double? MaterialStartTemperature { get; set; } = 5;
        public double? MaterialHeatCapacity { get; set; } = 1.49;
        
        //public static InputDataModel Default
        //{
        //    get
        //    {
        //        return new InputDataModel()
        //        {
        //            Height = 4d,
        //            Diameter = 2.1d,
        //            GasStartTemperature = 30d,
        //            GasHeatCapacity = 1.33d,
        //            Vol_heat_transfer_coeff = 2450d,
        //            Speed = 0.5d,
        //            MaterialWaste = 1.7d,
        //            MaterialHeatCapacity = 1.49d,
        //            MaterialStartTemperature = 650d
        //        };
        //    }

        //}

    }

    //public class Agregat
    //{
    //    public Agregat(double height, double diameter) { Height = height; Diameter = diameter; }
    //    public double Height { get; set; }
    //    public double Diameter { get; set; }
    //}

    //public class Gas : BaseParams
    //{
    //    public Gas(double startTemp, double heatCapacity, double volume_heatTransfer_coeff, double speed) : base(startTemp, heatCapacity)
    //    {
    //        Vol_heat_transfer_coeff = volume_heatTransfer_coeff; Speed = speed;
    //    }
    //    public double Vol_heat_transfer_coeff { get; set; }
    //    public double Speed { get; set; }
    //}

    //public class Material : BaseParams
    //{
    //    public double Waste { get; set; }

    //    public Material(double startTemp, double heatCapacity, double waste) : base(startTemp, heatCapacity)
    //    {
    //        Waste = waste;
    //    }
    //}

    //public class BaseParams
    //{
    //    public BaseParams(double startTemp, double heatCapacity)
    //    {
    //        StartTemperature = startTemp; HeatCapacity = heatCapacity;
    //    }
    //    public double StartTemperature { get; set; }
    //    public double HeatCapacity { get; set; }

    //}
}
