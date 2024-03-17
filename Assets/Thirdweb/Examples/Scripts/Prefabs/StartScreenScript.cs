using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setConnectedState(GameObject ConnectedState, GameObject DisconnectedState)
    {
        ConnectedState.SetActive(true);
        DisconnectedState.SetActive(false);
    }

    public void setDisconnectedState(GameObject ConnectedState, GameObject DisconnectedState)
    {
        ConnectedState.SetActive(false);
        DisconnectedState.SetActive(true);
    }
    
}
