using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scenario3 : MonoBehaviour
{
    public OVRGrabbable colba;
    public DebugPool debugPool;
    public TextMeshPro text1;
    public TextMeshPro text2;
    public TextMeshPro text3;
    public TextMeshPro text4;
    public TextMeshPro text5;

    public int SaltOut;
    public UIPanelControll Temperature;
    public ControlIsparitel contr;
    public NewWaterControll water;
    float RestTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void PhaseOne()
    {
        if (Temperature.CurrentNumber == 100)
        {
            text1.color = Color.green;
            text2.gameObject.SetActive(true);
        }
        else
        {
            text1.color = Color.white;
        }
    }

    void PhaseTwo()
    {
        if (contr.Started)
        {
            text2.color = Color.green;
            text3.gameObject.SetActive(true);

        }
        else
        {
            text2.color = Color.white;
        }
    }

    void PhaseThree()
    {
        if (water.Emitting)
        {
            text3.color = Color.green;
            contr.Finished = true;
        }
        else
        {
            text3.color = Color.white;
        }
    }

    void MistakeOne()
    {
        if (SaltOut > 10)
        {
            text5.gameObject.SetActive(true);
        }
        else
        {
            text5.gameObject.SetActive(false);
        }
    }

    void MistaceTwo()
    {
        if (debugPool.Splited)
        {
            text5.gameObject.SetActive(true);
        }
        else
        {
            text5.gameObject.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        PhaseOne();
        PhaseTwo();
        PhaseThree();

    }
}
