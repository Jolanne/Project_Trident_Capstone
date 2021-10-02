using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Collectable", menuName = "ScriptableObjects/CollectableScriptableObject", order = 1)]
public class CollectableSO : ScriptableObject
{
    public string collectableName;
    public GameObject collectablePrefab;

}
