using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController35 : MonoBehaviour
{
    Animator playerAnim;

    public float speed = 4.0f;

    bool isDeath = false;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ForwardKey();

        BackwardKey();

        LeftKey();

        RightKey();

        if (Input.GetKeyDown(KeyCode.Space) && isDeath == false)
        {
            playerAnim.SetTrigger("trigAttack");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Death"))
        {
            playerAnim.SetTrigger("trigDeath");

            isDeath = true;
        }
    }

    private void ForwardKey()
    {
        if (Input.GetKey(KeyCode.W) && isDeath == false)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            playerAnim.SetBool("isStrafe", true);
        }

        if (Input.GetKeyUp(KeyCode.W) && isDeath == false)
        {
            playerAnim.SetBool("isStrafe", false);
        }
    }

    private void BackwardKey()
    {
        if (Input.GetKey(KeyCode.S) && isDeath == false)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            playerAnim.SetBool("isStrafe", true);
        }

        if (Input.GetKeyUp(KeyCode.S) && isDeath == false)
        {
            playerAnim.SetBool("isStrafe", false);
        }
    }

    private void LeftKey()
    {
        if (Input.GetKey(KeyCode.A) && isDeath == false)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 270, 0);
            playerAnim.SetBool("isStrafe", true);
        }

        if (Input.GetKeyDown(KeyCode.A) && isDeath == false)
        {
            playerAnim.SetBool("isStrafe", false);
        }
    }

    private void RightKey()
    {
        if (Input.GetKey(KeyCode.D) && isDeath == false)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.Euler(0, 90, 0);
            playerAnim.SetBool("isStrafe", true);
        }

        if (Input.GetKeyDown(KeyCode.D) && isDeath == false)
        {
            playerAnim.SetBool("isStrafe", false);
        }
    }
}
