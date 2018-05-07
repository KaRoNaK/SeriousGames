using UnityEngine;

public class Movement : MonoBehaviour {

    [SerializeField]
    float rotationalSpeed;

    [SerializeField]
    float moveSpeed;

    private float vertical;
    private float horizontal;
    private Rigidbody rb;
   

    private void Awake() {

        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate() {
      //  anim.SetFloat("Speed", vertical);


        rb.MovePosition(transform.position + -transform.forward * vertical * moveSpeed * 0.01f);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0f, horizontal * rotationalSpeed, 0f)));
    }
}
