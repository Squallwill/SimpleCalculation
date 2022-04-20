using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calc : MonoBehaviour
{
    public float a;
    public float b;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("La somme est de :");
        Debug.Log(Sum());
        Debug.Log("Le produit est de :");
        Debug.Log(Prd());
        Div();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public float Sum()
    {
        return (a + b);
    }
    public float Prd()
    {
        return (a * b);
    }
    public float Div ()
    {
        if (b == 0)
        {
            Debug.Log("Erreur : Division imposible car b =0 ");
            return (0);
        }
        else
        {
            Debug.Log("Resultat de division");
            Debug.Log(a/b);
            return (1);
        }

    }
    
}

