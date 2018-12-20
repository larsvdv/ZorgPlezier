using UnityEngine;
using System.Collections;

public class BasicAI : MonoBehaviour
{

    public Transform[] target;
    Transform newTarget;

    Animator bassAnimation;

    bool isMoving = false;

    public float speed = 2.0f;

    public bool predator = false;

    void Update()
    {
        if (isMoving == false)
        {
            newTarget = target[Random.Range(0, target.Length)];
            isMoving = true;
        }

        transform.position = Vector3.MoveTowards(transform.position, newTarget.position, speed * Time.deltaTime);

        if (transform.position == newTarget.position)
        {
            isMoving = false;
        }

        transform.LookAt(newTarget);
    }
}