using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class GameHandler : MonoBehaviour
{

    [SerializeField] private HealthBar healthBar;
    // Start is called before the first frame update
    private void Start()
    {
        float health = 1f;
        FunctionPeriodic.Create(() => {
            if (health > .01f) {
                health -= .01f;
                healthBar.SetSize(health);
            
                if (health < .3f) { 
                    // Under 30% Health
                    if (health * 100f % 3 == 0) {
                        healthBar.setColor(Color.white);  
                    }else{
                        healthBar.setColor(Color.red); 
                    }
                }
            }
        }, .06f);
    }
}