using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleControl : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;

    void Update()
    {
        coinCountDisplay.GetComponent<Text>().text = "" + coinCount;
        coinEndDisplay.GetComponent<Text>().text = "" + coinCount;
    }
}
