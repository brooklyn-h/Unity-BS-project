using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum VehicleType
{

}
[System.Serializable]
public class Vehicle
{
    public VehicleType VehicleType;
    public string VehicleName;
    public Sprite VehicleImage;

    public bool Use()
    {
        return false;
    }
}
