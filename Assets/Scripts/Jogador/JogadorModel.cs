using UnityEngine;

public class JogadorModel: MonoBehaviour {
    [SerializeField] private string nome;
    [SerializeField] private int jogadasEfetuadas;
    [SerializeField] private float vidas, tamanho, velocidade;

    public string Nome {
        get => nome;
        set => this.nome = value;
    }

    public int JogadasEfetuadas {
        get => jogadasEfetuadas;
        set => this.jogadasEfetuadas = value;
    }

    public float Vidas {
        get => vidas;
        set => this.vidas = value;
    }

    public float Tamanho {
        get => tamanho;
        set => this.tamanho = value;
    }

    public float Velocidade {
        get => velocidade;
        set => this.velocidade = value;
    }
}
