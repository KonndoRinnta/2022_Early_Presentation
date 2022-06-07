using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using System.IO;

public class AutoCount : MonoBehaviour
{
    [SerializeField]
    [Header("ƒAƒCƒeƒ€‚Ì‰¿Ši")]
    int _price  = 50;

    [SerializeField]
    [Header("1‰ñ¶ŽY‚·‚éŽžŠÔ(•b)")] 
    int _productSpeed = 10;

    [SerializeField]
    [Header("1‰ñ‚É¶ŽY‚·‚é”")] 
    int _product = 1;

    [Header("w“ü‰ñ”")] 
    int _clickCounter;

    private GrapeCounter _grapeCounter = new GrapeCounter();

    public void OnBuyAutoCounter()
    {
        if (_grapeCounter.Grape > _price)
        {
            if (_clickCounter < 1)
            {
                AutoProduct();
                _clickCounter++;
            }
            else
            {
                _product *= 2;
                _clickCounter++;
            }
            if (_clickCounter % 5 == 0 && _clickCounter != 0)
            {
                _productSpeed -= 1;
            }
            _price *= 2;
        }
    }
    private IEnumerator AutoProduct()
    {
        while(true)
        {
            _grapeCounter.Grape += _product;
            yield return new WaitForSeconds(_productSpeed);
            _grapeCounter.Grape += _product;
        }
    }
}
