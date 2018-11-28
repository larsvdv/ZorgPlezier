using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRLoader : MonoBehaviour {
    public bool needsVR;
	// Use this for initialization
	void Awake ()
	{
        if (needsVR == true)
        {
            StartCoroutine(LoadCardboard());
        }
        else
        {
            StartCoroutine(LoadNone());
        }

	}

    IEnumerator LoadCardboard()
    {
        XRSettings.LoadDeviceByName("Cardboard");
        yield return null;
        XRSettings.enabled = true;
    }

    IEnumerator LoadNone()
    {
        XRSettings.LoadDeviceByName("None");
        yield return null;
        XRSettings.enabled = false;
    }
}
