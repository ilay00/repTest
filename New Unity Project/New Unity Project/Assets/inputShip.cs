using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputShip : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Spoce))
            Debug.Log(shipControler.use);
    }
}
