using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(EnemyScript1))]
public class EnemyEditor : Editor {

    //public override void OnInspectorGUI()
    //{
    //    EnemyScript1 myScript = (EnemyScript1)target;

    //    myScript.missileBarrageParameters.usePercentage = GUILayout.Toggle(myScript.missileBarrageParameters.usePercentage, "Use Percentage");

    //    foreach (var o in myScript.missileBarrageParameters.GetType().GetProperties())
    //    {
    //        if (o.GetType() == typeof(FloatParameters))
    //        {
    //            foreach(var i in o.GetType().GetProperties())
    //            {
    //                EditorGUILayout.FloatField((float)i., )
    //            }
    //        }
    //    }

    //    /*foreach(var o in myScript.missileBarrageParameters.GetType().GetProperties())
    //    {
    //        if(o.GetType() == typeof(FloatParameters))
    //        {
                
    //        }
    //    }
    //    EditorGUI.BeginDisabledGroup(myScript.missileBarrageParameters.usePercentage);
    //    EditorGUILayout.IntField("HELLO", 1);*/
    //}
}
