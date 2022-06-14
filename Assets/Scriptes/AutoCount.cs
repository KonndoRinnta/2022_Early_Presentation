using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;
using System.Numerics;
using System.IO;

public class AutoCount : ItemBase
{
    [SerializeField]
    [Header("1回生産する時間(秒)")]
    float _productSpeed = 10f;

    [SerializeField]
    [Header("1回に生産する数")]
    BigInteger _product = 1;

    public void OnBuyAutoCounter()
    {
        Debug.Log(GrapeCounter._grape);
        if (GrapeCounter._grape > _price -1)
        {
            if (ClickCounter == 0)
            {
                StartCoroutine(AutoProduct());
                ChangeClickCounter(1);
            }
            else
            {
                _productSpeed /= 2;
                ChangeClickCounter(1);
            }
            if (ClickCounter % 5 == 0 && ClickCounter != 0)
            {
                _product *= 2;
            }
            GrapeCounter._grape -= _price;
            _price *= 2;
            Debug.Log("オートカウンター購入" + ClickCounter + "回目");
        }
        else
        {
            Debug.Log("所持金が足りません");
        }
    }
    public IEnumerator AutoProduct()
    {
        while(true)
        {
            yield return new WaitForSeconds(_productSpeed);
            GrapeCounter._grape += _product;
            Debug.Log("自動生成");
        }
    }
}
