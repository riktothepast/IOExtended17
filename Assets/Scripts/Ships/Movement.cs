using UnityEngine;

public class Movement : MonoBehaviour {

    public float rotationSpeed;
    public float movementSpeed;
    public KeyCode left, right, accelerate;
    float currentAngle;
    Rigidbody2D rigidBody;

	void Start () {
        // obtener rigidBody: ribidBody = GetComponent<Rigidbody2D>();
        rigidBody = GetComponent<Rigidbody2D>();
    }
	
	void Update () {
        // Input class, ver que teclas fueron presionadas
        // currentAngle += rotationSpeed * Time.deltaTime;
        if (Input.GetKey(left))
        {

        } else if (Input.GetKey(right))
        {

        }

        // aplicar la rotacion
        // transform.Rotate(new Vector3(0, 0, currentAngle));

        // movamos a nuestra nave rigidBody.AddForce(transform.up * movementSpeed, ForceMode2D.Force);
        if (Input.GetKey(accelerate))
        {
           
        }
	}
}
