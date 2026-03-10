using UnityEngine;

public class movimentacao : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool pulando = false;
        int inicioPulo = 0;
        int frameAtual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        frameAtual = frameAtual + 1;

        if (Input.GetKey("d"))
        {
            transform.Translate(0.05f, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(-0.05f, 0, 0);
        }

        if (Input.GetKey("space"))&&pulando == false&& Physics.CheckSphere(transform.position, 0.2f)
        {
            pulando = true; 
            inicioPulo = frameAtual;
        }

        if (pulando && frameAtual - inicioPulo > 100)
        {
            pulando = false;
        }

        if (pulando)
        {
            this.transform.Translate(0, 0.05f, 0);
        }

    }
}
