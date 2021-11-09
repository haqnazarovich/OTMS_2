using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTMS_2.Models.Home
{
    public class ResultDataModel
    {
        public ResultDataModel(
            double agregatSqr, double gasWaste,
            double heatCapacitiesRatio, double fullRelativelyHeight, 
            double noNameFormulaResult, double[] gasTemps, double[] materialTemps)
        {
            Agregat_Сross_Sectional_Area = agregatSqr;
            GasWaste = gasWaste;
            HeatCapacitiesRatio = heatCapacitiesRatio;
            FullRelativelyHeight = fullRelativelyHeight;
            NoNameFormulaResult = noNameFormulaResult;
            GasTemperaturesByHeight = gasTemps;
            MaterialTemperaturesByHeight = materialTemps;
        }

        public double Agregat_Сross_Sectional_Area { get; set; }
        public double GasWaste { get; set; }
        public double HeatCapacitiesRatio { get; set; }
        public double FullRelativelyHeight { get; set; }
        public double NoNameFormulaResult { get; set; }

        public double[] GasTemperaturesByHeight { get; set; }
        public double[] MaterialTemperaturesByHeight { get; set; }

    }
}
