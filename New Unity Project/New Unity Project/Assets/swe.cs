using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    // Start is called before the first frame update
    
    
             public List<ManagerBase> managers = new List<ManagerBase>();
            void Awake()
    {
        foreach(var managerBase in managers)
        {
            Toolbox.Add(managerBase);
        }
    }
    

 
}
