using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LeverState
{
    Left = 0,
    Right
};

public class Lever : MonoBehaviour
{
    
    [SerializeField]
    LeverState state;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ToggleState()
    {
        state = state == LeverState.Right ? LeverState.Left : LeverState.Right;
        Debug.LogFormat( "Changed Lever {0} to {1}", this.gameObject.name,
            state == LeverState.Left ? "Left" : "Right" );
        
        EventManager.Fire( "LeverStateChange", this.gameObject );
    }

    public LeverState GetState()
    {
        return state;
    }
}
