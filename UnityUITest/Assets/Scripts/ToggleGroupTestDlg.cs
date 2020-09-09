using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleGroupTestDlg : MonoBehaviour
{
    public ToggleGroup m_ToggleGroup = null;
    public Text m_txtResult = null;
    public Button m_btnResult = null;

    string m_sValue = "";

    static string[] aName = { "사과", "배", "오렌지" };


    void Start()
    {
        m_btnResult.onClick.AddListener(OnCliked_Result);
        m_sValue = "사과";
    }

    public void OnCliked_Result()
    {
        string strResult = "당신이 선택한 과일은 " + m_sValue + " 입니다.";
        m_txtResult.text = strResult;
    }

    public void OnChanged_Toggle(int iIndex)
    {
        m_sValue = aName[iIndex];
    }

    public void OnCliked_Clear()
    {
        m_ToggleGroup.SetAllTogglesOff();
        m_txtResult.text = "초기화 되었습니다.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
