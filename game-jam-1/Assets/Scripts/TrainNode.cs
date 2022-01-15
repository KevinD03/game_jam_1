using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainNode : MonoBehaviour
{
    public bool splitUpwards = true;

    private Player _train;
    // Start is called before the first frame update
    void Start()
    {
        _train = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*void OnCollsionEnter(Collider other)
    {
        if (other.tag == "Train")
        {
            // train is at this lever, will need to let the train/track controller know to make the turn
            Debug.Log("COLLIDE WITH NODE");
            EventManager.Fire("NodeHit", this.gameObject);
        }
    }*/

    /*private void OnTriggerEnter(Collider2D other)
    {

        // enemy collide with player
        if (other.tag == "Train")
        {
            // get player script component

            if (_player != null)
            {
                Debug.Log("works");
            }
        }

        // enemy collide with projectile from player
    }*/

    public void trythis(){
        Debug.Log("what");
    }
}
