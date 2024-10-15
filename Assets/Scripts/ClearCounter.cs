using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{

    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;
    public void Interact() {
        Debug.Log("Sapeee");
        Transform KitchenObjectTransmform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        KitchenObjectTransmform.localPosition = Vector3.zero;

        Debug.Log(KitchenObjectTransmform.GetComponent<KitchenObject>().GetKitchenObjectSO().objectName);
    }
}
