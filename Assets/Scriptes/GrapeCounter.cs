using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Numerics;

public class GrapeCounter
{
    /// <summary>所持しているぶどうの数</summary>
    [SerializeField]
    [Header("所持しているぶどうの数")]
    public static BigInteger _grape = 0;

    /// <summary>1クリックに増やすぶどうの数</summary>
    [SerializeField]
    [Header("1クリックに増やすぶどうの数")]
    public static BigInteger _oneClickCount = 1;

    [SerializeField]
    [Header("所持しているぶどうの数のテキスト")]
    Text _grapeText;

    public void Update()
    {
        _grapeText.text = _grape.ToString();
    }

    /// <summary>Buttonをクリックしたらぶどうを増やす</summary>
    public void OnClickCount()
    {
        _grape += _oneClickCount;
    }
}
