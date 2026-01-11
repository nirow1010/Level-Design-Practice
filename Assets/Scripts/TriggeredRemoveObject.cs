using BTAI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredRemoveObject : MonoBehaviour
{
    public void Remove()
    {
        if (gameObject.activeSelf)
        {
            StartCoroutine(DelayedRemove());
        }
    }

    public void Recreate()
    {
        gameObject.SetActive(true);
    }

    private IEnumerator DelayedRemove()
    {
        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
    }
}
