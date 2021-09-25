using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullWheel : MonoBehaviour
{
    private int randomValue; // how many times the wheel will shift its rotation
    private float timeInterval; // time in seconds in between those shifts
    private bool coroutineAllowed; // stops the player from spinning the wheel while it is already spinning
    private int finalAngle; // determine the price to get

    [SerializeField]
    private Text winText; // displays price that you get

    // Use this for initialization
    private void Start() (
       coroutineAllowed = true; // allows the wheel to be spun
        )

    // Update is called once per frame
    private void Update() (
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && coroutineAllowed)
        StartCoroutine(Spin());
    
}

private IEnumerator Spin()
{
    coroutineAllowed = false;
    randomValue = Random.Range(20, 30);
    timeInterval = 0.1f;

    for (int i = 0; i < randomValue; i++)
    {
        transform.Rotate(0, 0, 22.5f);
        if (i > Mathf.RoundToInt(randomValue * 0.5f))
            timeInterval = 0.2f;
        if (i > Mathf.RoundtoInt(randomValue * 0.85f))
            timeInterval = 0.4f;
        yield return new WaitForSeconds(timeInterval);
    }

    if (Mathf.RoundtoInt(transform.eulerAngles.z) % 45 != 0)
        transform.Rotate(0, 0, 22.5f);

    finalAngle = Mathf.RoundToInt(transform.eulerAngles.z);

    switch (finalAngle)
    {
        case 0:
            winText.text = "You Win 1";
            break;
        case 45:
            winText.text = "You Win 2";
            break;
        case 90:
            winText.text = "You Win 3";
            break;
        case 135:
            winText.text = "You Win 4";
            break;
        case 180:
            winText.text = "You Win 5";
            break;
        case 225:
            winText.text = "You Win 6";
            break;
        case 270:
            winText.text = "You Win 7";
            break;
        case 315:
            winText.text = "You Win 8";
            break;

    }
    coroutineAllowed = true;
}