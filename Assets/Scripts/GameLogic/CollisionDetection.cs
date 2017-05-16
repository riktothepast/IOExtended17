using UnityEngine;

public class CollisionDetection : MonoBehaviour {

    // el metodo OnCollisionEnter2D permite detectar cuando una colision se ha iniciado entre 2 game objects que tengan colliders y por lo menos 1 rigid body
    // Destroy(collision.gameObject);

    void OnCollisionEnter2D(Collision2D collision) {
        // destruir el game object que entro en colision
    }
}
