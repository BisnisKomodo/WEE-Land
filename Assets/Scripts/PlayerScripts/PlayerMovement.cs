// using System.Collections;
// using System.Collections.Generic;
// using System.Runtime.InteropServices.WindowsRuntime;
// using Unity.VisualScripting;
// using UnityEngine;

// public class PlayerMovement : MonoBehaviour
// {
//     [SerializeField] private float movespeed;
//     private Rigidbody2D rb2d;
//     public LayerMask Landlayer;
//     public Interact interacting;
//     private bool canMove = true;
//     public Animator animator;

//     void Awake()
//     {
//         rb2d = GetComponent<Rigidbody2D>();
//     }

//     void FixedUpdate() 
//     {
//         animator.SetFloat("Horizontal", movespeed.x);
//         animator.SetFloat("Vertical", movespeed.y);
//         animator.SetFloat("Speed", movespeed.sqrMagnitude);
//         if(canMove)
//         {
//             float horizontalInput = Input.GetAxis("Horizontal");
//             float verticalInput = Input.GetAxis("Vertical");

//             Vector2 movement = new Vector2(horizontalInput, verticalInput) * movespeed;
//             rb2d.velocity = movement;
//         }

//         else
//         {
//             rb2d.velocity = Vector2.zero;
//         }
//     }

//     public void SetCanMove(bool state)
//     {
//         canMove = state;
//     }

//     public void CheckLand(GameObject Building, int money, float welfaretoadd, float EntertaintmentToAdd, float educationadd, float welfarereduction, float entertaintmentreduction, float educationreduction)
//     {
//         Collider2D[]Lands = Physics2D.OverlapCircleAll(transform.position, 0.1f, Landlayer);
//         foreach(Collider2D Land in Lands)
//         {
//             Interact LandBuilds = Land.GetComponent<Interact>();
//             LandBuilds.Builds(Building, money, welfaretoadd, EntertaintmentToAdd, educationadd, welfarereduction, entertaintmentreduction, educationreduction);
//             Debug.Log(interacting);
//         }
//     }

//     public void CheckLandV2()
//     {
//         Collider2D[]Lands = Physics2D.OverlapCircleAll(transform.position, 0.1f, Landlayer);
//         foreach(Collider2D Land in Lands)
//         {
//             Interact LandBuilds = Land.GetComponent<Interact>();
//             interacting = LandBuilds;
//             Debug.Log(interacting);
//         }
//     }

//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.R))
//         {
//             SellBuilding();
//         }
//     }
//     void SellBuilding()
//     {
//         Collider2D[] Lands = Physics2D.OverlapCircleAll(transform.position, 0.1f, Landlayer);
//         foreach(Collider2D Land in Lands)
//         {
//             Interact LandBuilds = Land.GetComponent<Interact>();
//             if (LandBuilds != null)
//             {
//                 LandBuilds.SellBuilding();
//             }
//         }
//     }
// }

// using UnityEngine;

// public class PlayerMovement : MonoBehaviour
// {
    
//     public float movespeed = 5f;
//     public Rigidbody2D rb;
//     Vector2 movement;
//     public Animator animator;

//      public LayerMask Landlayer;
//      public Interact interacting;
//      private bool canMove = true;

//     void FixedUpdate()
//     {
//         movement.x = Input.GetAxisRaw("Horizontal");
//         movement.y = Input.GetAxisRaw("Vertical");

//         animator.SetFloat("Horizontal", movement.x);
//         animator.SetFloat("Vertical", movement.y);
//         animator.SetFloat("Speed", movement.sqrMagnitude);

//          if(canMove)
//          {
//              float horizontalInput = Input.GetAxis("Horizontal");
//              float verticalInput = Input.GetAxis("Vertical");

//              Vector2 movement = new Vector2(horizontalInput, verticalInput) * movespeed;
//              rb.velocity = movement;
//          }

//          else
//          {
//              rb.velocity = Vector2.zero;
//          }
//     }

//     void Update()
//     {
//         rb.MovePosition(rb.position * movement * movespeed * Time.deltaTime);

//         if (Input.GetKeyDown(KeyCode.R))
//          {
//              SellBuilding();
//          }
//     }

//     public void SetCanMove(bool state)
//      {
//          canMove = state;
//      }

//      public void CheckLand(GameObject Building, int money, float welfaretoadd, float EntertaintmentToAdd, float educationadd, float welfarereduction, float entertaintmentreduction, float educationreduction)
//      {
//          Collider2D[]Lands = Physics2D.OverlapCircleAll(transform.position, 0.1f, Landlayer);
//          foreach(Collider2D Land in Lands)
//          {
//              Interact LandBuilds = Land.GetComponent<Interact>();
//              LandBuilds.Builds(Building, money, welfaretoadd, EntertaintmentToAdd, educationadd, welfarereduction, entertaintmentreduction, educationreduction);
//              Debug.Log(interacting);
//          }
//      }

//       public void CheckLandV2()
//      {
//          Collider2D[]Lands = Physics2D.OverlapCircleAll(transform.position, 0.1f, Landlayer);
//          foreach(Collider2D Land in Lands)
//          {
//              Interact LandBuilds = Land.GetComponent<Interact>();
//              interacting = LandBuilds;
//              Debug.Log(interacting);
//          }
//      }

//       void SellBuilding()
//      {
//          Collider2D[] Lands = Physics2D.OverlapCircleAll(transform.position, 0.1f, Landlayer);
//          foreach(Collider2D Land in Lands)
//          {
//              Interact LandBuilds = Land.GetComponent<Interact>();
//              if (LandBuilds != null)
//              {
//                  LandBuilds.SellBuilding();
//              }
//          }
//      }
// }

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;

    public LayerMask landLayer;
    public Interact interacting;
    private bool canMove = true;

    void FixedUpdate()
    {
        if (canMove)
        {
            // Get input
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            // Update animator parameters
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);

            // Apply movement
            Vector2 moveVelocity = movement.normalized * moveSpeed;
            rb.velocity = moveVelocity;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SellBuilding();
        }
    }

    public void SetCanMove(bool state)
    {
        canMove = state;
    }

    public void CheckLand(GameObject building, int money, float welfareToAdd, float entertainmentToAdd, float educationAdd, float welfareReduction, float entertainmentReduction, float educationReduction)
    {
        Collider2D[] lands = Physics2D.OverlapCircleAll(transform.position, 0.1f, landLayer);
        foreach (Collider2D land in lands)
        {
            Interact landBuilds = land.GetComponent<Interact>();
            landBuilds.Builds(building, money, welfareToAdd, entertainmentToAdd, educationAdd, welfareReduction, entertainmentReduction, educationReduction);
            Debug.Log(interacting);
        }
    }

    public void CheckLandV2()
    {
        Collider2D[] lands = Physics2D.OverlapCircleAll(transform.position, 0.1f, landLayer);
        foreach (Collider2D land in lands)
        {
            Interact landBuilds = land.GetComponent<Interact>();
            interacting = landBuilds;
            Debug.Log(interacting);
        }
    }

    void SellBuilding()
    {
        Collider2D[] lands = Physics2D.OverlapCircleAll(transform.position, 0.1f, landLayer);
        foreach (Collider2D land in lands)
        {
            Interact landBuilds = land.GetComponent<Interact>();
            if (landBuilds != null)
            {
                landBuilds.SellBuilding();
            }
        }
    }

    //i love unity damn
}
