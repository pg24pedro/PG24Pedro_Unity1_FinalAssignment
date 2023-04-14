using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadObjects : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void Execute()
    {
        var resource = Resources.Load("Managers");

        if (resource != null)
        { 
            Object.DontDestroyOnLoad(Object.Instantiate(resource));
        }
    }
}
