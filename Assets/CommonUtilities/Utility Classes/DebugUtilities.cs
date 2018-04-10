using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugUtilities {
    public static void SperatorPrint(params object[] objs)
    {
        string[] strings = new string[objs.Length];
        for (int i = 0; i < objs.Length; i++)
        {
            strings[i] = objs[i].ToString();
        }
        Debug.Log(string.Join(" | ", strings));
    }

    public static void SeperatorPrint(string delim = " | ", params object[] objs)
    {
        string[] strings = new string[objs.Length];
        for (int i = 0; i < objs.Length; i++)
        {
            strings[i] = objs[i].ToString();
        }
        Debug.Log(string.Join(delim, strings));
    }

    public static void Print(params object[] objs)
    {
        string[] strings = new string[objs.Length];
        for (int i = 0; i < objs.Length; i++)
        {
            strings[i] = objs[i].ToString();
        }
        Debug.Log(string.Join(" ", strings));
    }

    public static void Checkpoint()
    {
        Debug.Log("Checkpoint");
    }
}
