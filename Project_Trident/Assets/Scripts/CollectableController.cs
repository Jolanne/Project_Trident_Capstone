using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableController : MonoBehaviour
{
    public CollectableManager Cmgr;
    public bool isPicked;
    public bool isAssignedToItemBox;
    public int itemBoxIndex;
    public CollectableSO cso;

    [ContextMenu("Simulate Object Picked")]
    public void OnObjectPicked()
    {
        Cmgr.itemBoxes[itemBoxIndex].text = Cmgr.GenerateRandomBox(itemBoxIndex).cso.collectableName;
        isPicked = true;
    }
}
