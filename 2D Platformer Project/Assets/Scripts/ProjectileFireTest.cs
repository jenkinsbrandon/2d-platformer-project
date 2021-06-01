using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFireTest : MonoBehaviour
{

    public void Create(Vector3 spawnPosition, Vector3 targetPosition)
    {
        Transform projectileTrans = Instantiate(gameObject, spawnPosition, Quaternion.identity).transform;
        

        ProjectileFireTest projectile = projectileTrans.GetComponent<ProjectileFireTest>();
        
        projectile.Setup(targetPosition);
    }

    private Vector3 targetPostion;

    private void Setup(Vector3 p_targetPostion)
    {
        targetPostion = p_targetPostion;
        targetPostion.z = 0;
    }

    [SerializeField]
    float projectileSpeed = 20f;
    void Update()
    {
        Vector3 moveDirection = (targetPostion - transform.position).normalized;
        moveDirection.z = 0;
        
        projectileSpeed = 20f;
        

        transform.position += moveDirection * projectileSpeed * Time.deltaTime;
        Debug.Log(targetPostion);
        Debug.Log(transform.position);

        float destroySelfDistance = 1f;

       if(Vector3.Distance(transform.position, targetPostion) < destroySelfDistance)
       {
          // Destroy(gameObject);
       }
    }
}
