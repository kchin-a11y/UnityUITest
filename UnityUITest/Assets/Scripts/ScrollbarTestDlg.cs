using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarTestDlg : MonoBehaviour
{
    // Start is called before the first frame update
    public Scrollbar m_Scrollbar = null;
    public Text m_Text = null;
    public Button m_BtnRes = null;
    public Button m_BtnInit = null;

    void Start()
    {
        m_BtnRes.onClick.AddListener(OnClickedBtnRes);
        m_BtnInit.onClick.AddListener(OnClickedBtnInit);
    }

    public void OnValueChangedScrollbar()
    {
        m_Text.text = ((int)(m_Scrollbar.value * 100)).ToString();
    }

    public void OnClickedBtnRes()
    {
        m_Text.text = "현재 진행된 값은<color=#ff0000> " + ((int)(m_Scrollbar.value * 100)).ToString()  + " </color> 입니다.";
    }
    public void OnClickedBtnInit()
    {
        m_Scrollbar.value = 0;
        m_Text.text = "초기화됨";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
