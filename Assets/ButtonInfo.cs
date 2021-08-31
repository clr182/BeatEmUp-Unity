using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int ItemId;
    public Text PriceTxt;
    public Text QuantityTxt;
    public GameObject shopManager;

    void Update()
    {
        PriceTxt.text = "Price: $" + shopManager.GetComponent<ShopManager>().shopItems[2, ItemId].ToString();
        QuantityTxt.text =  shopManager.GetComponent<ShopManager>().shopItems[3, ItemId].ToString();
    }
}
