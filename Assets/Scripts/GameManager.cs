using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      //  EventManager.Instance.getName += PrintME;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
           // EventManager.Instance.GetName();
        }
    }

    public void PrintME()
    {
        print(" hello event");
    }
}
