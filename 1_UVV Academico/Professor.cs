public abstract class Professor
{
    public string? Nome { get; set; }
    public int Matricula { get; set; }
    public int CargaHoraria { get; set; }
    public double Beneficio { get; set; }

    public virtual void CalcularBeneficio() { }

    public virtual double GetBeneficio()
    {
        return Beneficio;
    }

}
