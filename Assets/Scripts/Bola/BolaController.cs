using UnityEngine;

public class BolaController: MonoBehaviour {
    private BolaModel bolaModel;
    private Rigidbody2D rigidbody2d;

    void Start() {
        this.bolaModel = this.GetComponent<BolaModel>();
        this.rigidbody2d = this.GetComponent<Rigidbody2D>();

        this.rigidbody2d.velocity = this.bolaModel.Direcao * this.bolaModel.Velocidade;
    }

    void Update() {
        
    }

    public void mudarAngulo(Vector2 direcao) {
        this.bolaModel.Direcao = direcao;
        this.rigidbody2d.velocity = direcao * this.bolaModel.Velocidade;
    }

    public void invocarRefletir(Collision2D collision) {

    }
}
