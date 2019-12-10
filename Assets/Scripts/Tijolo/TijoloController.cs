using System.Collections;
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

        if(this.tijoloModel.Vida <= 0) {
            this.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
            this.transform.GetChild(1).GetComponent<AudioSource>().Play();

            StartCoroutine(this.destruir());
        }
    }

    public IEnumerator destruir() {
        yield return new WaitForSeconds(0.1f);

        if(this.transform.GetChild(0).GetComponent<ParticleSystem>().isPlaying) this.destruir();

        Destroy(this.gameObject);
    }
}
