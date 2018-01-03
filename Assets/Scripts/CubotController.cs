using UnityEngine;

public class CubotController : MonoBehaviour {
	
	void FixedUpdate () {
        float torque = Input.GetAxis("Horizontal") * 0.1f;
        float force = Input.GetAxis("Vertical") * 1.0f;

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        Transform transform = GetComponent<Transform>();

        rigidbody.AddTorque(transform.up * torque);
        rigidbody.AddForce(transform.forward * force);
	}
}
