namespace OurVideoGame
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class CameraFollow : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            playerTransform = GameObject.FindGameObjectWithTag("CurrentPlayer").transform;
        }

        private Transform playerTransform;

        // Update is called once per frame
        void Update()
        {
            this.transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);
        }
    }
}