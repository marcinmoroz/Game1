using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Collections;

public class GameplayManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {        
        GameObject board = Instantiate(Resources.Load("Board"), position, rotation);    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
