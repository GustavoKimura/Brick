using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InsiraSeuNome: MonoBehaviour {
    [SerializeField] private Text nomeDoJogador;

    public void definirNomeDeUsuario() {
        Configuracoes.jogador.Nome = this.nomeDoJogador.text;
        Configuracoes.jogador.Vidas = 3;

        SceneManager.LoadScene("Jogo");
    }
}
