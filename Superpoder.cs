public class Superpoder{
    #region Properties
    private bool EsDeAtaque;
    private int CantidadDeUsos = 1;
    #endregion

    #region Constructors    
    public Superpoder(bool esDeAtaque)
    {
        this.EsDeAtaque = esDeAtaque;
    }
    #endregion

    #region SettersYGetters
    public bool GetEsDeAtaque(){
        return this.EsDeAtaque;
    }
    public void SetEsDeAtaque(bool esDeAtaque){
        this.EsDeAtaque = esDeAtaque;
    }
    public int GetCantidadDeUsos(){
        return this.CantidadDeUsos;
    }
    public void SetCantidadDeUsos(int cantidadDeUsos){
        this.CantidadDeUsos = cantidadDeUsos;
    }
    #endregion

    #region Methods
    #endregion
}