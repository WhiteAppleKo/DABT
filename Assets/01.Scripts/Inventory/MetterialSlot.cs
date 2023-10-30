using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetterialSlot : MonoBehaviour
{
    [SerializeField] Image image;

    private Metterial _Metterial;
    public Metterial Metterial {
        get { return _Metterial; }
        set {
            _Metterial = value;
            if (_Metterial != null) {
                image.sprite = _Metterial.MetterialImage;
                image.color = new Color(1, 1, 1, 1);
            } else {
                image.color = new Color(1, 1, 1, 0);
            }
        }
    }
}