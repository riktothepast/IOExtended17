using UnityEngine;

public class Manager : MonoBehaviour {

    public int totalPickUps;

    /* Podemos obtener todos los gameobjects con cierto tag asignado que se encuentran en una escena, el metodo
    FindGameObjectsWithTag nos regresa un arreglo.
    totalPickUps = GameObject.FindGameObjectsWithTag("Item").Length;
    */

    void Start () {
        // asignar la cantidad de items a recolectar
    }

    public void RemovePickUp()
    {
        totalPickUps--;
        if (totalPickUps <= 0)
        {
            Debug.Log("We have a winner");
        }
    }
}
