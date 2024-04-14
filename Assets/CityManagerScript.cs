using System;
using System.Collections.Generic;
using UnityEngine;

public class CityManagerScript : MonoBehaviour
{
    // Assign building prefabs in the inspector that already have the Building component attached
    public Building[] buildings;
    public Dictionary<GameConstants.ResourceType, int> resources = new Dictionary<GameConstants.ResourceType, int>();

    void Start()
    {
        Building cityCenter = FindCityCenter();
        if (cityCenter != null)
        {
            // Instantiate at a specific location
            Building cityCenterBuilding = Instantiate(cityCenter, new Vector3(0, 0, 0), Quaternion.identity);
            // Adding the instantiated building to a new list if needed
            List<Building> allBuildings = new List<Building>(buildings);
            allBuildings.Add(cityCenterBuilding);
            // Optionally convert back to array if necessary
            buildings = allBuildings.ToArray();
        }
        else
        {
            Debug.LogError("City center building not found in the assigned buildings!");
        }
    }

    Building FindCityCenter()
    {
        foreach (var building in buildings)
        {
            if (building.CompareTag("Center"))
            {
                return building;
            }
        }
        return null; // Return null if no city center is found
    }

    private void Update()
    {
        // farm fln gelince buildings.append(farm)..
        throw new NotImplementedException();
    }
}