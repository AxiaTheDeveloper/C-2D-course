using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDelivery : MonoBehaviour
{
    private bool paket1;

    //Delay hilangin objek
    [SerializeField]private float Delay = 1f;
    
    
    //Warna Mobil
    [SerializeField]private Color32 adaPaket = new Color32(1,1,1,1);
    [SerializeField]private Color32 noPaket = new Color32(1,1,1,1);
    //nyimpen spriterenderer
    SpriteRenderer spriteRender;

    void Awake() {
        spriteRender = GetComponent<SpriteRenderer>();
        
    }
    void Start() {
        paket1 = false;
        spriteRender.color = noPaket;
    }
    //collision2D other kshtau kita ngebump ke siapa
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Aw..");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Paket")
        {
            if(paket1 == false){
                Debug.Log("Paket Terambil!");
                paket1 = true;
                spriteRender.color = adaPaket;
                Destroy(other.gameObject,Delay);
            }
            else{
                Debug.Log("Sudah ada Paket!");
            }
            
        }
        if(other.tag == "Customer")
        {
            if(paket1 == true){
                Debug.Log("Paket Berhasil Dikirim!");
                paket1 = false;
                spriteRender.color = noPaket;
                Destroy(other.gameObject,Delay);
            }
            else{
                Debug.Log("Paket Belum Ada!");
            }
            
        }
    }
}
