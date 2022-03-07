using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameScript : MonoBehaviour
{
    public GameObject BowlingPins;
    public Camera Camera;
    public GameObject BowlingSphere;
    public Collision collision;
    private Vector3 target;
    private float speed = 60f;
    private float max_speed=400f;
    private Rigidbody rigidball;
    Ray ray;
    RaycastHit hit;

    List<GameObject> childObjects = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        Transform[] allChildren = BowlingPins.GetComponentsInChildren<Transform>();
        foreach (Transform child in allChildren)
        { 
            childObjects.Add(child.gameObject);
        }  
        rigidball = BowlingSphere.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            speed+=200*Time.deltaTime;
            if(speed>=max_speed){
                speed=max_speed;
            }
        }

        if(Input.GetMouseButtonUp(0)){
            ray = Camera.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hit)){
                target = hit.point;
                rigidball.AddForceAtPosition((BowlingSphere.transform.position-target)*speed,target,ForceMode.Impulse);
            }
            speed = 60f;
        }
    }
}
