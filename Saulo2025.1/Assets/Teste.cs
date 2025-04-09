using UnityEngine;

public class Teste : MonoBehaviour
{
    Carro fusca = new Carro();


    void Start()
    {
        fusca.AtribuirNome("Fusca do Pai");
        Debug.Log("O "+ fusca.NomeDoCarro());
    }

    void Update()
    {
        
    }
}
