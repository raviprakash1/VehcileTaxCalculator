using System;
using congestion.calculator;
using System.Linq;

class VechileFactory
{
    //Using Reflection
    public static IVehicle getVechile(string type)
    {
        var vehicleType = typeof(IVehicle);
        var vehicleClassesNames = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                                        .Where(x => vehicleType.IsAssignableFrom(x))
                                        .ToDictionary(x => x.Name.ToLower(), x => x);

        if (vehicleClassesNames.ContainsKey(type.ToLower()))
        {
            return (IVehicle)Activator.CreateInstance(vehicleClassesNames[type.ToLower()]);
        }
        return null;
    }

    //Using Switch case
    public static IVehicle getVechileSwitch(string type)
    {
        switch (type.ToLower())
        {
            case "car":
                return new Car();
            case "motorbike":
                return new Motorbike();
            default:
                return null;
        }
    }
}
