using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float rotationSpeed=10f;
    [SerializeField] float scaleSpeed=0.5f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,rotationSpeed*Time.deltaTime);
        if (transform.localScale.x>=2f){
           scaleSpeed= -scaleSpeed;
        }
        if (transform.localScale.x<=1.5f){
           scaleSpeed= -scaleSpeed;
        }
        transform.localScale+= new Vector3(scaleSpeed*Time.deltaTime,scaleSpeed*Time.deltaTime,0);

    }
}
