using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour  
{
    public Birdy Birdscrept;

    public GameObject Boru;
    public float Yukseklik;

    public float time;
    void Start()
    {
        StartCoroutine(Spawnobj(time));    
    }

    
    void Update()
    {
        
    }
    public IEnumerator Spawnobj (float time)  
    {
        while (!Birdscrept.isDead )    
        {

            Instantiate(Boru, new Vector3(1.5f, Random.Range(-Yukseklik, Yukseklik), 0), Quaternion.identity);
             
            yield return new WaitForSeconds(time);   

            
        }
            
        
    }
}

