using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Numerics;

public class ClickPowerUP : ItemBase
{
    [SerializeField]
    [Header("購入したら増える数")]
    BigInteger _clickPowerUp = 2;
    public void OnBuyClickPowerUp()
    {
        if (GrapeCounter._grape > _price - 1)
        {
            GrapeCounter._oneClickCount += _clickPowerUp;
            ChangeClickCounter(1);
            GrapeCounter._grape -= _price;
            _price *= 2;
            Debug.Log("クリックパワーアップ購入" + ClickCounter + "回目");
        }
        else
        {
            Debug.Log("所持金が足りません");
        }
        if (ClickCounter % 5 == 0 && ClickCounter != 0)
        {
            _clickPowerUp *= 2;
        }
    }
}
