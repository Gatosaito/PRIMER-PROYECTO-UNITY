using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi_script : MonoBehaviour
{

    public string mi_nombre;
    public string nombre_amigo;
    public int mi_edad;
    public int edad_amigo;
   

    // Start is called before the first frame update
    void Start()
    {
        int total;
        total = mi_edad + edad_amigo; 

        Debug.Log("Mi nombre es " + mi_nombre);
        Debug.Log("El nombre de mi amigo es " + nombre_amigo);
        Debug.Log("Mi edad es " + mi_edad);
        Debug.Log("La edad de mi amigo es " + edad_amigo);
        Debug.Log("la suma de nuestras edad es " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnJump() 
    {
    
    }


}


/* public string mensaje_bienvenida;
     public string mi_nombre;
     public int a;
     public float b;
     public bool esta_arriba;


             Debug.Log(mensaje_bienvenida);
         Debug.Log("Hello World, i'm" + mi_nombre);

     */
