using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrapeCounter : MonoBehaviour
{
    public int Grape { get => grape; set => grape = value; }
    /// <summary>所持しているぶどうの数</summary>
    [SerializeField]
    [Header("所持しているぶどうの数")]
    private int grape = 0;

    /// <summary>1クリックに増やすぶどうの数</summary>
    [SerializeField]
    [Header("1クリックに増やすぶどうの数")]
    int _oneClickCount = 1;

    [SerializeField]
    [Header("所持しているぶどうの数のテキスト")]
    Text _grapeText;

    public void Update()
    {
        _grapeText.text = Grape.ToString();
    }

    /// <summary>Buttonをクリックしたらぶどうを増やす</summary>
    public void OnClickCount()
    {
        Grape += _oneClickCount;
    }
}
