using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items
{
    public enum ItemType
    {
        ArmorNone,
        Armor_1,
        Armor_2,
        HelmetNone,
        Helmet,
        HealthPotion,
        Sword_1,
        Sword_2
    }

    public static int GetCost(ItemType itemTypes)
    {
        switch (itemTypes)
        {
            default:
            case ItemType.ArmorNone:    return 0;
            case ItemType.Armor_1:      return 30;
            case ItemType.Armor_2:      return 100;
            case ItemType.HelmetNone:   return 0;
            case ItemType.Helmet:       return 90;
            case ItemType.HealthPotion: return 30;
            case ItemType.Sword_1:      return 0;
            case ItemType.Sword_2:      return 150;

        }
    }

    //public static Sprite GetSprite(ItemType itemType)
    //{
    //    switch (itemType)
    //    {
    //        default:
    //        case ItemType.ArmorNone:    return GameAssets.i.ArmorNone;
    //        case ItemType.Armor_1:      return GameAssets.i.Armor_1;
    //        case ItemType.Armor_2:      return GameAssets.i.Armor_2;
    //        case ItemType.HelmetNone:   return GameAssets.i.HelmetNone;
    //        case ItemType.Helmet:       return GameAssets.i.Helmet;
    //        case ItemType.HealthPotion: return GameAssets.i.HealthPotion;
    //        case ItemType.Sword_1:      return GameAssets.i.Sword_1;
    //        case ItemType.Sword_2:      return GameAssets.i.Sword_2;
    //    }
    //}

}
