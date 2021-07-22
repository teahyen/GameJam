using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SettingManger : MonoBehaviour
{
    public GameObject settingPenal;
    public GameObject ExitPenal;
    public bool isPenal = false;
    public Slider checkBar;
    public Text ScrollbarTex;

    private void Start()
    {
        //settingPenal.SetActive(false);
        settingPenal.transform.DOScale(0, 0);
        ExitPenal.transform.DOScale(0, 0);
    }
    private void Update()
    {
        ScrollbarTex.text = (checkBar.value * 100).ToString("N0");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPenal)
            {
                settingPenal.transform.DOScale(0, 0.5f);
                isPenal = false;
            }
            else
            {
                settingPenal.transform.DOScale(1, 0.5f);
                isPenal = true;
            }
        }
    }
    //â �ݱ�
    public void CloseSet()
    {
        settingPenal.transform.DOScale(0, 0.5f);
        isPenal = false;
    } 

    //���� ���� â����
    public void ExitCheck()
    {
        ExitPenal.transform.DOScale(1, 0.2f);
    }
    //�ƴϿ��� ������ ���
    public void ExitNo()
    {
        ExitPenal.transform.DOScale(0, 0.2f);
    }
    //���� ������
    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
