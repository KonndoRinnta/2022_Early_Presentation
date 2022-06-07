using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrapeCounter : MonoBehaviour
{
    public int Grape { get => grape; set => grape = value; }
    /// <summary>�������Ă���Ԃǂ��̐�</summary>
    [SerializeField]
    [Header("�������Ă���Ԃǂ��̐�")]
    private int grape = 0;

    /// <summary>1�N���b�N�ɑ��₷�Ԃǂ��̐�</summary>
    [SerializeField]
    [Header("1�N���b�N�ɑ��₷�Ԃǂ��̐�")]
    int _oneClickCount = 1;

    [SerializeField]
    [Header("�������Ă���Ԃǂ��̐��̃e�L�X�g")]
    Text _grapeText;

    public void Update()
    {
        _grapeText.text = Grape.ToString();
    }

    /// <summary>Button���N���b�N������Ԃǂ��𑝂₷</summary>
    public void OnClickCount()
    {
        Grape += _oneClickCount;
    }
}
