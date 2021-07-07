using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chipcontroler : MonoBehaviour
{
    public static chipcontroler use;
    void Awake()
    {
        use = this;
    }
}
