using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureButton : GazeableButton
{
    public Object prefab;

    public override void OnPress(RaycastHit hitInfo)
    {
        base.OnPress(hitInfo);

        // Set player mode to place furniture
        Player.instance.activeMode = InputMode.FURNITURE;


        // Set active furniture prefab to this prefab
        Player.instance.activeFurniturePrefab = prefab;

    }

}
