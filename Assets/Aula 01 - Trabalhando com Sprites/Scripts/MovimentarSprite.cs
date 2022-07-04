using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentarSprite : MonoBehaviour
{
    public Transform direita;
    public Transform esquerda;
    public Transform rotacionarDireita;
    public Transform rotacionarEsquerda;
    public Transform scale;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        direita.Translate(new Vector3(0.001f, 0, 0));
        esquerda.Translate(new Vector3(-0.001f, 0, 0));

        rotacionarDireita.Rotate(new Vector3(0, 0, -0.03f));
        rotacionarEsquerda.Rotate(new Vector3(0, 0, 0.03f));

        scale.localScale += new Vector3(-0.001f, -0.001f, 0);
    }
}
