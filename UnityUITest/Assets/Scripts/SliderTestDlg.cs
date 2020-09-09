using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTestDlg : MonoBehaviour
{
    public Text m_Text = null;
    public Slider m_Slider = null;
    public Button m_BtnInit = null;
    public Button m_BtnRes = null;

    public int m_MinValue = 0;
    public int m_MaxValue = 100;

    void Start()
    {
        m_BtnInit.onClick.AddListener(ClickedInitBtn);
        m_BtnRes.onClick.AddListener(ClickedResBtn);

        Initialize();
    }

    public void Initialize()
    {
        m_Slider.minValue = m_MinValue;
        m_Slider.maxValue = m_MaxValue;

        m_Slider.value = 0;
    }

    public void SliderChangedValue()
    {
        m_Text.text = ((int)m_Slider.value).ToString();
    }

    public void ClickedInitBtn()
    {
        m_Slider.value = 0;
        m_Text.text = "초기화 됨";
    }

    public void ClickedResBtn()
    {
        m_Text.text = "현재 진행된 값은<color=#ff0000> " + ((int)m_Slider.value).ToString() + "</color> 입니다.";
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
