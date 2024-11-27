using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Girar_objetos : MonoBehaviour
{
    public Vector3 rotacion;

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called ince per frame
    void Update(){
        transform.Rotate(rotacion * Time.deltaTime);

    }
}
