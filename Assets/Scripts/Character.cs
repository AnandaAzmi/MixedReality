using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Animations;

public class Character : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("isAttacking", true);
            GameObject go = Instantiate(bulletPrefab, spawnPoint1.position, spawnPoint1.rotation) as GameObject;
            go.GetComponent<Rigidbody>().AddForce(transform.forward * 20, ForceMode.VelocityChange);
            GameObject go1 = Instantiate(bulletPrefab, spawnPoint2.position, spawnPoint2.rotation) as GameObject;
            go1.GetComponent<Rigidbody>().AddForce(transform.forward * 15, ForceMode.VelocityChange);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }
}