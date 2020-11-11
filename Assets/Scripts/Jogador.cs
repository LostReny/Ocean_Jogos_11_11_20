using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello player");
    }

    // Update is called once per frame
    void Update()
    {
        //Input Vertical - 0 quando não está apertado - -1 para baixo - 1 para cima
        var vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector2.up * vertical * velocidade * Time.deltaTime);
    }
}
