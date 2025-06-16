using UnityEngine;

public class Tail : MonoBehaviour
{
    public Transform follow;

    public float maxDistance;

    public float speed = 1.0f;
    void Update()
    {
        float actualDistance = Vector3.Distance(transform.position, follow.position);
        if (actualDistance > maxDistance)
        {
            var followToCurrent = (transform.position - follow.position).normalized;
            followToCurrent.Scale(new Vector3(maxDistance, 0, maxDistance));

            transform.position = follow.position + followToCurrent;

            Vector3 targetDirection = follow.position - transform.position;

            float singleStep = speed * Time.deltaTime;

            Vector3 newDirection = Vector3.RotateTowards(transform.position, targetDirection, singleStep, 0.0f);

            transform.rotation = Quaternion.LookRotation(newDirection);

        }
    }
}
