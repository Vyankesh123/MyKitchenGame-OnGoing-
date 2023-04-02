using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounter : BaseCounter
{
    public event EventHandler OnPlayerGrabbedObject;

    [SerializeField] private KitchenObjectsSO kitchenObjectSO;
    
    public override void Interact(Player player)
    {
        if(!player.HasKitchenObject())
        {
            // Player is not carrying anything
            KitchenObjects.SpawnKitchenObject(kitchenObjectSO, player);
            
          OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);

        }

    }
    
}
