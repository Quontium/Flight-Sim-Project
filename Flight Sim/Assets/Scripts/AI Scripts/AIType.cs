using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FlightSim.AI
{    
    public abstract class AIType : MonoBehaviour
    {
        [HideInInspector] public CreatePlane planeData;

        [HideInInspector] public Rigidbody rb;
        [HideInInspector] public Transform player;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }


        void FixedUpdate()
        {
            Fly();
        }

        public virtual void Fly()
        {
            Vector3 targetDir = player.position - transform.position;

            float xyAngle = vector3AngleOnPlane(player.position, transform.position, transform.forward, transform.up);
            float yzAngle = vector3AngleOnPlane(player.position, transform.position, transform.right, transform.forward);

            if (Mathf.Abs(xyAngle) >= 1f && Mathf.Abs(yzAngle) >= 1f)
            {
                rb.AddRelativeTorque(Vector3.forward * -planeData.torque * (xyAngle / Mathf.Abs(xyAngle)));
            }
            else if (yzAngle >= 1f)
            {
                rb.AddRelativeTorque(Vector3.right * -planeData.torque);

                //weapon.fire();
            }

            rb.AddRelativeForce(Vector3.forward * planeData.thrust);
        }

        float vector3AngleOnPlane(Vector3 from, Vector3 to, Vector3 planeNormal, Vector3 toOrientation)
        {
            Vector3 projectedVector = Vector3.ProjectOnPlane(from - to, planeNormal);
            float projectedVectorAngle = Vector3.SignedAngle(projectedVector, toOrientation, planeNormal);

            return projectedVectorAngle;
        }
    }

}
