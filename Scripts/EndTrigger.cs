using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour 
{
    public GameManager GameManager;

    void OnTriggerEnter ()
    {
        GameManager.CompleteLevel();
    }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
