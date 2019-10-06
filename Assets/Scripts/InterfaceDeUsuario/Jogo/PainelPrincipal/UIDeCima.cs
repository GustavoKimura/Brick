using UnityEngine;
using UnityEngine.UI;

public class UIDeCima: MonoBehaviour {
    [SerializeField] private Text vidas, nome;

    void Start() {
        this.nome.text = Configuracoes.jogador.Nome;
    }

    void Update() {
        this.vidas.text = "Vidas: " + Configuracoes.jogador.Vidas;
    }
}
