public class ProfHorista : Professor
{
    public double ValorHora { get; set; }

    public override void CalcularBeneficio()
    {
        Beneficio = CargaHoraria * ValorHora;
    }
}