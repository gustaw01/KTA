using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isPlacable;
    
    [SerializeField] Tower towerPrefab;
    
    public bool IsPlacable { get { return isPlacable; } }

    void OnMouseDown() {
        if(isPlacable){
            bool isPlaced = towerPrefab.CreateTower(towerPrefab, transform.position);
            isPlacable = !isPlaced;
        }
    }
}
