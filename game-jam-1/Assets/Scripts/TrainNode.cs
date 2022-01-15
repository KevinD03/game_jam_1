using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainNode : MonoBehaviour
{
    public bool splitUpwards = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollsionEnter( Collision collision )
    {
        if ( collision.collider.CompareTag( "Train" ) )
        {
            // train is at this lever, will need to let the train/track controller know to make the turn
            Debug.Log("COLLIDE WITH NODE");
            EventManager.Fire( "NodeHit", this.gameObject );
        }
    }
}
