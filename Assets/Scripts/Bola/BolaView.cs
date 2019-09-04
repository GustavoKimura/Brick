using UnityEngine;

public class BolaView: MonoBehaviour {
    private BolaController bolaController;

    void Start() {
        bolaController = GetComponent<BolaController>();
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Tijolo") {
            TijoloView tijoloView = collision.gameObject.GetComponent<TijoloView>();

            tijoloView.invocarReceberDano(1);
        }

        if(collision.gameObject.tag == "Parede") {
            bolaController.invocarRefletir(collision);
        } else {
            bolaController.invocarRefletir(collision);   
        }
    }
}
