using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerSpawn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject playerPrefab;
    void Start()
    {
        var player1 = PlayerInput.Instantiate(prefab: playerPrefab, playerIndex: 0, controlScheme: "playerOne", pairWithDevice: InputSystem.devices[0]);
        player1.gameObject.transform.position = new Vector3(11, 5, -2);
        var player2 = PlayerInput.Instantiate(prefab: playerPrefab, playerIndex: 1, controlScheme: "playerTwo", pairWithDevice: InputSystem.devices[1]);
        player2.gameObject.transform.position = new Vector3(-17, 5, -2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
