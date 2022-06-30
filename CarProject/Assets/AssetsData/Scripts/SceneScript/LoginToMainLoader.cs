using GameFramework.Procedure;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework.Fsm;
using UnityGameFramework.Runtime;

/// <summary>
/// Login��Main������loading
/// </summary>
public class LoginToMainLoader : ProcedureBase
{
    protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnEnter(procedureOwner);
        //���س���
        GameEntry.GetComponent<SceneComponent>().
            LoadScene("Assets/Study/Scene_Play.unity");
    }
}
