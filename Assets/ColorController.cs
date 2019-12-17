using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : MonoBehaviour
{
    public Texture2D primary;
    public Texture2D secondary;
    public int rotateSpeed;
    private bool isPrimary = true;

    private void FixedUpdate()
    {
        GetComponent<Transform>().Rotate(Vector3.up, Time.fixedDeltaTime * rotateSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
        //foreach(Touch touch in Input.touches)
        //{
        //    if (touch.phase == TouchPhase.Began)
        //    {
        //        if (sphere.color == primary)
        //        {
        //            sphere.color = secondary;
        //        } else
        //        {
        //            sphere.color = primary;
        //        }
        //    }
        //}       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isPrimary)
            {
                GetComponent<MeshRenderer>().material.mainTexture = secondary;
                isPrimary = false;
            }
            else
            {
                GetComponent<MeshRenderer>().material.mainTexture = primary;
                isPrimary = true;
            }
        }
    }
}
