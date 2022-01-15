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
        EventManager.Fire( "LeverStateChange", this.gameObject );
    }

    public LeverState GetState()
    {
        return state;
    }
}
