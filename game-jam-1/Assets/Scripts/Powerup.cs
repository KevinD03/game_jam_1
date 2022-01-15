using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Powerups
{
    DoublePoints = 0,
    HalfPoints,
    InstantDeath,

    PowerupsCount
}

public class Powerup : MonoBehaviour
{
    // Start is called before the first frame update
    private Powerups power;
    void Start()
    {
        // randomly pick a power up
        power = (Powerups) Random.Range( 0, (int) Powerups.PowerupsCount );
    }

    void OnCollsionEnter( Collision collision )
    {
        if ( collision.collider.CompareTag( "Train" ) )
        {
            if ( power == Powerups.InstantDeath )
            {
                EventManager.Fire( "EndGame" );
                Time.timeScale = 0;
            }
            else
            {
                EventManager.Fire( "PowerupCollected", this.gameObject );
            }
        }
    }
    
}
