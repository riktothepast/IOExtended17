using UnityEngine;

public class PickUp : MonoBehaviour {

    Manager manager;

    /* FindGameObjectWithTag nos permite obtener un objeto con ese tag asignado en la escena, Si hay varios unity nos devuelve el 1ero que encuentre.
        manager = GameObject.FindGameObjectWithTag("GameController").GetComponent<Manager>();
    */

    void Start()
    {
        // asignar el manager
    }

    // con OnTriggerEnter2D podemos detectar colisiones entre 2 colliders tipo "trigger" Destroy(this.gameObject);

    void OnTriggerEnter2D(Collider2D coll)
    {
        // llamar al metodo de remover pickup del manager
        // destruir este objeto
    }
}
