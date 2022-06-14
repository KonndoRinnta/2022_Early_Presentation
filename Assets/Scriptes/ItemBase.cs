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
    [Header("�A�C�e���̐����e�L�X�g")]
    GameObject _itemText;

    [SerializeField]
    [Header("�A�C�e���̉��i")]
    public BigInteger _price = 10;

    [SerializeField]
    [Header("�A�C�e���̒l�i�e�L�X�g")]
    Text _priceText;

    [SerializeField]
    [Header("�w���񐔃e�L�X�g")]
    Text _buyCountText;

    [SerializeField]
    [Header("�w���s���e�L�X�g")]
    GameObject _lackText;

    [SerializeField]
    [Header("�w���s���e�L�X�g�̕\������")]
    float _displayTime;

    /// <summary>�w����</summary>
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
    public IEnumerator NotBuyText()
    {
        _lackText.SetActive(true);
        yield return new WaitForSeconds(_displayTime);
        _lackText.SetActive(false);
    }
}
