using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EmeryvilleCaliforniaTime : MonoBehaviour
{
    public GameObject timeTextObject;

    // EDIT: use WorldTimeAPI to get the current local time of Reedsport, Oregan in AM/PM
    // string url = "http://worldtimeapi.org/api/timezone/America/Los_Angeles";

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTime", 0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        timeTextObject.GetComponent<TextMeshPro>().text = System.DateTime.Now.ToString("h:mm tt");
    }
}