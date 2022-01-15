using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    void OnCollsionEnter( Collision collision )
    {
        if ( collision.collider.CompareTag( "Train" ) )
        {
            // train is at this lever, will need to let the train/track controller know to make the turn
            EventManager.Fire( "EndGame" );
            Time.timeScale = 0;
        }
    }
}
