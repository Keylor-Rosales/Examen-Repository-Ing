using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTime : MonoBehaviour
{
    public GameObject[] ObjectActiveTime;
    public float InicioActive;
    public float Fin;

    void Update()
    {
        InicioActive += Time.deltaTime;
        for (int i = 0; i < ObjectActiveTime.Length; i++)
        {
            if (InicioActive >= Fin)
            {
                ObjectActiveTime[i].SetActive(true);
                InicioActive = 0;
                this.enabled = false;
            }
        }
    }
}
