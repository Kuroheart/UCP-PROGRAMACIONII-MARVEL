using System;
public class Superheroe{
    #region Properties
    //private decimal Stamina = StaminaInicial;
    private Superpoder Superpoder;
    // public decimal PoderEfectivoAtaque {
    //     get{
    //         return PoderAtaque * HitRatioAtaque;
    //     }
    // }
    #endregion
    #region Constructors
    public Superheroe(Superpoder superpoder,
                      int poderAtaque, 
                      decimal hitRatioAtaque, 
                      decimal porcentajeDefensa,
                      string universo, 
                      int anioCreacion)
    {
        this.Superpoder = superpoder;
    }
    public Superheroe(Superpoder superpoder,
                      int poderAtaque, 
                      decimal hitRatioAtaque, 
                      decimal porcentajeDefensa){
        this.Superpoder = superpoder;      
    }
    #endregion
    #region GettersYSetters
    
    
    public Superpoder GetSuperpoder(){
        return this.Superpoder;
    }
    public void SetSuperpoder(Superpoder superpoder){
        this.Superpoder = superpoder;
    }
    #endregion
    #region Methods
    public virtual void UsarSuperpoder(){}
   
    public void Atacar(Personaje personaje){
       
    }

    public void Defender(decimal danio, bool usarSuperpoder){
        
    }

    #endregion
}