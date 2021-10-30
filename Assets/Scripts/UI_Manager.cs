using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    private GameObject player;
    public Movement baseMovement;
    public BetterJumping baseJumping;
    public ImprovedMovement improvedMovement;
    public ImprovedJumping improvedJumping;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        baseMovement = player.GetComponent<Movement>();
        baseJumping = player.GetComponent<BetterJumping>();
        improvedMovement = player.GetComponent<ImprovedMovement>();
        improvedJumping = player.GetComponent<ImprovedJumping>();
        improvedMovement.enabled = false;
        improvedJumping.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void swapMovement()
    {
        baseMovement.enabled = !baseMovement.enabled;
        baseJumping.enabled = !baseJumping.enabled;
        improvedMovement.enabled = !improvedMovement.enabled;
        improvedJumping.enabled = !improvedJumping.enabled;
    }
}
