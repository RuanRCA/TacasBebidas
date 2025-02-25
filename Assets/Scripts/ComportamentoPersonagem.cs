using UnityEditor.SceneManagement;
using UnityEngine;

public class ComportamentoPersonagem : MonoBehaviour
{

    public float velocidadaePersonagem, forcadoPulo;
    

    // Update is called once per frame
    void Update()
    {
       
        // Este código é para fazer o personagem ir para a direita 

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 novaPos = new Vector3(velocidadaePersonagem * Time.deltaTime , 0 , 0);
            transform.localPosition += novaPos;

            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        // Este Código é para fazer o peronagem ir para a esquerda

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 novaPos = new Vector3 (velocidadaePersonagem * Time .deltaTime , 0 , 0);
            transform.localPosition -= novaPos;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }


        // Este Código é pra fazer o personagens pular 

        if (Input.GetKeyDown(KeyCode.Space))

        {
            if (gameObject.GetComponent<Rigidbody2D>().linearVelocity.y==0)
            {
                Vector2 sentidocima = new Vector2(0, 1);
                gameObject.GetComponent<Rigidbody2D>().AddForce(sentidocima * forcadoPulo);
            }

        }


    }
}
