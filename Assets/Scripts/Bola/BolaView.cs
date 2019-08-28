using UnityEngine;

public class BolaView: MonoBehaviour {
    private BolaController bolaController;

    void Start() {
        this.bolaController = this.GetComponent<BolaController>();
    }

    void Update() {

    }

    void OnCollisionEnter2d(Collision2D collision) {
        if(collision.gameObject.tag == "Tijolo") {
            TijoloView tijoloView = collision.gameObject.GetComponent<TijoloView>();

            tijoloView.invocarReceberDano(1);
        }

        if(collision.gameObject.tag == "Parede") {
            
        }
    }
}
