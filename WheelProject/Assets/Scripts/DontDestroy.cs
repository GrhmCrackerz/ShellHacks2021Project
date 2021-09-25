using System.Collections;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Awake(){
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            DontDestroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }
}
