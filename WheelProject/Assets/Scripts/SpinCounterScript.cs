using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpinCounterScript : MonoBehaviour
{
    public static int spinCounter = 5;
    Text spinText;
    // Start is called before the first frame update
    void Start()
    {
        spinText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        spinText.text = "Spin Counter: " + spinCounter;
    }
}
