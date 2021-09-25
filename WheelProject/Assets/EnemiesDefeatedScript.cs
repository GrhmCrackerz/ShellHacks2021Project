using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesDefeatedScript : MonoBehaviour
{
    public static int enemiesDefeated = 0;
    Text enemiesDefeatedCounter;
    // Start is called before the first frame update
    void Start()
    {
        enemiesDefeatedCounter = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        enemiesDefeatedCounter.text = "Enemies Defeated: " + enemiesDefeated;
    }
}