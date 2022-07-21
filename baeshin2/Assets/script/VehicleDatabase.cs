using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleDatabase : MonoBehaviour
{
    public static VehicleDatabase instance;
    private void Awake()
    {
        instance = this; 
    }
    public List<Vehicle> vehicleDB=new List<Vehicle>();
}
