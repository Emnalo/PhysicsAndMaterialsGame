using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class reset : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayableDirector BowlingTimeline;
    public GameObject BowlingSphere;
    private Vector3 initialposball;
    private Quaternion initialrotball;
    private Rigidbody ballrigid;
    void Start()
    {   ballrigid = BowlingSphere.GetComponent<Rigidbody>();
        initialposball = BowlingSphere.transform.position;
        initialrotball = BowlingSphere.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey("space")){
        BowlingSphere.transform.position = initialposball;
        BowlingSphere.transform.rotation = initialrotball;
        ballrigid.velocity = Vector3.zero;
        ballrigid.angularVelocity = Vector3.zero;
        BowlingTimeline.Play();
       }
    }

    private void OnCollisionEnter(Collision other){

        if(other.gameObject.name == "BowlingSphere"){

            StartCoroutine(PlaytimelineCoroutine());
        }

    } 

    IEnumerator PlaytimelineCoroutine(){
        yield return new WaitForSeconds(5);
        BowlingSphere.transform.position = initialposball;
        BowlingSphere.transform.rotation = initialrotball;
        ballrigid.velocity = Vector3.zero;
        ballrigid.angularVelocity = Vector3.zero;
        BowlingTimeline.Play();
    }
    
}
