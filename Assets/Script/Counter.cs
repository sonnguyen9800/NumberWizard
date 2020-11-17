using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private static GameObject instance;
    private void Awake() {
        DontDestroyOnLoad (gameObject);
        // if (instance == null) {
        //     instance = gameObject;
        // } else{
        //     Destroy(gameObject);
        // }
        if (GameObject.Find (gameObject.name) 
                 && GameObject.Find (gameObject.name) != this.gameObject)
                     {
                         Destroy (GameObject.Find (gameObject.name));
                     }
    }
    // Start is called before the first frame update
    void Start()
    {
        // if (FindObjectsOfType(GetType()).Length > 1)
        //  {
        //      Destroy(gameObject);
        //  }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
