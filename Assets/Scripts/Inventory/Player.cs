using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Inventory inventory;
    [SerializeField] private UI_Inventory uiInventory;

    public void Awake()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }
}
