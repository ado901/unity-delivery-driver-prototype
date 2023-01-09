using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float steerSpeed=200f;
    [SerializeField] float moveSpeed=10f;
    [SerializeField] float slowSpeed=20f;
    [SerializeField] float boostSpeed=20f;
    public int packagesCollected; 
    // Start is called before the first frame update
    void Start()
    {
       packagesCollected=0;
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount=Input.GetAxis("Horizontal")*steerSpeed*Time.deltaTime;
        float moveSpeedAmount=Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveSpeedAmount,0);
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag=="slow"){
            moveSpeed=slowSpeed;
        }
        if (other.gameObject.tag=="speed"){
            moveSpeed=boostSpeed;
        }
    }
}
