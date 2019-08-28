using UnityEngine;

public class TijoloController: MonoBehaviour {
    private TijoloModel tijoloModel;

    void Start() {
        this.tijoloModel = this.GetComponent<TijoloModel>();
    }

    void Update() {
        
    }

    public void receberDano(int dano) {
        this.tijoloModel.Vida -= dano;

        if(this.tijoloModel.Vida == 0) {
            Destroy(this.gameObject);
        }
    }
}
