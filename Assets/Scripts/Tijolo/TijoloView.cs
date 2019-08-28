using UnityEngine;

public class TijoloView: MonoBehaviour {
    private TijoloController tijoloController;

    void Start() {
        this.tijoloController = this.GetComponent<TijoloController>();
    }

    void Update() {
        
    }

    public void invocarReceberDano(int dano) {
        this.tijoloController.receberDano(dano);
    }
}
