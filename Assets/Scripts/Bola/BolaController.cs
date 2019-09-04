using UnityEngine;

public class BolaController: MonoBehaviour {
    private BolaModel bolaModel;
    private Rigidbody2D rigidbody2d;

    void Start() {
         bolaModel =  GetComponent<BolaModel>();
         rigidbody2d =  GetComponent<Rigidbody2D>();

         rigidbody2d.velocity =  bolaModel.Direcao *  bolaModel.Velocidade;
    }

    public void mudarAngulo(Vector2 direcao) {
         bolaModel.Direcao = direcao;
         rigidbody2d.velocity =  bolaModel.Direcao *  bolaModel.Velocidade;
    }

    public void invocarRefletir(Collision2D collision) {
         bolaModel.Direcao = Vector2.Reflect( bolaModel.Direcao, collision.contacts[0].normal);

         rigidbody2d.velocity =  bolaModel.Direcao *  bolaModel.Velocidade;
    }
    
     public Vector2 calcularReflexao(Collision2D jogador) {
          float jogador = 120;

          float escala = jogador / 2 / 100;

          float fatorEscala = 1.5f;

          float anguloEscala = ((jogador.transform.position.x - transform.position.x + escala) * fatorEscala)
     
          
     }
}
