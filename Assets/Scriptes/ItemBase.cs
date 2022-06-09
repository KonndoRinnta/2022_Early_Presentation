using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Numerics;

public class ItemBase : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public int ClickCounter => _clickCounter;

    [SerializeField]
    [Header("アイテムの説明テキスト")]
    GameObject _itemText;

    [SerializeField]
    [Header("アイテムの価格")]
    public BigInteger _price = 10;

    [SerializeField]
    [Header("アイテムの値段テキスト")]
    Text _priceText;

    [SerializeField]
    [Header("購入回数テキスト")]
    Text _buyCountText;

    /// <summary>購入回数</summary>
    int _clickCounter;

    public void OnPointerEnter(PointerEventData eventData)
    {
        _itemText.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _itemText.SetActive(false);
    }

    private void Update()
    {
        _priceText.text = _price.ToString();
        _buyCountText.text = ClickCounter.ToString();
    }

    public int ChangeClickCounter(int clickCounter)
    {
        _clickCounter += clickCounter;
        return clickCounter;
    }
}
