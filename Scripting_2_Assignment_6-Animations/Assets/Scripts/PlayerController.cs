using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            anim.Play("WAIT01", -1, 0.0f);

        if (Input.GetKeyDown(KeyCode.Alpha2))
            anim.Play("WAIT02", -1, 0.0f);

        if (Input.GetKeyDown(KeyCode.Alpha3))
            anim.Play("WAIT03", -1, 0.0f);

        if (Input.GetKeyDown(KeyCode.Alpha4))
            anim.Play("WAIT04", -1, 0.0f);

        if (Input.GetKeyDown(KeyCode.Mouse0))
            anim.Play("DAMAGED00", -1, 0.0f);

        if (Input.GetKeyDown(KeyCode.Mouse1))
            anim.Play("DAMAGED01", -1, 0.0f);

        float vertInput = Input.GetAxis("Vertical");
        float horInput = Input.GetAxis("Horizontal");
        anim.SetFloat("vertInput", vertInput);
        anim.SetFloat("horInput", horInput);

        bool run = Input.GetKey(KeyCode.LeftShift);

        anim.SetBool("isRunning", run);
        anim.SetBool("isJumping", Input.GetKeyDown(KeyCode.Space));

        float moveX = horInput * 25.0f * Time.deltaTime;
        float moveZ = vertInput * 40.0f * Time.deltaTime;

        if (moveZ <= 0)
            moveX = 0;

        else if (run)
        {
            moveX *= 4.0f;
            moveZ *= 4.0f;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(moveX, 0, moveZ);

    }
}
