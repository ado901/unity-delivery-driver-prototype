using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    //this things position (camera) matches player position
    [SerializeField] GameObject thingToFollow;

    // Update is called once per frame
    void LateUpdate()
    {
        // in 2D, we only care about x and y, so we leave z as is
        transform.position= new Vector3(thingToFollow.transform.position.x,thingToFollow.transform.position.y,transform.position.z);
    }
}
