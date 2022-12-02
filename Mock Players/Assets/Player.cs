using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, ICharacterMover1
{
    private CharacterController characterController;
    public int health { get; set; }
    private bool isPlayer;
    public bool IsPlayer => isPlayer;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        characterController.Move(new Vector3(horizontal*Time.deltaTime, 0, vertical*Time.deltaTime));
    }
}
