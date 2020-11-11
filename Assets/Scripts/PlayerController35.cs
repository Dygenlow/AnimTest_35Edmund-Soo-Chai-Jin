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
        if (Input.GetKey(KeyCode.W) && isDeath == false)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            playerAnim.SetBool("isStrafe", true);
        }

        if(Input.GetKeyUp(KeyCode.W) && isDeath == false)
        {
            playerAnim.SetBool("isStrafe", false);
        }

        if(Input.GetKeyDown(KeyCode.Space) && isDeath == false)
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
}
