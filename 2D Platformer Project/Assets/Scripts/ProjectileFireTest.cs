using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFireTest : MonoBehaviour
{

    //Creates the projectile prefab
    //Parameters: Spawn Position of the prefab (ie top of the towers); Target position (ie enemy)
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

    //Speed of the projectile
    //TODO: CHANGE TO GENERIC OBJECT FOR BETTER CODE STUFF (not sure how yet)
    [SerializeField]
    float projectileSpeed = 20f;

    //Update function: creates a move direction and creates velocity of the object toward the target position
    void Update()
    {

        Vector3 moveDirection = (targetPostion - transform.position).normalized;
        moveDirection.z = 0;
        
        projectileSpeed = 20f;
        
        transform.position += moveDirection * projectileSpeed * Time.deltaTime;
        //Debug.Log(targetPostion);
        //Debug.Log(transform.position);

        float destroySelfDistance = 1f;
        //Destroys the object if its in the range of the target
        if(Vector3.Distance(transform.position, targetPostion) < destroySelfDistance)
        {
            Destroy(gameObject);
        }
    }
}
