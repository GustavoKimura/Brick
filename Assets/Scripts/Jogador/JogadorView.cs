using UnityEngine;

public class JogadorView: MonoBehaviour {
    private JogadorController playerController;

    void Start() {
        this.playerController = this.GetComponent<JogadorController>();
    }

    void Update() {
        this.playerController.movimentar(Input.GetAxis("Horizontal"));
    }
}
