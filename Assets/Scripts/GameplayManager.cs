using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class GameplayManager : MonoBehaviour
{
    int dimmension = 10;
    public int Dimmension { get{return dimmension;} set{dimmension = value;} }

    // Start is called before the first frame update
    void Start()
    {        
        GameObject board = Instantiate(Resources.Load("Board"), new Vector3(0,0,0), new Quaternion()) as GameObject;    
        if(board != null)
        {
            Debug.Log("Okej obiekt zrobiony");
        }
        else
            Debug.Log("Nie ma board");
        
        var random = new System.Random((int)DateTime.Now.Ticks);
        
        var scale =board.transform.localScale;
        var startX = (-1*(scale.x/2)) + 0.5f;
        var startY = ((scale.y/2)) -   0.5f;
        for(int i =0; i < scale.x; i++)
        {
            for(int j=0; j < scale.y; j++)                
            {
                var posX = startX + (i);
                var posY = startY - (j);
                var field = Instantiate(Resources.Load("Cube"), new Vector3(posX,posY,-1), new Quaternion()) as GameObject;    
                //field.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                field.GetComponent<Renderer>().material.SetColor("_Color", UnityEngine.Random.ColorHSV());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
