using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredActivation : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] Indicator indicator1;
    [SerializeField] Indicator indicator2;

    // Update is called once per frame
    void Update()
    {
        if (!obj.activeSelf && indicator1.IsActive() && indicator2.IsActive())
        {
            obj.SetActive(true);
        }
    }
}
