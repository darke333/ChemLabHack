using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scenario3 : MonoBehaviour
{
    public List<GameObject> Hints;
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
    int number;

    // Start is called before the first frame update
    void Start()
    {
        Hints[0].SetActive(true);
        Hints[1].SetActive(true);

    }

    void ChangeHint(bool forward)
    {
        if (forward)
        {
            number++;
            Hints[number].SetActive(true);
            if (number > 0)
            {
                Hints[number - 1].SetActive(false);
            }
        }
        else
        {
            number--;
            Hints[number].SetActive(true);
            if (number < Hints.Count)
            {
                Hints[number + 1].SetActive(false);
            }
        }
    }

    void PhaseOne()
    {
        if (Temperature.CurrentNumber == 100)
        {
            text1.color = Color.green;
            text2.gameObject.SetActive(true);
            Hints[0].SetActive(false);
            Hints[1].SetActive(false);
            Hints[2].SetActive(true);
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
            Hints[2].SetActive(false);
            Hints[3].SetActive(true);



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
            foreach (GameObject hint in Hints)
            {
                hint.SetActive(false);
            }
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
