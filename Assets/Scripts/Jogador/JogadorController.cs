using UnityEngine;

public class JogadorController: MonoBehaviour {
    private JogadorModel playerModel;

    void Start() {
        this.playerModel = this.GetComponent<JogadorModel>();
    }

    void Update() {
        
    }

    public void movimentar(float forca) {
        if (
            this.transform.position.x > -1.8f && forca < 0 ||
            this.transform.position.x < 1.8f && forca > 0
        ) {
            this.transform.Translate(forca * this.playerModel.Velocidade, 0, 0);
        }
    }
}
