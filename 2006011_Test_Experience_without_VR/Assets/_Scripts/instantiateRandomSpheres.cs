using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateRandomSpheres : MonoBehaviour
{
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
       for(int i = 0;i<3000;i++){
       		GameObject s = GameObject.Instantiate(sphere, new Vector3(Random.Range(-1.0f, 1.0f),Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 5.0f)), Quaternion.identity);
       }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
