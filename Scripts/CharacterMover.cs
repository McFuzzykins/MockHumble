using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour, ICharacterMover
{
    private CharacterController cont;

    [SerializeField]
    private bool isPlayer;
    public bool IsPlayer => isPlayer;

    public int Health { get; set; }

    private void Awake()
    {
        cont = GetComponent<CharacterController>(); 
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        cont.Move(new Vector3(horizontal, 0, vertical));
    }
}
