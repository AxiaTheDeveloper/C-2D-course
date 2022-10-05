using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //Camera position same as car position
    //Car reference
    [SerializeField] GameObject patokanMobil;
    
    // Update is called once per frame
    //camera bakal ngikut smoothly krn kek ga nunggu/nabrak waktu updatenya ama waktu mobil
    void LateUpdate()
    {
        //x & y position
        transform.position = patokanMobil.transform.position + new Vector3 (0, 0, -15);
    }
}
