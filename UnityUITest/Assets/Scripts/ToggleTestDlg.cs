using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleTestDlg : MonoBehaviour
{
    public Text m_txtResult = null;
    public Button m_btnResult = null;
    public Toggle m_toggleApple = null;
    public Toggle m_togglePear = null;
    public Toggle m_toggleOrange = null;

    void Start()
    {
        m_btnResult.onClick.AddListener(On_ClickedResult);
    }

    private void Initialize()
    { 
    }

    public void On_ClickedResult()
    {
        string strValue = "";

        if (m_toggleApple.isOn)
            strValue += "사과 ";
        if (m_togglePear.isOn)
            strValue += "배 ";
        if (m_toggleOrange.isOn)
            strValue += "오렌지 ";

       if (m_toggleApple.isOn || m_togglePear.isOn || m_toggleOrange.isOn) m_txtResult.text = "당신이 선택한 과일은 " + strValue + "입니다.";
       else m_txtResult.text = "아무 것도 선택되지 않음";
    }

    public void OnChanged_Value(int idx)
    { 
    }

    public void On_ClickedClear()
    {
        m_txtResult.text = "초기화됨.";
        m_toggleApple.isOn = false;
        m_togglePear.isOn = false;
        m_toggleOrange.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
