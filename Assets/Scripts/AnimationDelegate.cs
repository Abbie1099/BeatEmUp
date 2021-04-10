using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDelegate : MonoBehaviour
{
    public GameObject leftArm_pt;
    public GameObject RightArm_pt;
    public GameObject leftLeg_pt;
    public GameObject RightLeg_pt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void leftarmON()
    {
        leftArm_pt.SetActive(true);
    }
    void leftarmOFF()
    {
        if(leftArm_pt.activeInHierarchy)
        {
            leftArm_pt.SetActive(false);
        }
    }
    void rightarmON()
    {
        RightArm_pt.SetActive(true);
    }
    void rightarmOFF()
    {
        if (RightArm_pt.activeInHierarchy)
        {
            RightArm_pt.SetActive(false);
        }
    }
    void leftLegON()
    {
        leftLeg_pt.SetActive(true);
    }
    void leftLegOFF()
    {
        if (leftLeg_pt.activeInHierarchy)
        {
            leftLeg_pt.SetActive(false);
        }
    }
    void rightLegON()
    {
        RightLeg_pt.SetActive(true);
    }
    void rightLegOFF()
    {
        if (RightLeg_pt.activeInHierarchy)
        {
            RightLeg_pt.SetActive(false);
        }
    }
}
