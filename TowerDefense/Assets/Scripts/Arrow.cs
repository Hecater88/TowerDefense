using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Transform target;
    public float speedArrow = 60f;
    public float explosionRadius = 8f;
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


        if (explosionRadius <= 0f)
        {
            Explode();
        }
        else
        {
            Damage(target);

        }
    }

    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.tag == "Enemy")
            {
                OnDrawGizmosSelected();
                Damage(collider.transform);
            }

        }
    }
    void Damage(Transform enemey)
    {
        Destroy(enemey.gameObject);

    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }
}
