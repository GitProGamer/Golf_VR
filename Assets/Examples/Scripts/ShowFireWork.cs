using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFireWork : MonoBehaviour
{
    public GameObject firework;
  


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Start Fire work now");
        StartFireWork();
    }

    private void StartFireWork()
    {
        firework.SetActive(true);
       // transform.GetChild(0).gameObject.SetActive(true);
       // transform.GetChild(1).gameObject.SetActive(true);
        
    }
}
