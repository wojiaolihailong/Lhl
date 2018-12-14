using System.Collections;
using System.Collections.Generic;
using FlappyBird;
using GameFramework;
using UnityEngine;
using GameEntry = UnityGameFramework.Runtime.GameEntry;
using UnityGameFramework.Runtime;


/// <summary>
/// 设置界面脚本
/// </summary>
public class SettingForm : UGuiForm
{
    public void OnCloseButtonClick()
    {
        Close();
    }

    public void OnMusicSettingValueChange(float value)
    {
         Log.Info("背景");
    }

    public void OnSoundSettingValueChange(float value)
    {
         Log.Info("音乐");

    }
}
