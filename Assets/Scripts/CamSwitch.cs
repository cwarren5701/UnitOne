using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject player1cam1;
    public GameObject player1cam2;
    public GameObject player2cam1;
    public GameObject player2cam2;

    // Start is called before the first frame update
    void Start()
    {
        player1cam1.SetActive(true);
        player1cam2.SetActive(false);
        player2cam1.SetActive(true);
        player2cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Player1CamSwitch")) {
            player1cam1.SetActive(!player1cam1.active);
            player1cam2.SetActive(!player1cam2.active);
        }
        if (Input.GetButtonDown("Player2CamSwitch")) {
            player2cam1.SetActive(!player2cam1.active);
            player2cam2.SetActive(!player2cam2.active);
        }
    }
}
