using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]private float kecepatanSetir = 1f;
    [SerializeField]private float kecepatanMobil = 0.01f;
    [SerializeField]private float mempercepat = 0.01f;
    [SerializeField]private float memperlambat = 0.01f;
    private float simpan;
    //[SerializeField]private float normalizeSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(gameObject);
        simpan = kecepatanMobil;
    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime agar pas main di beda komputer/alat, ga beda-beda gitu
        //Input cuma ngarahin, kecepatan ya biar tau kecepatannya berapa
        
        float arahSetir = Input.GetAxis("Horizontal") * kecepatanSetir * Time.deltaTime;
        float arahMobil = Input.GetAxis("Vertical") * kecepatanMobil * Time.deltaTime;
        
        //mengubah arah/merotasi Mobil
        transform.Rotate(0, 0, -arahSetir);

        //mengubah posisi mobil
        transform.Translate(0,arahMobil,0);  

        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Fast"){
            kecepatanMobil = mempercepat;
        }
    }
    void OnCollisionEnter2D(Collision2D other) {
        kecepatanMobil = memperlambat;
    }
}
