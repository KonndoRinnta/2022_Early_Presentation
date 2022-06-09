using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Numerics;

public class ClickPowerUP : ItemBase
{
    [SerializeField]
    [Header("�w�������瑝���鐔")]
    BigInteger _clickPowerUp = 2;
    public void OnBuyClickPowerUp()
    {
        if (GrapeCounter._grape > _price - 1)
        {
            GrapeCounter._oneClickCount += _clickPowerUp;
            ChangeClickCounter(1);
            GrapeCounter._grape -= _price;
            _price *= 2;
            Debug.Log("�N���b�N�p���[�A�b�v�w��" + ClickCounter + "���");
        }
        else
        {
            Debug.Log("������������܂���");
        }
        if (ClickCounter % 5 == 0 && ClickCounter != 0)
        {
            _clickPowerUp *= 2;
        }
    }
}
