using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculadora_masa_corporal : MonoBehaviour
{

    public string nombre_de_usuario;
    public float altura_cm;
    public float peso_kg;


    // Start is called before the first frame update
    void Start()
    {
        float alt_cm_dos;
        float imc;


        alt_cm_dos = altura_cm * altura_cm;
        imc = peso_kg / alt_cm_dos;

        Debug.Log("El nombre del usuario es:  " + nombre_de_usuario);

        Debug.Log("La altura en centimetros es:  " + altura_cm);

        Debug.Log("El peso en kilogramos es:  " + peso_kg);

        if(imc >= 0 && imc <= 18.5f) 
        {

            Debug.Log("el " + nombre_de_usuario + " tiene un peso inferior al normal");

        }

        if (imc >= 18.5f && imc <= 24.9f) 
        {

            Debug.Log("el " + nombre_de_usuario + " tiene un peso normal");

        }

        if (imc >= 24.9f && imc <= 29.9f) 
        {

            Debug.Log("el " + nombre_de_usuario + " tiene un peso superior al normal");

        }

        if (imc >= 29.9f && imc >= 30.0f)
        {

            Debug.Log("el usuario " + nombre_de_usuario + " tiene sobrepeso");

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
