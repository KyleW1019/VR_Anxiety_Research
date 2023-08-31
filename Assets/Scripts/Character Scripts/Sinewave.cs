using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Sinewave : MonoBehaviour
{
    public LineRenderer myLineRenderer;

    public int points;

    public float xStart;

    public float xFinish;

    public float progress;

    public float x;

    public float y;

    public float lasty;

    public Boolean on_off_bool = true;

    public InputActionReference toggleReference = null;
    

    //public float breathTime = 12 / 60;
    // Start is called before the first frame update
    void Start()
    {
        myLineRenderer = GetComponent<LineRenderer>();
        myLineRenderer.SetWidth(.2f, .2f);
        toggleReference.action.started += Toggle; 
    }

    private void Toggle(InputAction.CallbackContext context)
    {
        bool isActive = !gameObject.activeSelf;
        gameObject.SetActive(isActive);
    }
    void Draw()
    {
        xStart = 0;
        float Tau = 2 * Mathf.PI;
        xFinish = Tau;

        myLineRenderer.positionCount = points;

        for (int currentPoint = 0; currentPoint < points; currentPoint++)
        {
            progress = (float)currentPoint / (points - 1);
            x = Mathf.Lerp(xStart, xFinish, progress);
            y = Mathf.Sin(x + (Time.timeSinceLevelLoad * 0.5f));
            myLineRenderer.SetPosition(currentPoint, new Vector3(x,y,0));
            
            if (lasty < y)
            {
                //print("Breath In");
            }
            else
            {
               //print("Breath Out");
            }

            lasty = y;
        }
    }

    //void on_off_controller()
   // {
       // if (on_off_bool)
            //{
                //on_off_bool = false;
                //myLineRenderer.SetWidth(0f,0f);
            //}
       // else
            //{
                //on_off_bool = true;
                //myLineRenderer.SetWidth(.2f, .2f);
            //}
        
    //}
    // Update is called once per frame
    void Update()
    {
        if (on_off_bool)
        {
            Draw();
        }
        //on_off_controller();
    }
}
