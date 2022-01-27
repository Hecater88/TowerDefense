using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Transform target;
    public float speedArrow = 60f;
    public void ChaseEnemy(Transform _target)
    {
        target = _target;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = transform.position - target.position;

        float distanceThisFrame = speedArrow * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }
        transform.Translate(dir.normalized * distanceThisFrame * Time.deltaTime, Space.World);


    }
    void HitTarget()
    {
        Debug.Log("HIT " + target.name);
        Destroy(gameObject);
        Destroy(target.gameObject);
    }
}
