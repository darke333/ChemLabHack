using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public Substance.Game.SubstanceGraph Graph;

    public void OnChange(float value)
    {
    //    print("jdsf");

        Graph.SetInputFloat("sdf", value);
        Graph.QueueForRender();
        Graph.RenderSync();
      //  print("fsaf");
    }
}
