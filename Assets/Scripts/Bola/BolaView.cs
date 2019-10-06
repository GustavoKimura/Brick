using UnityEngine;
using UnityEngine.UI;

public class BolaView: MonoBehaviour {
    private BolaController bolaController;
    [SerializeField] private GameObject tijolos;

    private bool jogoIniciado = false;
    [SerializeField] private Text pressioneEspacoParaIniciar;

    [SerializeField] private GameObject jogador, painelFimDeJogo;
    [SerializeField] private Text textoFimDeJogo, jogadasEfetuadas;

    void Start() {
        bolaController = GetComponent<BolaController>();
    }

    void Update() {
        if(Input.GetKeyDown("space") && !this.jogoIniciado) {
            this.jogoIniciado = true;
            this.pressioneEspacoParaIniciar.gameObject.SetActive(false);

            this.bolaController.iniciarJogo();
        }

        if(this.transform.position.y < this.jogador.transform.position.y - this.jogador.transform.localScale.y) {
            Configuracoes.jogador.Vidas--;

            if(Configuracoes.jogador.Vidas <= 0) {
                this.textoFimDeJogo.text = "Você perdeu!";

                this.jogadasEfetuadas.text = "Jogadas efetuadas: " + Configuracoes.jogador.JogadasEfetuadas;

                this.painelFimDeJogo.SetActive(true);
            } else {
                this.transform.position = new Vector3(0, -2, 0);

                this.jogoIniciado = false;

                this.pressioneEspacoParaIniciar.gameObject.SetActive(true);

                this.bolaController.reiniciarJogo();
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Tijolo") {
            TijoloView tijoloView = collision.gameObject.GetComponent<TijoloView>();

            tijoloView.invocarReceberDano(1);

            if(this.tijolos.transform.childCount <= 1) {
                this.textoFimDeJogo.text = "Você venceu!";
                this.jogadasEfetuadas.text = "Jogadas efetuadas: " + Configuracoes.jogador.JogadasEfetuadas;
                this.painelFimDeJogo.SetActive(true);
            }
        }

        if(collision.gameObject.tag == "Jogador") {
            Configuracoes.jogador.JogadasEfetuadas++;

            bolaController.mudarAngulo(bolaController.calcularReflexao(collision));
        } else {
            bolaController.invocarRefletir(collision);  
        }
    }
}
