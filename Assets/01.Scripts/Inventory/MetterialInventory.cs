using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetterialInventory : MonoBehaviour
{
    public List<Metterial> Metterials;

    [SerializeField]
    private Transform slotParent;
    [SerializeField]
    private MetterialSlot[] slots;

#if UNITY_EDITOR
    private void OnValidate() {
        slots = slotParent.GetComponentsInChildren<MetterialSlot>();
    }
#endif

    void Awake() {
        FreshSlot();
    }

    public void FreshSlot() {
        int i = 0;
        for (; i < Metterials.Count && i < slots.Length; i++) {
            slots[i].Metterial = Metterials[i];
        }
        for (; i < slots.Length; i++) {
            slots[i].Metterial = null;
        }
    }

    public void AddItem(Metterial _Metterial) {
        if (Metterials.Count < slots.Length) {
            Metterials.Add(_Metterial);
            FreshSlot();
        } else {
            print("슬롯이 가득 차 있습니다.");
        }
    }
}