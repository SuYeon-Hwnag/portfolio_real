using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller_3D : MonoBehaviour
{
    Rigidbody playerRigidbody;
    public float speed = 30f;
    public int player_HP = 100;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // ����� ������ �Է°��� ���� �� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // ���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ���� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vec3 �ӵ��� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);

        // RigidBody�� �Ҵ�
        playerRigidbody.velocity = newVelocity;
    }

    public void HP_Controller()
    {

    }
}
