using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameConstants
{
    public enum BuildingType { Farm, Mine, Barack, School, Center };
    public enum ResourceType { Food, Wood, Stone, Faith, Science, Culture };

    
    // More complex constant
    public static readonly Vector3 DefaultSpawnPoint = new Vector3(0, 0, 0);
}
