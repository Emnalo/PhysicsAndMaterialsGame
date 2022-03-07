using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
public class GameScript : MonoBehaviour
{
    public GameObject BowlingPins;
    public Camera Camera;
    public GameObject BowlingBall;
    public PlayableDirector BowlingTimeline; 
    public SignalReceiver PositionPinReady,GameReady;
    private Vector3[] positions;
    private Quaternion[] rotations;
    List<GameObject> childObjects = new List<GameObject>();

    protected void Awake(){

    }

    // Start is called before the first frame update
    void Start()
    {
        Transform[] allChildren = BowlingPins.GetComponentsInChildren<Transform>();
        foreach (Transform child in allChildren)
        { 
            childObjects.Add(child.gameObject);
        }  
    }

    // Update is called once per frame
    void Update()
    {
       if(PositionPinReady.isActiveAndEnabled.Equals(1)){
        
       }
    }
}
