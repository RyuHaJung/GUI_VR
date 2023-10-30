using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Order : MonoBehaviour
{
    private Stack<GameObject> UIStack = new Stack<GameObject>();
    [SerializeField]private Canvas[] UIPanels;  //0번은 메인 1번은 옵션 2번은 사운드 조절
    private GameObject nowUI;

    private void Awake()
    {
        for(int i = 0; i<UIPanels.Length; i++)
        {
            //UIPanels[i].SetActive(false);
        }
    }

    public void PushUI(GameObject targetUI, GameObject nowUIPanel)
    {
        targetUI.SetActive(false);
        UIStack.Push(targetUI);
        nowUIPanel.SetActive(true);
        nowUI = nowUIPanel;
    }

    public void PopUI()
    {
        UIStack.Pop().SetActive(true);
    }

    public void ToOptionPage()
    {
       // PushUI(UIPanels[0], UIPanels[1]);
    }

    public void ToSoundValuePage()
    {
        //PushUI(UIPanels[1], UIPanels[2]);
    }
}
