using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    //-25 70
    //-23 35
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Collision with " + other.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag=="Package"){
            Debug.Log("Package received!");
            Destroy(other.gameObject);
            this.gameObject.GetComponent<Driver>().packagesCollected++;
            float redcolor=(1.0f/8)*this.gameObject.GetComponent<Driver>().packagesCollected;
            Debug.Log(redcolor);
            this.gameObject.GetComponent<SpriteRenderer>().color=new Color(1f,redcolor,1f);
            //Debug.Log(this.gameObject.GetComponent<SpriteRenderer>().color);
        }
        if (other.gameObject.tag=="Customer" && this.gameObject.GetComponent<Driver>().packagesCollected>0){
            Debug.Log("Package delivered!");
            if(GameObject.FindGameObjectsWithTag("Package").Length==0){
                other.gameObject.SetActive(false);
                Debug.Log("You win!");
            }else{GameObject newCustomer=GameObject.Instantiate(GameObject.FindGameObjectWithTag("Customer"),new Vector3Int(Random.Range(-25,70),Random.Range(-23,35),0),Quaternion.identity);
            
            
            newCustomer.SetActive(true);
            other.gameObject.SetActive(false);
            this.gameObject.GetComponent<Driver>().packagesCollected--;
            float redcolor=(1f/8)*this.gameObject.GetComponent<Driver>().packagesCollected;
            this.gameObject.GetComponent<SpriteRenderer>().color=new Color(1f,redcolor,1f);
            }

            
        }
        
        //Debug.Log("Trigger with " + other.gameObject.name);
    }
}
