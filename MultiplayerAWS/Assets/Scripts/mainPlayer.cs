using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using Mirror;
public class mainPlayer : NetworkBehaviour
{
    
    CharacterController characterController;
    Vector3 moveDirecion;
    private Vector3 moveDirection = Vector3.zero;
    public bool isJump;
    public float Horizontal, Vertical;
    public float speed;
   /* [SyncVar]*/
    public int Health;
    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 30;
    }
    void Start()
    {
        Health = 100;
        characterController = GetComponent<CharacterController>();
        speed = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer) 
        {
            move();
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                this.Health -= 5;
            }
        }
       
        
        
    }
    public void move()
    {
        if (characterController.isGrounded == false)
        {
            //Add our gravity Vecotr
            moveDirection += Physics.gravity;
        }
        Horizontal = (Input.GetAxis("Horizontal"));
        Vertical = (Input.GetAxis("Vertical"));

        moveDirection = new Vector3(Horizontal, 0.0f, Vertical);
        moveDirection *= speed;
        characterController.Move(moveDirection * Time.deltaTime);

        if ((Horizontal != 0) || (Vertical != 0))
        {
            this.gameObject.transform.localEulerAngles = new Vector3(0f, Mathf.Atan2(Horizontal, Vertical) * 180 / Mathf.PI, 0f);
            
        }
    }
     
}
