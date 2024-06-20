//Data Structure
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int AnnualPetroleumConsumptionFuelType1 { get; set; } 
    public int AnnualPetroleumConsumptionFuelType2 { get; set; } 
    public double TimeToChargeAt120V { get; set; } 
    public double TimeToChargeAt240V { get; set; } 
    public int CityMpgFuelType1 { get; set; } 
    public double UnroundedCityMpgFuelType1 { get; set; } 
    public int CityMpgFuelType2 { get; set; } 
    public double UnroundedCityMpgFuelType2 { get; set; } 
    public double CityGasolineConsumption { get; set; } 
    public double CityElectricityConsumption { get; set; } 
    public int EpaCityUtilityFactor { get; set; } 
    public double Co2FuelType1 { get; set; } 
    public double Co2FuelType2 { get; set; } 
    public double Co2TailpipeFuelType2 { get; set; } 
    public double Co2TailpipeFuelType1 { get; set; } 
    public int CombinedMpgFuelType1 { get; set; } 
    public double UnroundedCombinedMpgFuelType1 { get; set; } 
    public int CombinedMpgFuelType2 { get; set; } 
    public double UnroundedCombinedMpgFuelType2 { get; set; } 
    public double CombinedElectricityConsumption { get; set; } 
    public double CombinedGasolineConsumption { get; set; } 
    public int EpaCombinedUtilityFactor { get; set; } 
    public int Cylinders { get; set; } 
    public double EngineDisplacement { get; set; } 
    public string Drive { get; set; } 
    public int EpaModelTypeIndex { get; set; } 
    public string EngineDescriptor { get; set; } 
    public int EpaFuelEconomyScore { get; set; } 
    public int AnnualFuelCostFuelType1 { get; set; } 
    public int AnnualFuelCostFuelType2 { get; set; } 
    public string FuelType { get; set; } 
    public string FuelType1 { get; set; } 
    public int GHGScore { get; set; } 
    public int GHGScoreAlternativeFuel { get; set; } 
    public int HighwayMpgFuelType1 { get; set; } 
    public double UnroundedHighwayMpgFuelType1 { get; set; } 
    public int HighwayMpgFuelType2 { get; set; } 
    public double UnroundedHighwayMpgFuelType2 { get; set; } 
    public double HighwayGasolineConsumption { get; set; } 
    public double HighwayElectricityConsumption { get; set; } 
    public int EpaHighwayUtilityFactor { get; set; } 
    public int HatchbackLuggageVolume { get; set; } 
    public int HatchbackPassengerVolume { get; set; } 
    public int ID { get; set; } 
    public int TwoDoorLuggageVolume { get; set; } 
    public int FourDoorLuggageVolume { get; set; } 
    public string MpgData { get; set; } 
    public string PHEVBlended { get; set; } 
    public int TwoDoorPassengerVolume { get; set; } 
    public int FourDoorPassengerVolume { get; set; } 
    public int RangeFuelType1 { get; set; } 
    public int RangeCityFuelType1 { get; set; } 
    public int RangeCityFuelType2 { get; set; } 
    public int RangeHighwayFuelType1 { get; set; } 
    public int RangeHighwayFuelType2 { get; set; } 
    public string Transmission { get; set; } 
    public double UnadjustedCityMpgFuelType1 { get; set; } 
    public double UnadjustedCityMpgFuelType2 { get; set; } 
    public double UnadjustedHighwayMpgFuelType1 { get; set; } 
    public double UnadjustedHighwayMpgFuelType2 { get; set; } 
    public string VehicleSizeClass { get; set; } 
    public int Year { get; set; } 
    public string YouSaveSpend { get; set; } 
    public string Guzzler { get; set; } 
    public string TransmissionDescriptor { get; set; } 
    public string TCharger { get; set; } 
    public string SCharger { get; set; } 
    public string ATVType { get; set; } 
    public string FuelType2 { get; set; } 
    public int EpaRangeFuelType2 { get; set; } 
    public string ElectricMotor { get; set; } 
    public string MFRCode { get; set; } 
    public string C240Dscr { get; set; } 
    public string Charge240B { get; set; } 
    public string C240BDscr { get; set; } 
    public string CreatedOn { get; set; } 
    public string ModifiedOn { get; set; } 
    public string StartStop { get; set; } 
    public string PHEVCity { get; set; } 
    public string PHEVHighway { get; set; } 
    public string PHEVCombined { get; set; } 
    public string BaseModel { get; set; } 

    // Constructor to initialize a Car object from a CSV line
    public Car(string csvLine)
    {
        string[] values = csvLine.Split(';');
        if (values.Length == 88)
        {
            Make = values[0];
            Model = values[1];
            // ... (Assign other properties based on their index in the values array)
            BaseModel = values[87];
        }
        else
        {
            throw new ArgumentException("Invalid CSV line format.");
        }
    }
}