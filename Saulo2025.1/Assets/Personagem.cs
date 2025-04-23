using UnityEngine;

public class Personagem : MonoBehaviour
{
    private string nome;
    private string energia;
    private int forca_ataque;
    private int forca_do_pulo;
    private int velocidade;
    private int numero_de_pes;
    private int numero_de_maos;
    
    public void AtribuirNome(string nome)
    {
        this.nome = nome ;
    }
    public string atribuirNome()
    {
        return this.nome;
    }
    
    private void Atribuirenergia(string energia)
    {
        this.energia = energia ;
    }
    public string atribuirenergia()
    {
        return this.energia;
    }
    private void Atribuirforca_ataque(int forca_ataque)
    {
        this.forca_ataque  = forca_ataque ;
    }
    public int atribuirforca_ataque()
    {
        return this.forca_ataque;
    }

    private void Atribuirforca_do_pulo(int forca_do_pulo)
    {
        this.forca_do_pulo = forca_do_pulo;
    }

    public int atribuirforca_do_pulo()
    {
        return this.forca_do_pulo;
    }
    private int Atribuirvelocidade(int velocidade)
    {
       return this.velocidade = velocidade ;
    }
    public int Velocidade()
    {
        return this.velocidade ;
    }
    
    private void atribuirnumero_de_pes(int numero_de_pes)
    {
        this.numero_de_pes = numero_de_pes ;
    }

    public int Numero_de_pes()
    {
        return this.numero_de_pes ;
    }
    private void Atribuirnumero_de_maos(int numero_de_maos)
    {
        this.numero_de_maos = numero_de_maos ;
    }
    
    public int atribuirnumero_de_maos(int numero_de_maos)
    {
        return this.numero_de_maos ;
    }
    
    
}

