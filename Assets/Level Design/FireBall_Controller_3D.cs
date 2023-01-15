using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall_Controller_3D : MonoBehaviour
{
    public float speed = 8f;
    Rigidbody EnermyRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        EnermyRigidbody = GetComponent<Rigidbody>();

        EnermyRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player_Controller_3D playercontroller = other.GetComponent<Player_Controller_3D>();

            if (playercontroller != null)
            {
                // Ã¼·Â ±ðÀÓ
                playercontroller.HP_Controller();
            }
        }
    }
}
