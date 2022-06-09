using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Numerics;

public class GrapeCounter
{
    /// <summary>�������Ă���Ԃǂ��̐�</summary>
    [SerializeField]
    [Header("�������Ă���Ԃǂ��̐�")]
    public static BigInteger _grape = 0;

    /// <summary>1�N���b�N�ɑ��₷�Ԃǂ��̐�</summary>
    [SerializeField]
    [Header("1�N���b�N�ɑ��₷�Ԃǂ��̐�")]
    public static BigInteger _oneClickCount = 1;

    [SerializeField]
    [Header("�������Ă���Ԃǂ��̐��̃e�L�X�g")]
    Text _grapeText;

    public void Update()
    {
        _grapeText.text = _grape.ToString();
    }

    /// <summary>Button���N���b�N������Ԃǂ��𑝂₷</summary>
    public void OnClickCount()
    {
        _grape += _oneClickCount;
    }
}
