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
    //창 닫기
    public void CloseSet()
    {
        settingPenal.transform.DOScale(0, 0.5f);
        isPenal = false;
    } 

    //게임 종료 창으로
    public void ExitCheck()
    {
        ExitPenal.transform.DOScale(1, 0.2f);
    }
    //아니오를 눌렀을 경우
    public void ExitNo()
    {
        ExitPenal.transform.DOScale(0, 0.2f);
    }
    //예를 누르면
    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
