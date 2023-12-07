using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityGun : MonoBehaviour
{
    public GameObject heldObject;
    public bool isHolding;
    public LayerMask layerMask;
    public Transform holdPosition;
    bool fire = false;
    // Start is called before the first frame update
    void Start()
    {
        isHolding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (heldObject == null)
            {
                RaycastHit colliderHit;
                if (Physics.Raycast(transform.position,transform.forward, out colliderHit, 10.0f, layerMask))
                {
                    heldObject = colliderHit.collider.gameObject;
                    heldObject.GetComponent<Rigidbody>().useGravity = false;
                    isHolding = true;
                }
                
            }
        }

        if (Input.GetButtonUp("Fire1"))
        {
            // drop the object again
            if (heldObject != null)
            {
                heldObject.GetComponent<Rigidbody>().useGravity = true;
                heldObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                heldObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                heldObject.GetComponent<Rigidbody>().ResetInertiaTensor();
                heldObject = null;
                isHolding = false;
            }
        }

        if (Input.GetButtonUp("Fire2"))
        {
            fire = true;
            isHolding = false;
        }
    }

    private void FixedUpdate()
    {
        if (heldObject != null)
        {
            // move the thing we're holding
            heldObject.GetComponent<Rigidbody>().MovePosition(holdPosition.position);
            heldObject.GetComponent<Rigidbody>().MoveRotation(holdPosition.rotation);

            if (fire)
            {
                fire = false;
                heldObject.GetComponent<Rigidbody>().AddForce(transform.forward *
                5.0f, ForceMode.Impulse);
                heldObject.GetComponent<Rigidbody>().useGravity = true;
                heldObject = null;
                
            }
        }


    }
}
