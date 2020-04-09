﻿/************************************************************
    文件: LoginScene.cs
    作者: jiaxiaocheng
    功能: 登录
*************************************************************/

using UnityEngine;

public class LoginScene : SceneBase
{
    protected override void OnInitSkinFront() 
    {
        this.SetMainSkinPath("Scene/LoginScene");
    }

    public override void Init()
    {
        base.Init();
        this.cache = true;
        this._type = SceneType.LoginScene;
    }

    public override void OnShowing()
    {

    }

    protected override void OnClick(GameObject target) 
    { 
        switch(target.gameObject.name)
        {
            case "Btn_Panel":
                PanelMgr.GetInstance.ShowPanel(PanelName.TestPanel);
                break;
            case "Btn_Main":
                SceneMgr.GetInstance.SwitchingScene(SceneType.MainScene);
                break;
        }
    }

}