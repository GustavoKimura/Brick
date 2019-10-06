using UnityEngine;

public class BolaController: MonoBehaviour {
    private BolaModel bolaModel;
    private Rigidbody2D rigidbody2d;

    private void Start() {
        bolaModel = GetComponent<BolaModel>();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    public void iniciarJogo() {
        rigidbody2d.velocity = bolaModel.Direcao * bolaModel.Velocidade;
    }

    public void reiniciarJogo() {
        this.bolaModel.Direcao = new Vector2(this.bolaModel.Direcao.x, this.bolaModel.Direcao.y * -1);
        rigidbody2d.velocity = new Vector2(0, 0);
    }

    public void mudarAngulo(Vector2 direcao) {
         bolaModel.Direcao = direcao;

         rigidbody2d.velocity =  bolaModel.Direcao *  bolaModel.Velocidade;
    }

    public void invocarRefletir(Collision2D collision) {
         bolaModel.Direcao = Vector2.Reflect(bolaModel.Direcao, collision.contacts[0].normal);

         rigidbody2d.velocity =  bolaModel.Direcao *  bolaModel.Velocidade;
    }
    
     public Vector2 calcularReflexao(Collision2D jogador) {
        float j = 120;

        float escala = j / 2 / 100;

        float fatorEscala = 1.5f;

        float anguloEscala = ((jogador.transform.position.x - transform.position.x + escala) * fatorEscala);
     
        float anguloDeg = anguloEscala * 100;

        float anguloRad = anguloDeg * Mathf.PI / 180;

        return new Vector2(Mathf.Cos(anguloRad), Mathf.Sin(anguloRad));
     }
}
