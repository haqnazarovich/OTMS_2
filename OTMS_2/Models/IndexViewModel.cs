using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OTMS_2.Models.Home;

namespace OTMS_2.Models
{
    public class IndexViewModel
    {
        
        public InputDataModel Input { get; set; }
        public ResultDataModel Result { get; set; }

        public IndexViewModel() { Input = new InputDataModel()/*InputDataModel.Defaul*/; }
        public IndexViewModel(InputDataModel input) { Input = input; }
        public int StepsCount { get { return ((int)(Input.Height / Input.CalculationStep)) + 1; } }
        public void CalculateTemps()
        {
            //Agregat agr = Input.agregat;
            //Material mat = Input.material;
            //Gas gas = Input.gas;

            double agrSqrt = Math.PI * Math.Pow((double)Input.Diameter, 2) / 4d;
            double gasWaste = (double)Input.Speed * agrSqrt;
            double heatCapacitiesRatio = (double)Input.MaterialWaste * (double)Input.MaterialHeatCapacity / (gasWaste * (double)Input.GasHeatCapacity);

            double fullRelativelyHeight = (double)Input.Vol_heat_transfer_coeff * agrSqrt * (double)Input.Height /
                ((double)Input.Speed * agrSqrt * (double)Input.GasHeatCapacity * 1000d);

            double noNameFormulaResult = 1d - heatCapacitiesRatio * Math.Exp(-(1d - fullRelativelyHeight) * heatCapacitiesRatio / fullRelativelyHeight);

            double[] gasTemps = new double[StepsCount];
            double[] materialTemps = new double[StepsCount];

            for(int i = 0; i < StepsCount; i++)
            {
                double y = Math.Round(i * (double)Input.CalculationStep, 2);

                double Y = (double)Input.Vol_heat_transfer_coeff * y / (double)(Input.Speed * Input.GasHeatCapacity * 1000);
                double a = 1d - Math.Exp((heatCapacitiesRatio - 1d) * Y / heatCapacitiesRatio);
                double b = 1d - heatCapacitiesRatio * Math.Exp((heatCapacitiesRatio - 1d) * Y / heatCapacitiesRatio);

                double U = a / (1d - heatCapacitiesRatio * Math.Exp((heatCapacitiesRatio - 1d) * fullRelativelyHeight / heatCapacitiesRatio));

                double O = b / (1d - heatCapacitiesRatio * Math.Exp((heatCapacitiesRatio - 1d) * fullRelativelyHeight / heatCapacitiesRatio));

                double materialTemp = (double)Input.MaterialStartTemperature + (double)(Input.GasStartTemperature - Input.MaterialStartTemperature) * U;
                double gasTemp = (double)Input.MaterialStartTemperature + (double)(Input.GasStartTemperature - Input.MaterialStartTemperature) * O;

                gasTemps[i] = Math.Round(gasTemp,1);
                materialTemps[i] = Math.Round(materialTemp, 1);
            }

            Result = new ResultDataModel(agrSqrt, gasWaste, heatCapacitiesRatio, fullRelativelyHeight, noNameFormulaResult, gasTemps, materialTemps);
        }

    }
}
