using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectableManager : MonoBehaviour
{
    public List<CollectableController> Collectables;
    public List<TextMeshProUGUI> itemBoxes;
    private void Start()
    {
        for(int i = 0; i < 3; i++)
        itemBoxes[i].text = GenerateRandomBox(i).cso.collectableName;
    }

    public CollectableController GenerateRandomBox(int itemIndex)
    {
        // Produce a shortlist of the objects that are not picked.
        List<CollectableController> shortList = Collectables.FindAll(x => x.isPicked == false && x.isAssignedToItemBox == false);
        if(shortList.Count == 0)
        {
            Debug.Log("Game Over, you have found all items. Dialogue plays");
        }
        // Random generating an index from the shortList.
        int randomindex = UnityEngine.Random.Range(0, shortList.Count);
        shortList[randomindex].isAssignedToItemBox = true;
        shortList[randomindex].itemBoxIndex = itemIndex;
        return shortList[randomindex];


    }

}
